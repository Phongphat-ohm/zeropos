using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace zeropos
{
    public partial class StockManagement : Form
    {
        private Timer clockTimer;

        public StockManagement()
        {
            InitializeComponent();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            LoadStockStat();
            LoadTimeNow();
            GetAllCategory();
            InitTransactionComboBox();
        }

        private void LoadTimeNow()
        {
            clockTimer = new Timer();
            clockTimer.Interval = 1000; // 1 วินาที
            clockTimer.Tick += (s, e) =>
            {
                txt_time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            };

            txt_time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            clockTimer.Start();
        }

        private void LoadStockStat()
        {
            try
            {
                using (SqliteConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string command = @"SELECT 
                        (SELECT COUNT(*) FROM product) AS total_product,
                        (SELECT COUNT(*) FROM product WHERE stock > 0 AND stock <= 10) AS low_stock,
                        (SELECT COUNT(*) FROM product WHERE stock = 0) AS out_of_stock,
                        (SELECT COUNT(*) FROM stock WHERE DATE(created_at) = DATE('now')) AS today_movement;
                    ";

                    using (SqliteCommand cmd = new SqliteCommand(command, conn))
                    {
                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txt_stat_all_pr.Text = reader["total_product"].ToString();
                                txt_stat_pr_alomost_out.Text = reader["low_stock"].ToString();
                                txt_stat_pr_out_stock.Text = reader["out_of_stock"].ToString();
                                txt_stat_transaction_count.Text = reader["today_movement"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock statistics: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void InitTransactionComboBox()
        {
            var dt = new DataTable();
            dt.Columns.Add("value");   // ค่าที่ใช้จริง (EN)
            dt.Columns.Add("display"); // ค่าที่แสดง (TH)

            dt.Rows.Add("IN", "รับเข้า");
            dt.Rows.Add("OUT", "จ่ายออก");
            dt.Rows.Add("ADJUST", "ปรับยอด");

            combo_transaction_type.DataSource = dt;
            combo_transaction_type.DisplayMember = "display";
            combo_transaction_type.ValueMember = "value";

            combo_transaction_type.SelectedIndex = 0;
        }

        private void btn_clear_filter_Click(object sender, EventArgs e)
        {
            inp_search.Clear();
            combo_category.SelectedValue = 0;
            tbl_data.DataSource = null;
            txt_found_count.Text = "พบ 0 รายการ";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search_text = inp_search.Text.Trim();

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        p.id AS 'รหัส',
                        p.sku AS 'SKU',
                        p.name AS 'ชื่อสินค้า',
                        c.name AS 'หมวดหมู่',
                        p.unit AS 'หน่วย',
                        p.stock AS 'คงเหลือ',
                        p.cost AS 'ต้นทุน',
                        p.price AS 'ราคาขาย'
                    FROM product p
                    LEFT JOIN category c ON p.category_id = c.id
                    WHERE 1=1
                ";

                using (SqliteCommand cmd = new SqliteCommand())
                {
                    cmd.Connection = conn;

                    // 🔍 ค้นหาจากชื่อ หรือ SKU
                    if (!string.IsNullOrEmpty(search_text))
                    {
                        query += " AND (p.name LIKE @search OR p.sku LIKE @search)";
                        cmd.Parameters.AddWithValue("@search", "%" + search_text + "%");
                    }

                    // 📂 filter หมวดหมู่
                    if (combo_category.SelectedValue != null && combo_category.SelectedValue.ToString() != "0")
                    {
                        query += " AND p.category_id = @category_id";
                        cmd.Parameters.AddWithValue("@category_id", Convert.ToInt32(combo_category.SelectedValue));
                    }

                    cmd.CommandText = query;

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        tbl_data.DataSource = dt;

                        txt_found_count.Text = $"พบ {dt.Rows.Count} รายการ";
                    }
                }
            }
        }

        private ProductData GetProductById(string product_id)
        {
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
                            return new ProductData
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                SKU = reader["sku"].ToString(),
                                Name = reader["name"].ToString(),
                                Stock = Convert.ToInt32(reader["stock"])
                            };
                        }
                    }
                }
            }

            return null; // ไม่เจอสินค้า
        }

        private void tbl_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tbl_data.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["รหัส"].Value);

                ProductData pr = GetProductById(productId.ToString());

                if (pr != null)
                {
                    MessageBox.Show("เลือกสินค้า\n" + "รหัสสินค้า: " + pr.SKU + "\nชื่อสินค้า: " + pr.Name+ "\nมาเพื่อทำรายการแล้ว", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inp_transaction_count.Focus();
                    panel_transaction.Enabled = true;
                    inp_pr_id.Text = pr.Id.ToString();
                    inp_pr_sku.Text = pr.SKU.ToString();
                    inp_pr_name.Text = pr.Name.ToString();
                    inp_pr_current_stock.Text = pr.Stock.ToString();
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลสินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_clear_form_Click(object sender, EventArgs e)
        {
            combo_transaction_type.SelectedIndex = 0;
            inp_transaction_count.Clear();
            inp_transaction_note.Clear();
        }

        private void btn_save_transaction_Click(object sender, EventArgs e)
        {
            string transaction_type = combo_transaction_type.SelectedValue?.ToString();
            string quantity_text = inp_transaction_count.Text.Trim();
            string note = inp_transaction_note.Text.Trim();

            int ref_id = UserSession.IsLoggedIn ? UserSession.UserId : 0;

            string product_id_text = inp_pr_id.Text.Trim();
            string current_stock_text = inp_pr_current_stock.Text.Trim();

            if (string.IsNullOrEmpty(product_id_text))
            {
                MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการทำรายการ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(transaction_type))
            {
                MessageBox.Show("กรุณาเลือกประเภทการทำรายการ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combo_transaction_type.Focus();
                return;
            }

            if (!int.TryParse(quantity_text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("กรุณากรอกจำนวนให้ถูกต้องและมากกว่า 0", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_transaction_count.Focus();
                return;
            }

            if (!int.TryParse(product_id_text, out int product_id))
            {
                MessageBox.Show("รหัสสินค้าไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(current_stock_text, out int current_stock))
            {
                MessageBox.Show("จำนวนสต๊อกปัจจุบันไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int before_qty = current_stock;
            int after_qty = current_stock;

            if (transaction_type == "IN")
            {
                after_qty = current_stock + quantity;
            }
            else if (transaction_type == "OUT")
            {
                after_qty = current_stock - quantity;

                if (after_qty < 0)
                {
                    MessageBox.Show("สต๊อกไม่พอสำหรับการจ่ายออก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_transaction_count.Focus();
                    return;
                }
            }
            else if (transaction_type == "ADJUST")
            {
                // ADJUST = ปรับยอดให้เป็นจำนวนใหม่
                after_qty = quantity;
            }
            else
            {
                MessageBox.Show("ประเภทการทำรายการไม่ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "ยืนยันการบันทึกรายการสต๊อก\n" +
                $"สินค้า ID: {product_id}\n" +
                $"ประเภท: {combo_transaction_type.Text}\n" +
                $"จำนวน: {quantity}\n" +
                $"ก่อนทำรายการ: {before_qty}\n" +
                $"หลังทำรายการ: {after_qty}\n" +
                $"หรือไม่?",
                "ยืนยันการบันทึก",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.OK)
                return;

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (SqliteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string insertStockQuery = @"
                            INSERT INTO stock
                            (
                                type,
                                product_id,
                                qty,
                                note,
                                ref_id,
                                before_qty,
                                after_qty,
                                created_at,
                                user_id
                            )
                            VALUES
                            (
                                @type,
                                @product_id,
                                @count,
                                @note,
                                @ref_id,
                                @before_qty,
                                @after_qty,
                                @created_at,
                                @user_id
                            )
                        ";

                        using (SqliteCommand stockCmd = new SqliteCommand(insertStockQuery, conn, transaction))
                        {
                            stockCmd.Parameters.AddWithValue("@type", transaction_type);
                            stockCmd.Parameters.AddWithValue("@product_id", product_id);
                            stockCmd.Parameters.AddWithValue("@count", quantity);
                            stockCmd.Parameters.AddWithValue("@note", note);
                            stockCmd.Parameters.AddWithValue("@ref_id", 0);
                            stockCmd.Parameters.AddWithValue("@before_qty", before_qty);
                            stockCmd.Parameters.AddWithValue("@after_qty", after_qty);
                            stockCmd.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture));
                            stockCmd.Parameters.AddWithValue("@user_id", ref_id);

                            stockCmd.ExecuteNonQuery();
                        }

                        string updateProductQuery = @"
                            UPDATE product
                            SET stock = @stock
                            WHERE id = @id
                        ";

                        using (SqliteCommand productCmd = new SqliteCommand(updateProductQuery, conn, transaction))
                        {
                            productCmd.Parameters.AddWithValue("@stock", after_qty);
                            productCmd.Parameters.AddWithValue("@id", product_id);

                            int result = productCmd.ExecuteNonQuery();

                            if (result <= 0)
                                throw new Exception("ไม่สามารถอัปเดตสต๊อกสินค้าได้");
                        }

                        transaction.Commit();

                        MessageBox.Show("บันทึกรายการสต๊อกสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        inp_pr_current_stock.Text = after_qty.ToString();
                        inp_transaction_count.Clear();
                        inp_transaction_note.Clear();
                        combo_transaction_type.SelectedIndex = 0;

                        btn_search.PerformClick();
                        LoadStockStat();
                        // ถ้ามีฟังก์ชันโหลด history ของสินค้าที่เลือก
                        // LoadStockHistory(product_id);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_show_transaction_list_Click(object sender, EventArgs e)
        {
            StockTransactionView view = new StockTransactionView();
            view.product_id = inp_pr_id.Text;
            view.ShowDialog();
        }
    }
}
public class ProductData
{
    public int Id { get; set; }
    public string SKU { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
}