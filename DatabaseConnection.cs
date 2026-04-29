using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace zeropos
{
    internal class DatabaseConnection
    {
        public static string GetConnectionString()
        {
            //Settings settings = new Settings();
            //string dbFile = settings.database_file;

            //if (string.IsNullOrWhiteSpace(dbFile))
            //{
            //    throw new Exception("ยังไม่ได้ตั้งค่าไฟล์ฐานข้อมูล");
            //}

            string dbPath = Path.Combine(Application.StartupPath, "main_database.db");

            string connectionString = $"Data Source={dbPath}";

            return connectionString;
        }

        public static SqliteConnection GetConnection()
        {
            var conn = new SqliteConnection(GetConnectionString());
            conn.Open();
            return conn;
        }

        public static void ConnectionStatus(ToolStripStatusLabel sta_db_connection)
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(GetConnectionString()))
                {
                    conn.Open();
                    sta_db_connection.Text = "เชื่อมต่อสำเร็จ";
                    sta_db_connection.ForeColor = Color.Green;
                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message);
                sta_db_connection.Text = "เชื่อมต่อไม่สำเร็จ";
                sta_db_connection.ForeColor = Color.Red;
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Error: " + ex.Message);
                sta_db_connection.Text = "เชื่อมต่อไม่สำเร็จ";
                sta_db_connection.ForeColor = Color.Red;
            }
        }
    }
}