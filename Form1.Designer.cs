namespace zeropos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            sta_db_connection = new ToolStripStatusLabel();
            sta_db_file = new ToolStripStatusLabel();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            จดการToolStripMenuItem = new ToolStripMenuItem();
            จดการสนคาToolStripMenuItem = new ToolStripMenuItem();
            จดการสตอกToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            จดการผใชToolStripMenuItem = new ToolStripMenuItem();
            จดการสมาชกToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            main_panel = new Panel();
            txt_status_label = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, sta_db_connection, sta_db_file });
            statusStrip1.Location = new Point(0, 983);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1920, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.Control;
            toolStripStatusLabel1.Image = Properties.Resources.data_sharing;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(196, 21);
            toolStripStatusLabel1.Text = "สถานะการเชื่อต่อฐานข้อมูล: ";
            // 
            // sta_db_connection
            // 
            sta_db_connection.BackColor = SystemColors.Control;
            sta_db_connection.ForeColor = SystemColors.Highlight;
            sta_db_connection.Name = "sta_db_connection";
            sta_db_connection.Size = new Size(98, 21);
            sta_db_connection.Text = "กำลังเชื่อมต่อ...";
            // 
            // sta_db_file
            // 
            sta_db_file.BackColor = Color.Transparent;
            sta_db_file.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sta_db_file.ForeColor = SystemColors.ControlDark;
            sta_db_file.Name = "sta_db_file";
            sta_db_file.Size = new Size(16, 21);
            sta_db_file.Text = "...";
            sta_db_file.TextAlign = ContentAlignment.MiddleLeft;
            sta_db_file.Click += sta_db_file_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Padding = new Padding(10, 10, 10, 0);
            toolStripButton1.Size = new Size(56, 46);
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 49);
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, toolStripDropDownButton1, toolStripSeparator5, toolStripButton2, toolStripSeparator2, toolStripDropDownButton2, toolStripSeparator3, toolStripButton3, toolStripSeparator4 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1920, 49);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.BackColor = SystemColors.Control;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { จดการToolStripMenuItem, จดการสนคาToolStripMenuItem, จดการสตอกToolStripMenuItem });
            toolStripDropDownButton1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripDropDownButton1.Image = Properties.Resources.packages;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Padding = new Padding(20, 0, 20, 0);
            toolStripDropDownButton1.Size = new Size(147, 46);
            toolStripDropDownButton1.Text = "จัดการสต๊อก";
            // 
            // จดการToolStripMenuItem
            // 
            จดการToolStripMenuItem.Image = Properties.Resources.market_segment;
            จดการToolStripMenuItem.Name = "จดการToolStripMenuItem";
            จดการToolStripMenuItem.Size = new Size(197, 22);
            จดการToolStripMenuItem.Text = "จัดการหมวดหมู่สินค้า";
            จดการToolStripMenuItem.Click += จดการToolStripMenuItem_Click;
            // 
            // จดการสนคาToolStripMenuItem
            // 
            จดการสนคาToolStripMenuItem.Image = Properties.Resources.box;
            จดการสนคาToolStripMenuItem.Name = "จดการสนคาToolStripMenuItem";
            จดการสนคาToolStripMenuItem.Size = new Size(197, 22);
            จดการสนคาToolStripMenuItem.Text = "จัดการสินค้า";
            จดการสนคาToolStripMenuItem.Click += จดการสนคาToolStripMenuItem_Click;
            // 
            // จดการสตอกToolStripMenuItem
            // 
            จดการสตอกToolStripMenuItem.Image = Properties.Resources.checklist;
            จดการสตอกToolStripMenuItem.Name = "จดการสตอกToolStripMenuItem";
            จดการสตอกToolStripMenuItem.Size = new Size(197, 22);
            จดการสตอกToolStripMenuItem.Text = "จัดการสต๊อก";
            จดการสตอกToolStripMenuItem.Click += จดการสตอกToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 49);
            // 
            // toolStripButton2
            // 
            toolStripButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton2.Image = Properties.Resources.cashier;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Padding = new Padding(20, 0, 20, 0);
            toolStripButton2.Size = new Size(152, 46);
            toolStripButton2.Text = "ระบบขายสินค้า";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 49);
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { จดการผใชToolStripMenuItem, จดการสมาชกToolStripMenuItem });
            toolStripDropDownButton2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripDropDownButton2.Image = Properties.Resources.youth;
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Padding = new Padding(20, 0, 20, 0);
            toolStripDropDownButton2.Size = new Size(159, 46);
            toolStripDropDownButton2.Text = "ระบบงานบุคคล";
            // 
            // จดการผใชToolStripMenuItem
            // 
            จดการผใชToolStripMenuItem.Image = Properties.Resources.user;
            จดการผใชToolStripMenuItem.Name = "จดการผใชToolStripMenuItem";
            จดการผใชToolStripMenuItem.Size = new Size(180, 22);
            จดการผใชToolStripMenuItem.Text = "จัดการผู้ใช้";
            จดการผใชToolStripMenuItem.Click += จดการผใชToolStripMenuItem_Click;
            // 
            // จดการสมาชกToolStripMenuItem
            // 
            จดการสมาชกToolStripMenuItem.Image = Properties.Resources.star;
            จดการสมาชกToolStripMenuItem.Name = "จดการสมาชกToolStripMenuItem";
            จดการสมาชกToolStripMenuItem.Size = new Size(180, 22);
            จดการสมาชกToolStripMenuItem.Text = "จัดการสมาชิก";
            จดการสมาชกToolStripMenuItem.Click += จดการสมาชกToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 49);
            // 
            // toolStripButton3
            // 
            toolStripButton3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripButton3.Image = Properties.Resources.cogwheel;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Padding = new Padding(20, 0, 20, 0);
            toolStripButton3.Size = new Size(147, 46);
            toolStripButton3.Text = "การตั้งค่าระบบ";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 49);
            // 
            // main_panel
            // 
            main_panel.BackColor = SystemColors.Control;
            main_panel.Location = new Point(0, 104);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1920, 876);
            main_panel.TabIndex = 3;
            // 
            // txt_status_label
            // 
            txt_status_label.BackColor = Color.FromArgb(255, 192, 192);
            txt_status_label.BorderStyle = BorderStyle.Fixed3D;
            txt_status_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_status_label.Location = new Point(0, 74);
            txt_status_label.Name = "txt_status_label";
            txt_status_label.Size = new Size(1920, 28);
            txt_status_label.TabIndex = 4;
            txt_status_label.Text = "...";
            txt_status_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1920, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            fileToolStripMenuItem.Image = Properties.Resources.folder;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(53, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Image = Properties.Resources.logout;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(92, 22);
            logoutToolStripMenuItem.Text = "Exit";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1920, 1009);
            Controls.Add(txt_status_label);
            Controls.Add(main_panel);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ZEROPOS";
            WindowState = FormWindowState.Maximized;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel sta_db_connection;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStrip toolStrip1;
        private Panel main_panel;
        private Label txt_status_label;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem จดการToolStripMenuItem;
        private ToolStripMenuItem จดการสนคาToolStripMenuItem;
        private ToolStripMenuItem จดการสตอกToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem จดการผใชToolStripMenuItem;
        private ToolStripMenuItem จดการสมาชกToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripStatusLabel sta_db_file;
    }
}
