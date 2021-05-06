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
    }
}
