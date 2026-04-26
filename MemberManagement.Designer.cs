namespace zeropos
{
    partial class MemberManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberManagement));
            panel1 = new Panel();
            btn_add_member = new Button();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            txt_found_count = new Label();
            tbl_member = new DataGridView();
            btn_clear = new Button();
            btn_search = new Button();
            combo_status = new ComboBox();
            inp_search = new TextBox();
            label3 = new Label();
            panel_form = new Panel();
            check_auto_generate_mb_code = new CheckBox();
            btn_disable_user = new Button();
            btn_save = new Button();
            btn_clear_form = new Button();
            label13 = new Label();
            combo_member_status = new ComboBox();
            inp_create_at = new TextBox();
            label12 = new Label();
            label11 = new Label();
            inp_address = new TextBox();
            label10 = new Label();
            inp_phone = new MaskedTextBox();
            inp_name = new TextBox();
            label9 = new Label();
            inp_member_code = new TextBox();
            label7 = new Label();
            inp_id = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            txt_state = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_member).BeginInit();
            panel_form.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btn_add_member);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1880, 125);
            panel1.TabIndex = 0;
            // 
            // btn_add_member
            // 
            btn_add_member.BackColor = Color.DodgerBlue;
            btn_add_member.ForeColor = Color.White;
            btn_add_member.Location = new Point(1621, 30);
            btn_add_member.Name = "btn_add_member";
            btn_add_member.Size = new Size(214, 62);
            btn_add_member.TabIndex = 2;
            btn_add_member.Text = "+ เพิ่มสมาชิก";
            btn_add_member.UseVisualStyleBackColor = false;
            btn_add_member.Click += btn_add_member_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(28, 67);
            label2.Name = "label2";
            label2.Size = new Size(382, 25);
            label2.TabIndex = 1;
            label2.Text = "ค้นหา เพิ่ม แก้ไข และจัดการข้อมูลสมาชิกของร้านค้า";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(205, 47);
            label1.TabIndex = 0;
            label1.Text = "จัดการสมาชิก";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txt_found_count);
            panel2.Controls.Add(tbl_member);
            panel2.Controls.Add(btn_clear);
            panel2.Controls.Add(btn_search);
            panel2.Controls.Add(combo_status);
            panel2.Controls.Add(inp_search);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 716);
            panel2.TabIndex = 1;
            // 
            // txt_found_count
            // 
            txt_found_count.AutoSize = true;
            txt_found_count.ForeColor = SystemColors.ControlDarkDark;
            txt_found_count.Location = new Point(1167, 103);
            txt_found_count.Name = "txt_found_count";
            txt_found_count.RightToLeft = RightToLeft.Yes;
            txt_found_count.Size = new Size(100, 25);
            txt_found_count.TabIndex = 7;
            txt_found_count.Text = "ค้นพบ 0 คน";
            txt_found_count.TextAlign = ContentAlignment.TopRight;
            // 
            // tbl_member
            // 
            tbl_member.AllowUserToAddRows = false;
            tbl_member.AllowUserToDeleteRows = false;
            tbl_member.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_member.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbl_member.BackgroundColor = SystemColors.ControlLightLight;
            tbl_member.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbl_member.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbl_member.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbl_member.DefaultCellStyle = dataGridViewCellStyle2;
            tbl_member.Location = new Point(28, 131);
            tbl_member.Name = "tbl_member";
            tbl_member.ReadOnly = true;
            tbl_member.Size = new Size(1239, 559);
            tbl_member.TabIndex = 6;
            tbl_member.CellDoubleClick += tbl_member_CellDoubleClick;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Silver;
            btn_clear.ForeColor = Color.Black;
            btn_clear.Location = new Point(983, 60);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(140, 44);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "ล้าง";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.DodgerBlue;
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(837, 60);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(140, 44);
            btn_search.TabIndex = 4;
            btn_search.Text = "ค้นหา";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // combo_status
            // 
            combo_status.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_status.FormattingEnabled = true;
            combo_status.Location = new Point(614, 67);
            combo_status.Name = "combo_status";
            combo_status.Size = new Size(217, 33);
            combo_status.TabIndex = 2;
            // 
            // inp_search
            // 
            inp_search.Location = new Point(28, 67);
            inp_search.Name = "inp_search";
            inp_search.Size = new Size(580, 33);
            inp_search.TabIndex = 1;
            inp_search.KeyDown += inp_search_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 27);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 0;
            label3.Text = "ค้นหาสมาชิก";
            // 
            // panel_form
            // 
            panel_form.BackColor = SystemColors.ControlLight;
            panel_form.BorderStyle = BorderStyle.Fixed3D;
            panel_form.Controls.Add(check_auto_generate_mb_code);
            panel_form.Controls.Add(btn_disable_user);
            panel_form.Controls.Add(btn_save);
            panel_form.Controls.Add(btn_clear_form);
            panel_form.Controls.Add(label13);
            panel_form.Controls.Add(combo_member_status);
            panel_form.Controls.Add(inp_create_at);
            panel_form.Controls.Add(label12);
            panel_form.Controls.Add(label11);
            panel_form.Controls.Add(inp_address);
            panel_form.Controls.Add(label10);
            panel_form.Controls.Add(inp_phone);
            panel_form.Controls.Add(inp_name);
            panel_form.Controls.Add(label9);
            panel_form.Controls.Add(inp_member_code);
            panel_form.Controls.Add(label7);
            panel_form.Controls.Add(inp_id);
            panel_form.Controls.Add(label6);
            panel_form.Controls.Add(label5);
            panel_form.Controls.Add(label4);
            panel_form.Enabled = false;
            panel_form.Location = new Point(1318, 143);
            panel_form.Name = "panel_form";
            panel_form.Size = new Size(574, 604);
            panel_form.TabIndex = 2;
            // 
            // check_auto_generate_mb_code
            // 
            check_auto_generate_mb_code.AutoSize = true;
            check_auto_generate_mb_code.Location = new Point(405, 200);
            check_auto_generate_mb_code.Name = "check_auto_generate_mb_code";
            check_auto_generate_mb_code.RightToLeft = RightToLeft.Yes;
            check_auto_generate_mb_code.Size = new Size(124, 29);
            check_auto_generate_mb_code.TabIndex = 23;
            check_auto_generate_mb_code.Text = "สร้างอัตโนมัติ";
            check_auto_generate_mb_code.UseVisualStyleBackColor = true;
            check_auto_generate_mb_code.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btn_disable_user
            // 
            btn_disable_user.Location = new Point(376, 525);
            btn_disable_user.Name = "btn_disable_user";
            btn_disable_user.Size = new Size(153, 43);
            btn_disable_user.TabIndex = 22;
            btn_disable_user.Text = "ปิดใช้งาน";
            btn_disable_user.UseVisualStyleBackColor = true;
            btn_disable_user.Click += btn_disable_user_Click;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(215, 525);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(153, 43);
            btn_save.TabIndex = 21;
            btn_save.Text = "บันทึก";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear_form
            // 
            btn_clear_form.Location = new Point(51, 525);
            btn_clear_form.Name = "btn_clear_form";
            btn_clear_form.Size = new Size(153, 43);
            btn_clear_form.TabIndex = 18;
            btn_clear_form.Text = "ล้างฟอร์ม";
            btn_clear_form.UseVisualStyleBackColor = true;
            btn_clear_form.Click += btn_clear_form_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(51, 451);
            label13.Name = "label13";
            label13.Size = new Size(121, 25);
            label13.TabIndex = 17;
            label13.Text = "เป็นสมาชิกเมื่ิอ:";
            // 
            // combo_member_status
            // 
            combo_member_status.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_member_status.FormattingEnabled = true;
            combo_member_status.Location = new Point(199, 409);
            combo_member_status.Name = "combo_member_status";
            combo_member_status.Size = new Size(330, 33);
            combo_member_status.TabIndex = 16;
            // 
            // inp_create_at
            // 
            inp_create_at.Location = new Point(199, 448);
            inp_create_at.Name = "inp_create_at";
            inp_create_at.ReadOnly = true;
            inp_create_at.Size = new Size(330, 33);
            inp_create_at.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(51, 412);
            label12.Name = "label12";
            label12.Size = new Size(93, 25);
            label12.TabIndex = 14;
            label12.Text = "สถานะผุ้ใช้:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 327);
            label11.Name = "label11";
            label11.Size = new Size(47, 25);
            label11.TabIndex = 13;
            label11.Text = "ที่อยู่:";
            // 
            // inp_address
            // 
            inp_address.Location = new Point(199, 313);
            inp_address.Multiline = true;
            inp_address.Name = "inp_address";
            inp_address.Size = new Size(330, 90);
            inp_address.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 277);
            label10.Name = "label10";
            label10.Size = new Size(142, 25);
            label10.TabIndex = 11;
            label10.Text = "หมายเลขโทรศัพท์:";
            // 
            // inp_phone
            // 
            inp_phone.Location = new Point(199, 274);
            inp_phone.Mask = "000-000-0000";
            inp_phone.Name = "inp_phone";
            inp_phone.Size = new Size(330, 33);
            inp_phone.TabIndex = 10;
            // 
            // inp_name
            // 
            inp_name.Location = new Point(199, 235);
            inp_name.Name = "inp_name";
            inp_name.Size = new Size(330, 33);
            inp_name.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 238);
            label9.Name = "label9";
            label9.Size = new Size(107, 25);
            label9.TabIndex = 8;
            label9.Text = "ชื่อ-นามสกุล:";
            // 
            // inp_member_code
            // 
            inp_member_code.Location = new Point(199, 161);
            inp_member_code.Name = "inp_member_code";
            inp_member_code.Size = new Size(330, 33);
            inp_member_code.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 164);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 4;
            label7.Text = "รหัสสมาชิก:";
            // 
            // inp_id
            // 
            inp_id.Location = new Point(199, 122);
            inp_id.Name = "inp_id";
            inp_id.ReadOnly = true;
            inp_id.Size = new Size(330, 33);
            inp_id.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 125);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 2;
            label6.Text = "ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(19, 60);
            label5.Name = "label5";
            label5.Size = new Size(284, 25);
            label5.TabIndex = 1;
            label5.Text = "เลือกสมาชิกจากตารางหรือเพิ่มสมาชิก";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 18);
            label4.Name = "label4";
            label4.Size = new Size(173, 37);
            label4.TabIndex = 0;
            label4.Text = "ข้อมูลสมาชิก";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_state);
            groupBox1.Location = new Point(1318, 753);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 106);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "รายการ";
            // 
            // txt_state
            // 
            txt_state.BackColor = SystemColors.ControlLight;
            txt_state.BorderStyle = BorderStyle.Fixed3D;
            txt_state.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_state.Location = new Point(6, 29);
            txt_state.Name = "txt_state";
            txt_state.Size = new Size(562, 74);
            txt_state.TabIndex = 4;
            txt_state.Text = "...";
            txt_state.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MemberManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1904, 871);
            Controls.Add(groupBox1);
            Controls.Add(panel_form);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "MemberManagement";
            Text = "จัดการสมาชิก";
            Load += MemberManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_member).EndInit();
            panel_form.ResumeLayout(false);
            panel_form.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btn_add_member;
        private Label label2;
        private Panel panel2;
        private Button btn_search;
        private ComboBox combo_status;
        private TextBox inp_search;
        private Label label3;
        private DataGridView tbl_member;
        private Button btn_clear;
        private Panel panel_form;
        private Label label5;
        private Label label4;
        private TextBox inp_member_code;
        private Label label7;
        private TextBox inp_id;
        private Label label6;
        private Label label10;
        private MaskedTextBox inp_phone;
        private TextBox inp_name;
        private Label label9;
        private Button btn_clear_form;
        private Label label13;
        private ComboBox combo_member_status;
        private TextBox inp_create_at;
        private Label label12;
        private Label label11;
        private TextBox inp_address;
        private Button btn_disable_user;
        private Button btn_save;
        private GroupBox groupBox1;
        private Label txt_state;
        private CheckBox check_auto_generate_mb_code;
        private Label txt_found_count;
    }
}