using Microsoft.Data.Sqlite;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace zeropos
{
    public partial class CategoryManagement : Form
    {
        private string _state;
        private string state
        {
            get { return _state; }
            set { _state = value; txt_state.Text = _state; }
        }

        public CategoryManagement()
        {
            InitializeComponent();
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            int category_count = AllCategoryCount();
            txt_all_category.Text = category_count.ToString() + " รายการ";
        }

        private int AllCategoryCount()
        {
            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM category";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();

                    return Convert.ToInt32(result);
                }
            }
        }

        private void CLearForm()
        {
            state = "...";
            inp_id.Clear();
            inp_name.Clear();
            inp_create_at.Clear();
            panel_category.Enabled = false;
            inp_id.Enabled = false;
            panel_menu.Enabled = true;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (state == "สร้างหมวดหมู่")
            {
                string id = inp_id.Text.Trim();
                string name = inp_name.Text.Trim();
                string create_at = inp_create_at.Text.Trim();

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("กรุณากรอกชื่อหมวดหมู่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_name.Focus();
                    return;
                }

                DialogResult confirm = MessageBox.Show(
                    $"ต้องการสร้างหมวดหมู่\nชื่อ: {name}\nหรือไม่?",
                    "ยืนยันการสร้าง",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (confirm != DialogResult.OK)
                    return;

                try
                {
                    using (SqliteConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();

                        // เช็คชื่อหมวดหมู่ซ้ำ
                        string checkQuery = "SELECT COUNT(*) FROM category WHERE name = @name";
                        using (SqliteCommand checkCmd = new SqliteCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@name", name);
                            long count = (long)checkCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                MessageBox.Show("ชื่อหมวดหมู่นี้มีอยู่แล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                inp_name.Focus();
                                return;
                            }
                        }

                        string query = @"
                            INSERT INTO category (id, name, create_at)
                            VALUES (@id, @name, @create_at)
                        ";

                        using (SqliteCommand cmd = new SqliteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@create_at", create_at);

                            int result = cmd.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("สร้างหมวดหมู่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                state = "...";
                                panel_category.Enabled = false;
                                panel_menu.Enabled = true;

                                CLearForm();
                                AllCategoryCount();

                                inp_search.Text = name;

                                btn_search.PerformClick();
                            }
                            else
                            {
                                MessageBox.Show("ไม่สามารถสร้างหมวดหมู่ได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                CLearForm();
                state = "สร้างหมวดหมู่";
                panel_category.Enabled = true;
                inp_id.Enabled = false;
                inp_create_at.Enabled = false;
                inp_name.Focus();

                int all_category_count = AllCategoryCount();
                inp_id.Text = (all_category_count + 1).ToString();

                // ถ้าจะใช้ปีคริสต์ศักราชปกติ
                inp_create_at.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

                // ถ้าคุณอยากแสดงปี พ.ศ. จริง ๆ ใช้อันนี้แทน
                // inp_create_at.Text = DateTime.Now.ToString("dd/MM/") + (DateTime.Now.Year + 543) + DateTime.Now.ToString(" HH:mm:ss");

                panel_menu.Enabled = false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search_text = inp_search.Text.Trim();

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        id AS 'รหัส',
                        name AS 'ชื่อหมวดหมู่',
                        create_at AS 'วันที่สร้าง'
                    FROM category
                    WHERE name LIKE @search
                ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + search_text + "%");

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        tbl_data.DataSource = dt;

                        txt_found_search_category.Text = $"{dt.Rows.Count} รายการ";
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

        private void CategoryManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                CLearForm();
                inp_search.Focus();
            }
        }

        private void LoadCategoryById(string id)
        {
            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM category WHERE id = @id";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            CLearForm();
                            inp_id.Text = reader["id"].ToString();
                            inp_name.Text = reader["name"].ToString();
                            inp_create_at.Text = reader["create_at"].ToString();

                            inp_id.Enabled = false;
                            inp_create_at.Enabled = false;

                            panel_category.Enabled = true;
                            state = "แก้ไขหมวดหมู่";
                        }
                    }
                }
            }
        }

        private void tbl_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tbl_data.Rows[e.RowIndex];

                string id = row.Cells["รหัส"].Value?.ToString();
                LoadCategoryById(id);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string id = inp_id.Text.Trim();
            string name = inp_name.Text.Trim();
            string create_at = inp_create_at.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("กรุณาเลือกหมวดหมู่ที่ต้องการแก้ไข", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("กรุณากรอกชื่อหมวดหมู่", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_name.Focus();
                return;
            }

            try
            {
                using (SqliteConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // เช็คว่ามีหมวดหมู่นี้จริงไหม
                    string checkCategoryQuery = "SELECT COUNT(*) FROM category WHERE id = @id";
                    using (SqliteCommand checkCategoryCmd = new SqliteCommand(checkCategoryQuery, conn))
                    {
                        checkCategoryCmd.Parameters.AddWithValue("@id", id);

                        long categoryCount = (long)checkCategoryCmd.ExecuteScalar();

                        if (categoryCount <= 0)
                        {
                            MessageBox.Show("ไม่พบหมวดหมู่ที่ต้องการแก้ไข", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // เช็คชื่อซ้ำ แต่ไม่รวม id เดิม
                    string checkNameQuery = @"
                SELECT COUNT(*) 
                FROM category 
                WHERE name = @name AND id != @id
            ";

                    using (SqliteCommand checkNameCmd = new SqliteCommand(checkNameQuery, conn))
                    {
                        checkNameCmd.Parameters.AddWithValue("@name", name);
                        checkNameCmd.Parameters.AddWithValue("@id", id);

                        long duplicateCount = (long)checkNameCmd.ExecuteScalar();

                        if (duplicateCount > 0)
                        {
                            MessageBox.Show("ชื่อหมวดหมู่นี้มีอยู่แล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            inp_name.Focus();
                            return;
                        }
                    }

                    DialogResult confirm = MessageBox.Show(
                        $"ต้องการแก้ไขหมวดหมู่\nID: {id}\nชื่อใหม่: {name}\nหรือไม่?",
                        "ยืนยันการแก้ไข",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question
                    );

                    if (confirm != DialogResult.OK)
                        return;

                    string updateQuery = @"
                UPDATE category
                SET name = @name
                WHERE id = @id
            ";

                    using (SqliteCommand cmd = new SqliteCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("แก้ไขหมวดหมู่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CLearForm();
                            AllCategoryCount();

                            inp_search.Text = name;

                            btn_search.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถแก้ไขหมวดหมู่ได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string id = inp_id.Text.Trim();
            string name = inp_name.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("กรุณาเลือกหมวดหมู่ที่ต้องการลบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqliteConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // เช็คว่าหมวดหมู่นี้มีอยู่จริงไหม
                    string checkCategoryQuery = "SELECT COUNT(*) FROM category WHERE id = @id";
                    using (SqliteCommand checkCategoryCmd = new SqliteCommand(checkCategoryQuery, conn))
                    {
                        checkCategoryCmd.Parameters.AddWithValue("@id", id);

                        long categoryCount = (long)checkCategoryCmd.ExecuteScalar();

                        if (categoryCount <= 0)
                        {
                            MessageBox.Show("ไม่พบหมวดหมู่ที่ต้องการลบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // เช็คว่ามีสินค้าในหมวดหมู่นี้หรือไม่
                    string checkProductQuery = "SELECT COUNT(*) FROM product WHERE category_id = @category_id";
                    using (SqliteCommand checkProductCmd = new SqliteCommand(checkProductQuery, conn))
                    {
                        checkProductCmd.Parameters.AddWithValue("@category_id", id);

                        long productCount = (long)checkProductCmd.ExecuteScalar();

                        if (productCount > 0)
                        {
                            MessageBox.Show(
                                $"ไม่สามารถลบหมวดหมู่นี้ได้\nเนื่องจากมีสินค้าอยู่ในหมวดหมู่นี้ {productCount} รายการ",
                                "แจ้งเตือน",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }

                    DialogResult confirm = MessageBox.Show(
                        $"ต้องการลบหมวดหมู่\nID: {id}\nชื่อ: {name}\nหรือไม่?",
                        "ยืนยันการลบ",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question
                    );

                    if (confirm != DialogResult.OK)
                        return;

                    string deleteQuery = "DELETE FROM category WHERE id = @id";
                    using (SqliteCommand cmd = new SqliteCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("ลบหมวดหมู่สำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            CLearForm();
                            AllCategoryCount();

                            btn_search.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถลบหมวดหมู่ได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
