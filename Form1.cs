using Microsoft.Data.Sqlite;

namespace zeropos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUser();
            DatabaseConnection.ConnectionStatus(sta_db_connection);

            // ดึง path จาก connection string
            string dbPath = DatabaseConnection.GetConnectionString().Split('=')[1];

            if (File.Exists(dbPath))
            {
                FileInfo fileInfo = new FileInfo(dbPath);

                long fileSizeBytes = fileInfo.Length;

                // แปลงเป็น KB / MB
                string fileSizeText;
                if (fileSizeBytes >= 1024 * 1024)
                {
                    fileSizeText = $"{fileSizeBytes / (1024.0 * 1024.0):0.00} MB";
                }
                else if (fileSizeBytes >= 1024)
                {
                    fileSizeText = $"{fileSizeBytes / 1024.0:0.00} KB";
                }
                else
                {
                    fileSizeText = $"{fileSizeBytes} Bytes";
                }

                sta_db_file.Text = $"{dbPath} ({fileSizeText})";
            }
            else
            {
                sta_db_file.Text = $"{dbPath} (ไม่พบไฟล์)";
            }

            OpenFormInPanel(new Home());
            txt_status_label.Text = "หน้าหลัก";

        }

        private void LoadUser()
        {
            int user_id = UserSession.UserId;

            if (user_id <= 0)
            {
                MessageBox.Show("ยังไม่ได้เข้าสู่ระบบ", "แจ้งเตือน",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT id, name, username, role, status
                    FROM users
                    WHERE id = @id
                    LIMIT 1
                ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", user_id);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("ไม่พบข้อมูลผู้ใช้", "แจ้งเตือน",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string name = reader["name"].ToString();
                        string username = reader["username"].ToString();
                        string role = reader["role"].ToString();
                        int status = Convert.ToInt32(reader["status"]);

                        if (role != "admin")
                        {
                            toolStripButton3.Visible = false;
                            จดการผใชToolStripMenuItem.Visible = false;
                            toolStripSeparator4.Visible = false;
                        }
                        else
                        {
                            toolStripButton3.Visible = true;
                            จดการผใชToolStripMenuItem.Visible = true;
                            toolStripSeparator4.Visible = true;
                        }

                        sta_user.Text = name;
                    }
                }
            }
        }

        private void OpenFormInPanel(Form childForm)
        {
            main_panel.Controls.Clear(); // ลบของเดิม

            childForm.TopLevel = false; // 🔥 สำคัญมาก
            childForm.FormBorderStyle = FormBorderStyle.None; // ไม่มีขอบ
            childForm.Dock = DockStyle.Fill; // เต็ม panel

            main_panel.Controls.Add(childForm);
            childForm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new Home());
            txt_status_label.Text = "หน้าหลัก";
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void จดการสนคาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new ProductManagement());
            txt_status_label.Text = "จัดการสินค้า";
        }

        private void จดการToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new CategoryManagement());
            txt_status_label.Text = "จัดการหมวดหมู่สินค้า";
        }

        private void จดการสตอกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new StockManagement());
            txt_status_label.Text = "จัดการสต็อกสินค้า";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PointOfSale pos = new PointOfSale();
            pos.ShowDialog();
        }

        private void จดการสมาชกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new MemberManagement());
            txt_status_label.Text = "จัดการสมาชิก";
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new SettingsForm());
            txt_status_label.Text = "การตั้งค่า";
        }

        private void sta_db_file_Click(object sender, EventArgs e)
        {
            // ดึง path จาก connection string
            string dbPath = DatabaseConnection.GetConnectionString().Split('=')[1];

            if (File.Exists(dbPath))
            {
                FileInfo fileInfo = new FileInfo(dbPath);

                long fileSizeBytes = fileInfo.Length;

                // แปลงเป็น KB / MB
                string fileSizeText;
                if (fileSizeBytes >= 1024 * 1024)
                {
                    fileSizeText = $"{fileSizeBytes / (1024.0 * 1024.0):0.00} MB";
                }
                else if (fileSizeBytes >= 1024)
                {
                    fileSizeText = $"{fileSizeBytes / 1024.0:0.00} KB";
                }
                else
                {
                    fileSizeText = $"{fileSizeBytes} Bytes";
                }

                sta_db_file.Text = $"{dbPath} ({fileSizeText})";
            }
            else
            {
                sta_db_file.Text = $"{dbPath} (ไม่พบไฟล์)";
            }
        }

        private void จดการผใชToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormInPanel(new UserManagement());
            txt_status_label.Text = "จัดการผู้ใช้";
        }

        private void ออกจากระบบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "ต้องการออกจากระบบใช่หรือไม่?",
                "ยืนยัน",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            // 🔓 เคลียร์ session
            UserSession.Logout();

            // 🔁 เปิดหน้า login ใหม่
            this.Hide();

            using (LoginForm login = new LoginForm())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // login ใหม่สำเร็จ → โหลดข้อมูล user ใหม่
                    this.Show();
                    LoadUser(); // ถ้ามี function นี้
                }
                else
                {
                    // ❌ ปิดโปรแกรมถ้าไม่ login
                    Application.Exit();
                }
            }
        }
    }
}
