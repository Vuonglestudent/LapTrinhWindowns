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
    class BLHoaDon
    {
        private static BLHoaDon instance;
        public static BLHoaDon Instance
        {
            get { if (instance == null) instance = new BLHoaDon(); return instance; }
            private set { instance = value; }
        }

        public void ThemHoaDon(string IDHoaDon, string IDNhanVien, int IDBan, DateTime NgayLap, int tongTien, string khuyenMai, ref string err)
        {
            DBMain db = new DBMain();
            string query = "Insert Into HOADON (IDNhanVien, NgayLap, TongTien, KhuyenMai, IDBan, IDHoaDon) " +
                "Values ('" + IDNhanVien + "','" + NgayLap + "'," + tongTien + ",'" + khuyenMai + "'," + IDBan + ",'" + IDHoaDon + "')";
            try
            {
                db.MyExecuteNonQuery(query, CommandType.Text, ref err);
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại!");
            }
        }

        public bool ThanhToanHoaDon(string idHoaDon, ref string err)
        {
            /*
                var hd = ql.HOADONs.Find(idHoaDon);
             */

            DBMain db = new DBMain();
            string query = "Update HOADON " +
                "Set NgayThanhToan = '" + DateTime.Now + "'" +
                " Where IDHoaDon = '" + idHoaDon + "'";
            var kq = db.MyExecuteNonQuery(query, CommandType.Text, ref err);
            return kq;

        }

        public HOADON LayHoaDonID(string ID) //Không sử dụng
        {
            /* (EntityModels)
                var hoadon = (ql.HOADONs.Where(x => x.IDHoaDon == ID).Select(x => x)).SingleOrDefault();
            */
            DBMain db = new DBMain();
            string query = "Select * " +
                "From HOADON " +
                "Where IDHoaDon = '" + ID + "'";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);
            HOADON hd = new HOADON();
            if (query != null)
            {
                hd.IDHoaDon = kq.Rows[0]["IDHoaDon"].ToString();
                hd.IDBan = (int)kq.Rows[0]["IDBan"];
                hd.IDNhanVien = kq.Rows[0]["IDNhanVien"].ToString();
                hd.KhuyenMai = kq.Rows[0]["KhuyenMai"].ToString();
                hd.NgayLap = (DateTime)kq.Rows[0]["NgayLap"];
                if (kq.Rows[0]["NgayThanhToan"].ToString() != "")
                    hd.NgayThanhToan = (DateTime)kq.Rows[0]["NgayThanhToan"];
                else
                    hd.NgayThanhToan = null;
                hd.TongTien = (int)kq.Rows[0]["TongTien"];
            }
            return hd;
        }

        //        //Hàm lấy bảng các hóa đơn từ ngày batdau đến ngày ketthuc, kích hoạt khi thay đổi value dateTimePicker
        public DataTable LayHoaDon(DateTime batdau, DateTime ketthuc)
        {
            //            var hoadon = ql.HOADONs.OrderBy(x=>x.NgayLap)
            //            .Where(x=>(x.NgayLap < kt.Date && x.NgayLap >= batdau.Date))
            //            .Select(x=>x);

            DBMain db = new DBMain();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                            new DataColumn("IDHoaDon"),
                            new DataColumn("NhanVien"),
                            new DataColumn("NgayLap"),
                            new DataColumn("NgayThanhToan"),
                            new DataColumn("TongTien")
            });
            DateTime kt = ketthuc.AddDays(1);
            DateTime bd = batdau;
            string query = "Select * from HOADON Where NgayLap < '" + kt.ToString("yyyy-MM-dd HH:MM:ss") + "' And NgayLap >= '"
                + bd.ToString("yyyy-MM-dd HH:MM:ss") + "' Order By NgayLap";
            var rs = db.ExecuteQueryDataSet(query, CommandType.Text);
            foreach (DataRow r in rs.Rows)
            {
                string ngaylap = ((DateTime)r["NgayLap"]).ToString("HH:mm   dd/MM/yyyy");
                string ngaythanhtoan;
                if (r["NgayThanhToan"].ToString() != "")
                {
                    ngaythanhtoan = ((DateTime)r["NgayThanhToan"]).ToString("HH:mm   dd/MM/yyyy");
                }
                else ngaythanhtoan = "";
                dt.Rows.Add(r["IDHoaDon"], r["IDNhanVien"], ngaylap, ngaythanhtoan, r["TongTien"]);
            }
            return dt;
        }

        //        //Hàm lấy thời gian lập của bill sớm nhất
        public DateTime TimeOfFirstBill()
        {
            //            DateTime result = ql.HOADONs.OrderBy(x => x.NgayLap).Select(x=>x.NgayLap).FirstOrDefault();
            //            if (result != default)
            //            {
            //                return result;
            //            }
            //            return DateTime.Now;

            DBMain db = new DBMain();
            string query = "Select top(1) NgayLap From HOADON Order By NgayLap";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);
            if(kq.Rows.Count > 0)
            {
                return ((DateTime)kq.Rows[0]["NgayLap"]).Date;
            }
            return DateTime.Now.Date;
        }

        //        //Hàm lấy thời gian lập của bill gần nhất
        public DateTime TimeOfLastBill()
        {
            //            DateTime result = ql.HOADONs.OrderByDescending(x => x.NgayLap).Select(x=>x.NgayLap).FirstOrDefault();
            //            if (result != default)
            //            {
            //                return result;
            //            }
            //            return DateTime.Now;

            DBMain db = new DBMain();
            string query = "Select top(1) NgayLap From HOADON Order By NgayLap Desc";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);
            if (kq.Rows.Count > 0)
            {
                return ((DateTime)kq.Rows[0]["NgayLap"]).AddDays(1).Date;
            }
            return DateTime.Now.Date;
        }

        //        //2 hàm trên hỗ trợ việc đưa thời gian vào 2 datetimepicker khi mới mở form


        //        public bool CheckExist()
        //        {
        //            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
        //            if (ql.HOADONs.Count() > 0)
        //                return true;
        //            return false;
        //        }

        public DateTime layNgayLap(string ID)
        {
            //            DateTime result = ql.HOADONs.Where(x => x.IDHoaDon == ID).Select(x => x.NgayLap).FirstOrDefault();
            //            if (result != default)
            //            {
            //                return result;
            //            }
            //            return DateTime.Now;

            DBMain db = new DBMain();
            string query = "Select NgayLap From HOADON Where IDHoaDon = '" + ID + "'";
            string rs = db.ExecuteQueryDataSet(query, CommandType.Text).Rows[0]["NgayLap"].ToString();
            return DateTime.Now;
        }
    }
}
