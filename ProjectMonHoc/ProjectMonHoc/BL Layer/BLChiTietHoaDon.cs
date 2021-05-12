using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMonHoc.EntityModel;

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
        public DataTable LayChiTietHoaDon(string IDHoaDon)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();

            var queryCTHoaDon = from cthd in qlCF.CHITIETHOADONs
                                join mn in qlCF.NUOCUONGs on cthd.IDMonNuoc equals mn.IDMonNuoc
                                where cthd.IDHoaDon == IDHoaDon
                                select new { cthd.IDHoaDon, mn.TenMon, mn.GiaTien, cthd.SoLuong, ThanhTien = cthd.GiaTien };

            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("IDHoaDon"),
                new DataColumn("TenMon"),
                new DataColumn("GiaTien"),
                new DataColumn("SoLuong"),
                new DataColumn("ThanhTien"),
            }); ;

            foreach (var i in queryCTHoaDon)
            {
                dt.Rows.Add(i.IDHoaDon, i.TenMon, i.GiaTien, i.SoLuong, i.ThanhTien);
            }
            return dt;
        }
        public void ThemChiTietHoaDon(string IDHoaDon, string IDMonNuoc, int SoLuong, int GiaTien)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            CHITIETHOADON cthd = new CHITIETHOADON();
            cthd.IDHoaDon = IDHoaDon;
            cthd.IDMonNuoc = IDMonNuoc;
            cthd.SoLuong = SoLuong;
            cthd.GiaTien = GiaTien;
            qlCF.CHITIETHOADONs.Add(cthd);
            try
            {
                qlCF.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
        }
    }
}
