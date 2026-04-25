namespace zeropos
{
    partial class StockManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockManagement));
            panel1 = new Panel();
            txt_stat_all_pr = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txt_stat_pr_alomost_out = new Label();
            Label100 = new Label();
            panel3 = new Panel();
            txt_stat_pr_out_stock = new Label();
            label6 = new Label();
            panel4 = new Panel();
            txt_stat_transaction_count = new Label();
            label8 = new Label();
            panel5 = new Panel();
            tbl_data = new DataGridView();
            groupBox1 = new GroupBox();
            txt_found_count = new Label();
            btn_clear_filter = new Button();
            btn_search = new Button();
            combo_category = new ComboBox();
            inp_search = new TextBox();
            panel_transaction = new Panel();
            label19 = new Label();
            txt_time = new Label();
            btn_show_transaction_list = new Button();
            groupBox2 = new GroupBox();
            btn_clear_form = new Button();
            btn_save_transaction = new Button();
            inp_transaction_note = new TextBox();
            label17 = new Label();
            inp_transaction_count = new TextBox();
            label16 = new Label();
            combo_transaction_type = new ComboBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            inp_pr_current_stock = new TextBox();
            inp_pr_name = new TextBox();
            inp_pr_sku = new TextBox();
            inp_pr_id = new TextBox();
            label10 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_data).BeginInit();
            groupBox1.SuspendLayout();
            panel_transaction.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txt_stat_all_pr);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 100);
            panel1.TabIndex = 0;
            // 
            // txt_stat_all_pr
            // 
            txt_stat_all_pr.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_stat_all_pr.ForeColor = Color.FromArgb(0, 192, 0);
            txt_stat_all_pr.Location = new Point(8, 34);
            txt_stat_all_pr.Name = "txt_stat_all_pr";
            txt_stat_all_pr.Size = new Size(285, 58);
            txt_stat_all_pr.TabIndex = 1;
            txt_stat_all_pr.Text = "0";
            txt_stat_all_pr.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "สินค้าทั้งหมด";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txt_stat_pr_alomost_out);
            panel2.Controls.Add(Label100);
            panel2.Location = new Point(324, 14);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 100);
            panel2.TabIndex = 2;
            // 
            // txt_stat_pr_alomost_out
            // 
            txt_stat_pr_alomost_out.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_stat_pr_alomost_out.ForeColor = Color.FromArgb(192, 192, 0);
            txt_stat_pr_alomost_out.Location = new Point(8, 34);
            txt_stat_pr_alomost_out.Name = "txt_stat_pr_alomost_out";
            txt_stat_pr_alomost_out.Size = new Size(285, 58);
            txt_stat_pr_alomost_out.TabIndex = 1;
            txt_stat_pr_alomost_out.Text = "0";
            txt_stat_pr_alomost_out.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label100
            // 
            Label100.AutoSize = true;
            Label100.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label100.ForeColor = SystemColors.ControlDarkDark;
            Label100.Location = new Point(8, 9);
            Label100.Name = "Label100";
            Label100.Size = new Size(114, 25);
            Label100.TabIndex = 0;
            Label100.Text = "สินค้าใกล้หมด";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(txt_stat_pr_out_stock);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(634, 14);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 100);
            panel3.TabIndex = 3;
            // 
            // txt_stat_pr_out_stock
            // 
            txt_stat_pr_out_stock.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_stat_pr_out_stock.ForeColor = Color.FromArgb(192, 0, 0);
            txt_stat_pr_out_stock.Location = new Point(8, 34);
            txt_stat_pr_out_stock.Name = "txt_stat_pr_out_stock";
            txt_stat_pr_out_stock.Size = new Size(285, 58);
            txt_stat_pr_out_stock.TabIndex = 1;
            txt_stat_pr_out_stock.Text = "0";
            txt_stat_pr_out_stock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(8, 9);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 0;
            label6.Text = "สินค้าหมด";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(txt_stat_transaction_count);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(944, 14);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 100);
            panel4.TabIndex = 4;
            // 
            // txt_stat_transaction_count
            // 
            txt_stat_transaction_count.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_stat_transaction_count.ForeColor = Color.Blue;
            txt_stat_transaction_count.Location = new Point(8, 34);
            txt_stat_transaction_count.Name = "txt_stat_transaction_count";
            txt_stat_transaction_count.Size = new Size(285, 58);
            txt_stat_transaction_count.TabIndex = 1;
            txt_stat_transaction_count.Text = "0";
            txt_stat_transaction_count.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(8, 9);
            label8.Name = "label8";
            label8.Size = new Size(170, 25);
            label8.TabIndex = 0;
            label8.Text = "รายการเคลื่อนไหววันนี้";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(tbl_data);
            panel5.Controls.Add(groupBox1);
            panel5.Location = new Point(12, 122);
            panel5.Name = "panel5";
            panel5.Size = new Size(1400, 737);
            panel5.TabIndex = 5;
            // 
            // tbl_data
            // 
            tbl_data.AllowUserToAddRows = false;
            tbl_data.AllowUserToDeleteRows = false;
            tbl_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbl_data.BackgroundColor = SystemColors.ControlLightLight;
            tbl_data.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbl_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbl_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbl_data.DefaultCellStyle = dataGridViewCellStyle2;
            tbl_data.Location = new Point(10, 106);
            tbl_data.Name = "tbl_data";
            tbl_data.ReadOnly = true;
            tbl_data.Size = new Size(1371, 615);
            tbl_data.TabIndex = 1;
            tbl_data.CellDoubleClick += tbl_data_CellDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_found_count);
            groupBox1.Controls.Add(btn_clear_filter);
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(combo_category);
            groupBox1.Controls.Add(inp_search);
            groupBox1.Location = new Point(10, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1371, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ค้นหาสินค้า";
            // 
            // txt_found_count
            // 
            txt_found_count.ForeColor = SystemColors.AppWorkspace;
            txt_found_count.Location = new Point(1151, 15);
            txt_found_count.Name = "txt_found_count";
            txt_found_count.Size = new Size(211, 66);
            txt_found_count.TabIndex = 4;
            txt_found_count.Text = "พบ 0 รายการ";
            txt_found_count.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_clear_filter
            // 
            btn_clear_filter.Location = new Point(825, 31);
            btn_clear_filter.Name = "btn_clear_filter";
            btn_clear_filter.Size = new Size(127, 33);
            btn_clear_filter.TabIndex = 3;
            btn_clear_filter.Text = "ล้างตัวกรอง";
            btn_clear_filter.UseVisualStyleBackColor = true;
            btn_clear_filter.Click += btn_clear_filter_Click;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(692, 32);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(127, 33);
            btn_search.TabIndex = 2;
            btn_search.Text = "ค้นหา";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // combo_category
            // 
            combo_category.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_category.FormattingEnabled = true;
            combo_category.Items.AddRange(new object[] { "หมวดหมู่ทั้งหมด" });
            combo_category.Location = new Point(437, 32);
            combo_category.Name = "combo_category";
            combo_category.Size = new Size(249, 33);
            combo_category.TabIndex = 1;
            // 
            // inp_search
            // 
            inp_search.Location = new Point(16, 32);
            inp_search.Name = "inp_search";
            inp_search.PlaceholderText = "ค้นหาจาก ID SKU หรือ ชื่อ";
            inp_search.Size = new Size(415, 33);
            inp_search.TabIndex = 0;
            // 
            // panel_transaction
            // 
            panel_transaction.BackColor = SystemColors.ControlLightLight;
            panel_transaction.BorderStyle = BorderStyle.Fixed3D;
            panel_transaction.Controls.Add(label19);
            panel_transaction.Controls.Add(txt_time);
            panel_transaction.Controls.Add(btn_show_transaction_list);
            panel_transaction.Controls.Add(groupBox2);
            panel_transaction.Controls.Add(label14);
            panel_transaction.Controls.Add(label13);
            panel_transaction.Controls.Add(label12);
            panel_transaction.Controls.Add(label11);
            panel_transaction.Controls.Add(inp_pr_current_stock);
            panel_transaction.Controls.Add(inp_pr_name);
            panel_transaction.Controls.Add(inp_pr_sku);
            panel_transaction.Controls.Add(inp_pr_id);
            panel_transaction.Controls.Add(label10);
            panel_transaction.Controls.Add(label9);
            panel_transaction.Enabled = false;
            panel_transaction.Location = new Point(1418, 122);
            panel_transaction.Name = "panel_transaction";
            panel_transaction.Size = new Size(474, 737);
            panel_transaction.TabIndex = 6;
            // 
            // label19
            // 
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(21, 659);
            label19.Name = "label19";
            label19.Size = new Size(431, 62);
            label19.TabIndex = 19;
            label19.Text = "** เลือกสินค้าที่ต้องการทำรายการก่อนที่จะทำรายการสต๊อกต่างๆ **\r\nเมื่อทำการบันทึกแล้วจะไม่สามารถแก้ไขหรือลบข้อมูลได้";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_time
            // 
            txt_time.BackColor = SystemColors.ControlLight;
            txt_time.BorderStyle = BorderStyle.Fixed3D;
            txt_time.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_time.Location = new Point(21, 584);
            txt_time.Name = "txt_time";
            txt_time.Size = new Size(431, 75);
            txt_time.TabIndex = 18;
            txt_time.Text = "...";
            txt_time.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_show_transaction_list
            // 
            btn_show_transaction_list.Location = new Point(21, 540);
            btn_show_transaction_list.Name = "btn_show_transaction_list";
            btn_show_transaction_list.Size = new Size(431, 41);
            btn_show_transaction_list.TabIndex = 17;
            btn_show_transaction_list.Text = "ดูการเคลื่อนไหวสต๊อก";
            btn_show_transaction_list.UseVisualStyleBackColor = true;
            btn_show_transaction_list.Click += btn_show_transaction_list_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_clear_form);
            groupBox2.Controls.Add(btn_save_transaction);
            groupBox2.Controls.Add(inp_transaction_note);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(inp_transaction_count);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(combo_transaction_type);
            groupBox2.Controls.Add(label15);
            groupBox2.Location = new Point(21, 265);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 269);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "ทำรายการร";
            // 
            // btn_clear_form
            // 
            btn_clear_form.Location = new Point(224, 211);
            btn_clear_form.Name = "btn_clear_form";
            btn_clear_form.Size = new Size(190, 41);
            btn_clear_form.TabIndex = 16;
            btn_clear_form.Text = "ล้างฟอร์ม";
            btn_clear_form.UseVisualStyleBackColor = true;
            btn_clear_form.Click += btn_clear_form_Click;
            // 
            // btn_save_transaction
            // 
            btn_save_transaction.Location = new Point(16, 211);
            btn_save_transaction.Name = "btn_save_transaction";
            btn_save_transaction.Size = new Size(190, 41);
            btn_save_transaction.TabIndex = 15;
            btn_save_transaction.Text = "บันทึกรายการ";
            btn_save_transaction.UseVisualStyleBackColor = true;
            btn_save_transaction.Click += btn_save_transaction_Click;
            // 
            // inp_transaction_note
            // 
            inp_transaction_note.Location = new Point(151, 119);
            inp_transaction_note.Multiline = true;
            inp_transaction_note.Name = "inp_transaction_note";
            inp_transaction_note.Size = new Size(263, 86);
            inp_transaction_note.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(16, 122);
            label17.Name = "label17";
            label17.Size = new Size(80, 25);
            label17.TabIndex = 13;
            label17.Text = "หมายเหตุ";
            // 
            // inp_transaction_count
            // 
            inp_transaction_count.Location = new Point(151, 80);
            inp_transaction_count.Name = "inp_transaction_count";
            inp_transaction_count.Size = new Size(263, 33);
            inp_transaction_count.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(16, 83);
            label16.Name = "label16";
            label16.Size = new Size(62, 25);
            label16.TabIndex = 12;
            label16.Text = "จำนวน";
            // 
            // combo_transaction_type
            // 
            combo_transaction_type.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_transaction_type.FormattingEnabled = true;
            combo_transaction_type.Location = new Point(151, 41);
            combo_transaction_type.Name = "combo_transaction_type";
            combo_transaction_type.Size = new Size(263, 33);
            combo_transaction_type.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 44);
            label15.Name = "label15";
            label15.Size = new Size(120, 25);
            label15.TabIndex = 10;
            label15.Text = "ประเภทรายการ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(37, 208);
            label14.Name = "label14";
            label14.Size = new Size(116, 25);
            label14.TabIndex = 9;
            label14.Text = "จำนวนคงเหลือ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 169);
            label13.Name = "label13";
            label13.Size = new Size(74, 25);
            label13.TabIndex = 8;
            label13.Text = "ชื่อสินค้า";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 174);
            label12.Name = "label12";
            label12.Size = new Size(30, 25);
            label12.TabIndex = 8;
            label12.Text = "ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 130);
            label11.Name = "label11";
            label11.Size = new Size(46, 25);
            label11.TabIndex = 7;
            label11.Text = "SKU";
            // 
            // inp_pr_current_stock
            // 
            inp_pr_current_stock.Location = new Point(172, 205);
            inp_pr_current_stock.Name = "inp_pr_current_stock";
            inp_pr_current_stock.ReadOnly = true;
            inp_pr_current_stock.Size = new Size(263, 33);
            inp_pr_current_stock.TabIndex = 6;
            // 
            // inp_pr_name
            // 
            inp_pr_name.Location = new Point(172, 166);
            inp_pr_name.Name = "inp_pr_name";
            inp_pr_name.ReadOnly = true;
            inp_pr_name.Size = new Size(263, 33);
            inp_pr_name.TabIndex = 5;
            // 
            // inp_pr_sku
            // 
            inp_pr_sku.Location = new Point(172, 127);
            inp_pr_sku.Name = "inp_pr_sku";
            inp_pr_sku.ReadOnly = true;
            inp_pr_sku.Size = new Size(263, 33);
            inp_pr_sku.TabIndex = 4;
            // 
            // inp_pr_id
            // 
            inp_pr_id.Location = new Point(172, 88);
            inp_pr_id.Name = "inp_pr_id";
            inp_pr_id.ReadOnly = true;
            inp_pr_id.Size = new Size(263, 33);
            inp_pr_id.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 91);
            label10.Name = "label10";
            label10.Size = new Size(30, 25);
            label10.TabIndex = 2;
            label10.Text = "ID";
            // 
            // label9
            // 
            label9.BackColor = Color.FromArgb(192, 255, 255);
            label9.BorderStyle = BorderStyle.Fixed3D;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(3, 3);
            label9.Name = "label9";
            label9.Size = new Size(464, 60);
            label9.TabIndex = 1;
            label9.Text = "ฟอร์มจัดการสต๊อกสินคค้า";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StockManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 871);
            Controls.Add(panel_transaction);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "StockManagement";
            Text = "จัดการสต๊อกสินค้า";
            Load += StockManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_data).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel_transaction.ResumeLayout(false);
            panel_transaction.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label txt_stat_all_pr;
        private Label label1;
        private Panel panel2;
        private Label txt_stat_pr_alomost_out;
        private Label Label100;
        private Panel panel3;
        private Label txt_stat_pr_out_stock;
        private Label label6;
        private Panel panel4;
        private Label txt_stat_transaction_count;
        private Label label8;
        private Panel panel5;
        private GroupBox groupBox1;
        private ComboBox combo_category;
        private TextBox inp_search;
        private Button btn_clear_filter;
        private Button btn_search;
        private DataGridView tbl_data;
        private Panel panel_transaction;
        private Label label9;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox inp_pr_current_stock;
        private TextBox inp_pr_name;
        private TextBox inp_pr_sku;
        private TextBox inp_pr_id;
        private Label label10;
        private GroupBox groupBox2;
        private TextBox inp_transaction_note;
        private Label label17;
        private TextBox inp_transaction_count;
        private Label label16;
        private ComboBox combo_transaction_type;
        private Label label15;
        private Label txt_time;
        private Button btn_show_transaction_list;
        private Button btn_clear_form;
        private Button btn_save_transaction;
        private Label label19;
        private Label txt_found_count;
    }
}