using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace zeropos
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CheckDatabaseConnection();
        }

        private void CheckDatabaseConnection()
        {
            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    txt_pos_status.Text = "พร้อมใช้งานระบบ POS";
                    icon_pos_status.ForeColor = Color.LawnGreen;
                }
                catch
                {
                    txt_pos_status.Text = "ไม่สามารถเชื่อมต่อฐานข้อมูลได้";
                    icon_pos_status.ForeColor = Color.Red;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));

                return builder.ToString();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = inp_username.Text.Trim();
            string password = inp_password.Text;

            if (string.IsNullOrEmpty(username))
            {
                inp_username.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                inp_password.Focus();
                return;
            }

            string hashedPassword = HashPassword(password);

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT id, name, username, role, status
                    FROM users
                    WHERE username = @username
                      AND password = @password
                    LIMIT 1
                ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "เข้าสู่ระบบไม่สำเร็จ",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            inp_password.Clear();
                            inp_password.Focus();
                            return;
                        }

                        int status = Convert.ToInt32(reader["status"]);

                        if (status != 1)
                        {
                            MessageBox.Show("ผู้ใช้นี้ถูกปิดใช้งาน", "ไม่สามารถเข้าสู่ระบบได้",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        UserSession.Login(
                            Convert.ToInt32(reader["id"]),
                            reader["name"].ToString(),
                            reader["username"].ToString(),
                            reader["role"].ToString()
                        );

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void inp_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void inp_password_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }
    }
}
