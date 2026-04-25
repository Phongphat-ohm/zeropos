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
    public partial class BillMemberAdd : Form
    {
        public string _member_id;
        public string _member_code;
        public string _member_name;
        public string _member_phone;

        public BillMemberAdd()
        {
            InitializeComponent();
        }

        private void BillMemberAdd_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
            return;
        }

        private void BillMemberAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_cancel.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.F1)
            {
                btn_search.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.F2)
            {
                btn_select_member.PerformClick();
                return;
            }

            if(e.KeyCode == Keys.Delete)
            {
                btn_clear_member.PerformClick();
                return;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string search_text = inp_search.Text.Trim();

            if (string.IsNullOrEmpty(search_text))
            {
                MessageBox.Show("กรุณากรอกคำค้นหา", "การแจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                inp_search.Focus();
                return;
            }

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT id, member_code, name, phone
                    FROM members
                    WHERE member_code = @search
                       OR phone = @search
                    LIMIT 1
                ";

                using (SqliteCommand cmd = new SqliteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", search_text);

                    using (SqliteDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("ไม่พบสมาชิก", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            inp_search.Focus();
                            inp_search.SelectAll();
                            return;
                        }

                        int member_id = Convert.ToInt32(reader["id"]);
                        string code = reader["member_code"].ToString();
                        string name = reader["name"].ToString();
                        string phone = reader["phone"].ToString();

                        txt_member_id.Text = member_id.ToString();
                        txt_member_code.Text = code;
                        txt_member_name.Text = name;
                        txt_member_phone.Text = phone;

                        btn_select_member.Focus();
                        return;
                    }
                }
            }
        }

        private void btn_select_member_Click(object sender, EventArgs e)
        {
            _member_id = txt_member_id.Text.ToString();
            _member_code = txt_member_code.Text.ToString();
            _member_name = txt_member_name.Text.ToString();
            _member_phone = txt_member_phone.Text.ToString();
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void inp_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inp_search.Clear();
            txt_member_id.Text = "";
            txt_member_code.Text = "";
            txt_member_name.Text = "";
            txt_member_phone.Text = "";
            inp_search.Focus();
        }
    }
}
