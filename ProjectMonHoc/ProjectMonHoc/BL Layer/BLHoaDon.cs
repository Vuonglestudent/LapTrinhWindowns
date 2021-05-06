using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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

        public void ThemHoaDon (string IDHoaDon,string IDNhanVien, DateTime NgayLap, int tongTien, string khuyenMai)
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            HOADON hoadon = new HOADON();
            hoadon.IDNhanVien = IDNhanVien;
            hoadon.NgayLap = NgayLap;
            hoadon.TongTien = tongTien;
            hoadon.KhuyenMai = khuyenMai;
            hoadon.IDHoaDon = IDHoaDon;
            qlCF.HOADONs.InsertOnSubmit(hoadon);
            try
            {
                qlCF.SubmitChanges();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại!");
            }
        }

    }
}
