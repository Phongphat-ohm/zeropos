namespace zeropos
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            tabControl1 = new TabControl();
            tab_shop_settings = new TabPage();
            btn_shop_cancel = new Button();
            inp_shop_address = new TextBox();
            btn_shop_save = new Button();
            label9 = new Label();
            inp_shop_vat_id = new TextBox();
            label8 = new Label();
            inp_shop_phone = new TextBox();
            label7 = new Label();
            inp_shop_name = new TextBox();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            inp_logo_path = new TextBox();
            picture_logo_image = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tab_shop_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_logo_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_shop_settings);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 149);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1880, 710);
            tabControl1.TabIndex = 0;
            // 
            // tab_shop_settings
            // 
            tab_shop_settings.BorderStyle = BorderStyle.Fixed3D;
            tab_shop_settings.Controls.Add(btn_shop_cancel);
            tab_shop_settings.Controls.Add(inp_shop_address);
            tab_shop_settings.Controls.Add(btn_shop_save);
            tab_shop_settings.Controls.Add(label9);
            tab_shop_settings.Controls.Add(inp_shop_vat_id);
            tab_shop_settings.Controls.Add(label8);
            tab_shop_settings.Controls.Add(inp_shop_phone);
            tab_shop_settings.Controls.Add(label7);
            tab_shop_settings.Controls.Add(inp_shop_name);
            tab_shop_settings.Controls.Add(label6);
            tab_shop_settings.Controls.Add(button4);
            tab_shop_settings.Controls.Add(button3);
            tab_shop_settings.Controls.Add(inp_logo_path);
            tab_shop_settings.Controls.Add(picture_logo_image);
            tab_shop_settings.Controls.Add(pictureBox1);
            tab_shop_settings.Controls.Add(label5);
            tab_shop_settings.Controls.Add(label3);
            tab_shop_settings.Controls.Add(label4);
            tab_shop_settings.Location = new Point(4, 34);
            tab_shop_settings.Name = "tab_shop_settings";
            tab_shop_settings.Padding = new Padding(3);
            tab_shop_settings.Size = new Size(1872, 672);
            tab_shop_settings.TabIndex = 0;
            tab_shop_settings.Text = "ข้อมูลร้านค้า";
            tab_shop_settings.UseVisualStyleBackColor = true;
            // 
            // btn_shop_cancel
            // 
            btn_shop_cancel.BackColor = Color.Silver;
            btn_shop_cancel.ForeColor = Color.Black;
            btn_shop_cancel.Location = new Point(1438, 596);
            btn_shop_cancel.Name = "btn_shop_cancel";
            btn_shop_cancel.Size = new Size(201, 49);
            btn_shop_cancel.TabIndex = 3;
            btn_shop_cancel.Text = "ยกเลิก";
            btn_shop_cancel.UseVisualStyleBackColor = false;
            btn_shop_cancel.Click += button2_Click;
            // 
            // inp_shop_address
            // 
            inp_shop_address.Location = new Point(709, 348);
            inp_shop_address.Multiline = true;
            inp_shop_address.Name = "inp_shop_address";
            inp_shop_address.Size = new Size(686, 91);
            inp_shop_address.TabIndex = 17;
            // 
            // btn_shop_save
            // 
            btn_shop_save.BackColor = Color.Blue;
            btn_shop_save.ForeColor = Color.White;
            btn_shop_save.Location = new Point(1645, 596);
            btn_shop_save.Name = "btn_shop_save";
            btn_shop_save.Size = new Size(201, 49);
            btn_shop_save.TabIndex = 2;
            btn_shop_save.Text = "บันทึกข้อมูล";
            btn_shop_save.UseVisualStyleBackColor = false;
            btn_shop_save.Click += btn_shop_save_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(544, 351);
            label9.Name = "label9";
            label9.Size = new Size(91, 25);
            label9.TabIndex = 16;
            label9.Text = "ที่อยู่ร้านค้า";
            // 
            // inp_shop_vat_id
            // 
            inp_shop_vat_id.Location = new Point(709, 288);
            inp_shop_vat_id.Name = "inp_shop_vat_id";
            inp_shop_vat_id.Size = new Size(686, 33);
            inp_shop_vat_id.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(544, 291);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 14;
            label8.Text = "เลขที่ผู้เสียภาษี";
            // 
            // inp_shop_phone
            // 
            inp_shop_phone.Location = new Point(709, 225);
            inp_shop_phone.Name = "inp_shop_phone";
            inp_shop_phone.Size = new Size(686, 33);
            inp_shop_phone.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(544, 228);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 12;
            label7.Text = "เบอร์โทร";
            // 
            // inp_shop_name
            // 
            inp_shop_name.Location = new Point(709, 169);
            inp_shop_name.Name = "inp_shop_name";
            inp_shop_name.Size = new Size(686, 33);
            inp_shop_name.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(544, 172);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 10;
            label6.Text = "ชื่อร้านค้า";
            // 
            // button4
            // 
            button4.Location = new Point(194, 457);
            button4.Name = "button4";
            button4.Size = new Size(143, 43);
            button4.TabIndex = 9;
            button4.Text = "ลบโลโก้";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.ForeColor = Color.White;
            button3.Location = new Point(45, 457);
            button3.Name = "button3";
            button3.Size = new Size(143, 43);
            button3.TabIndex = 8;
            button3.Text = "เลือกโลโก้";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // inp_logo_path
            // 
            inp_logo_path.Location = new Point(45, 406);
            inp_logo_path.Name = "inp_logo_path";
            inp_logo_path.ReadOnly = true;
            inp_logo_path.Size = new Size(360, 33);
            inp_logo_path.TabIndex = 7;
            inp_logo_path.TextChanged += inp_logo_path_TextChanged;
            // 
            // picture_logo_image
            // 
            picture_logo_image.BackColor = Color.White;
            picture_logo_image.BorderStyle = BorderStyle.Fixed3D;
            picture_logo_image.Location = new Point(45, 200);
            picture_logo_image.Name = "picture_logo_image";
            picture_logo_image.Padding = new Padding(5);
            picture_logo_image.Size = new Size(200, 200);
            picture_logo_image.SizeMode = PictureBoxSizeMode.Zoom;
            picture_logo_image.TabIndex = 6;
            picture_logo_image.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cogwheel;
            pictureBox1.Location = new Point(45, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(45, 172);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 4;
            label5.Text = "โลโก้ร้านค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 109);
            label3.Name = "label3";
            label3.Size = new Size(461, 25);
            label3.TabIndex = 3;
            label3.Text = "กำหนดข้อมูลร้านค้าและโลโก้สำหรับสร้างใบเสร็จและรายงานต่างๆ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 69);
            label4.Name = "label4";
            label4.Size = new Size(212, 40);
            label4.TabIndex = 2;
            label4.Text = "การตั้งค่าร้านค้า";
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1872, 682);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ใบเสร็จ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.BorderStyle = BorderStyle.Fixed3D;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1872, 682);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "ฐาข้อมูล";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.BorderStyle = BorderStyle.Fixed3D;
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1872, 682);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "เครื่องพิมพ์";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1880, 131);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 66);
            label2.Name = "label2";
            label2.Size = new Size(381, 25);
            label2.TabIndex = 1;
            label2.Text = "ตั้งค่าข้อมูลร้านค้า ใบเสร็จ ฐานข้อมูล และเครื่องพิมพ์";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(191, 40);
            label1.TabIndex = 0;
            label1.Text = "การตั้งค่าระบบ";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 871);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "SettingsForm";
            Text = "การตั้งค่า";
            Load += SettingsForm_Load;
            tabControl1.ResumeLayout(false);
            tab_shop_settings.ResumeLayout(false);
            tab_shop_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_logo_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab_shop_settings;
        private TabPage tabPage2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btn_shop_save;
        private Button btn_shop_cancel;
        private Label label5;
        private Label label3;
        private Label label4;
        private Button button4;
        private Button button3;
        private TextBox inp_logo_path;
        private PictureBox picture_logo_image;
        private PictureBox pictureBox1;
        private TextBox inp_shop_address;
        private Label label9;
        private TextBox inp_shop_vat_id;
        private Label label8;
        private TextBox inp_shop_phone;
        private Label label7;
        private TextBox inp_shop_name;
        private Label label6;
    }
}