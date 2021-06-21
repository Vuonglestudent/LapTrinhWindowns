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
using ProjectMonHoc.EntityModel;

namespace ProjectMonHoc.Screen
{
    public partial class Bill : UserControl
    {
        static Bill intance;

        public static Bill Intance 
        {
            get
            {
                if (intance != null)
                    return intance;
                else intance = new Bill();
                return intance;
            }
        }

        public Bill()
        {
            InitializeComponent();
        }

        public Bill(string IDbill)
        {
            InitializeComponent();
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            HOADON hd = BLHoaDon.Instance.LayHoaDonID(IDbill);
            lbID.Text = IDbill;
            lbNgayLap.Text = hd.NgayLap.ToString();
            lbBan.Text = hd.IDBan.ToString();
            lbGiamGia.Text = hd.KhuyenMai;
            lbTongTien.Text = hd.TongTien.ToString() + "$";
            DataTable cthd = BLChiTietHoaDon.Instance.LayChiTietHoaDon(IDbill);
            cthd.Columns.Remove(cthd.Columns["IDHoaDon"]);
            int sizeOfDgv = cthd.Rows.Count * dgvMonAn.RowTemplate.Height;
            this.Height += sizeOfDgv;
            Point pn = panel1.Location;
            pn.Y += sizeOfDgv;
            panel1.Location = pn;
            dgvMonAn.Height = sizeOfDgv;
            dgvMonAn.DataSource = cthd;
        }
    }
}
