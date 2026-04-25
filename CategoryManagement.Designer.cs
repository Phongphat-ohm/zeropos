namespace zeropos
{
    partial class CategoryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManagement));
            panel_category = new Panel();
            inp_id = new TextBox();
            inp_create_at = new TextBox();
            panel_menu = new Panel();
            btn_delete = new Button();
            btn_edit = new Button();
            inp_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            txt_state = new Label();
            btn_create = new Button();
            tbl_data = new DataGridView();
            txt_found_search_category = new Label();
            txt_all_category = new Label();
            groupBox6 = new GroupBox();
            groupBox5 = new GroupBox();
            btn_search = new Button();
            inp_search = new TextBox();
            label5 = new Label();
            panel_category.SuspendLayout();
            panel_menu.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_data).BeginInit();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // panel_category
            // 
            panel_category.BackColor = SystemColors.ControlLight;
            panel_category.BorderStyle = BorderStyle.Fixed3D;
            panel_category.Controls.Add(inp_id);
            panel_category.Controls.Add(inp_create_at);
            panel_category.Controls.Add(panel_menu);
            panel_category.Controls.Add(inp_name);
            panel_category.Controls.Add(label4);
            panel_category.Controls.Add(label3);
            panel_category.Controls.Add(label2);
            panel_category.Controls.Add(label1);
            panel_category.Enabled = false;
            panel_category.Location = new Point(12, 12);
            panel_category.Name = "panel_category";
            panel_category.Size = new Size(500, 290);
            panel_category.TabIndex = 0;
            // 
            // inp_id
            // 
            inp_id.Location = new Point(147, 78);
            inp_id.Name = "inp_id";
            inp_id.Size = new Size(314, 33);
            inp_id.TabIndex = 6;
            // 
            // inp_create_at
            // 
            inp_create_at.Location = new Point(147, 156);
            inp_create_at.Name = "inp_create_at";
            inp_create_at.Size = new Size(314, 33);
            inp_create_at.TabIndex = 5;
            // 
            // panel_menu
            // 
            panel_menu.BackColor = Color.Transparent;
            panel_menu.Controls.Add(btn_delete);
            panel_menu.Controls.Add(btn_edit);
            panel_menu.Location = new Point(3, 212);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(490, 69);
            panel_menu.TabIndex = 1;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(255, 128, 128);
            btn_delete.ForeColor = Color.Maroon;
            btn_delete.Location = new Point(248, 5);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(230, 57);
            btn_delete.TabIndex = 13;
            btn_delete.Text = "ลบ";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(12, 5);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(230, 57);
            btn_edit.TabIndex = 12;
            btn_edit.Text = "แก้ไข";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // inp_name
            // 
            inp_name.Location = new Point(147, 117);
            inp_name.Name = "inp_name";
            inp_name.Size = new Size(314, 33);
            inp_name.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 159);
            label4.Name = "label4";
            label4.Size = new Size(77, 25);
            label4.TabIndex = 3;
            label4.Text = "วันที่สร้าง";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 120);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "ชื่อหมวดหมู่";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 81);
            label2.Name = "label2";
            label2.Size = new Size(30, 25);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(490, 60);
            label1.TabIndex = 0;
            label1.Text = "จัดการหมวดหมู่สินค้า";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ControlLightLight;
            groupBox4.Controls.Add(txt_state);
            groupBox4.Location = new Point(12, 371);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(500, 109);
            groupBox4.TabIndex = 16;
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
            // btn_create
            // 
            btn_create.Location = new Point(12, 308);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(500, 57);
            btn_create.TabIndex = 15;
            btn_create.Text = "เพิ่มหมวดหมู่สินค้า";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
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
            tbl_data.Location = new Point(519, 157);
            tbl_data.Name = "tbl_data";
            tbl_data.ReadOnly = true;
            tbl_data.Size = new Size(1374, 702);
            tbl_data.TabIndex = 17;
            tbl_data.CellDoubleClick += tbl_data_CellDoubleClick;
            // 
            // txt_found_search_category
            // 
            txt_found_search_category.BorderStyle = BorderStyle.Fixed3D;
            txt_found_search_category.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_found_search_category.Location = new Point(6, 29);
            txt_found_search_category.Name = "txt_found_search_category";
            txt_found_search_category.Size = new Size(668, 68);
            txt_found_search_category.TabIndex = 0;
            txt_found_search_category.Text = "0 รายการ";
            txt_found_search_category.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_all_category
            // 
            txt_all_category.BorderStyle = BorderStyle.Fixed3D;
            txt_all_category.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_all_category.Location = new Point(6, 29);
            txt_all_category.Name = "txt_all_category";
            txt_all_category.Size = new Size(668, 68);
            txt_all_category.TabIndex = 0;
            txt_all_category.Text = "0 รายการ";
            txt_all_category.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.FromArgb(255, 192, 192);
            groupBox6.Controls.Add(txt_found_search_category);
            groupBox6.Location = new Point(1213, 51);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(680, 100);
            groupBox6.TabIndex = 22;
            groupBox6.TabStop = false;
            groupBox6.Text = "หมวดหมู่ที่ค้นพบ";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(192, 255, 192);
            groupBox5.Controls.Add(txt_all_category);
            groupBox5.Location = new Point(519, 51);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(680, 100);
            groupBox5.TabIndex = 21;
            groupBox5.TabStop = false;
            groupBox5.Text = "หมวดหมู่ทั้งหมด";
            // 
            // btn_search
            // 
            btn_search.Location = new Point(1775, 12);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(118, 33);
            btn_search.TabIndex = 20;
            btn_search.Text = "ค้นหา";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // inp_search
            // 
            inp_search.Location = new Point(579, 12);
            inp_search.Name = "inp_search";
            inp_search.PlaceholderText = "ค้นหาจากชื่อประเภทสินค้า";
            inp_search.Size = new Size(1190, 33);
            inp_search.TabIndex = 19;
            inp_search.KeyDown += inp_search_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(519, 15);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 18;
            label5.Text = "ค้นหา";
            // 
            // CategoryManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 871);
            Controls.Add(tbl_data);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(btn_search);
            Controls.Add(inp_search);
            Controls.Add(label5);
            Controls.Add(groupBox4);
            Controls.Add(btn_create);
            Controls.Add(panel_category);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(5);
            Name = "CategoryManagement";
            StartPosition = FormStartPosition.CenterParent;
            Text = "จัดการหมวดหมู่สินค้า";
            Load += CategoryManagement_Load;
            KeyDown += CategoryManagement_KeyDown;
            panel_category.ResumeLayout(false);
            panel_category.PerformLayout();
            panel_menu.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_data).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_category;
        private Label label1;
        private TextBox inp_id;
        private TextBox inp_create_at;
        private TextBox inp_name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel_menu;
        private Button btn_edit;
        private Button btn_delete;
        private GroupBox groupBox4;
        private Label txt_state;
        private Button btn_create;
        private DataGridView tbl_data;
        private Label txt_found_search_category;
        private Label txt_all_category;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Button btn_search;
        private TextBox inp_search;
        private Label label5;
    }
}