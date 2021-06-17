using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMonHoc.Screen
{
    public partial class frmChangePassword : Form
    {

        public frmChangePassword()
        {
            InitializeComponent();
            this.btnHuy.Image = (Image)(new Bitmap(Image.FromFile(@"../../Images/cancel.png"), new Size(25, 25)));
            this.btnLuu.Image = (Image)(new Bitmap(Image.FromFile(@"../../Images/save.png"), new Size(25, 25)));
            this.pnOld.Controls.Add(new PictureBox { Height = 2, Dock = DockStyle.Bottom, Image = Image.FromFile(@"../../Images/BAR.png") });
            this.pnNew.Controls.Add(new PictureBox { Height = 2, Dock = DockStyle.Bottom, Image = Image.FromFile(@"../../Images/BAR.png") });
            this.pnConfrim.Controls.Add(new PictureBox { Height = 2, Dock = DockStyle.Bottom, Image = Image.FromFile(@"../../Images/BAR.png") });
        }

        private void pbOld_Click(object sender, EventArgs e)
        {
            txtOld.UseSystemPasswordChar = !txtOld.UseSystemPasswordChar;

        }
    }
}
