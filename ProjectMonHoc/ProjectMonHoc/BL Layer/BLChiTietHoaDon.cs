using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectMonHoc.BL_Layer
{
    class BLChiTietHoaDon
    {
        private static BLChiTietHoaDon instance;
        public static BLChiTietHoaDon Instance
        {
            get { if (instance == null) instance = new BLChiTietHoaDon(); return instance; }
            private set { instance = value; }
        }
        public IQueryable LayChiTietHoaDon(string IDHoaDon)
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            var queryCTHoaDon = from cthd in qlCF.CHITIETHOADONs
                                join mn in qlCF.NUOCUONGs on cthd.IDMonNuoc equals mn.IDMonNuoc
                                where cthd.IDHoaDon == IDHoaDon
                                select new { mn.IDMonNuoc, mn.TenMon, mn.GiaTien, cthd.SoLuong, ThanhTien = cthd.GiaTien };
            return queryCTHoaDon;
        }
        public void ThemChiTietHoaDon(string IDHoaDon, string IDMonNuoc, int SoLuong, int GiaTien)
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            CHITIETHOADON cthd = new CHITIETHOADON();
            cthd.IDHoaDon = IDHoaDon;
            cthd.IDMonNuoc = IDMonNuoc;
            cthd.SoLuong = SoLuong;
            cthd.GiaTien = GiaTien;
            qlCF.CHITIETHOADONs.InsertOnSubmit(cthd);
            try
            {
                qlCF.SubmitChanges();
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
        }
    }
}
