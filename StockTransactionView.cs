using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace zeropos
{
    public partial class StockTransactionView : Form
    {
        public string product_id;

        public StockTransactionView()
        {
            InitializeComponent();
        }

        private void StockTransactionView_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(this.Width, this.Height);
            this.MaximumSize = new Size(this.Width, this.Height);

            if (string.IsNullOrEmpty(product_id))
            {
                MessageBox.Show("กรุณาเลือกสินค้าก่อนดูรายการสต๊อก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }
            else
            {
                LoadProductData();
                InitTransactionComboBox();
                LoadStockHistory(product_id);
            }
        }

        private void LoadProductData()
        {
            if (string.IsNullOrEmpty(product_id))
            {
                MessageBox.Show("ไม่พบรหัสสินค้า");
                return;
            }

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
            SELECT id, sku, name, stock
            FROM product
            WHERE id = @id
        ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", product_id);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_pr_id.Text = reader["id"].ToString();
                            txt_pr_sku.Text = reader["sku"].ToString();
                            txt_pr_name.Text = reader["name"].ToString();
                            txt_pr_stock.Text = reader["stock"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบข้อมูลสินค้า");
                            this.Close();
                        }
                    }
                }
            }
        }

        private void InitTransactionComboBox()
        {
            var dt = new DataTable();
            dt.Columns.Add("value");   // ค่าที่ใช้จริง (EN)
            dt.Columns.Add("display"); // ค่าที่แสดง (TH)

            dt.Rows.Add("ALL", "ทั้งหมด");
            dt.Rows.Add("IN", "รับเข้า");
            dt.Rows.Add("OUT", "จ่ายออก");
            dt.Rows.Add("ADJUST", "ปรับยอด");

            combo_transaction_type.DataSource = dt;
            combo_transaction_type.DisplayMember = "display";
            combo_transaction_type.ValueMember = "value";

            combo_transaction_type.SelectedIndex = 0;
        }

        private void LoadStockHistory(string productId)
        {
            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        s.created_at AS 'เวลา',

                        CASE 
                            WHEN s.type = 'IN' THEN 'รับเข้า'
                            WHEN s.type = 'OUT' THEN 'จ่ายออก'
                            WHEN s.type = 'ADJUST' THEN 'ปรับยอด'
                        END AS 'ประเภท',

                        s.qty AS 'จำนวน',
                        s.before_qty AS 'ก่อน',
                        s.after_qty AS 'หลัง',

                        s.note AS 'หมายเหตุ',

                        s.user_id AS 'ID ผู้ทำรายการ',                 -- 🔥 id ผู้ทำรายการ
                        COALESCE(u.name, 'ไม่ระบุ') AS 'ผู้ทำรายการ',
                        s.ref_id AS 'อ้างอิง',             -- 🔥 ref_id แสดงตรง ๆ

                        s.type AS 'type_raw'           -- 🔥 logic
                    FROM stock s
                    LEFT JOIN product p ON s.product_id = p.id
                    LEFT JOIN users u ON s.user_id = u.id   -- 🔥 join user

                    WHERE s.product_id = @product_id

                    ORDER BY s.id DESC;
                ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product_id", productId);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        tbl_data.DataSource = dt;

                        // 🔥 ซ่อน column raw
                        if (tbl_data.Columns["type_raw"] != null)
                            tbl_data.Columns["type_raw"].Visible = false;

                        // 🔥 ปรับ UI
                        CountStockSummary();
                        FormatStockHistoryTable();
                    }
                }
            }
        }

        private void FormatStockHistoryTable()
        {
            foreach (DataGridViewRow row in tbl_data.Rows)
            {
                if (row.IsNewRow) continue;

                string type = row.Cells["type_raw"].Value?.ToString();
                int qty = Convert.ToInt32(row.Cells["จำนวน"].Value);

                // 🔥 ใส่ + -
                if (type == "OUT")
                {
                    row.Cells["จำนวน"].Value = "-" + qty;
                }
                else
                {
                    row.Cells["จำนวน"].Value = "+" + qty;
                }

                // 🔥 เปลี่ยนสี
                if (type == "IN")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(220, 255, 220); // เขียวอ่อน
                }
                else if (type == "OUT")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 220, 220); // แดงอ่อน
                }
                else if (type == "ADJUST")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(220, 235, 255); // น้ำเงินอ่อน
                }
            }
        }

        private void CountStockSummary()
        {
            int total = 0;
            int total_in = 0;
            int total_out = 0;
            int total_adjust = 0;

            foreach (DataGridViewRow row in tbl_data.Rows)
            {
                if (row.IsNewRow) continue;

                total++;

                string type = row.Cells["type_raw"].Value?.ToString();

                if (type == "IN")
                    total_in++;
                else if (type == "OUT")
                    total_out++;
                else if (type == "ADJUST")
                    total_adjust++;
            }

            txt_all_transaction_count.Text = total.ToString();
            txt_transaction_in.Text = total_in.ToString();
            txt_transaction_out.Text = total_out.ToString();
            txt_transaction_adjust.Text = total_adjust.ToString();
        }

        private void check_search_day_CheckedChanged(object sender, EventArgs e)
        {
            if (check_search_day.Checked)
            {
                inp_start_date.Enabled = true;
                inp_end_date.Enabled = true;
            }
            else
            {
                inp_start_date.Enabled = false;
                inp_end_date.Enabled = false;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search_text = inp_search.Text.Trim();
            string transaction_type = combo_transaction_type.SelectedValue?.ToString();
            bool search_form_date = check_search_day.Checked;
            DateTime start_date = inp_start_date.Value.Date;
            DateTime end_date = inp_end_date.Value.Date;

            if (string.IsNullOrEmpty(product_id))
            {
                MessageBox.Show("ไม่พบรหัสสินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        s.created_at AS 'เวลา',

                        CASE 
                            WHEN s.type = 'IN' THEN 'รับเข้า'
                            WHEN s.type = 'OUT' THEN 'จ่ายออก'
                            WHEN s.type = 'ADJUST' THEN 'ปรับยอด'
                        END AS 'ประเภท',

                        s.qty AS 'จำนวน',
                        s.before_qty AS 'ก่อน',
                        s.after_qty AS 'หลัง',

                        s.note AS 'หมายเหตุ',

                        s.user_id AS 'ID ผู้ทำรายการ',
                        COALESCE(u.name, 'ไม่ระบุ') AS 'ผู้ทำรายการ',
                        s.ref_id AS 'อ้างอิง',

                        s.type AS 'type_raw'
                    FROM stock s
                    LEFT JOIN product p ON s.product_id = p.id
                    LEFT JOIN users u ON s.user_id = u.id
                    WHERE s.product_id = @product_id
                ";

                using (SqliteCommand cmd = new SqliteCommand())
                {
                    cmd.Connection = conn;
                    cmd.Parameters.AddWithValue("@product_id", product_id);

                    if (!string.IsNullOrEmpty(search_text))
                    {
                        query += @"
                    AND (
                        s.note LIKE @search
                        OR CAST(s.user_id AS TEXT) LIKE @search
                        OR COALESCE(u.name, '') LIKE @search
                        OR CAST(s.ref_id AS TEXT) LIKE @search
                        OR CAST(s.qty AS TEXT) LIKE @search
                    )
                ";
                        cmd.Parameters.AddWithValue("@search", "%" + search_text + "%");
                    }

                    if (!string.IsNullOrEmpty(transaction_type) && transaction_type != "ALL")
                    {
                        query += " AND s.type = @type ";
                        cmd.Parameters.AddWithValue("@type", transaction_type);
                    }

                    if (search_form_date)
                    {
                        query += " AND DATE(s.created_at) BETWEEN @start_date AND @end_date ";
                        cmd.Parameters.AddWithValue("@start_date", start_date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                        cmd.Parameters.AddWithValue("@end_date", end_date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    }

                    query += " ORDER BY s.id DESC ";

                    cmd.CommandText = query;

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        tbl_data.DataSource = dt;

                        if (tbl_data.Columns["type_raw"] != null)
                            tbl_data.Columns["type_raw"].Visible = false;

                        FormatStockHistoryTable();
                        CountStockSummary();
                    }
                }
            }
        }

        private void btn_clear_filter_Click(object sender, EventArgs e)
        {
            inp_search.Clear();
            combo_transaction_type.SelectedIndex = 0;
            check_search_day.Checked = false;
            inp_start_date.Value = DateTime.Now;
            inp_end_date.Value = DateTime.Now;
    
            LoadStockHistory(product_id);
        }
    }
}
