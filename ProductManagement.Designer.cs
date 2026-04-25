namespace zeropos
{
    partial class ProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagement));
            panel_data = new Panel();
            btn_pr_delete = new Button();
            btn_pr_edit = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txt_profit = new Label();
            label11 = new Label();
            label10 = new Label();
            inp_pr_price = new TextBox();
            label9 = new Label();
            inp_pr_cost = new TextBox();
            label5 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            inp_pr_stock = new TextBox();
            label14 = new Label();
            inp_pr_unit = new TextBox();
            label13 = new Label();
            combo_pr_cateory = new ComboBox();
            label8 = new Label();
            inp_pr_name = new TextBox();
            label7 = new Label();
            inp_pr_sku = new TextBox();
            label6 = new Label();
            inp_pr_id = new TextBox();
            label4 = new Label();
            tbl_data = new DataGridView();
            label1 = new Label();
            inp_search = new TextBox();
            btn_search = new Button();
            btn_clear_filter = new Button();
            combo_category_search = new ComboBox();
            label2 = new Label();
            btn_pr_create = new Button();
            groupBox4 = new GroupBox();
            txt_state = new Label();
            groupBox5 = new GroupBox();
            txt_all_product = new Label();
            groupBox6 = new GroupBox();
            txt_found_search_product = new Label();
            panel_data.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_data).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // panel_data
            // 
            panel_data.BackColor = SystemColors.ControlLight;
            panel_data.BorderStyle = BorderStyle.Fixed3D;
            panel_data.Controls.Add(btn_pr_delete);
            panel_data.Controls.Add(btn_pr_edit);
            panel_data.Controls.Add(groupBox2);
            panel_data.Controls.Add(label3);
            panel_data.Controls.Add(groupBox1);
            panel_data.Enabled = false;
            panel_data.Location = new Point(12, 12);
            panel_data.Name = "panel_data";
            panel_data.Size = new Size(500, 669);
            panel_data.TabIndex = 0;
            // 
            // btn_pr_delete
            // 
            btn_pr_delete.BackColor = Color.FromArgb(255, 128, 128);
            btn_pr_delete.ForeColor = Color.Maroon;
            btn_pr_delete.Location = new Point(255, 595);
            btn_pr_delete.Name = "btn_pr_delete";
            btn_pr_delete.Size = new Size(225, 57);
            btn_pr_delete.TabIndex = 12;
            btn_pr_delete.Text = "ลบ";
            btn_pr_delete.UseVisualStyleBackColor = false;
            btn_pr_delete.Click += btn_pr_delete_Click;
            // 
            // btn_pr_edit
            // 
            btn_pr_edit.Location = new Point(18, 595);
            btn_pr_edit.Name = "btn_pr_edit";
            btn_pr_edit.Size = new Size(225, 57);
            btn_pr_edit.TabIndex = 11;
            btn_pr_edit.Text = "แก้ไข";
            btn_pr_edit.UseVisualStyleBackColor = true;
            btn_pr_edit.Click += btn_pr_edit_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(inp_pr_price);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(inp_pr_cost);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(18, 371);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(462, 218);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "ราคา";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_profit);
            groupBox3.Location = new Point(6, 118);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(450, 94);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "กำไร/ชิ้น";
            // 
            // txt_profit
            // 
            txt_profit.BackColor = Color.FromArgb(192, 255, 192);
            txt_profit.BorderStyle = BorderStyle.Fixed3D;
            txt_profit.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_profit.ForeColor = Color.Green;
            txt_profit.Location = new Point(6, 29);
            txt_profit.Name = "txt_profit";
            txt_profit.Size = new Size(438, 62);
            txt_profit.TabIndex = 0;
            txt_profit.Text = "0.00 บาท";
            txt_profit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(413, 82);
            label11.Name = "label11";
            label11.Size = new Size(43, 25);
            label11.TabIndex = 6;
            label11.Text = "บาท";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(413, 43);
            label10.Name = "label10";
            label10.Size = new Size(43, 25);
            label10.TabIndex = 5;
            label10.Text = "บาท";
            // 
            // inp_pr_price
            // 
            inp_pr_price.Location = new Point(103, 79);
            inp_pr_price.Name = "inp_pr_price";
            inp_pr_price.Size = new Size(304, 33);
            inp_pr_price.TabIndex = 4;
            inp_pr_price.TextChanged += inp_pr_price_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 82);
            label9.Name = "label9";
            label9.Size = new Size(79, 25);
            label9.TabIndex = 3;
            label9.Text = "ราคาขาย";
            // 
            // inp_pr_cost
            // 
            inp_pr_cost.Location = new Point(103, 40);
            inp_pr_cost.Name = "inp_pr_cost";
            inp_pr_cost.Size = new Size(304, 33);
            inp_pr_cost.TabIndex = 2;
            inp_pr_cost.TextChanged += inp_pr_cost_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 43);
            label5.Name = "label5";
            label5.Size = new Size(71, 25);
            label5.TabIndex = 1;
            label5.Text = "ราคาซื้อ";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(3, 4);
            label3.Name = "label3";
            label3.Size = new Size(490, 55);
            label3.TabIndex = 0;
            label3.Text = "ข้อมูลสินค้า";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(inp_pr_stock);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(inp_pr_unit);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(combo_pr_cateory);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(inp_pr_name);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(inp_pr_sku);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(inp_pr_id);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(18, 83);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(462, 282);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลสินค้า";
            // 
            // inp_pr_stock
            // 
            inp_pr_stock.Location = new Point(120, 235);
            inp_pr_stock.Name = "inp_pr_stock";
            inp_pr_stock.Size = new Size(336, 33);
            inp_pr_stock.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 238);
            label14.Name = "label14";
            label14.Size = new Size(62, 25);
            label14.TabIndex = 11;
            label14.Text = "จำนวน";
            // 
            // inp_pr_unit
            // 
            inp_pr_unit.Location = new Point(120, 196);
            inp_pr_unit.Name = "inp_pr_unit";
            inp_pr_unit.Size = new Size(336, 33);
            inp_pr_unit.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 199);
            label13.Name = "label13";
            label13.Size = new Size(75, 25);
            label13.TabIndex = 9;
            label13.Text = "หน่วยนับ";
            // 
            // combo_pr_cateory
            // 
            combo_pr_cateory.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_pr_cateory.FormattingEnabled = true;
            combo_pr_cateory.Location = new Point(120, 157);
            combo_pr_cateory.Name = "combo_pr_cateory";
            combo_pr_cateory.Size = new Size(336, 33);
            combo_pr_cateory.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 160);
            label8.Name = "label8";
            label8.Size = new Size(76, 25);
            label8.TabIndex = 7;
            label8.Text = "หมวดหมู่";
            // 
            // inp_pr_name
            // 
            inp_pr_name.Location = new Point(120, 118);
            inp_pr_name.Name = "inp_pr_name";
            inp_pr_name.Size = new Size(336, 33);
            inp_pr_name.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 121);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 5;
            label7.Text = "ชื่อสินค้า";
            // 
            // inp_pr_sku
            // 
            inp_pr_sku.Location = new Point(120, 79);
            inp_pr_sku.Name = "inp_pr_sku";
            inp_pr_sku.Size = new Size(336, 33);
            inp_pr_sku.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 82);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 3;
            label6.Text = "SKU";
            // 
            // inp_pr_id
            // 
            inp_pr_id.Location = new Point(120, 40);
            inp_pr_id.Name = "inp_pr_id";
            inp_pr_id.Size = new Size(336, 33);
            inp_pr_id.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 43);
            label4.Name = "label4";
            label4.Size = new Size(30, 25);
            label4.TabIndex = 1;
            label4.Text = "ID";
            // 
            // tbl_data
            // 
            tbl_data.AllowUserToAddRows = false;
            tbl_data.AllowUserToDeleteRows = false;
            tbl_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbl_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbl_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbl_data.DefaultCellStyle = dataGridViewCellStyle2;
            tbl_data.Location = new Point(518, 157);
            tbl_data.Name = "tbl_data";
            tbl_data.ReadOnly = true;
            tbl_data.Size = new Size(1374, 702);
            tbl_data.TabIndex = 1;
            tbl_data.CellDoubleClick += tbl_data_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(518, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 2;
            label1.Text = "ค้นหา";
            // 
            // inp_search
            // 
            inp_search.Location = new Point(578, 12);
            inp_search.Name = "inp_search";
            inp_search.PlaceholderText = "ค้นหาสินค้าจาก SKU หรือ ชื่อสินค้า";
            inp_search.Size = new Size(571, 33);
            inp_search.TabIndex = 3;
            inp_search.KeyDown += inp_search_KeyDown;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(1631, 12);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(118, 33);
            btn_search.TabIndex = 4;
            btn_search.Text = "ค้นหา";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_clear_filter
            // 
            btn_clear_filter.Location = new Point(1755, 12);
            btn_clear_filter.Name = "btn_clear_filter";
            btn_clear_filter.Size = new Size(137, 33);
            btn_clear_filter.TabIndex = 5;
            btn_clear_filter.Text = "ล้างตัวกรอง";
            btn_clear_filter.UseVisualStyleBackColor = true;
            btn_clear_filter.Click += btn_clear_filter_Click;
            // 
            // combo_category_search
            // 
            combo_category_search.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_category_search.FormattingEnabled = true;
            combo_category_search.Items.AddRange(new object[] { "0.ทุกหมวดหมู่" });
            combo_category_search.Location = new Point(1237, 12);
            combo_category_search.Name = "combo_category_search";
            combo_category_search.Size = new Size(388, 33);
            combo_category_search.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1155, 16);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 7;
            label2.Text = "หมวดหมู่";
            // 
            // btn_pr_create
            // 
            btn_pr_create.Location = new Point(12, 687);
            btn_pr_create.Name = "btn_pr_create";
            btn_pr_create.Size = new Size(500, 57);
            btn_pr_create.TabIndex = 13;
            btn_pr_create.Text = "เพิ่มสินค้า";
            btn_pr_create.UseVisualStyleBackColor = true;
            btn_pr_create.Click += btn_pr_create_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ControlLightLight;
            groupBox4.Controls.Add(txt_state);
            groupBox4.Location = new Point(12, 750);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(500, 109);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "รายการ";
            // 
            // txt_state
            // 
            txt_state.BackColor = Color.FromArgb(255, 192, 192);
            txt_state.BorderStyle = BorderStyle.Fixed3D;
            txt_state.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_state.ForeColor = Color.FromArgb(64, 0, 0);
            txt_state.Location = new Point(6, 29);
            txt_state.Name = "txt_state";
            txt_state.Size = new Size(489, 77);
            txt_state.TabIndex = 1;
            txt_state.Text = "...";
            txt_state.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(192, 255, 192);
            groupBox5.Controls.Add(txt_all_product);
            groupBox5.Location = new Point(518, 51);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(680, 100);
            groupBox5.TabIndex = 15;
            groupBox5.TabStop = false;
            groupBox5.Text = "จำนวนสินค้าทั้งหมด";
            // 
            // txt_all_product
            // 
            txt_all_product.BorderStyle = BorderStyle.Fixed3D;
            txt_all_product.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_all_product.Location = new Point(6, 29);
            txt_all_product.Name = "txt_all_product";
            txt_all_product.Size = new Size(668, 68);
            txt_all_product.TabIndex = 0;
            txt_all_product.Text = "0 ชิ้น";
            txt_all_product.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.FromArgb(255, 192, 192);
            groupBox6.Controls.Add(txt_found_search_product);
            groupBox6.Location = new Point(1212, 51);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(680, 100);
            groupBox6.TabIndex = 16;
            groupBox6.TabStop = false;
            groupBox6.Text = "ค้นพบ";
            // 
            // txt_found_search_product
            // 
            txt_found_search_product.BorderStyle = BorderStyle.Fixed3D;
            txt_found_search_product.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_found_search_product.Location = new Point(6, 29);
            txt_found_search_product.Name = "txt_found_search_product";
            txt_found_search_product.Size = new Size(668, 68);
            txt_found_search_product.TabIndex = 0;
            txt_found_search_product.Text = "0 ชิ้น";
            txt_found_search_product.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ProductManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 871);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(btn_pr_create);
            Controls.Add(label2);
            Controls.Add(combo_category_search);
            Controls.Add(btn_clear_filter);
            Controls.Add(btn_search);
            Controls.Add(inp_search);
            Controls.Add(label1);
            Controls.Add(tbl_data);
            Controls.Add(panel_data);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(5);
            Name = "ProductManagement";
            Text = "จัดการสินค้า";
            Load += ProductManagement_Load;
            KeyDown += ProductManagement_KeyDown;
            panel_data.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_data).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_data;
        private DataGridView tbl_data;
        private Label label1;
        private TextBox inp_search;
        private Button btn_search;
        private Button btn_clear_filter;
        private ComboBox combo_category_search;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox inp_pr_id;
        private GroupBox groupBox2;
        private TextBox inp_pr_cost;
        private Label label5;
        private GroupBox groupBox1;
        private ComboBox combo_pr_cateory;
        private Label label8;
        private TextBox inp_pr_name;
        private Label label7;
        private TextBox inp_pr_sku;
        private Label label6;
        private GroupBox groupBox3;
        private Label txt_profit;
        private Label label11;
        private Label label10;
        private TextBox inp_pr_price;
        private Label label9;
        private TextBox inp_pr_stock;
        private Label label14;
        private TextBox inp_pr_unit;
        private Label label13;
        private Button btn_pr_delete;
        private Button btn_pr_edit;
        private Button btn_pr_create;
        private GroupBox groupBox4;
        private Label txt_state;
        private GroupBox groupBox5;
        private Label txt_all_product;
        private GroupBox groupBox6;
        private Label txt_found_search_product;
    }
}