using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMonHoc.DTO;
using ProjectMonHoc.EntityModel;

namespace ProjectMonHoc.Screen
{
    public partial class frmProfile : Form
    {
        NHANVIEN userCurrent;
        public frmProfile(NHANVIEN user)
        {
            InitializeComponent();
            userCurrent = user;
            this.txtName.Controls.Add(new PictureBox { Height = 2, Dock = DockStyle.Bottom, Image = Image.FromFile(@"../../Images/BAR.png") });
        }


        #region Paint

        public void DrawRoundRect(Graphics g, SolidBrush sb ,Pen p, float X, float Y, float width, float height, float radius)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            if (p != null) g.DrawPath(p, gp);
            if (sb != null) g.FillPath(sb, gp);
            gp.Dispose();
        }

        private void pnName_Paint(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            DrawRoundRect(v, new SolidBrush(Color.White), null, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            base.OnPaint(e);
        }

        private void pnPhone_Paint(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            DrawRoundRect(v, null, Pens.Pink, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            base.OnPaint(e);
        }

        private void pnAdress_Paint(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            DrawRoundRect(v, null, Pens.Pink, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            base.OnPaint(e);
        }

        private void pnEmail_Paint(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            DrawRoundRect(v, null, Pens.Pink, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            base.OnPaint(e);
        }

        private void pnJob_Paint(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            DrawRoundRect(v, null, Pens.Pink, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            base.OnPaint(e);
        }
        #endregion

        private void frmProfile_Load(object sender, EventArgs e)
        {
            txtName.Text = userCurrent.Ho + " " + userCurrent.Ten;
            txtAddress.Text = userCurrent.DiaChi;
            txtEmail.Text = userCurrent.Email;
            txtPhone.Text = userCurrent.SDT;
            dtpNgaySinh.Value = userCurrent.NgaySinh;
            pbAvatar1.BackgroundImage = Image.FromFile(@"../../Images/" + userCurrent.HinhNV);
            pbAvatar2.BackgroundImage = Image.FromFile(@"../../Images/" + userCurrent.HinhNV);
            txtJob.Text = BL_Layer.BLCongViec.Instance.LayCongViecById(userCurrent.IDCongViec);
        }
    }
}
