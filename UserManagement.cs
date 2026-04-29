using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace zeropos
{
    public partial class UserManagement : Form
    {
        private string _state = "...";
        private string state
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                txt_state.Text = $"{_state}";
            }
        }


        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            DataTable role_datatbl = new DataTable();
            role_datatbl.Columns.Add("name");
            role_datatbl.Columns.Add("value");

            role_datatbl.Rows.Add("ผู้ดูแลระบบ", "admin");
            role_datatbl.Rows.Add("พนักงาน", "staff");

            combo_role.DataSource = role_datatbl;
            combo_role.DisplayMember = "name";
            combo_role.ValueMember = "value";

            DataTable role_datatbl_copy = role_datatbl.Copy();

            DataRow allRoleRow = role_datatbl_copy.NewRow();
            allRoleRow["name"] = "ทั้งหมด";
            allRoleRow["value"] = "all";
            role_datatbl_copy.Rows.InsertAt(allRoleRow, 0);

            combo_role_search.DataSource = role_datatbl_copy;
            combo_role_search.DisplayMember = "name";
            combo_role_search.ValueMember = "value";


            DataTable user_status_tbl = new DataTable();
            user_status_tbl.Columns.Add("name");
            user_status_tbl.Columns.Add("value");

            user_status_tbl.Rows.Add("ใช้งาน", "1");
            user_status_tbl.Rows.Add("ไม่ใช้งาน", "0");

            combo_status.DataSource = user_status_tbl;
            combo_status.DisplayMember = "name";
            combo_status.ValueMember = "value";

            DataTable user_status_tbl_copy = user_status_tbl.Copy();

            DataRow allStatusRow = user_status_tbl_copy.NewRow();
            allStatusRow["name"] = "ทั้งหมด";
            allStatusRow["value"] = "all";
            user_status_tbl_copy.Rows.InsertAt(allStatusRow, 0);

            combo_status_search.DataSource = user_status_tbl_copy;
            combo_status_search.DisplayMember = "name";
            combo_status_search.ValueMember = "value";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search_text = inp_search.Text.Trim();
            string role_filter = combo_role_search.SelectedValue?.ToString() ?? "all";
            string status_filter = combo_status_search.SelectedValue?.ToString() ?? "all";

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT
                id AS 'ID',
                name AS 'ชื่อ',
                username AS 'ชื่อผู้ใช้',

                CASE 
                    WHEN role = 'admin' THEN 'ผู้ดูแลระบบ'
                    WHEN role = 'staff' THEN 'พนักงาน'
                    ELSE role
                END AS 'สิทธิ์',

                CASE 
                    WHEN status = 1 THEN 'ใช้งาน'
                    ELSE 'ปิดใช้งาน'
                END AS 'สถานะ'

            FROM users
            WHERE
                (
                    @search_text = ''
                    OR name LIKE @keyword
                    OR username LIKE @keyword
                    OR role LIKE @keyword
                )
                AND
                (
                    @role_filter = 'all'
                    OR role = @role_filter
                )
                AND
                (
                    @status_filter = 'all'
                    OR status = @status_filter
                )
            ORDER BY id DESC
        ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search_text", search_text);
                    cmd.Parameters.AddWithValue("@keyword", "%" + search_text + "%");
                    cmd.Parameters.AddWithValue("@role_filter", role_filter);
                    cmd.Parameters.AddWithValue("@status_filter", status_filter);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        tbl_users.Columns.Clear();
                        tbl_users.AutoGenerateColumns = true;
                        tbl_users.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            txt_found_count.Text = "พบ 0 คน";
                            //MessageBox.Show("ไม่พบข้อมูลผู้ใช้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            inp_search.Focus();
                            return;
                        }

                        tbl_users.ClearSelection();
                        tbl_users.Rows[0].Selected = true;

                        txt_found_count.Text = $"พบ {dt.Rows.Count} คน";
                    }
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            inp_search.Clear();
            combo_status_search.SelectedValue = "all";
            combo_role_search.SelectedValue = "all";
            tbl_users.DataSource = null;
            txt_found_count.Text = "พบ 0 คน";
        }

        private void btn_add_member_Click(object sender, EventArgs e)
        {
            clearForm();

            btn_disable_user.Enabled = false;
            state = "เพิ่มผู้ใช้";
            panel_form.Enabled = true;

            inp_name.Clear();
            inp_username.Clear();
            inp_password.Clear();
            inp_password.PlaceholderText = "";
            combo_role.SelectedValue = "staff";
            combo_status.SelectedValue = "1";

            inp_name.Focus();

        }

        private void clearForm()
        {
            inp_id.Clear();
            inp_name.Clear();
            inp_username.Clear();
            inp_password.Clear();
            btn_disable_user.Enabled = true;
            combo_role.SelectedValue = "staff";
            combo_status.SelectedValue = "1";
            state = "...";
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void txt_state_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (state == "เพิ่มผู้ใช้")
            {
                DialogResult confirm_create = MessageBox.Show("คุณต้องการเพิ่มผู้ใช้ใหม่ใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm_create != DialogResult.Yes)
                {
                    return;
                }

                string name = inp_name.Text.Trim();
                string username = inp_username.Text.Trim();
                string password = inp_password.Text.Trim();
                string role = combo_role.SelectedValue?.ToString() ?? "staff";
                string status = combo_status.SelectedValue?.ToString() ?? "1";

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("กรุณากรอกชื่อ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_name.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("กรุณากรอกชื่อผู้ใช้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_username.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("กรุณากรอกรหัสผ่าน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_password.Focus();
                    return;
                }

                using (SqliteConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";

                    using (SqliteCommand checkCmd = new SqliteCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("ชื่ผู้ใช้นี้ถูกใช้งานแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            inp_username.Focus();
                            inp_username.SelectAll();
                            return;
                        }
                    }

                    string hashedPassword = HashPassword(password);

                    string insertQuery = @"
                        INSERT INTO users
                        (
                            name,
                            username,
                            password,
                            role,
                            status
                        )
                        VALUES
                        (
                            @name,
                            @username,
                            @password,
                            @role,
                            @status
                        )
                    ";

                    using (SqliteCommand cmd = new SqliteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@status", status);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("เพิ่มผู้ใช้สำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                state = "";
                panel_form.Enabled = false;

                inp_name.Clear();
                inp_username.Clear();
                inp_password.Clear();
                combo_role.SelectedValue = "staff";
                combo_status.SelectedValue = "1";

                btn_search.PerformClick();
                clearForm();
                return;
            }

            if (state == "แก้ไขผู้ใช้")
            {
                DialogResult confirm_edit = MessageBox.Show("คุณต้องการแก้ไขข้อมูลผู้ใช้นี้ใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm_edit != DialogResult.Yes)
                {
                    return;
                }

                string id = inp_id.Text.Trim();
                string name = inp_name.Text.Trim();
                string username = inp_username.Text.Trim();
                string password = inp_password.Text.Trim();
                string role = combo_role.SelectedValue?.ToString() ?? "staff";
                string status = combo_status.SelectedValue?.ToString() ?? "1";

                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("ไม่พบ ID ผู้ใช้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("กรุณากรอกชื่อผู้ใช้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_name.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(username))
                {
                    MessageBox.Show("กรุณากรอก Username", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_username.Focus();
                    return;
                }

                using (SqliteConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string checkUsernameQuery = @"
            SELECT COUNT(*)
            FROM users
            WHERE username = @username
              AND id <> @id
        ";

                    using (SqliteCommand checkCmd = new SqliteCommand(checkUsernameQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        checkCmd.Parameters.AddWithValue("@id", id);

                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Username นี้ถูกใช้งานแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            inp_username.Focus();
                            inp_username.SelectAll();
                            return;
                        }
                    }

                    string updateQuery;

                    if (string.IsNullOrWhiteSpace(password))
                    {
                        updateQuery = @"
                UPDATE users
                SET 
                    name = @name,
                    username = @username,
                    role = @role,
                    status = @status
                WHERE id = @id
            ";
                    }
                    else
                    {
                        updateQuery = @"
                UPDATE users
                SET 
                    name = @name,
                    username = @username,
                    password = @password,
                    role = @role,
                    status = @status
                WHERE id = @id
            ";
                    }

                    using (SqliteCommand cmd = new SqliteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@status", status);

                        if (!string.IsNullOrWhiteSpace(password))
                        {
                            cmd.Parameters.AddWithValue("@password", HashPassword(password));
                        }

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("แก้ไขข้อมูลผู้ใช้สำเร็จ", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                state = "";
                panel_form.Enabled = false;

                inp_id.Clear();
                inp_name.Clear();
                inp_username.Clear();
                inp_password.Clear();
                combo_role.SelectedValue = "staff";
                combo_status.SelectedValue = "1";

                btn_search.PerformClick();
            }
        }

        private void btn_clear_form_Click(object sender, EventArgs e)
        {
            clearForm();
            panel_form.Enabled = false;
            inp_search.Focus();
            inp_password.PlaceholderText = "";
        }

        private void tbl_users_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            clearForm();
            DataGridViewRow row = tbl_users.Rows[e.RowIndex];
            string user_id = row.Cells["ID"].Value?.ToString();

            if (string.IsNullOrEmpty(user_id)) return;

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT id, name, username, role, status
                    FROM users
                    WHERE id = @id
                    LIMIT 1
                ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", user_id);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("ไม่พบข้อมูลผู้ใช้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        inp_id.Text = reader["id"].ToString();
                        inp_name.Text = reader["name"].ToString();
                        inp_username.Text = reader["username"].ToString();

                        // ไม่ควรดึง password มาแสดง เพราะเป็นรหัสที่ hash แล้ว
                        inp_password.Clear();
                        inp_password.PlaceholderText = "เว้นว่างถ้าไม่ต้องการเปลี่ยนรหัสผ่าน";

                        combo_role.SelectedValue = reader["role"].ToString();
                        combo_status.SelectedValue = reader["status"].ToString();

                        state = "แก้ไขผู้ใช้";
                        panel_form.Enabled = true;
                        inp_name.Focus();
                    }
                }
            }
        }

        private void btn_disable_user_Click(object sender, EventArgs e)
        {
            if (tbl_users.CurrentRow == null)
            {
                MessageBox.Show("กรุณาเลือกผู้ใช้ก่อน", "แจ้งเตือน",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userId = tbl_users.CurrentRow.Cells["ID"].Value?.ToString();
            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("ไม่พบ ID ผู้ใช้", "แจ้งเตือน",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔥 เช็คว่าปิดอยู่แล้วไหม (optional)
            string currentStatus = tbl_users.CurrentRow.Cells["สถานะ"].Value?.ToString();
            if (currentStatus == "ปิดใช้งาน")
            {
                MessageBox.Show("ผู้ใช้นี้ถูกปิดใช้งานอยู่แล้ว", "แจ้งเตือน",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                "ต้องการปิดใช้งานผู้ใช้นี้ใช่หรือไม่?",
                "ยืนยัน",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "UPDATE users SET status = 0 WHERE id = @id";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("ปิดใช้งานผู้ใช้สำเร็จ", "สำเร็จ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // รีโหลดตาราง
            btn_search.PerformClick();
        }
    }
}
