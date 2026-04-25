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
            DatabaseConnection.ConnectionStatus(sta_db_connection);

            OpenFormInPanel(new Home());
            txt_status_label.Text = "หน้าหลัก";
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
    }
}
