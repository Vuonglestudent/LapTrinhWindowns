using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMonHoc.DTO;
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
            /* (EntityModels)
             * var queryCTHoaDon = from cthd in qlCF.CHITIETHOADONs
                                join ma in qlCF.MONANs on cthd.IDMonAn equals ma.IDMonAn
                                where cthd.IDHoaDon == IDHoaDon
                                select new { cthd.IDHoaDon, ma.TenMon, ma.GiaTien, cthd.SoLuong, ThanhTien = ma.GiaTien * cthd.SoLuong };
            */
            DBMain db = new DBMain();
            string query = "Select  CHITIETHOADON.IDHoaDon, TenMon, GiaTien, SoLuong, (GiaTien * SoLuong) as ThanhTien " +
                "From CHITIETHOADON join MONAN on CHITIETHOADON.IDMonAN = MONAN.IDMonAn " +
                "Where CHITIETHOADON.IDHoaDon = '" + IDHoaDon + "'";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("IDHoaDon"),
                new DataColumn("TenMon"),
                new DataColumn("GiaTien"),
                new DataColumn("SoLuong"),
                new DataColumn("ThanhTien"),
            }); ;

            foreach (DataRow i in kq.Rows)
            {
                dt.Rows.Add(i["IDHoaDon"].ToString(), i["TenMon"].ToString(), (int)i["GiaTien"], (int)i["SoLuong"], (int)i["ThanhTien"]);
            }
            return dt;
        }
        public void ThemChiTietHoaDon(string IDHoaDon, string IDMonNuoc, int SoLuong, int GiaTien, ref string err)
        {
            DBMain db = new DBMain();
            string query = "Insert Into CHITIETHOADON (IDHoaDon, IDMonAn, SoLuong) " +
                "Values ('" + IDHoaDon + "','" + IDMonNuoc + "'," + SoLuong + ")";
            try
            {
                db.MyExecuteNonQuery(query, CommandType.Text, ref err);
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra, vui lòng thử lại sau!");
            }
        }
    }
}
