namespace zeropos
{
    partial class BillMemberAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillMemberAdd));
            panel1 = new Panel();
            btn_clear_member = new Button();
            btn_cancel = new Button();
            btn_select_member = new Button();
            label11 = new Label();
            panel2 = new Panel();
            txt_member_phone = new Label();
            label9 = new Label();
            txt_member_name = new Label();
            label8 = new Label();
            txt_member_code = new Label();
            label6 = new Label();
            txt_member_id = new Label();
            label3 = new Label();
            btn_search = new Button();
            inp_search = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_clear_member);
            panel1.Controls.Add(btn_cancel);
            panel1.Controls.Add(btn_select_member);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_search);
            panel1.Controls.Add(inp_search);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(765, 473);
            panel1.TabIndex = 0;
            // 
            // btn_clear_member
            // 
            btn_clear_member.BackColor = Color.FromArgb(192, 0, 0);
            btn_clear_member.ForeColor = Color.White;
            btn_clear_member.Location = new Point(391, 377);
            btn_clear_member.Name = "btn_clear_member";
            btn_clear_member.Size = new Size(159, 43);
            btn_clear_member.TabIndex = 18;
            btn_clear_member.Text = "ล้างสมาชิก";
            btn_clear_member.UseVisualStyleBackColor = false;
            btn_clear_member.Click += button1_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Silver;
            btn_cancel.ForeColor = Color.Black;
            btn_cancel.Location = new Point(226, 377);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(159, 43);
            btn_cancel.TabIndex = 17;
            btn_cancel.Text = "ยกเลิก";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += button3_Click_1;
            // 
            // btn_select_member
            // 
            btn_select_member.BackColor = Color.FromArgb(0, 192, 0);
            btn_select_member.ForeColor = Color.White;
            btn_select_member.Location = new Point(556, 377);
            btn_select_member.Name = "btn_select_member";
            btn_select_member.Size = new Size(159, 43);
            btn_select_member.TabIndex = 16;
            btn_select_member.Text = "เลือกสมาชิก";
            btn_select_member.UseVisualStyleBackColor = false;
            btn_select_member.Click += btn_select_member_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDark;
            label11.Location = new Point(357, 430);
            label11.Name = "label11";
            label11.Size = new Size(358, 20);
            label11.TabIndex = 15;
            label11.Text = "F1=ค้นหาสมาชิก, F2=เลือกสมาชิก, Esc=ยกเลิก/ปิดหน้าต่าง";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txt_member_phone);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txt_member_name);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_member_code);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txt_member_id);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(46, 182);
            panel2.Name = "panel2";
            panel2.Size = new Size(669, 178);
            panel2.TabIndex = 14;
            // 
            // txt_member_phone
            // 
            txt_member_phone.BackColor = SystemColors.ControlLight;
            txt_member_phone.BorderStyle = BorderStyle.Fixed3D;
            txt_member_phone.Location = new Point(174, 118);
            txt_member_phone.Name = "txt_member_phone";
            txt_member_phone.Size = new Size(471, 36);
            txt_member_phone.TabIndex = 7;
            txt_member_phone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 124);
            label9.Name = "label9";
            label9.Size = new Size(142, 25);
            label9.TabIndex = 6;
            label9.Text = "หมายเลขโทรศัพท์:";
            // 
            // txt_member_name
            // 
            txt_member_name.BackColor = SystemColors.ControlLight;
            txt_member_name.BorderStyle = BorderStyle.Fixed3D;
            txt_member_name.Location = new Point(121, 70);
            txt_member_name.Name = "txt_member_name";
            txt_member_name.Size = new Size(524, 36);
            txt_member_name.TabIndex = 5;
            txt_member_name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 76);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 4;
            label8.Text = "ชื่อสมาชิก:";
            // 
            // txt_member_code
            // 
            txt_member_code.BackColor = SystemColors.ControlLight;
            txt_member_code.BorderStyle = BorderStyle.Fixed3D;
            txt_member_code.Location = new Point(298, 22);
            txt_member_code.Name = "txt_member_code";
            txt_member_code.Size = new Size(347, 36);
            txt_member_code.TabIndex = 3;
            txt_member_code.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 28);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 2;
            label6.Text = "รหัสสมาชิก: ";
            // 
            // txt_member_id
            // 
            txt_member_id.BackColor = SystemColors.ControlLight;
            txt_member_id.BorderStyle = BorderStyle.Fixed3D;
            txt_member_id.Location = new Point(66, 22);
            txt_member_id.Name = "txt_member_id";
            txt_member_id.Size = new Size(118, 36);
            txt_member_id.TabIndex = 1;
            txt_member_id.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 28);
            label3.Name = "label3";
            label3.Size = new Size(34, 25);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Blue;
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(556, 121);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(159, 43);
            btn_search.TabIndex = 13;
            btn_search.Text = "ค้นหาสมาชิก";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // inp_search
            // 
            inp_search.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inp_search.Location = new Point(46, 121);
            inp_search.Name = "inp_search";
            inp_search.PlaceholderText = "รหัสสมาชิก หรือหมายเลขโทรศัพท์";
            inp_search.Size = new Size(504, 43);
            inp_search.TabIndex = 12;
            inp_search.KeyDown += inp_search_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(94, 68);
            label2.Name = "label2";
            label2.Size = new Size(378, 21);
            label2.TabIndex = 11;
            label2.Text = "กรอกรหัสสมาชิก หรือหมายเลขโทรศัพท์เพื่อเพิ่มสมาชิกในบิลล์";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 25);
            label1.Name = "label1";
            label1.Size = new Size(212, 40);
            label1.TabIndex = 9;
            label1.Text = "เพิ่มสมาชิกในบิลล์";
            // 
            // BillMemberAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(790, 499);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(5);
            Name = "BillMemberAdd";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "เพิ่มสมาชิกในบิลล์";
            Load += BillMemberAdd_Load;
            KeyDown += BillMemberAdd_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_cancel;
        private Button btn_select_member;
        private Label label11;
        private Panel panel2;
        private Label txt_member_phone;
        private Label label9;
        private Label txt_member_name;
        private Label label8;
        private Label txt_member_code;
        private Label label6;
        private Label txt_member_id;
        private Label label3;
        private Button btn_search;
        private TextBox inp_search;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btn_clear_member;
    }
}