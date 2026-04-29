using Microsoft.Data.Sqlite;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace zeropos
{
    internal class BillReport
    {
        private const int PaperWidth = 200;
        private const int ContentWidth = 180;

        private string shopName;
        private string shopAddress;
        private string taxId;
        private string logoPath;
        private string footerText;
        private string shopPhone;

        public BillReport()
        {
            Settings settings = new Settings();

            shopName = string.IsNullOrWhiteSpace(settings.shop_name) ? "ZERO POS" : settings.shop_name;
            shopAddress = settings.shop_address ?? "";
            taxId = settings.tax_id ?? "";
            logoPath = settings.logo_path ?? "";
            footerText = settings.bill_footer ?? "ขอบคุณที่ใช้บริการ";
            shopPhone = settings.shop_phone ?? "";
        }

        public void PrintBill(long orderId, bool showPreview = false)
        {
            BillHeader bill = GetBillHeader(orderId);

            if (bill == null)
            {
                MessageBox.Show("ไม่พบบิลนี้");
                return;
            }

            DataTable billItems = GetBillItems(orderId);

            int paperHeight = CalculatePaperHeight(billItems);

            PrintDocument printDoc = new PrintDocument();
            printDoc.DefaultPageSettings.PaperSize = new PaperSize("58mm Receipt", PaperWidth, paperHeight);
            printDoc.DefaultPageSettings.Margins = new Margins(5, 5, 5, 5);

            printDoc.PrintPage += (sender, e) =>
            {
                DrawReceipt(e.Graphics, bill, billItems);
                e.HasMorePages = false;
            };

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;

            string savedPrinter = new Settings().printer_name;

            bool printerExists = false;

            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                if (printer == savedPrinter)
                {
                    printerExists = true;
                    break;
                }
            }

            // ✅ ถ้ามี → ใช้ตาม settings
            if (printerExists)
            {
                printDoc.PrinterSettings.PrinterName = savedPrinter;
            }
            else
            {
                printDoc.PrinterSettings.PrinterName = new PrinterSettings().PrinterName;
            }


            // 🔽 ส่วน print
            if (showPreview)
            {
                preview.Document = printDoc; // สำคัญ!
                preview.ShowDialog();
            }
            else
            {
                printDoc.Print();
            }
        }

        private BillHeader GetBillHeader(long orderId)
        {
            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        o.bill_code,
                        o.order_date,
                        o.total,
                        o.discount,
                        o.net_total,
                        IFNULL(o.paid, 0) AS paid,
                        IFNULL(o.change, 0) AS change,
                        IFNULL(o.vat, 0) AS vat,
                        IFNULL(o.vat_rate, 0) AS vat_rate,

                        IFNULL(m.member_code, '') AS member_code,
                        IFNULL(m.name, '') AS member_name,
                        IFNULL(m.phone, '') AS member_phone
                    FROM ""order"" o
                    LEFT JOIN members m ON o.member_id = m.id
                    WHERE o.id = @order_id
                ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@order_id", orderId);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read()) return null;

                        return new BillHeader
                        {
                            BillCode = reader["bill_code"].ToString(),
                            OrderDate = reader["order_date"].ToString(),
                            Total = Convert.ToDecimal(reader["total"]),
                            Discount = Convert.ToDecimal(reader["discount"]),
                            NetTotal = Convert.ToDecimal(reader["net_total"]),
                            Paid = Convert.ToDecimal(reader["paid"]),
                            Change = Convert.ToDecimal(reader["change"]),
                            Vat = Convert.ToDecimal(reader["vat"]),
                            VatRate = Convert.ToDecimal(reader["vat_rate"]),

                            MemberCode = reader["member_code"].ToString(),
                            MemberName = reader["member_name"].ToString(),
                            MemberPhone = reader["member_phone"].ToString()
                        };
                    }
                }
            }
        }

        private DataTable GetBillItems(long orderId)
        {
            DataTable dt = new DataTable();

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT 
                        p.name,
                        oi.price,
                        oi.quantity,
                        oi.net_total
                    FROM order_items oi
                    LEFT JOIN product p ON oi.product_id = p.id
                    WHERE oi.order_id = @order_id
                ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@order_id", orderId);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }

        private int CalculatePaperHeight(DataTable billItems)
        {
            int height = 260;

            if (!string.IsNullOrWhiteSpace(logoPath) && File.Exists(logoPath))
                height += 85;

            if (!string.IsNullOrWhiteSpace(shopAddress))
                height += 45;

            if (!string.IsNullOrWhiteSpace(taxId))
                height += 20;

            height += billItems.Rows.Count * 38;

            if (!string.IsNullOrWhiteSpace(footerText))
                height += 60;

            height += 120;

            return Math.Max(height, 500);
        }

        private void DrawReceipt(Graphics g, BillHeader bill, DataTable billItems)
        {
            using Font font = new Font("Tahoma", 8);
            using Font fontSmall = new Font("Tahoma", 7);
            using Font fontBold = new Font("Tahoma", 8, FontStyle.Bold);
            using Font fontTotal = new Font("Tahoma", 12, FontStyle.Bold);
            using Font fontTitle = new Font("Tahoma", 10, FontStyle.Bold);

            using StringFormat center = new StringFormat { Alignment = StringAlignment.Center };
            using StringFormat right = new StringFormat { Alignment = StringAlignment.Far };

            int left = 5;
            int y = 5;
            int lineHeight = 18;

            DrawTextAutoHeight(g, "ใบเสร็จรับเงิน", fontTotal, left, ref y, PaperWidth, center);
            y += 5;

            DrawLogo(g, ref y, left);

            DrawTextAutoHeight(g, shopName, fontTitle, left, ref y, PaperWidth, center);

            if (!string.IsNullOrWhiteSpace(shopAddress))
            {
                DrawTextAutoHeight(g, shopAddress, fontSmall, left, ref y, PaperWidth, center);
            }

            if (!string.IsNullOrWhiteSpace(taxId))
            {
                DrawTextAutoHeight(g, "เลขผู้เสียภาษี: " + taxId, fontSmall, left, ref y, PaperWidth, center);
            }

            if (!string.IsNullOrWhiteSpace(shopPhone))
            {
                DrawTextAutoHeight(g, "โทร: " + shopPhone, fontSmall, left, ref y, PaperWidth, center);
            }

            y += 3;
            DrawEqual(g, font, left, ref y);
            y += 3;

            g.DrawString($"เลขที่บิล: {bill.BillCode}", font, Brushes.Black, left, y);
            y += lineHeight;

            g.DrawString($"วันที่: {bill.OrderDate}", font, Brushes.Black, left, y);
            y += lineHeight;

            if (!string.IsNullOrWhiteSpace(bill.MemberName))
            {
                g.DrawString($"สมาชิก: {bill.MemberName}", font, Brushes.Black, left, y);
                y += lineHeight;

                g.DrawString($"รหัสสมาชิก: {bill.MemberCode}", font, Brushes.Black, left, y);
                y += lineHeight;
            }
            else
            {
                g.DrawString("สมาชิก: -", font, Brushes.Black, left, y);
                y += lineHeight;
            }

            DrawLine(g, font, left, ref y);

            foreach (DataRow row in billItems.Rows)
            {
                string name = row["name"].ToString();
                decimal price = Convert.ToDecimal(row["price"]);
                int qty = Convert.ToInt32(row["quantity"]);
                decimal itemTotal = Convert.ToDecimal(row["net_total"]);

                DrawTextAutoHeight(g, name, font, left, ref y, ContentWidth, null);

                g.DrawString($"{qty} x {price:N2}", font, Brushes.Black, left + 10, y);

                g.DrawString(
                    itemTotal.ToString("N2"),
                    font,
                    Brushes.Black,
                    new RectangleF(left, y, ContentWidth, lineHeight),
                    right
                );

                y += lineHeight;
            }

            DrawLine(g, font, left, ref y);

            DrawAmountRow(g, font, "ราคารวม", bill.Total, left, y, right);
            y += lineHeight;

            DrawAmountRow(g, font, "ส่วนลด", bill.Discount, left, y, right);
            y += lineHeight;

            DrawAmountRow(g, font, $"ภาษีมูลค่าเพิ่ม({bill.VatRate}%)", bill.Vat, left, y, right);
            y += lineHeight;

            DrawAmountRow(g, fontTotal, "ราคาสุทธิ", bill.NetTotal, left, y, right);
            y += 25;

            DrawAmountRow(g, font, "รับเงิน", bill.Paid, left, y, right);
            y += lineHeight;

            DrawAmountRow(g, font, "เงินทอน", bill.Change, left, y, right);
            y += lineHeight + 5;

            DrawEqual(g, font, left, ref y);

            if (!string.IsNullOrWhiteSpace(footerText))
            {
                DrawTextAutoHeight(g, footerText, font, left, ref y, ContentWidth, center);
            }
        }

        private void DrawLogo(Graphics g, ref int y, int left)
        {
            if (string.IsNullOrWhiteSpace(logoPath)) return;
            if (!File.Exists(logoPath)) return;

            using Image logo = Image.FromFile(logoPath);

            int logoSize = 80;
            int logoX = left + (PaperWidth - logoSize) / 2;

            g.DrawImage(logo, logoX, y, logoSize, logoSize);
            y += logoSize + 5;
        }

        private void DrawLine(Graphics g, Font font, int left, ref int y)
        {
            float maxWidth = ContentWidth + 20;

            string dash = "-";
            string line = "";

            // 🔥 ต่อ - ไปเรื่อย ๆ จนเต็มความกว้าง
            while (g.MeasureString(line + dash, font).Width < maxWidth)
            {
                line += dash;
            }

            g.DrawString(line, font, Brushes.Black, left, y);
            y += (int)g.MeasureString(line, font).Height;
        }

        private void DrawEqual(Graphics g, Font font, int left, ref int y)
        {
            float maxWidth = ContentWidth + 20;

            string dash = "=";
            string line = "";

            // 🔥 ต่อ - ไปเรื่อย ๆ จนเต็มความกว้าง
            while (g.MeasureString(line + dash, font).Width < maxWidth)
            {
                line += dash;
            }

            g.DrawString(line, font, Brushes.Black, left, y);
            y += (int)g.MeasureString(line, font).Height;
        }

        private void DrawAmountRow(Graphics g, Font font, string label, decimal amount, int left, int y, StringFormat right)
        {
            g.DrawString(label, font, Brushes.Black, left, y);

            g.DrawString(
                amount.ToString("N2"),
                font,
                Brushes.Black,
                new RectangleF(left, y, ContentWidth, 22),
                right
            );
        }

        private void DrawTextAutoHeight(
            Graphics g,
            string text,
            Font font,
            int left,
            ref int y,
            int width,
            StringFormat format
        )
        {
            if (string.IsNullOrWhiteSpace(text)) return;

            SizeF size = g.MeasureString(text, font, width);

            g.DrawString(
                text,
                font,
                Brushes.Black,
                new RectangleF(left, y, width, size.Height),
                format
            );

            y += (int)Math.Ceiling(size.Height) + 2;
        }

        private class BillHeader
        {
            public string BillCode { get; set; }
            public string OrderDate { get; set; }
            public decimal Total { get; set; }
            public decimal Discount { get; set; }
            public decimal NetTotal { get; set; }
            public decimal Paid { get; set; }
            public decimal Change { get; set; }
            public decimal Vat { get; set; }
            public decimal VatRate { get; set; }

            public string MemberCode { get; set; }
            public string MemberName { get; set; }
            public string MemberPhone { get; set; }
        }
    }
}