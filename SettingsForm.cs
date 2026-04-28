using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
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
            inp_vat_rate.Text= settings.vat.ToString();
            check_calculate_vat.Checked = settings.calculate_vat;


            //Load Bill Settings
            inp_bill_prefix.Text = settings.bill_prefix;
            inp_bill_footer_text.Text = settings.bill_footer;

            combo_printer_name.Items.Clear();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                combo_printer_name.Items.Add(printer);
            }
            combo_printer_name.SelectedItem = settings.printer_name;

            check_auto_print_bill.Checked = settings.auto_bill_print;
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
            settings.vat = float.Parse(inp_vat_rate.Text);
            settings.calculate_vat = check_calculate_vat.Checked;

            settings.Save();

            MessageBox.Show(
                "บันทึกการตั้งค่าสำเร็จ",
                "แจ้งเตือน",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void inp_bill_prefix_TextChanged(object sender, EventArgs e)
        {
            DateTime nowDate = DateTime.Now;
            txt_prefix_preview.Text = inp_bill_prefix.Text + $"-{nowDate.ToString("yyyyMMdd", CultureInfo.InvariantCulture)}-0000";
        }

        private void btn_test_print_Click(object sender, EventArgs e)
        {
            string printerName = combo_printer_name.Text;

            if (string.IsNullOrWhiteSpace(printerName))
            {
                MessageBox.Show("กรุณาเลือกเครื่องพิมพ์");
                return;
            }

            // ตรวจสอบว่า printer มีจริงไหม
            bool found = false;
            foreach (string p in PrinterSettings.InstalledPrinters)
            {
                if (p == printerName)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                MessageBox.Show("ไม่พบเครื่องพิมพ์นี้");
                return;
            }

            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = printerName;

            // 🔥 ตั้งกระดาษ 58mm
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("58mm", 200, 800);
            printDoc.DefaultPageSettings.Margins = new Margins(5, 5, 5, 5);

            printDoc.PrintPage += (s, ev) =>
            {
                Graphics g = ev.Graphics;

                Font font = new Font("Tahoma", 8);
                Font fontBold = new Font("Tahoma", 9, FontStyle.Bold);

                int left = 5;
                int y = 5;
                int width = 180;
                int lineHeight = 18;

                StringFormat center = new StringFormat();
                center.Alignment = StringAlignment.Center;

                StringFormat right = new StringFormat();
                right.Alignment = StringAlignment.Far;

                // ================= TEST HEADER =================
                g.DrawString("TEST PRINT", fontBold, Brushes.Black, new RectangleF(left, y, width, 20), center);
                y += 25;

                g.DrawString("================================", font, Brushes.Black, left, y);
                y += lineHeight;

                // ================= SAMPLE =================
                g.DrawString("สินค้า A", font, Brushes.Black, left, y);
                g.DrawString("20.00", font, Brushes.Black, new RectangleF(left, y, width, lineHeight), right);
                y += lineHeight;

                g.DrawString("สินค้า B", font, Brushes.Black, left, y);
                g.DrawString("30.00", font, Brushes.Black, new RectangleF(left, y, width, lineHeight), right);
                y += lineHeight;

                g.DrawString("--------------------------------", font, Brushes.Black, left, y);
                y += lineHeight;

                g.DrawString("รวม", fontBold, Brushes.Black, left, y);
                g.DrawString("50.00", fontBold, Brushes.Black, new RectangleF(left, y, width, lineHeight), right);
                y += lineHeight;

                // ================= PREFIX =================
                g.DrawString("PREFIX: " + inp_bill_prefix.Text, font, Brushes.Black, left, y);
                y += lineHeight;

                // ================= FOOTER =================
                string footer = inp_bill_footer_text.Text;
                SizeF size = g.MeasureString(footer, font, width);

                g.DrawString(
                    footer,
                    font,
                    Brushes.Black,
                    new RectangleF(left, y, width, size.Height),
                    center
                );

                y += (int)size.Height;

                ev.HasMorePages = false;
            };

            try
            {
                printDoc.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("พิมพ์ไม่สำเร็จ: " + ex.Message);
            }
        }

        private void btn_bill_cancel_Click(object sender, EventArgs e)
        {
            LoadSettigns();
        }

        private void btn_bill_save_Click(object sender, EventArgs e)
        {
            settings.bill_prefix = inp_bill_prefix.Text;
            settings.bill_footer = inp_bill_footer_text.Text;
            settings.printer_name = combo_printer_name.Text;
            settings.auto_bill_print = check_auto_print_bill.Checked;
            settings.Save();
        }
    }
}
