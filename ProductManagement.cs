using Microsoft.Data.Sqlite;
using System.Data;
using System.Globalization;
using System.Xml.Serialization;

namespace zeropos
{
    public partial class ProductManagement : Form
    {
        private string _state;
        private string state
        {
            get { return _state; }
            set { _state = value; txt_state.Text = _state; }
        }

        public ProductManagement()
        {
            InitializeComponent();
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            int all_pr_count = GetAllProductCount();
            txt_all_product.Text = all_pr_count.ToString() + " ชิ้น";
            GetAllCategory();
        }

        private void GetProduct()
        {
            if (combo_category_search.SelectedValue == null) return;

            int category_id = Convert.ToInt32(combo_category_search.SelectedValue);
            string keyword = inp_search.Text.Trim();

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
                        p.stock AS 'สต็อก',
                        p.cost AS 'ต้นทุน',
                        p.price AS 'ราคา'
                    FROM product p
                    LEFT JOIN category c ON p.category_id = c.id
                    WHERE 1=1
                ";

                // filter หมวดหมู่ (0 = ทุกหมวด)
                if (category_id != 0)
                {
                    query += " AND p.category_id = @category_id";
                }

                // filter คำค้นหา (ชื่อสินค้า หรือ SKU)
                if (!string.IsNullOrEmpty(keyword))
                {
                    query += " AND (p.name LIKE @keyword COLLATE NOCASE OR p.sku LIKE @keyword COLLATE NOCASE)";
                }

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    if (category_id != 0)
                    {
                        cmd.Parameters.AddWithValue("@category_id", category_id);
                    }

                    if (!string.IsNullOrEmpty(keyword))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                    }

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        tbl_data.DataSource = dt;
                        tbl_data.AutoResizeColumns();

                        txt_found_search_product.Text = dt.Rows.Count.ToString() + " ชิ้น";

                        if (tbl_data.Columns.Contains("ต้นทุน"))
                            tbl_data.Columns["ต้นทุน"].DefaultCellStyle.Format = "N2";

                        if (tbl_data.Columns.Contains("ราคา"))
                            tbl_data.Columns["ราคา"].DefaultCellStyle.Format = "N2";
                    }
                }
            }
        }

        private int GetAllProductCount()
        {
            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM product";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    // ExecuteScalar ใช้กับ query ที่คืนค่าเดียว
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count;
                }
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

                    combo_pr_cateory.DataSource = dt.Copy();
                    combo_pr_cateory.DisplayMember = "name";
                    combo_pr_cateory.ValueMember = "id";


                    DataTable dtSearch = dt.Copy();
                    DataRow row = dtSearch.NewRow();
                    row["id"] = 0; // ใช้ 0 แทนทั้งหมด
                    row["name"] = "ทุกหมวดหมู่";
                    dtSearch.Rows.InsertAt(row, 0);

                    combo_category_search.DataSource = dtSearch;
                    combo_category_search.DisplayMember = "name";
                    combo_category_search.ValueMember = "id";
                }
            }
        }

        private void clearForm()
        {
            state = "...";
            panel_data.Enabled = false;
            inp_pr_id.ReadOnly = true;
            inp_pr_id.Clear();
            inp_pr_sku.Clear();
            inp_pr_name.Clear();
            combo_pr_cateory.Text = "";
            inp_pr_unit.Clear();
            inp_pr_stock.Clear();
            inp_pr_cost.Clear();
            inp_pr_price.Clear();
            btn_pr_edit.Enabled = true;
            btn_pr_delete.Enabled = true;
            txt_profit.Text = "0.00 บาท";
            inp_search.Focus();
            inp_pr_stock.Text = "0";
            inp_pr_stock.ReadOnly = true ; // ไม่อนุญาตแก้ไขสต็อกโดยตรง
        }

        private void btn_pr_create_Click(object sender, EventArgs e)
        {
            if (state != "เพิ่มสินค้า")
            {
                clearForm();
                state = "เพิ่มสินค้า";
                panel_data.Enabled = true;

                int all_pr_count = GetAllProductCount();
                int product_id = all_pr_count + 1;

                inp_pr_id.Text = product_id.ToString();
                inp_pr_id.ReadOnly = true;
                inp_pr_sku.Focus();

                btn_pr_edit.Enabled = false;
                btn_pr_delete.Enabled = false;
            }
            else
            {
                string pr_id = inp_pr_id.Text.Trim();
                string pr_sku = inp_pr_sku.Text.Trim();
                string pr_name = inp_pr_name.Text.Trim();
                string pr_unit = inp_pr_unit.Text.Trim();
                string pr_stock_text = inp_pr_stock.Text.Trim();
                string pr_cost_text = inp_pr_cost.Text.Trim();
                string pr_price_text = inp_pr_price.Text.Trim();

                if (string.IsNullOrEmpty(pr_sku))
                {
                    MessageBox.Show("กรุณากรอก SKU", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_pr_sku.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(pr_name))
                {
                    MessageBox.Show("กรุณากรอกชื่อสินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_pr_name.Focus();
                    return;
                }

                if (combo_pr_cateory.SelectedValue == null)
                {
                    MessageBox.Show("กรุณาเลือกหมวดหมู่สินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    combo_pr_cateory.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(pr_unit))
                {
                    MessageBox.Show("กรุณากรอกหน่วยสินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_pr_unit.Focus();
                    return;
                }

                if (!int.TryParse(pr_stock_text, out int pr_stock))
                {
                    MessageBox.Show("กรุณากรอกจำนวนสต็อกให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_pr_stock.Focus();
                    return;
                }

                if (!float.TryParse(pr_cost_text, out float pr_cost))
                {
                    MessageBox.Show("กรุณากรอกต้นทุนให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_pr_cost.Focus();
                    return;
                }

                if (!float.TryParse(pr_price_text, out float pr_price))
                {
                    MessageBox.Show("กรุณากรอกราคาขายให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    inp_pr_price.Focus();
                    return;
                }

                int category_id = Convert.ToInt32(combo_pr_cateory.SelectedValue);

                using (SqliteConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM product WHERE sku = @sku";

                    using (SqliteCommand checkCmd = new SqliteCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@sku", pr_sku);

                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("SKU นี้มีอยู่แล้ว กรุณาใช้ SKU อื่น", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            inp_pr_sku.Focus();
                            return;
                        }
                    }
                }

                DialogResult confirm_create = MessageBox.Show(
                    "คุณต้องการเพิ่มสินค้า\n" +
                    $"SKU: {pr_sku.ToString()}\n" +
                    $"ชื่อ: {pr_name.ToString()}\n" +
                    $"หรือไม่?",
                    "ยืนยันการสร้าง",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (confirm_create == DialogResult.OK)
                {
                    try
                    {
                        using (SqliteConnection conn = DatabaseConnection.GetConnection())
                        {
                            conn.Open();

                            string query = @"
                                INSERT INTO product 
                                (id, sku, name, category_id, unit, stock, cost, price)
                                VALUES
                                (@id, @sku, @name, @category_id, @unit, @stock, @cost, @price)
                            ";

                            using (SqliteCommand cmd = new SqliteCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", pr_id);
                                cmd.Parameters.AddWithValue("@sku", pr_sku);
                                cmd.Parameters.AddWithValue("@name", pr_name);
                                cmd.Parameters.AddWithValue("@category_id", category_id);
                                cmd.Parameters.AddWithValue("@unit", pr_unit);
                                cmd.Parameters.AddWithValue("@stock", pr_stock);
                                cmd.Parameters.AddWithValue("@cost", pr_cost);
                                cmd.Parameters.AddWithValue("@price", pr_price);

                                int result = cmd.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show("เพิ่มสินค้าสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    state = "...";
                                    combo_category_search.SelectedValue = category_id;
                                    GetProduct();
                                    clearForm();
                                }
                                else
                                {
                                    MessageBox.Show("ไม่สามารถเพิ่มสินค้าได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("เกิดข้อผิดพลาด: " + ex.Message);
                    }
                    return;
                }
            }
        }

        private void CalculateProfit()
        {
            float cost = 0;
            float price = 0;

            float.TryParse(inp_pr_cost.Text, out cost);
            float.TryParse(inp_pr_price.Text, out price);

            float profit = price - cost;

            txt_profit.Text = profit.ToString("F2") + " บาท";
        }

        private void inp_pr_cost_TextChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void inp_pr_price_TextChanged(object sender, EventArgs e)
        {
            CalculateProfit();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            GetProduct();
        }

        private void ProductManagement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                clearForm();
            }
        }

        private void inp_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
            }
        }

        private Product.ProductProps GetProductFromId(string product_id)
        {
            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM product WHERE id = @id";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", product_id);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            state = "เลือกสินค้า";
                            return new Product.ProductProps
                            {
                                id = Convert.ToInt32(reader["id"]),
                                sku = reader["sku"].ToString(),
                                name = reader["name"].ToString(),
                                category_id = Convert.ToInt32(reader["category_id"]),
                                unit = reader["unit"].ToString(),
                                stock = Convert.ToInt32(reader["stock"]),
                                cost = Convert.ToSingle(reader["cost"]),
                                price = Convert.ToSingle(reader["price"])
                            };
                        }
                    }
                }
            }

            return null; // ถ้าไม่เจอ
        }

        private void tbl_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tbl_data.Rows[e.RowIndex];

                string pr_id = row.Cells["รหัส"].Value.ToString();
                Product.ProductProps pr = GetProductFromId(pr_id);

                if (pr != null)
                {
                    clearForm();
                    state = $"เลือกสินค้า : {pr_id}";
                    panel_data.Enabled = true;
                    inp_pr_id.Text = pr.id.ToString();
                    inp_pr_sku.Text = pr.sku.ToString();
                    inp_pr_name.Text = pr.name.ToString();
                    combo_pr_cateory.SelectedValue = pr.category_id.ToString();
                    inp_pr_unit.Text = pr.unit.ToString();
                    inp_pr_stock.Text = pr.stock.ToString();
                    inp_pr_cost.Text = pr.cost.ToString();
                    inp_pr_price.Text = pr.price.ToString();
                    inp_pr_stock.ReadOnly = true; // ไม่อนุญาตแก้ไขสต็อกโดยตรง
                    CalculateProfit();
                    inp_pr_sku.Focus();
                    return;
                }
            }
        }

        private void btn_clear_filter_Click(object sender, EventArgs e)
        {
            inp_search.Clear();
            combo_category_search.SelectedValue = 0;
            txt_found_search_product.Text = "0 ชิ้น";
            tbl_data.DataSource = null;
        }

        private void btn_pr_edit_Click(object sender, EventArgs e)
        {
            string pr_id = inp_pr_id.Text.Trim();
            string pr_sku = inp_pr_sku.Text.Trim();
            string pr_name = inp_pr_name.Text.Trim();
            string pr_unit = inp_pr_unit.Text.Trim();
            string pr_stock_text = inp_pr_stock.Text.Trim();
            string pr_cost_text = inp_pr_cost.Text.Trim();
            string pr_price_text = inp_pr_price.Text.Trim();

            if (string.IsNullOrEmpty(pr_id))
            {
                MessageBox.Show("ไม่พบรหัสสินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(pr_sku))
            {
                MessageBox.Show("กรุณากรอก SKU", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_pr_sku.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pr_name))
            {
                MessageBox.Show("กรุณากรอกชื่อสินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_pr_name.Focus();
                return;
            }

            if (combo_pr_cateory.SelectedValue == null)
            {
                MessageBox.Show("กรุณาเลือกหมวดหมู่สินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                combo_pr_cateory.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pr_unit))
            {
                MessageBox.Show("กรุณากรอกหน่วยสินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_pr_unit.Focus();
                return;
            }

            if (!int.TryParse(pr_stock_text, out int pr_stock))
            {
                MessageBox.Show("กรุณากรอกจำนวนสต็อกให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_pr_stock.Focus();
                return;
            }

            if (!float.TryParse(pr_cost_text, out float pr_cost))
            {
                MessageBox.Show("กรุณากรอกต้นทุนให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_pr_cost.Focus();
                return;
            }

            if (!float.TryParse(pr_price_text, out float pr_price))
            {
                MessageBox.Show("กรุณากรอกราคาขายให้ถูกต้อง", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_pr_price.Focus();
                return;
            }

            int category_id = Convert.ToInt32(combo_pr_cateory.SelectedValue);

            Product.ProductProps product = GetProductFromId(pr_id);

            if (product != null)
            {
                DialogResult confirm_edit = MessageBox.Show(
                    "ต้องการแก้ไขสินค้า\n" +
                    $"ID: {product.id}\n" +
                    $"SKU เดิม: {product.sku}\n" +
                    $"SKU ใหม่: {pr_sku}\n" +
                    $"ชื่อใหม่: {pr_name}\n" +
                    $"หรือไม่?",
                    "ยืนยันการแก้ไข",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

                if (confirm_edit == DialogResult.OK)
                {
                    try
                    {
                        using (SqliteConnection conn = DatabaseConnection.GetConnection())
                        {
                            conn.Open();

                            // เช็คว่า SKU ซ้ำกับสินค้าตัวอื่นหรือไม่
                            string checkSkuQuery = @"
                        SELECT COUNT(*) 
                        FROM product 
                        WHERE sku = @sku AND id != @id
                    ";

                            using (SqliteCommand checkCmd = new SqliteCommand(checkSkuQuery, conn))
                            {
                                checkCmd.Parameters.AddWithValue("@sku", pr_sku);
                                checkCmd.Parameters.AddWithValue("@id", pr_id);

                                long skuCount = (long)checkCmd.ExecuteScalar();

                                if (skuCount > 0)
                                {
                                    MessageBox.Show("SKU นี้ถูกใช้ไปแล้ว กรุณาใช้ SKU อื่น", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    inp_pr_sku.Focus();
                                    return;
                                }
                            }

                            string updateQuery = @"
                        UPDATE product
                        SET 
                            sku = @sku,
                            name = @name,
                            category_id = @category_id,
                            unit = @unit,
                            stock = @stock,
                            cost = @cost,
                            price = @price
                        WHERE id = @id
                    ";

                            using (SqliteCommand cmd = new SqliteCommand(updateQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@id", pr_id);
                                cmd.Parameters.AddWithValue("@sku", pr_sku);
                                cmd.Parameters.AddWithValue("@name", pr_name);
                                cmd.Parameters.AddWithValue("@category_id", category_id);
                                cmd.Parameters.AddWithValue("@unit", pr_unit);
                                cmd.Parameters.AddWithValue("@stock", pr_stock);
                                cmd.Parameters.AddWithValue("@cost", pr_cost);
                                cmd.Parameters.AddWithValue("@price", pr_price);

                                int result = cmd.ExecuteNonQuery();

                                if (result > 0)
                                {
                                    MessageBox.Show("แก้ไขสินค้าสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    combo_category_search.SelectedValue = category_id;
                                    inp_search.Text = pr_sku;
                                    GetProduct();
                                    clearForm();
                                }
                                else
                                {
                                    MessageBox.Show("ไม่สามารถแก้ไขสินค้าได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                MessageBox.Show(
                    "ไม่พบสินค้า\n" +
                    $"ID: {pr_id}\n" +
                    $"SKU: {pr_sku}",
                    "แจ้งเตือน",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btn_pr_delete_Click(object sender, EventArgs e)
        {
            string pr_id = inp_pr_id.Text.Trim();

            if (string.IsNullOrEmpty(pr_id))
            {
                MessageBox.Show("กรุณาเลือกสินค้าที่ต้องการลบ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // เช็คว่ามีสินค้าจริงไหม
            Product.ProductProps product = GetProductFromId(pr_id);

            if (product == null)
            {
                MessageBox.Show("ไม่พบสินค้า", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ยืนยันการลบ
            DialogResult confirm_delete = MessageBox.Show(
                "คุณต้องการลบสินค้านี้หรือไม่?\n" +
                $"ID: {product.id}\n" +
                $"SKU: {product.sku}\n" +
                $"ชื่อ: {product.name}",
                "ยืนยันการลบ",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning
            );

            if (confirm_delete != DialogResult.OK)
                return;

            try
            {
                using (SqliteConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = "DELETE FROM product WHERE id = @id";

                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", pr_id);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("ลบสินค้าสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GetProduct();
                            clearForm();
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถลบสินค้าได้", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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