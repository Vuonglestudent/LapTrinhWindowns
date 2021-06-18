using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMonHoc.EntityModel;

namespace ProjectMonHoc.Screen
{
    public partial class frmChangePassword : Form
    {
        NHANVIEN userCurrent;
        public frmChangePassword(NHANVIEN user)
        {
            InitializeComponent();
            userCurrent = user;
            this.btnHuy.Image = (Image)(new Bitmap(Image.FromFile(@"../../Images/cancel.png"), new Size(25, 25)));
            this.btnLuu.Image = (Image)(new Bitmap(Image.FromFile(@"../../Images/save.png"), new Size(25, 25)));
            this.pnOld.Controls.Add(new PictureBox { Height = 2, Dock = DockStyle.Bottom, Image = Image.FromFile(@"../../Images/BAR.png") });
            this.pnNew.Controls.Add(new PictureBox { Height = 2, Dock = DockStyle.Bottom, Image = Image.FromFile(@"../../Images/BAR.png") });
            this.pnConfrim.Controls.Add(new PictureBox { Height = 2, Dock = DockStyle.Bottom, Image = Image.FromFile(@"../../Images/BAR.png") });
        }

        #region eventShowPass
        private void pbOld_Click(object sender, EventArgs e)
        {
            txtOld.UseSystemPasswordChar = !txtOld.UseSystemPasswordChar;
            this.pbOld.BackgroundImage = txtOld.UseSystemPasswordChar
                ? Image.FromFile(@"../../Images/hiddenPass.png") 
                : Image.FromFile(@"../../Images/showPass.png");
        }

        private void pbNew_Click(object sender, EventArgs e)
        {
            txtNew.UseSystemPasswordChar = !txtNew.UseSystemPasswordChar;
            this.pbNew.BackgroundImage = txtNew.UseSystemPasswordChar
                ? Image.FromFile(@"../../Images/hiddenPass.png")
                : Image.FromFile(@"../../Images/showPass.png");
        }

        private void pbConfrim_Click(object sender, EventArgs e)
        {
            txtConfrim.UseSystemPasswordChar = !txtConfrim.UseSystemPasswordChar;
            this.pbConfrim.BackgroundImage = txtConfrim.UseSystemPasswordChar
                ? Image.FromFile(@"../../Images/hiddenPass.png")
                : Image.FromFile(@"../../Images/showPass.png");
        }

        #endregion

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtOld.ResetText();
            txtNew.ResetText();
            txtConfrim.ResetText();
            txtOld.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtOld.Text != "" && txtNew.Text != "" && txtConfrim.Text != "")
            {
                if(txtNew.Text == txtConfrim.Text)
                {
                    bool check = BL_Layer.BLTaiKhoan.Instance.DoiMatKhau(txtOld.Text, txtNew.Text, userCurrent.IDNhanVien);
                    if (check)
                    {
                        MessageBox.Show("Cập nhật mật khẩu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật mật khẩu thất bại");
                    }
                } else
                {
                    MessageBox.Show("Mật khẩu mới xác nhận không chính xác");
                }
            } else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
    }
}
