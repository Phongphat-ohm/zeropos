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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            tab_bill_priner_settings = new TabPage();
            panel2 = new Panel();
            btn_test_print = new Button();
            btn_bill_cancel = new Button();
            btn_bill_save = new Button();
            label17 = new Label();
            check_auto_print_bill = new CheckBox();
            combo_printer_name = new ComboBox();
            label16 = new Label();
            inp_bill_footer_text = new TextBox();
            label15 = new Label();
            label14 = new Label();
            txt_prefix_preview = new Label();
            inp_bill_prefix = new TextBox();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            tab_shop_settings = new TabPage();
            check_calculate_vat = new CheckBox();
            inp_vat_rate = new TextBox();
            label13 = new Label();
            btn_shop_cancel = new Button();
            inp_shop_address = new TextBox();
            inp_shop_vat_id = new TextBox();
            inp_shop_phone = new TextBox();
            inp_shop_name = new TextBox();
            inp_logo_path = new TextBox();
            btn_shop_save = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            picture_logo_image = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            tabControl1 = new TabControl();
            panel1.SuspendLayout();
            tab_bill_priner_settings.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tab_shop_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_logo_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
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
            // tab_bill_priner_settings
            // 
            tab_bill_priner_settings.BorderStyle = BorderStyle.Fixed3D;
            tab_bill_priner_settings.Controls.Add(panel2);
            tab_bill_priner_settings.Location = new Point(4, 24);
            tab_bill_priner_settings.Name = "tab_bill_priner_settings";
            tab_bill_priner_settings.Padding = new Padding(3);
            tab_bill_priner_settings.Size = new Size(1872, 682);
            tab_bill_priner_settings.TabIndex = 1;
            tab_bill_priner_settings.Text = "ใบเสร็จ/เครื่องพิมพ์";
            tab_bill_priner_settings.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(btn_test_print);
            panel2.Controls.Add(btn_bill_cancel);
            panel2.Controls.Add(btn_bill_save);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(check_auto_print_bill);
            panel2.Controls.Add(combo_printer_name);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(inp_bill_footer_text);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txt_prefix_preview);
            panel2.Controls.Add(inp_bill_prefix);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1856, 661);
            panel2.TabIndex = 1;
            // 
            // btn_test_print
            // 
            btn_test_print.BackColor = Color.FromArgb(255, 192, 192);
            btn_test_print.ForeColor = Color.Black;
            btn_test_print.Location = new Point(877, 348);
            btn_test_print.Name = "btn_test_print";
            btn_test_print.Size = new Size(201, 49);
            btn_test_print.TabIndex = 21;
            btn_test_print.Text = "ทดสอบการพิมพ์";
            btn_test_print.UseVisualStyleBackColor = false;
            btn_test_print.Click += btn_test_print_Click;
            // 
            // btn_bill_cancel
            // 
            btn_bill_cancel.BackColor = Color.Silver;
            btn_bill_cancel.ForeColor = Color.Black;
            btn_bill_cancel.Location = new Point(1438, 596);
            btn_bill_cancel.Name = "btn_bill_cancel";
            btn_bill_cancel.Size = new Size(201, 49);
            btn_bill_cancel.TabIndex = 20;
            btn_bill_cancel.Text = "ยกเลิก";
            btn_bill_cancel.UseVisualStyleBackColor = false;
            btn_bill_cancel.Click += btn_bill_cancel_Click;
            // 
            // btn_bill_save
            // 
            btn_bill_save.BackColor = Color.Blue;
            btn_bill_save.ForeColor = Color.White;
            btn_bill_save.Location = new Point(1645, 596);
            btn_bill_save.Name = "btn_bill_save";
            btn_bill_save.Size = new Size(201, 49);
            btn_bill_save.TabIndex = 19;
            btn_bill_save.Text = "บันทึกข้อมูล";
            btn_bill_save.UseVisualStyleBackColor = false;
            btn_bill_save.Click += btn_bill_save_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(877, 307);
            label17.Name = "label17";
            label17.Size = new Size(200, 17);
            label17.TabIndex = 18;
            label17.Text = "พิมพ์ใบเสร็จอัตโนมัติโดยไม่ต้องเปิดดูบิลล์";
            // 
            // check_auto_print_bill
            // 
            check_auto_print_bill.AutoSize = true;
            check_auto_print_bill.Location = new Point(877, 275);
            check_auto_print_bill.Name = "check_auto_print_bill";
            check_auto_print_bill.Size = new Size(178, 29);
            check_auto_print_bill.TabIndex = 17;
            check_auto_print_bill.Text = "พิมพ์ใบเสร็จอัตโนมัติ";
            check_auto_print_bill.UseVisualStyleBackColor = true;
            // 
            // combo_printer_name
            // 
            combo_printer_name.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_printer_name.FormattingEnabled = true;
            combo_printer_name.Location = new Point(877, 224);
            combo_printer_name.Name = "combo_printer_name";
            combo_printer_name.Size = new Size(709, 33);
            combo_printer_name.TabIndex = 16;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(877, 196);
            label16.Name = "label16";
            label16.Size = new Size(111, 25);
            label16.TabIndex = 15;
            label16.Text = "ชื่อเครื่องพิมพ์";
            // 
            // inp_bill_footer_text
            // 
            inp_bill_footer_text.Location = new Point(58, 348);
            inp_bill_footer_text.Multiline = true;
            inp_bill_footer_text.Name = "inp_bill_footer_text";
            inp_bill_footer_text.Size = new Size(681, 102);
            inp_bill_footer_text.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(58, 320);
            label15.Name = "label15";
            label15.Size = new Size(151, 25);
            label15.TabIndex = 13;
            label15.Text = "ข้อความท้ายใบเสร็จ";
            // 
            // label14
            // 
            label14.Location = new Point(58, 271);
            label14.Name = "label14";
            label14.Size = new Size(74, 35);
            label14.TabIndex = 12;
            label14.Text = "ตัวอย่าง:";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_prefix_preview
            // 
            txt_prefix_preview.BackColor = SystemColors.ControlLight;
            txt_prefix_preview.BorderStyle = BorderStyle.Fixed3D;
            txt_prefix_preview.Location = new Point(138, 271);
            txt_prefix_preview.Name = "txt_prefix_preview";
            txt_prefix_preview.Size = new Size(601, 35);
            txt_prefix_preview.TabIndex = 11;
            txt_prefix_preview.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // inp_bill_prefix
            // 
            inp_bill_prefix.Location = new Point(58, 224);
            inp_bill_prefix.Name = "inp_bill_prefix";
            inp_bill_prefix.Size = new Size(681, 33);
            inp_bill_prefix.TabIndex = 10;
            inp_bill_prefix.TextChanged += inp_bill_prefix_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(58, 196);
            label12.Name = "label12";
            label12.Size = new Size(171, 25);
            label12.TabIndex = 9;
            label12.Text = "คำนำหน้าเลขที่ใบเสร็จ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cogwheel;
            pictureBox2.Location = new Point(58, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 123);
            label10.Name = "label10";
            label10.Size = new Size(259, 25);
            label10.TabIndex = 7;
            label10.Text = "กำหนดข้อมูลใบเสร็จและเครื่องพิมพ์";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(58, 83);
            label11.Name = "label11";
            label11.Size = new Size(401, 40);
            label11.TabIndex = 6;
            label11.Text = "การตั้งค่าใบเสร็จและเครื่องพิมพ์";
            // 
            // tab_shop_settings
            // 
            tab_shop_settings.BorderStyle = BorderStyle.Fixed3D;
            tab_shop_settings.Controls.Add(check_calculate_vat);
            tab_shop_settings.Controls.Add(inp_vat_rate);
            tab_shop_settings.Controls.Add(label13);
            tab_shop_settings.Controls.Add(btn_shop_cancel);
            tab_shop_settings.Controls.Add(inp_shop_address);
            tab_shop_settings.Controls.Add(inp_shop_vat_id);
            tab_shop_settings.Controls.Add(inp_shop_phone);
            tab_shop_settings.Controls.Add(inp_shop_name);
            tab_shop_settings.Controls.Add(inp_logo_path);
            tab_shop_settings.Controls.Add(btn_shop_save);
            tab_shop_settings.Controls.Add(label9);
            tab_shop_settings.Controls.Add(label8);
            tab_shop_settings.Controls.Add(label7);
            tab_shop_settings.Controls.Add(label6);
            tab_shop_settings.Controls.Add(button4);
            tab_shop_settings.Controls.Add(button3);
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
            // check_calculate_vat
            // 
            check_calculate_vat.AutoSize = true;
            check_calculate_vat.Location = new Point(1275, 518);
            check_calculate_vat.Name = "check_calculate_vat";
            check_calculate_vat.RightToLeft = RightToLeft.Yes;
            check_calculate_vat.Size = new Size(119, 29);
            check_calculate_vat.TabIndex = 20;
            check_calculate_vat.Text = "คำณวนภาษี";
            check_calculate_vat.UseVisualStyleBackColor = true;
            // 
            // inp_vat_rate
            // 
            inp_vat_rate.Location = new Point(709, 479);
            inp_vat_rate.Name = "inp_vat_rate";
            inp_vat_rate.Size = new Size(686, 33);
            inp_vat_rate.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(544, 482);
            label13.Name = "label13";
            label13.Size = new Size(71, 25);
            label13.TabIndex = 18;
            label13.Text = "ภาษี(%)";
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
            // inp_shop_vat_id
            // 
            inp_shop_vat_id.Location = new Point(709, 288);
            inp_shop_vat_id.Name = "inp_shop_vat_id";
            inp_shop_vat_id.Size = new Size(686, 33);
            inp_shop_vat_id.TabIndex = 15;
            // 
            // inp_shop_phone
            // 
            inp_shop_phone.Location = new Point(709, 225);
            inp_shop_phone.Name = "inp_shop_phone";
            inp_shop_phone.Size = new Size(686, 33);
            inp_shop_phone.TabIndex = 13;
            // 
            // inp_shop_name
            // 
            inp_shop_name.Location = new Point(709, 169);
            inp_shop_name.Name = "inp_shop_name";
            inp_shop_name.Size = new Size(686, 33);
            inp_shop_name.TabIndex = 11;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(544, 291);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 14;
            label8.Text = "เลขที่ผู้เสียภาษี";
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_shop_settings);
            tabControl1.Controls.Add(tab_bill_priner_settings);
            tabControl1.Location = new Point(12, 149);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1880, 710);
            tabControl1.TabIndex = 0;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tab_bill_priner_settings.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tab_shop_settings.ResumeLayout(false);
            tab_shop_settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_logo_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TabPage tab_bill_priner_settings;
        private Panel panel2;
        private Button btn_test_print;
        private Button btn_bill_cancel;
        private Button btn_bill_save;
        private Label label17;
        private CheckBox check_auto_print_bill;
        private ComboBox combo_printer_name;
        private Label label16;
        private TextBox inp_bill_footer_text;
        private Label label15;
        private Label label14;
        private Label txt_prefix_preview;
        private TextBox inp_bill_prefix;
        private Label label12;
        private PictureBox pictureBox2;
        private Label label10;
        private Label label11;
        private TabPage tab_shop_settings;
        private Button btn_shop_cancel;
        private TextBox inp_shop_address;
        private TextBox inp_shop_vat_id;
        private TextBox inp_shop_phone;
        private TextBox inp_shop_name;
        private TextBox inp_logo_path;
        private Button btn_shop_save;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button4;
        private Button button3;
        private PictureBox picture_logo_image;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label3;
        private Label label4;
        private TabControl tabControl1;
        private TextBox inp_vat_rate;
        private Label label13;
        private CheckBox check_calculate_vat;
    }
}