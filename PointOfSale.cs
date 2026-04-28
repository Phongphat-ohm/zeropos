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
    public partial class PointOfSale : Form
    {
        private Timer clockTimer;
        private int _item_count = 0;
        private decimal _bill_total = 0;
        private decimal _discount = 0;
        private decimal _net_total = 0;
        private int member_id = 0;
        private decimal _vat = 0;

        private int item_count
        {
            get { return _item_count; }
            set
            {
                _item_count = value;
                txt_bill_pr_count.Text = _item_count.ToString();
            }
        }
        private decimal bill_total
        {
            get { return _bill_total; }
            set
            {
                _bill_total = value;
                txt_bill_total.Text = _bill_total.ToString("F2");
            }
        }
        private decimal discount
        {
            get { return _discount; }
            set
            {
                _discount = value;
                txt_bill_discount.Text = _discount.ToString("F2");
            }
        }
        private decimal net_total
        {
            get { return _net_total; }
            set
            {
                _net_total = value;
                txt_bill_net_total.Text = _net_total.ToString("F2");
            }
        }

        private decimal vat
        {
            get { return _vat; }
            set
            {
                _vat = value;
                txt_vat.Text = _vat.ToString("F2");
            }
        }
        public PointOfSale()
        {
            InitializeComponent();
        }

        private void PointOfSale_Load(object sender, EventArgs e)
        {
            LoadTimeNow();
            LoadUser();
            BillCoder bill_coder = new BillCoder();
            string bill_code = bill_coder.Generate();

            txt_bill_code.Text = bill_code;
        }

        private void LoadUser()
        {
            string user_id = UserSession.UserId.ToString();

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT name FROM users WHERE id = @user_id";
                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        txt_user_name.Text = result.ToString();
                        txt_user_name.ForeColor = Color.Green;
                    }
                    else
                    {
                        txt_user_name.Text = "Unknown User";
                        txt_user_name.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void LoadTimeNow()
        {
            clockTimer = new Timer();
            clockTimer.Interval = 1000; // 1 วินาที
            clockTimer.Tick += (s, e) =>
            {
                txt_clock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            };

            txt_clock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            clockTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private ProductSaleData GetProductBySKU(string sku)
        {
            if (string.IsNullOrWhiteSpace(sku))
                return null;

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        id,
                        sku,
                        name,
                        unit,
                        stock,
                        price
                    FROM product
                    WHERE sku = @sku
                    LIMIT 1
                ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sku", sku.Trim());

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ProductSaleData
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                SKU = reader["sku"].ToString(),
                                Name = reader["name"].ToString(),
                                Unit = reader["unit"].ToString(),
                                Stock = Convert.ToInt32(reader["stock"]),
                                Price = Convert.ToDecimal(reader["price"])
                            };
                        }
                    }
                }
            }

            return null;
        }

        public class ProductSaleData
        {
            public int Id { get; set; }
            public string SKU { get; set; }
            public string Name { get; set; }
            public string Unit { get; set; }
            public int Stock { get; set; }
            public decimal Price { get; set; }
        }

        private void btn_search_product_Click(object sender, EventArgs e)
        {
            string sku = inp_barcode.Text;

            if (string.IsNullOrEmpty(sku))
            {
                MessageBox.Show("กรุณากรอกรหัสสินค้าก่อนเพิ่มสินค้าลงบิลล์", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_barcode.Clear();
                inp_barcode.Focus();
                return;
            }

            ProductSaleData pr = GetProductBySKU(sku);

            if (pr == null)
            {
                MessageBox.Show("ไม่พบสินค้าตามรหัสที่กรอก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_barcode.Clear();
                inp_barcode.Focus();
                return;
            }

            if (!decimal.TryParse(inp_qty.Text.Trim(), out decimal qty) || qty <= 0)
            {
                qty = 1;
                inp_qty.Text = "1";
            }

            if (pr.Stock < qty)
            {
                MessageBox.Show("สินค้าในสต๊อกมีจำนวนไม่เพียงพอ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_barcode.Clear();
                inp_barcode.Focus();
                inp_qty.Text = "1";
                return;
            }

            decimal total_calculate = (pr.Price * qty);

            // Set Product Form
            inp_pr_id.Text = pr.Id.ToString();
            inp_pr_name.Text = pr.Name;
            inp_pr_price.Text = pr.Price.ToString("F2");
            inp_pr_qty.Text = inp_qty.Text;
            inp_pr_sku.Text = pr.SKU;
            inp_pr_stock.Text = pr.Stock.ToString();
            inp_pr_total.Text = total_calculate.ToString("F2");

            // Add To Bill Item List Table
            tbl_bill_items.Rows.Insert(0, pr.SKU, pr.Name, pr.Price.ToString("F2"), inp_pr_qty.Text, total_calculate.ToString("F2")); ;

            // Set Bill report
            item_count += Convert.ToInt32(inp_qty.Text);
            bill_total += total_calculate;

            CalculateBillSummary();

            inp_barcode.Clear();
            inp_qty.Text = "1";
        }

        private void inp_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search_product.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.Escape)
            {
                btn_clear_search_text.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.PageDown)
            {
                inp_qty.Focus();
                return;
            }
        }

        private void btn_clear_search_text_Click(object sender, EventArgs e)
        {
            inp_barcode.Clear();
            inp_barcode.Focus();
            inp_qty.Text = "1";
            return;
        }

        private void tbl_bill_items_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tbl_bill_items.Rows[e.RowIndex];

                DialogResult confirm_remove = MessageBox.Show($"คุณต้องการลบรายการสินค้า\nชื่อ: '{row.Cells[1].Value}'\nออกจากบิลล์หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm_remove == DialogResult.Yes)
                {
                    int product_qty = Convert.ToInt32(row.Cells["pr_qty"].Value);
                    decimal product_total = Convert.ToDecimal(row.Cells["pr_total"].Value);

                    // Remove From Bill Item List Table
                    tbl_bill_items.Rows.RemoveAt(e.RowIndex);

                    // Set Bill report
                    item_count -= product_qty;
                    bill_total -= product_total;

                    CalculateBillSummary();

                }
            }
        }

        private void PointOfSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                inp_barcode.Focus();
                return;
            }

            if (e.KeyCode == Keys.F2)
            {
                f2_btn_search_product.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.F3)
            {
                f3_btn_search_member.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.F4)
            {
                f5_btn_pay.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.F5)
            {
                f4_btn_clear_bill.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.Delete)
            {
                tbl_bill_items.Rows[0].Selected = true;
                tbl_bill_items.Focus();
                return;
            }

        }

        private void inp_receive_cash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(inp_receive_cash.Text))
                {
                    MessageBox.Show("กรุณากรอกจำนวนเงินที่รับจากลูกค้าก่อนชำระเงิน", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_receive_cash.Focus();
                    return;
                }
                else
                {
                    decimal receive_cash = Convert.ToDecimal(inp_receive_cash.Text);

                    if (string.IsNullOrEmpty(receive_cash.ToString()))
                    {
                        receive_cash = 0;
                    }

                    if (receive_cash <= 0)
                    {
                        MessageBox.Show("จำนวนเงินที่รับจากลูกค้าต้องมากกว่า 0", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        inp_receive_cash.Focus();
                        return;
                    }

                    if (receive_cash < net_total)
                    {
                        MessageBox.Show("จำนวนเงินที่รับจากลูกค้าต้องไม่น้อยกว่ายอดสุทธิของบิลล์", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        inp_receive_cash.Focus();
                        return;
                    }

                    MessageBox.Show("คำนวณเงินทอนเรียบร้อย", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_change.Text = (receive_cash - net_total).ToString("F2");
                    btn_pay.Focus();
                    return;
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DialogResult confirm_pay = MessageBox.Show($"คุณต้องการชำระเงินสำหรับบิลล์นี้หรือไม่?", "ยืนยันการชำระเงิน", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm_pay == DialogResult.Yes)
            {
                BillPay();
            }
        }

        private class BillItem
        {
            public string Sku { get; set; }
            public string Name { get; set; }
            public int Qty { get; set; }
            public decimal Price { get; set; }
        }

        void BillPay()
        {
            string bill_code = txt_bill_code.Text.Trim();
            string member_id_text = inp_member_id.Text.Trim();
            DataGridView data = tbl_bill_items;

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("ไม่พบรายการสินค้าในบิลล์นี้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_barcode.Focus();
                return;
            }

            if (string.IsNullOrEmpty(bill_code))
            {
                MessageBox.Show("ไม่พบรหัสบิล", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int user_id = UserSession.IsLoggedIn ? UserSession.UserId : 0;

            int? member_id = null;
            if (!string.IsNullOrEmpty(member_id_text) && int.TryParse(member_id_text, out int mid))
            {
                member_id = mid;
            }

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                using (SqliteTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        string created_at = DateTime.Now.ToString(
                            "yyyy-MM-dd HH:mm:ss",
                            System.Globalization.CultureInfo.InvariantCulture
                        );

                        string orderQuery = @"
                            INSERT INTO ""order""
                            (
                                bill_code,
                                member_id,
                                total,
                                discount,
                                net_total,
                                user_id,
                                order_date,
                                paid,
                                change,
                                vat,
                                vat_rate
                            )
                            VALUES
                            (
                                @bill_code,
                                @member_id,
                                @total,
                                @discount,
                                @net_total,
                                @user_id,
                                @created_at,
                                @paid,
                                @change,
                                @vat,
                                @vat_rate
                            )
                        ";

                        using (SqliteCommand cmd = new SqliteCommand(orderQuery, conn, transaction))
                        {
                            decimal receive_cash = Convert.ToDecimal(inp_receive_cash.Text);
                            decimal change = receive_cash - net_total;

                            cmd.Parameters.AddWithValue("@bill_code", bill_code);
                            cmd.Parameters.AddWithValue("@member_id", member_id.HasValue ? member_id.Value : DBNull.Value);
                            cmd.Parameters.AddWithValue("@total", bill_total);
                            cmd.Parameters.AddWithValue("@discount", discount);
                            cmd.Parameters.AddWithValue("@net_total", net_total);
                            cmd.Parameters.AddWithValue("@user_id", user_id);
                            cmd.Parameters.AddWithValue("@created_at", created_at);
                            cmd.Parameters.AddWithValue("@paid", receive_cash);
                            cmd.Parameters.AddWithValue("@change", change);
                            cmd.Parameters.AddWithValue("@vat", vat);
                            cmd.Parameters.AddWithValue("@vat_rate", new Settings().vat);
                            cmd.ExecuteNonQuery();
                        }

                        long order_id;

                        using (SqliteCommand cmd = new SqliteCommand("SELECT last_insert_rowid();", conn, transaction))
                        {
                            order_id = (long)cmd.ExecuteScalar();
                        }

                        // ===============================
                        // รวม SKU ซ้ำก่อน
                        // ===============================
                        Dictionary<string, BillItem> items = new Dictionary<string, BillItem>();

                        foreach (DataGridViewRow row in data.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string sku = row.Cells["pr_sku"].Value?.ToString();
                            string name = row.Cells["pr_name"].Value?.ToString();

                            if (string.IsNullOrEmpty(sku))
                                throw new Exception("พบรายการสินค้าไม่มี SKU");

                            if (!int.TryParse(row.Cells["pr_qty"].Value?.ToString(), out int qty) || qty <= 0)
                                throw new Exception($"จำนวนสินค้าไม่ถูกต้อง: {name}");

                            if (!decimal.TryParse(row.Cells["pr_price"].Value?.ToString(), out decimal price))
                                throw new Exception($"ราคาสินค้าไม่ถูกต้อง: {name}");

                            if (items.ContainsKey(sku))
                            {
                                items[sku].Qty += qty;
                            }
                            else
                            {
                                items.Add(sku, new BillItem
                                {
                                    Sku = sku,
                                    Name = name,
                                    Qty = qty,
                                    Price = price
                                });
                            }
                        }

                        // ===============================
                        // บันทึก order_items + ตัด stock
                        // SKU เดียวกันจะบันทึก stock แค่ครั้งเดียว
                        // ===============================
                        foreach (BillItem item in items.Values)
                        {
                            string sku = item.Sku;
                            string name = item.Name;
                            int qty = item.Qty;
                            decimal price = item.Price;
                            decimal item_total = price * qty;

                            int product_id = 0;
                            int current_stock = 0;

                            string getProductQuery = @"
                                SELECT id, stock
                                FROM product
                                WHERE sku = @sku
                                LIMIT 1
                            ";

                            using (SqliteCommand cmd = new SqliteCommand(getProductQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@sku", sku);

                                using (SqliteDataReader reader = cmd.ExecuteReader())
                                {
                                    if (!reader.Read())
                                        throw new Exception($"ไม่พบสินค้า SKU: {sku}");

                                    product_id = Convert.ToInt32(reader["id"]);
                                    current_stock = Convert.ToInt32(reader["stock"]);
                                }
                            }

                            if (current_stock < qty)
                                throw new Exception($"สินค้า {name} สต๊อกไม่พอ เหลือ {current_stock}");

                            int before_qty = current_stock;
                            int after_qty = current_stock - qty;

                            decimal item_discount = 0;
                            decimal item_net_total = item_total - item_discount;

                            string itemQuery = @"
                                INSERT INTO order_items
                                (
                                    order_id,
                                    product_id,
                                    price,
                                    quantity,
                                    total,
                                    discount,
                                    net_total
                                )
                                VALUES
                                (
                                    @order_id,
                                    @product_id,
                                    @price,
                                    @quantity,
                                    @total,
                                    @discount,
                                    @net_total
                                )
                            ";

                            using (SqliteCommand cmd = new SqliteCommand(itemQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@order_id", order_id);
                                cmd.Parameters.AddWithValue("@product_id", product_id);
                                cmd.Parameters.AddWithValue("@price", price);
                                cmd.Parameters.AddWithValue("@quantity", qty);
                                cmd.Parameters.AddWithValue("@total", item_total);
                                cmd.Parameters.AddWithValue("@discount", item_discount);
                                cmd.Parameters.AddWithValue("@net_total", item_net_total);
                                cmd.ExecuteNonQuery();
                            }

                            string updateStockQuery = @"
                                UPDATE product
                                SET stock = @stock
                                WHERE id = @id
                            ";

                            using (SqliteCommand cmd = new SqliteCommand(updateStockQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@stock", after_qty);
                                cmd.Parameters.AddWithValue("@id", product_id);
                                cmd.ExecuteNonQuery();
                            }

                            string stockQuery = @"
                                INSERT INTO stock
                                (
                                    product_id,
                                    qty,
                                    type,
                                    ref_id,
                                    note,
                                    created_at,
                                    before_qty,
                                    after_qty,
                                    user_id
                                )
                                VALUES
                                (
                                    @product_id,
                                    @qty,
                                    @type,
                                    @ref_id,
                                    @note,
                                    @created_at,
                                    @before_qty,
                                    @after_qty,
                                    @user_id
                                )
                            ";

                            using (SqliteCommand cmd = new SqliteCommand(stockQuery, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@product_id", product_id);
                                cmd.Parameters.AddWithValue("@qty", qty);
                                cmd.Parameters.AddWithValue("@type", "OUT");
                                cmd.Parameters.AddWithValue("@ref_id", order_id);
                                cmd.Parameters.AddWithValue("@note", $"ขายสินค้า บิล {bill_code}");
                                cmd.Parameters.AddWithValue("@created_at", created_at);
                                cmd.Parameters.AddWithValue("@before_qty", before_qty);
                                cmd.Parameters.AddWithValue("@after_qty", after_qty);
                                cmd.Parameters.AddWithValue("@user_id", user_id);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        MessageBox.Show("ชำระเงินสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        tbl_bill_items.Rows.Clear();
                        item_count = 0;
                        bill_total = 0;
                        discount = 0;
                        net_total = 0;

                        txt_bill_code.Text = new BillCoder().Generate();
                        ClearBill();

                        Settings settings = new Settings();
                        if (settings.auto_bill_print)
                        {
                            BillReport report = new BillReport();
                            report.PrintBill(order_id);
                        }
                        else
                        {
                            DialogResult print_bill = MessageBox.Show("ต้องการพิมพ์ใบเสร็จหรือไม่?", "ยืนยันการพิมพ์", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            
                            if (print_bill == DialogResult.Yes)
                            {
                                BillReport report = new BillReport();
                                report.PrintBill(order_id);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("ชำระเงินไม่สำเร็จ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearBill()
        {
            // =========================
            // 🧾 1. เคลียร์รายการสินค้า
            // =========================
            tbl_bill_items.Rows.Clear();

            // =========================
            // 📊 2. Reset ค่าคำนวณบิล
            // =========================
            item_count = 0;
            bill_total = 0;
            discount = 0;
            net_total = 0;
            vat = 0;

            txt_change.Text = "0.00";

            // =========================
            // 🧍 3. เคลียร์สมาชิก
            // =========================
            inp_member_id.Clear();
            inp_member_code.Clear();
            inp_member_name.Clear();
            inp_member_phone.Clear();

            // =========================
            // 📦 4. เคลียร์ข้อมูลสินค้า
            // =========================
            inp_pr_id.Clear();
            inp_pr_sku.Clear();
            inp_pr_name.Clear();
            inp_pr_price.Clear();
            inp_pr_qty.Clear();
            inp_pr_stock.Clear();
            inp_pr_total.Clear();

            // =========================
            // 🔍 5. ช่องค้นหา
            // =========================
            inp_barcode.Clear();
            inp_qty.Text = "1";

            // =========================
            // 💰 6. เงินรับ
            // =========================
            inp_receive_cash.Clear();

            // =========================
            // 🧾 7. สร้างรหัสบิลใหม่
            // =========================

            // =========================
            // 🎯 8. Focus กลับไปยิงบาร์โค้ด
            // =========================
            inp_barcode.Focus();
        }

        private void f5_btn_pay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inp_receive_cash.Text))
            {
                inp_receive_cash.Focus();
                return;
            }
            else
            {
                f5_btn_pay.PerformClick();
                return;
            }
        }

        private void f3_btn_search_member_Click(object sender, EventArgs e)
        {
            btn_add_member.PerformClick();
        }

        private void f2_btn_search_product_Click(object sender, EventArgs e)
        {
            BillProductSearch pr_search = new BillProductSearch();
            pr_search.ShowDialog();

            if (pr_search.DialogResult == DialogResult.OK)
            {
                inp_barcode.Text = pr_search.SKU;
                inp_barcode.Focus();
                return;
            }
        }

        private void f4_btn_clear_bill_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "ต้องการล้างบิลหรือไม่?",
                "ยืนยัน",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                ClearBill();
            }
        }

        private void inp_qty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
            {
                inp_barcode.Focus();
                return;
            }

            if (e.KeyCode == Keys.Escape)
            {
                btn_clear_search_text.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                inp_barcode.Focus();
                return;
            }
        }

        private void btn_add_member_Click(object sender, EventArgs e)
        {
            BillMemberAdd bill_member_add = new BillMemberAdd();
            bill_member_add.ShowDialog();

            if (bill_member_add.DialogResult == DialogResult.OK)
            {
                inp_member_id.Text = bill_member_add._member_id;
                inp_member_code.Text = bill_member_add._member_code;
                inp_member_name.Text = bill_member_add._member_name;
                inp_member_phone.Text = bill_member_add._member_phone;
                inp_barcode.Focus();
                return;
            }
        }

        private void btn_clear_member_Click(object sender, EventArgs e)
        {
            inp_member_id.Clear();
            inp_member_code.Clear();
            inp_member_name.Clear();
            inp_member_phone.Clear();
            inp_barcode.Focus();
            return;
        }

        private void tbl_bill_items_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (tbl_bill_items.CurrentCell == null) return;

                int rowIndex = tbl_bill_items.CurrentCell.RowIndex;

                DataGridViewRow row = tbl_bill_items.Rows[rowIndex];

                DialogResult confirm_remove = MessageBox.Show($"คุณต้องการลบรายการสินค้า\nชื่อ: '{row.Cells[1].Value}'\nออกจากบิลล์หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm_remove == DialogResult.Yes)
                {
                    int product_qty = Convert.ToInt32(row.Cells["pr_qty"].Value);
                    decimal product_total = Convert.ToDecimal(row.Cells["pr_total"].Value);

                    // Remove From Bill Item List Table
                    tbl_bill_items.Rows.RemoveAt(rowIndex);

                    // Set Bill report
                    item_count -= product_qty;
                    bill_total -= product_total;

                    CalculateBillSummary();

                }
            }
        }

        private void btn_cancel_bill_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "ต้องการล้างบิลหรือไม่?",
                "ยืนยัน",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                ClearBill();
            }
        }

        private void CalculateBillSummary()
        {
            decimal vat_rate = 0;
            decimal afterDiscount = bill_total - discount;

            Settings settings = new Settings();

            if (settings.calculate_vat)
            {
                vat_rate = Convert.ToDecimal(settings.vat);
            }

            if (afterDiscount < 0)
                afterDiscount = 0;

            vat = afterDiscount * (vat_rate/100);
            net_total = afterDiscount + vat;

            // แสดงผลบนหน้าจอ
            txt_bill_total.Text = bill_total.ToString("F2");
            txt_bill_discount.Text = discount.ToString("F2");
            txt_vat.Text = vat.ToString("F2");
            txt_bill_net_total.Text = net_total.ToString("F2");
            txt_bill_pr_count.Text = item_count.ToString();
        }
    }
}