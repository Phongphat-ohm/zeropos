namespace zeropos
{
    partial class UserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagement));
            txt_state = new Label();
            groupBox1 = new GroupBox();
            inp_search = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            btn_add_member = new Button();
            label2 = new Label();
            label1 = new Label();
            combo_role_search = new ComboBox();
            btn_search = new Button();
            txt_found_count = new Label();
            tbl_users = new DataGridView();
            panel2 = new Panel();
            combo_status_search = new ComboBox();
            btn_clear = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            inp_id = new TextBox();
            label7 = new Label();
            inp_name = new TextBox();
            btn_clear_form = new Button();
            btn_save = new Button();
            btn_disable_user = new Button();
            panel_form = new Panel();
            combo_status = new ComboBox();
            combo_role = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            inp_password = new TextBox();
            label9 = new Label();
            inp_username = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_users).BeginInit();
            panel2.SuspendLayout();
            panel_form.SuspendLayout();
            SuspendLayout();
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
            txt_state.Click += txt_state_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_state);
            groupBox1.Location = new Point(1318, 753);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(574, 106);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "รายการ";
            // 
            // inp_search
            // 
            inp_search.Location = new Point(28, 67);
            inp_search.Name = "inp_search";
            inp_search.Size = new Size(580, 33);
            inp_search.TabIndex = 1;
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
            panel1.TabIndex = 4;
            // 
            // btn_add_member
            // 
            btn_add_member.BackColor = Color.DodgerBlue;
            btn_add_member.ForeColor = Color.White;
            btn_add_member.Location = new Point(1621, 30);
            btn_add_member.Name = "btn_add_member";
            btn_add_member.Size = new Size(214, 62);
            btn_add_member.TabIndex = 2;
            btn_add_member.Text = "+ เพิ่มผู้ใช้";
            btn_add_member.UseVisualStyleBackColor = false;
            btn_add_member.Click += btn_add_member_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(28, 67);
            label2.Name = "label2";
            label2.Size = new Size(392, 25);
            label2.TabIndex = 1;
            label2.Text = "ค้นหา เพิ่ม แก้ไข และจัดการข้อมูลพนักงานของร้านค้า";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 47);
            label1.TabIndex = 0;
            label1.Text = "จัดการผู้ใช้";
            // 
            // combo_role_search
            // 
            combo_role_search.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_role_search.FormattingEnabled = true;
            combo_role_search.Location = new Point(614, 67);
            combo_role_search.Name = "combo_role_search";
            combo_role_search.Size = new Size(217, 33);
            combo_role_search.TabIndex = 2;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.DodgerBlue;
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(981, 60);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(140, 44);
            btn_search.TabIndex = 4;
            btn_search.Text = "ค้นหา";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
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
            txt_found_count.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbl_users
            // 
            tbl_users.AllowUserToAddRows = false;
            tbl_users.AllowUserToDeleteRows = false;
            tbl_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbl_users.BackgroundColor = SystemColors.ControlLightLight;
            tbl_users.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tbl_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tbl_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tbl_users.DefaultCellStyle = dataGridViewCellStyle2;
            tbl_users.Location = new Point(28, 131);
            tbl_users.Name = "tbl_users";
            tbl_users.ReadOnly = true;
            tbl_users.Size = new Size(1239, 559);
            tbl_users.TabIndex = 6;
            tbl_users.CellDoubleClick += tbl_users_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(combo_status_search);
            panel2.Controls.Add(txt_found_count);
            panel2.Controls.Add(tbl_users);
            panel2.Controls.Add(btn_clear);
            panel2.Controls.Add(btn_search);
            panel2.Controls.Add(combo_role_search);
            panel2.Controls.Add(inp_search);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 716);
            panel2.TabIndex = 5;
            // 
            // combo_status_search
            // 
            combo_status_search.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_status_search.FormattingEnabled = true;
            combo_status_search.Location = new Point(837, 67);
            combo_status_search.Name = "combo_status_search";
            combo_status_search.Size = new Size(138, 33);
            combo_status_search.TabIndex = 8;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Silver;
            btn_clear.ForeColor = Color.Black;
            btn_clear.Location = new Point(1127, 60);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(140, 44);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "ล้าง";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 125);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 2;
            label6.Text = "ID:";
            // 
            // inp_id
            // 
            inp_id.Location = new Point(199, 122);
            inp_id.Name = "inp_id";
            inp_id.ReadOnly = true;
            inp_id.Size = new Size(330, 33);
            inp_id.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(51, 179);
            label7.Name = "label7";
            label7.Size = new Size(37, 25);
            label7.TabIndex = 4;
            label7.Text = "ชื่อ:";
            // 
            // inp_name
            // 
            inp_name.Location = new Point(199, 176);
            inp_name.Name = "inp_name";
            inp_name.Size = new Size(330, 33);
            inp_name.TabIndex = 5;
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
            // panel_form
            // 
            panel_form.BackColor = SystemColors.ControlLight;
            panel_form.BorderStyle = BorderStyle.Fixed3D;
            panel_form.Controls.Add(combo_status);
            panel_form.Controls.Add(combo_role);
            panel_form.Controls.Add(label11);
            panel_form.Controls.Add(label10);
            panel_form.Controls.Add(inp_password);
            panel_form.Controls.Add(label9);
            panel_form.Controls.Add(inp_username);
            panel_form.Controls.Add(label8);
            panel_form.Controls.Add(btn_disable_user);
            panel_form.Controls.Add(btn_save);
            panel_form.Controls.Add(btn_clear_form);
            panel_form.Controls.Add(inp_name);
            panel_form.Controls.Add(label7);
            panel_form.Controls.Add(inp_id);
            panel_form.Controls.Add(label6);
            panel_form.Controls.Add(label5);
            panel_form.Controls.Add(label4);
            panel_form.Enabled = false;
            panel_form.Location = new Point(1318, 143);
            panel_form.Name = "panel_form";
            panel_form.Size = new Size(574, 604);
            panel_form.TabIndex = 6;
            // 
            // combo_status
            // 
            combo_status.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_status.FormattingEnabled = true;
            combo_status.Location = new Point(199, 422);
            combo_status.Name = "combo_status";
            combo_status.Size = new Size(330, 33);
            combo_status.TabIndex = 32;
            // 
            // combo_role
            // 
            combo_role.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_role.FormattingEnabled = true;
            combo_role.Location = new Point(199, 358);
            combo_role.Name = "combo_role";
            combo_role.Size = new Size(330, 33);
            combo_role.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 425);
            label11.Name = "label11";
            label11.Size = new Size(64, 25);
            label11.TabIndex = 29;
            label11.Text = "สถานะ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 361);
            label10.Name = "label10";
            label10.Size = new Size(76, 25);
            label10.TabIndex = 27;
            label10.Text = "สิทธิ์ผู้ใช้:";
            // 
            // inp_password
            // 
            inp_password.Location = new Point(199, 297);
            inp_password.Name = "inp_password";
            inp_password.Size = new Size(330, 33);
            inp_password.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(51, 300);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 25;
            label9.Text = "รหัสผ่าน:";
            // 
            // inp_username
            // 
            inp_username.Location = new Point(199, 236);
            inp_username.Name = "inp_username";
            inp_username.Size = new Size(330, 33);
            inp_username.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 239);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 23;
            label8.Text = "ชื่อผู้ใช้:";
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 871);
            Controls.Add(groupBox1);
            Controls.Add(panel_form);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "UserManagement";
            Text = "จัดการผู้ใช้";
            Load += UserManagement_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_users).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_form.ResumeLayout(false);
            panel_form.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label txt_state;
        private GroupBox groupBox1;
        private TextBox inp_search;
        private Label label3;
        private Panel panel1;
        private Button btn_add_member;
        private Label label2;
        private Label label1;
        private ComboBox combo_role_search;
        private Button btn_search;
        private Label txt_found_count;
        private DataGridView tbl_users;
        private Panel panel2;
        private Button btn_clear;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox inp_id;
        private Label label7;
        private TextBox inp_name;
        private Button btn_clear_form;
        private Button btn_save;
        private Button btn_disable_user;
        private Panel panel_form;
        private ComboBox combo_role;
        private Label label11;
        private Label label10;
        private TextBox inp_password;
        private Label label9;
        private TextBox inp_username;
        private Label label8;
        private ComboBox combo_status;
        private ComboBox combo_status_search;
    }
}