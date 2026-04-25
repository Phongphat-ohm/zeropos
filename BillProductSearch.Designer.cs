namespace zeropos
{
    partial class BillProductSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillProductSearch));
            panel1 = new Panel();
            combo_category = new ComboBox();
            label5 = new Label();
            btn_cancel = new Button();
            btn_select_pr = new Button();
            label4 = new Label();
            tbl_products = new DataGridView();
            btn_clear = new Button();
            btn_search = new Button();
            inp_search = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(combo_category);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btn_cancel);
            panel1.Controls.Add(btn_select_pr);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbl_products);
            panel1.Controls.Add(btn_clear);
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(inp_search);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 608);
            panel1.TabIndex = 0;
            // 
            // combo_category
            // 
            combo_category.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_category.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combo_category.FormattingEnabled = true;
            combo_category.Items.AddRange(new object[] { "หมวดหมู่ทั้งหมด" });
            combo_category.Location = new Point(353, 140);
            combo_category.Name = "combo_category";
            combo_category.Size = new Size(249, 38);
            combo_category.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(20, 564);
            label5.Name = "label5";
            label5.Size = new Size(446, 20);
            label5.TabIndex = 11;
            label5.Text = "F2 = ค้นหา    Enter = เลือกสินค้า    ↑↓ = เลือกรายการ    Esc = ปิดหน้าต่าง";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Silver;
            btn_cancel.Location = new Point(599, 553);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(112, 39);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "ยกเลิก";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += button4_Click;
            // 
            // btn_select_pr
            // 
            btn_select_pr.BackColor = Color.FromArgb(0, 192, 0);
            btn_select_pr.ForeColor = Color.White;
            btn_select_pr.Location = new Point(717, 553);
            btn_select_pr.Name = "btn_select_pr";
            btn_select_pr.Size = new Size(155, 39);
            btn_select_pr.TabIndex = 9;
            btn_select_pr.Text = "เลือกสินค้า";
            btn_select_pr.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(20, 182);
            label4.Name = "label4";
            label4.Size = new Size(247, 20);
            label4.TabIndex = 8;
            label4.Text = "กรอกคำค้นหาแล้วกด Enter หรือปุ่มค้นหา";
            // 
            // tbl_products
            // 
            tbl_products.AllowUserToAddRows = false;
            tbl_products.AllowUserToDeleteRows = false;
            tbl_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_products.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbl_products.BackgroundColor = SystemColors.ControlLightLight;
            tbl_products.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbl_products.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbl_products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbl_products.DefaultCellStyle = dataGridViewCellStyle2;
            tbl_products.Location = new Point(20, 205);
            tbl_products.Name = "tbl_products";
            tbl_products.ReadOnly = true;
            tbl_products.Size = new Size(852, 337);
            tbl_products.TabIndex = 7;
            tbl_products.KeyDown += tbl_products_KeyDown;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Yellow;
            btn_clear.Location = new Point(743, 140);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(129, 39);
            btn_clear.TabIndex = 6;
            btn_clear.Text = "ล้าง";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(0, 0, 192);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(608, 140);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(129, 39);
            btn_search.TabIndex = 5;
            btn_search.Text = "ค้นหา";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // inp_search
            // 
            inp_search.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inp_search.Location = new Point(20, 140);
            inp_search.Name = "inp_search";
            inp_search.Size = new Size(327, 39);
            inp_search.TabIndex = 4;
            inp_search.KeyDown += inp_search_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 112);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 3;
            label3.Text = "คำค้นหา";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(95, 64);
            label2.Name = "label2";
            label2.Size = new Size(403, 20);
            label2.TabIndex = 2;
            label2.Text = "ค้นหาด้วย SKU / ชื่อสินค้า / หมวดหมู่ แล้วเลือกสินค้าเพื่อเพิ่มเข้าบิลล์";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(90, 20);
            label1.Name = "label1";
            label1.Size = new Size(144, 40);
            label1.TabIndex = 1;
            label1.Text = "ค้นหาสินค้า";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BillProductSearch
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(927, 632);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(5);
            Name = "BillProductSearch";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ค้นหาสินค้า";
            Load += BillProductSearch_Load;
            KeyDown += BillProductSearch_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_products).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridView tbl_products;
        private Button btn_clear;
        private Button btn_search;
        private TextBox inp_search;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label5;
        private Button btn_cancel;
        private Button btn_select_pr;
        private ComboBox combo_category;
    }
}