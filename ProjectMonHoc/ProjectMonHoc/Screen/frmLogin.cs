using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMonHoc.BL_Layer;

namespace ProjectMonHoc
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.tbxTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTK.Controls.Add(new Label { Height = 3, Dock = DockStyle.Bottom, Image = Image.FromFile(@"../../Images/BAR.png") });
            this.tbxMK.Controls.Add(new Label { Height = 3, Dock = DockStyle.Bottom, Image = Image.FromFile(@"../../Images/BAR.png") });
            this.tbxTK.GotFocus += RemovePHTextUserName;
            this.tbxTK.LostFocus += AddPHTextUserName;
            this.tbxMK.GotFocus += RemovePHTextPassword;
            this.tbxMK.LostFocus += AddPHTextPassword;
            panel1.BackgroundImage = Image.FromFile(@"../../Images/Login_background.png");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            switch (BLTaiKhoan.Instance.checkLogin(tbxTK.Text, tbxMK.Text))
            {
                case 0:
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu vui lòng kiểm tra lại!");
                        break;
                    }
                case 1:
                    {
                        this.Close();
                        ProjectMonHoc.Program.mainForm.login(1, tbxTK.Text);
                        break;
                    }
                default :
                    {
                        this.Close();
                        ProjectMonHoc.Program.mainForm.login(2, tbxTK.Text);
                        break;
                    }
            }
        }

        private void tbxMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnDangNhap_Click(sender, e);
        }

        public void RemovePHTextUserName(object sender, EventArgs e)
        {
            if (this.tbxTK.Text == "Tài khoản...")
            {
                this.tbxTK.Text = "";
            }
        }

        public void AddPHTextUserName(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.tbxTK.Text))
                this.tbxTK.Text = "Tài khoản...";
        }

        public void RemovePHTextPassword(object sender, EventArgs e)
        {
            this.tbxMK.UseSystemPasswordChar = true;
            if (this.tbxMK.Text == "Mật khẩu...")
            {
                this.tbxMK.Text = "";
            }
        }

        public void AddPHTextPassword(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.tbxMK.Text))
            {
                this.tbxMK.UseSystemPasswordChar = false;
                this.tbxMK.Text = "Mật khẩu...";
            }
        }
    }
}
