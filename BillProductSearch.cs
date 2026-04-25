using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace zeropos
{
    public partial class BillProductSearch : Form
    {
        public string SKU;

        public BillProductSearch()
        {
            InitializeComponent();
        }

        private void BillProductSearch_Load(object sender, EventArgs e)
        {
            GetAllCategory();
        }

        private void GetAllCategory()
        {
            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT id, name FROM category";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    DataTable dtSearch = dt.Copy();
                    DataRow row = dtSearch.NewRow();
                    row["id"] = 0; // ใช้ 0 แทนทั้งหมด
                    row["name"] = "ทุกหมวดหมู่";
                    dtSearch.Rows.InsertAt(row, 0);

                    combo_category.DataSource = dtSearch;
                    combo_category.DisplayMember = "name";
                    combo_category.ValueMember = "id";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
            return;
        }

        private void BillProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_cancel.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.F2)
            {
                btn_search.PerformClick();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search_text = inp_search.Text.Trim();

            if (combo_category.SelectedValue == null)
            {
                MessageBox.Show("กรุณาเลือกหมวดหมู่", "แจ้งเตือน");
                return;
            }

            int category_id = Convert.ToInt32(combo_category.SelectedValue);

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        p.id AS 'ID',
                        p.sku AS 'SKU',
                        p.name AS 'ชื่อสินค้า',
                        c.name AS 'หมวดหมู่',
                        p.unit AS 'หน่วยนับ',
                        p.stock AS 'จำนวนคงเหลือ',
                        p.price AS 'ราคา/ชิ้น'
                    FROM product p
                    LEFT JOIN category c ON p.category_id = c.id
                    WHERE 
                        (@category_id = 0 OR p.category_id = @category_id)
                        AND
                        (
                            @search_text = ''
                            OR p.sku = @search_text
                            OR p.name LIKE @name
                        )
                    LIMIT 10
                ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@category_id", category_id);
                    cmd.Parameters.AddWithValue("@search_text", search_text);
                    cmd.Parameters.AddWithValue("@name", "%" + search_text + "%");

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("ไม่พบสินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tbl_products.DataSource = null;
                            inp_search.Focus();
                            return;
                        }

                        tbl_products.DataSource = dt;

                        if (tbl_products.Rows.Count > 0)
                        {
                            tbl_products.Focus();
                            tbl_products.ClearSelection();
                            tbl_products.Rows[0].Selected = true;
                            tbl_products.CurrentCell = tbl_products.Rows[0].Cells["SKU"];
                        }
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            inp_search.Clear();
            tbl_products.DataSource = null;
        }

        private void tbl_products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (tbl_products.CurrentCell == null) return;

                int rowIndex = tbl_products.CurrentCell.RowIndex;

                // 👉 ได้ row ที่กด Enter
                DataGridViewRow row = tbl_products.Rows[rowIndex];

                // ตัวอย่างดึงข้อมูล
                string sku = row.Cells["SKU"].Value?.ToString();
                string name = row.Cells["ชื่อสินค้า"].Value?.ToString();

                SKU = sku;
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }
    }
}
