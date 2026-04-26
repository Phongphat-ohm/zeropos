using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace zeropos
{
    public partial class SettingsForm : Form
    {
        private Settings settings = new Settings();

        public SettingsForm()
        {
            InitializeComponent();
            LoadSettigns();
        }

        private void LoadSettigns()
        {
            // Load Logo
            inp_logo_path.Text = settings.logo_path;
            picture_logo_image.ImageLocation = settings.logo_path;
            // Load Shop Detail
            inp_shop_name.Text = settings.shop_name;
            inp_shop_address.Text = settings.shop_address;
            inp_shop_phone.Text = settings.shop_phone;
            inp_shop_address.Text = settings.shop_address;
            inp_shop_vat_id.Text = settings.tax_id;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadSettigns();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "เลือกไฟล์รูปภาพ";
                ofd.Filter = "Image Files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
                ofd.Multiselect = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;

                    // ตัวอย่างเอาไปใส่ TextBox
                    inp_logo_path.Text = filePath;

                    // ตัวอย่างแสดงใน PictureBox
                    if (picture_logo_image.Image != null)
                    {
                        picture_logo_image.Image.Dispose();
                        picture_logo_image.Image = null;
                    }

                    using (var img = Image.FromFile(filePath))
                    {
                        picture_logo_image.Image = new Bitmap(img); // กันไฟล์ล็อค
                    }
                }
            }
        }

        private void inp_logo_path_TextChanged(object sender, EventArgs e)
        {
            picture_logo_image.ImageLocation = inp_logo_path.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inp_logo_path.Clear();
        }

        private void btn_shop_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "ต้องการบันทึกการตั้งค่าร้านค้าใช่หรือไม่?",
                "ยืนยันการทำรายการ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (result != DialogResult.Yes)
                return;

            settings.logo_path = inp_logo_path.Text.Trim();
            settings.shop_name = inp_shop_name.Text.Trim();
            settings.shop_address = inp_shop_address.Text.Trim();
            settings.shop_phone = inp_shop_phone.Text.Trim();
            settings.tax_id = inp_shop_vat_id.Text.Trim();

            settings.Save();

            MessageBox.Show(
                "บันทึกการตั้งค่าสำเร็จ",
                "แจ้งเตือน",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
