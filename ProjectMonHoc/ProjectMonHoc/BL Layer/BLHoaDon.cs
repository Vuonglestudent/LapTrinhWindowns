using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMonHoc.EntityModel;

namespace ProjectMonHoc.BL_Layer
{
    class BLHoaDon
    {
        private static BLHoaDon instance;
        public static BLHoaDon Instance
        {
            get { if (instance == null) instance = new BLHoaDon(); return instance; }
            private set { instance = value; }
        }

        public void ThemHoaDon (string IDHoaDon,string IDNhanVien, int IDBan, DateTime NgayLap, int tongTien, string khuyenMai)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            HOADON hoadon = new HOADON();
            hoadon.IDNhanVien = IDNhanVien;
            hoadon.NgayLap = NgayLap;
            hoadon.TongTien = tongTien;
            hoadon.KhuyenMai = khuyenMai;
            hoadon.IDBan = IDBan;
            hoadon.IDHoaDon = IDHoaDon;
            qlCF.HOADONs.Add(hoadon);
            try
            {
                qlCF.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại!");
            }
        }

        public bool ThanhToanHoaDon(string idHoaDon)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var hd = ql.HOADONs.Find(idHoaDon);

            if (hd != null)
            {
                hd.NgayThanhToan = DateTime.Now;
                ql.SaveChanges();
                return true;
            }
            else return false;
        }

    }
}
