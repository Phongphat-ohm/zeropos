using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace zeropos
{
    public partial class MemberManagement : Form
    {
        private string _state = "...";
        private string state
        {
            get { return _state; }
            set
            {
                _state = value;
                txt_state.Text = _state;
            }
        }

        public MemberManagement()
        {
            InitializeComponent();
        }

        private void MemberManagement_Load(object sender, EventArgs e)
        {
            LoadStatus();
        }

        private void LoadStatus()
        {
            // ====== สำหรับฟอร์มปกติ ======
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));

            dt.Rows.Add(0, "ปิดใช้งาน");
            dt.Rows.Add(1, "พร้อมใช้งาน");

            combo_member_status.DataSource = dt;
            combo_member_status.DisplayMember = "name";
            combo_member_status.ValueMember = "id";

            // ====== สำหรับค้นหา ======
            DataTable dt_2 = dt.Copy();

            DataRow row = dt_2.NewRow();
            row["id"] = -1;
            row["name"] = "ทั้งหมด";
            dt_2.Rows.InsertAt(row, 0);

            combo_status.DataSource = dt_2;
            combo_status.DisplayMember = "name";
            combo_status.ValueMember = "id";
        }

        private void ClearForm()
        {
            inp_id.Clear();
            inp_name.Clear();
            inp_member_code.Clear();
            inp_phone.Clear();
            inp_address.Clear();
            combo_member_status.SelectedValue = 1;
            inp_create_at.Clear();
            panel_form.Enabled = false;
            check_auto_generate_mb_code.Checked = false;
            check_auto_generate_mb_code.Enabled = true;
        }

        private void btn_add_member_Click(object sender, EventArgs e)
        {
            if (state != "เพิ่มสมาชิก")
            {
                state = "เพิ่มสมาชิก";

                ClearForm();

                panel_form.Enabled = true;
                inp_member_code.Focus();

                inp_create_at.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                combo_member_status.SelectedValue = 1;

                btn_add_member.Text = "บันทึกสมาชิก";
                return;
            }
        }

        private string generateRandomMemberCode()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 1000000).ToString(); // 100000 - 999999
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_auto_generate_mb_code.Checked)
            {
                inp_member_code.Enabled = false;
                string member_code = generateRandomMemberCode();
                inp_member_code.Text = member_code;
                inp_name.Focus();
            }
            else
            {
                inp_member_code.Enabled = true;
                inp_member_code.Clear();
                inp_member_code.Focus();
            }
        }

        private void btn_clear_form_Click(object sender, EventArgs e)
        {
            ClearForm();
            state = "...";
            inp_search.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (state == "เพิ่มสมาชิก")
            {
                DialogResult result = MessageBox.Show(
                    "ต้องการเพิ่มสมาชิกนี้ใช่หรือไม่?",
                    "ยืนยันการทำรายการ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes)
                {
                    return;
                }

                string member_code = inp_member_code.Text.Trim();
                string name = inp_name.Text.Trim();
                string phone = Regex.Replace(inp_phone.Text, @"\D", "");
                string address = inp_address.Text.Trim();
                int status = Convert.ToInt32(combo_member_status.SelectedValue);
                string create_at = inp_create_at.Text.Trim();

                if (string.IsNullOrWhiteSpace(member_code))
                {
                    MessageBox.Show("กรุณากรอกรหัสสมาชิก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_member_code.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("กรุณากรอกชื่อสมาชิก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_name.Focus();
                    return;
                }

                try
                {
                    using (SqliteConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();

                        string checkQuery = @"
                            SELECT COUNT(*) 
                            FROM members 
                            WHERE member_code = @member_code
                        ";

                        using (SqliteCommand checkCmd = new SqliteCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@member_code", member_code);

                            long count = (long)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("รหัสสมาชิกนี้มีอยู่แล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                inp_member_code.Focus();
                                return;
                            }
                        }

                        string insertQuery = @"
                            INSERT INTO members 
                            (
                                member_code,
                                name,
                                phone,
                                address,
                                status,
                                create_at
                            )
                            VALUES 
                            (
                                @member_code,
                                @name,
                                @phone,
                                @address,
                                @status,
                                @create_at
                            )
                        ";

                        using (SqliteCommand cmd = new SqliteCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@member_code", member_code);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@phone", phone);
                            cmd.Parameters.AddWithValue("@address", address);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@create_at", create_at);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("เพิ่มสมาชิกสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();

                    panel_form.Enabled = false;
                    state = "...";
                    btn_add_member.Text = "เพิ่มสมาชิก";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (state == "แก้ไขข้อมูล")
            {
                DialogResult result = MessageBox.Show(
                    "ต้องการบันทึกการแก้ไขข้อมูลนี้ใช่หรือไม่?",
                    "ยืนยันการทำรายการ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes)
                {
                    return;
                }

                int member_id = Convert.ToInt32(inp_id.Text);
                string member_code = inp_member_code.Text.Trim();
                string name = inp_name.Text.Trim();
                string phone = Regex.Replace(inp_phone.Text, @"\D", "");
                string address = inp_address.Text.Trim();
                int status = Convert.ToInt32(combo_member_status.SelectedValue);

                if (string.IsNullOrWhiteSpace(member_code))
                {
                    MessageBox.Show("กรุณากรอกรหัสสมาชิก");
                    inp_member_code.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("กรุณากรอกชื่อสมาชิก");
                    inp_name.Focus();
                    return;
                }

                try
                {
                    using (SqliteConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();

                        string checkQuery = @"
                            SELECT COUNT(*)
                            FROM members
                            WHERE member_code = @member_code
                            AND id != @id
                        ";

                        using (SqliteCommand checkCmd = new SqliteCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@member_code", member_code);
                            checkCmd.Parameters.AddWithValue("@id", member_id);

                            long count = (long)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("รหัสสมาชิกนี้ถูกใช้แล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                inp_member_code.Focus();
                                return;
                            }
                        }

                        string updateQuery = @"
                UPDATE members
                SET
                    member_code = @member_code,
                    name = @name,
                    phone = @phone,
                    address = @address,
                    status = @status
                WHERE id = @id
            ";

                        using (SqliteCommand cmd = new SqliteCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@member_code", member_code);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@phone", phone);
                            cmd.Parameters.AddWithValue("@address", address);
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@id", member_id);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("แก้ไขข้อมูลสมาชิกสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearForm();
                    btn_search.PerformClick();

                    panel_form.Enabled = false;
                    state = "...";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search_text = inp_search.Text.Trim();

            if (combo_status.SelectedValue == null)
                return;

            int status_filter = Convert.ToInt32(combo_status.SelectedValue);

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT 
                id AS 'ID',
                member_code AS 'รหัสสมาชิก',
                name AS 'ชื่อ',
                phone AS 'เบอร์โทร',
                address AS 'ที่อยู่',
                CASE 
                    WHEN status = 1 THEN 'พร้อมใช้งาน'
                    ELSE 'ปิดใช้งาน'
                END AS 'สถานะ',
                create_at AS 'วันที่สมัคร'
            FROM members
            WHERE 1=1
        ";

                if (!string.IsNullOrWhiteSpace(search_text))
                {
                    query += @"
                AND (
                    member_code LIKE @search OR
                    name LIKE @search OR
                    phone LIKE @search
                )
            ";
                }

                if (status_filter != -1)
                {
                    query += " AND IFNULL(status, 1) = @status ";
                }

                query += " ORDER BY id DESC ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(search_text))
                        cmd.Parameters.AddWithValue("@search", "%" + search_text + "%");

                    if (status_filter != -1)
                        cmd.Parameters.AddWithValue("@status", status_filter);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable data = new DataTable();
                        data.Load(reader);

                        tbl_member.Columns.Clear();
                        tbl_member.AutoGenerateColumns = true;
                        tbl_member.DataSource = data;
                        tbl_member.AutoResizeColumns();

                        txt_found_count.Text = $"ค้นพบ {data.Rows.Count} คน";
                    }
                }
            }
        }

        private void inp_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }

        private void LoadMemberById(int memberId)
        {
            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT id, member_code, name, phone, address, status, create_at
                    FROM members
                    WHERE id = @id
                    LIMIT 1
                ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", memberId);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("ไม่พบสมาชิก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        ClearForm();

                        state = "แก้ไขข้อมูล";
                        panel_form.Enabled = true;
                        check_auto_generate_mb_code.Enabled = false;

                        inp_id.Text = reader["id"].ToString();
                        inp_member_code.Text = reader["member_code"].ToString();
                        inp_name.Text = reader["name"].ToString();
                        inp_phone.Text = reader["phone"].ToString();
                        inp_address.Text = reader["address"].ToString();
                        inp_create_at.Text = reader["create_at"].ToString();

                        combo_member_status.SelectedValue = Convert.ToInt32(reader["status"]);
                    }
                }
            }
        }

        private void tbl_member_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = tbl_member.Rows[e.RowIndex];
            int memberId = Convert.ToInt32(row.Cells["ID"].Value);

            LoadMemberById(memberId);
        }

        private void btn_disable_user_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inp_id.Text))
            {
                MessageBox.Show("กรุณาเลือกสมาชิกก่อน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int member_id = Convert.ToInt32(inp_id.Text);

            // 🔥 ยืนยันก่อนทำรายการ
            DialogResult result = MessageBox.Show(
                "ต้องการปิดใช้งานสมาชิกนี้ใช่หรือไม่?",
                "ยืนยันการทำรายการ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqliteConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"
                UPDATE members
                SET status = 0
                WHERE id = @id
            ";

                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", member_id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("ปิดใช้งานสมาชิกสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                btn_search.PerformClick();

                panel_form.Enabled = false;
                state = "...";
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            inp_search.Clear();
            combo_status.SelectedValue = -1;
            tbl_member.DataSource = null;
            txt_found_count.Text = "ค้นพบ 0 คน";
        }
    }
}
