using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Clicket
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLupaPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnRegister.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password= tbPassword.Text;

            Action action = new Action();
            User user = action.login(username, password);

            if(user.Name != null)
            {
                if (User.RoleID == 1000)
                {
                    var frm = new Dashboard();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    this.Hide();
                }
                else if(User.RoleID == 1001)
                {
                    var frm = new DashboardAdmin();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("silakan cek ulang username dan password", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblBuatAkun_LinkClicked(object sender, EventArgs e)
        {
            pnRegister.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string name = tbName.Text;
            string email = tbEmail.Text;
            string phone = tbPhone.Text;
            DateTime birth = dtpBirth.Value.Date;

            Action action = new Action();
            action.register(username, password, name, email, phone, birth);
            pnRegister.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnRegister.Visible = false;
        }
    }
}
