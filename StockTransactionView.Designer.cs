namespace zeropos
{
    partial class StockTransactionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockTransactionView));
            label1 = new Label();
            groupBox1 = new GroupBox();
            txt_pr_stock = new Label();
            txt_pr_name = new Label();
            txt_pr_sku = new Label();
            txt_pr_id = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            check_search_day = new CheckBox();
            panel2 = new Panel();
            label22 = new Label();
            txt_transaction_adjust = new Label();
            label21 = new Label();
            txt_transaction_out = new Label();
            label19 = new Label();
            txt_transaction_in = new Label();
            label17 = new Label();
            txt_all_transaction_count = new Label();
            label14 = new Label();
            btn_clear_filter = new Button();
            btn_search = new Button();
            inp_end_date = new DateTimePicker();
            label13 = new Label();
            inp_start_date = new DateTimePicker();
            label12 = new Label();
            combo_transaction_type = new ComboBox();
            label11 = new Label();
            inp_search = new TextBox();
            label10 = new Label();
            tbl_data = new DataGridView();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_data).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(256, 37);
            label1.TabIndex = 0;
            label1.Text = "ประวัติการทำรายการ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_pr_stock);
            groupBox1.Controls.Add(txt_pr_name);
            groupBox1.Controls.Add(txt_pr_sku);
            groupBox1.Controls.Add(txt_pr_id);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1360, 106);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ข้อมูลสินค้า";
            // 
            // txt_pr_stock
            // 
            txt_pr_stock.BackColor = SystemColors.ControlLightLight;
            txt_pr_stock.BorderStyle = BorderStyle.Fixed3D;
            txt_pr_stock.Location = new Point(1131, 44);
            txt_pr_stock.Name = "txt_pr_stock";
            txt_pr_stock.RightToLeft = RightToLeft.No;
            txt_pr_stock.Size = new Size(195, 31);
            txt_pr_stock.TabIndex = 10;
            txt_pr_stock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_pr_name
            // 
            txt_pr_name.BackColor = SystemColors.ControlLightLight;
            txt_pr_name.BorderStyle = BorderStyle.Fixed3D;
            txt_pr_name.Location = new Point(559, 44);
            txt_pr_name.Name = "txt_pr_name";
            txt_pr_name.RightToLeft = RightToLeft.No;
            txt_pr_name.Size = new Size(444, 31);
            txt_pr_name.TabIndex = 9;
            txt_pr_name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_pr_sku
            // 
            txt_pr_sku.BackColor = SystemColors.ControlLightLight;
            txt_pr_sku.BorderStyle = BorderStyle.Fixed3D;
            txt_pr_sku.Location = new Point(241, 44);
            txt_pr_sku.Name = "txt_pr_sku";
            txt_pr_sku.RightToLeft = RightToLeft.No;
            txt_pr_sku.Size = new Size(232, 31);
            txt_pr_sku.TabIndex = 8;
            txt_pr_sku.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_pr_id
            // 
            txt_pr_id.BackColor = SystemColors.ControlLightLight;
            txt_pr_id.BorderStyle = BorderStyle.Fixed3D;
            txt_pr_id.Location = new Point(62, 44);
            txt_pr_id.Name = "txt_pr_id";
            txt_pr_id.RightToLeft = RightToLeft.No;
            txt_pr_id.Size = new Size(121, 31);
            txt_pr_id.TabIndex = 7;
            txt_pr_id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1009, 47);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(116, 25);
            label5.TabIndex = 6;
            label5.Text = "จำนวนคงเหลือ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 47);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(74, 25);
            label4.TabIndex = 4;
            label4.Text = "ชื่อสินค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 47);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(46, 25);
            label3.TabIndex = 2;
            label3.Text = "SKU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 47);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(30, 25);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(check_search_day);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_clear_filter);
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(inp_end_date);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(inp_start_date);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(combo_transaction_type);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(inp_search);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(12, 161);
            panel1.Name = "panel1";
            panel1.Size = new Size(1360, 119);
            panel1.TabIndex = 2;
            // 
            // check_search_day
            // 
            check_search_day.AutoSize = true;
            check_search_day.Location = new Point(630, 23);
            check_search_day.Name = "check_search_day";
            check_search_day.Size = new Size(134, 29);
            check_search_day.TabIndex = 12;
            check_search_day.Text = "ค้นหาจากวันที่";
            check_search_day.UseVisualStyleBackColor = true;
            check_search_day.CheckedChanged += check_search_day_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label22);
            panel2.Controls.Add(txt_transaction_adjust);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(txt_transaction_out);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(txt_transaction_in);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(txt_all_transaction_count);
            panel2.Controls.Add(label14);
            panel2.Location = new Point(495, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 40);
            panel2.TabIndex = 11;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(229, 6);
            label22.Name = "label22";
            label22.Size = new Size(67, 25);
            label22.TabIndex = 8;
            label22.Text = "รายการ";
            // 
            // txt_transaction_adjust
            // 
            txt_transaction_adjust.AutoSize = true;
            txt_transaction_adjust.ForeColor = Color.Teal;
            txt_transaction_adjust.Location = new Point(734, 6);
            txt_transaction_adjust.Name = "txt_transaction_adjust";
            txt_transaction_adjust.Size = new Size(22, 25);
            txt_transaction_adjust.TabIndex = 7;
            txt_transaction_adjust.Text = "0";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.ForeColor = Color.Teal;
            label21.Location = new Point(655, 6);
            label21.Name = "label21";
            label21.Size = new Size(73, 25);
            label21.TabIndex = 6;
            label21.Text = "ปรับยอด";
            // 
            // txt_transaction_out
            // 
            txt_transaction_out.AutoSize = true;
            txt_transaction_out.ForeColor = Color.FromArgb(192, 0, 0);
            txt_transaction_out.Location = new Point(548, 6);
            txt_transaction_out.Name = "txt_transaction_out";
            txt_transaction_out.Size = new Size(22, 25);
            txt_transaction_out.TabIndex = 5;
            txt_transaction_out.Text = "0";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.FromArgb(192, 0, 0);
            label19.Location = new Point(470, 6);
            label19.Name = "label19";
            label19.Size = new Size(72, 25);
            label19.TabIndex = 4;
            label19.Text = "จ่ายออก";
            // 
            // txt_transaction_in
            // 
            txt_transaction_in.AutoSize = true;
            txt_transaction_in.ForeColor = Color.Green;
            txt_transaction_in.Location = new Point(364, 6);
            txt_transaction_in.Name = "txt_transaction_in";
            txt_transaction_in.Size = new Size(22, 25);
            txt_transaction_in.TabIndex = 3;
            txt_transaction_in.Text = "0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Green;
            label17.Location = new Point(302, 6);
            label17.Name = "label17";
            label17.Size = new Size(56, 25);
            label17.TabIndex = 2;
            label17.Text = "รับเข้า";
            // 
            // txt_all_transaction_count
            // 
            txt_all_transaction_count.AutoSize = true;
            txt_all_transaction_count.Location = new Point(136, 6);
            txt_all_transaction_count.Name = "txt_all_transaction_count";
            txt_all_transaction_count.Size = new Size(22, 25);
            txt_all_transaction_count.TabIndex = 1;
            txt_all_transaction_count.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 6);
            label14.Name = "label14";
            label14.Size = new Size(122, 25);
            label14.TabIndex = 0;
            label14.Text = "รายการทั้งหมด:";
            // 
            // btn_clear_filter
            // 
            btn_clear_filter.Location = new Point(251, 63);
            btn_clear_filter.Name = "btn_clear_filter";
            btn_clear_filter.Size = new Size(220, 35);
            btn_clear_filter.TabIndex = 10;
            btn_clear_filter.Text = "ล้างตัวกรอง";
            btn_clear_filter.UseVisualStyleBackColor = true;
            btn_clear_filter.Click += btn_clear_filter_Click;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(21, 63);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(220, 35);
            btn_search.TabIndex = 9;
            btn_search.Text = "ค้นหา";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // inp_end_date
            // 
            inp_end_date.Enabled = false;
            inp_end_date.Location = new Point(1132, 21);
            inp_end_date.Name = "inp_end_date";
            inp_end_date.Size = new Size(192, 33);
            inp_end_date.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1041, 24);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.Yes;
            label13.Size = new Size(85, 25);
            label13.TabIndex = 7;
            label13.Text = "สิ้นสุดวันที่";
            // 
            // inp_start_date
            // 
            inp_start_date.Enabled = false;
            inp_start_date.Location = new Point(843, 21);
            inp_start_date.Name = "inp_start_date";
            inp_start_date.Size = new Size(192, 33);
            inp_start_date.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(770, 24);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(67, 25);
            label12.TabIndex = 5;
            label12.Text = "เริ่มวันที่";
            // 
            // combo_transaction_type
            // 
            combo_transaction_type.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_transaction_type.FormattingEnabled = true;
            combo_transaction_type.Location = new Point(449, 21);
            combo_transaction_type.Name = "combo_transaction_type";
            combo_transaction_type.Size = new Size(164, 33);
            combo_transaction_type.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(323, 24);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(120, 25);
            label11.TabIndex = 3;
            label11.Text = "ประเภทรายการ";
            // 
            // inp_search
            // 
            inp_search.Location = new Point(101, 21);
            inp_search.Name = "inp_search";
            inp_search.Size = new Size(216, 33);
            inp_search.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 24);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(74, 25);
            label10.TabIndex = 1;
            label10.Text = "คำค้นหา";
            // 
            // tbl_data
            // 
            tbl_data.AllowUserToAddRows = false;
            tbl_data.AllowUserToDeleteRows = false;
            tbl_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbl_data.BackgroundColor = SystemColors.ControlLightLight;
            tbl_data.BorderStyle = BorderStyle.Fixed3D;
            tbl_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_data.Location = new Point(12, 286);
            tbl_data.Name = "tbl_data";
            tbl_data.ReadOnly = true;
            tbl_data.Size = new Size(1360, 563);
            tbl_data.TabIndex = 3;
            // 
            // StockTransactionView
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 861);
            Controls.Add(tbl_data);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StockTransactionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ดูรายการเคลื่อนไหวสต๊อก";
            Load += StockTransactionView_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label txt_pr_id;
        private Label label5;
        private Label txt_pr_stock;
        private Label txt_pr_name;
        private Label txt_pr_sku;
        private Panel panel1;
        private DateTimePicker inp_end_date;
        private Label label13;
        private DateTimePicker inp_start_date;
        private Label label12;
        private ComboBox combo_transaction_type;
        private Label label11;
        private TextBox inp_search;
        private Label label10;
        private Button btn_clear_filter;
        private Button btn_search;
        private DataGridView tbl_data;
        private Panel panel2;
        private Label txt_transaction_adjust;
        private Label label21;
        private Label txt_transaction_out;
        private Label label19;
        private Label txt_transaction_in;
        private Label label17;
        private Label txt_all_transaction_count;
        private Label label14;
        private Label label22;
        private CheckBox check_search_day;
    }
}