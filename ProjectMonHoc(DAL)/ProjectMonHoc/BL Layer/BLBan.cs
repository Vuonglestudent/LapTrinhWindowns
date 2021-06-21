using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data;
using ProjectMonHoc.EntityModel;
using ProjectMonHoc.DTO;

namespace ProjectMonHoc.BL_Layer
{
    public class BLBan
    {
        private static BLBan instance;
        public static BLBan Instance
        {
            get { if (instance == null) instance = new BLBan(); return instance; }
            private set { instance = value; }
        }

        public List<BAN> LayBan()
        {
            /* (EntityModels)
             * var kq = from tt in qlCF.BANs
                     where tt.TrangThaiXoa == false
                     select new { tt.IDBan, tt.TenBan, tt.TrangThai, tt.SucChua };
             */
            List<BAN> lstBan = new List<BAN>();
            DBMain db = new DBMain();
            string query = "Select IDBan, TenBan, TrangThai, SucChua " +
                "From BAN " +
                "Where TrangThaiXoa = 0";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);

            foreach (DataRow item in kq.Rows)
            {
                BAN ban = new BAN();
                ban.IDBan = (int)item["IDBan"];
                ban.TenBan = item["TenBan"].ToString();
                ban.TrangThai = (bool)item["TrangThai"];
                ban.SucChua = (int)item["SucChua"];
                lstBan.Add(ban);
            }

            return lstBan;
        }

        public bool TrangThai(int IDBan)
        {
            /* (EntityModels)
             * BAN kq = (from tt in qlCF.BANs
                      where tt.IDBan == IDBan
                      select tt).SingleOrDefault();
            */
            DBMain db = new DBMain();
            string query = "Select TrangThai " +
                "From BAN " +
                "Where IDBan = '" + IDBan + "'";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);

            return (bool)kq.Rows[0]["TrangThai"];
        }

        public DataTable LayChiTietHoaDonBan(int IDBan)
        {
            /* (EntityModels)
             * var IDHoaDon = qlCF.HOADONs
                .Where(x => x.IDBan == IDBan)
                .Where(x => x.NgayLap < DateTime.Now)
                .Where(x => x.NgayThanhToan == null)
                .Select(x => x.IDHoaDon).SingleOrDefault();
            */
            DBMain db = new DBMain();
            string query = "Select IDHoaDon " +
                "From HOADON " +
                "Where NgayLap < '" + DateTime.Now + "' And IDBan = '" + IDBan + "' And NgayThanhToan is null";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);
            string IDHoaDon = kq.Rows[0]["IDHoaDon"].ToString();
            return BLChiTietHoaDon.Instance.LayChiTietHoaDon(IDHoaDon);
        }

        public bool ThayDoiTrangThai(int idBan, ref string err)
        {
            /*
                var ban = ql.BANs.Find(idBan);
             */
            DBMain db = new DBMain();
            string find = "Select TrangThai " +
                "From BAN " +
                "Where IDBan = '" + idBan + "'";
            var kq1 = db.ExecuteQueryDataSet(find, CommandType.Text);

            if (kq1 != null)
            {
                int tt = (bool)kq1.Rows[0]["TrangThai"] ? 0 : 1;
                string query = "Update BAN " +
                    "Set TrangThai = " + tt +
                    " Where IDBan = '" + idBan + "'";
                return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
            }
            return false;

        }

        //public bool ThemBan(int idBan, string TenBan, int SucChua)
        //{
        //    QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
        //    var id = ql.BANs.OrderByDescending(x => x.IDBan).FirstOrDefault();
        //    BAN ban = new BAN();
        //    ban.TenBan = TenBan;
        //    ban.SucChua = SucChua;
        //    ql.BANs.Add(ban);
        //    ql.SaveChanges();
        //    return true;
        //}
        //public bool CapNhatBan(int idBan, string TenBan, int SucChua)
        //{
        //    QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
        //    var ban = (from b in ql.BANs
        //             where b.IDBan == idBan
        //             select b).SingleOrDefault();
        //    if (ban == null)
        //    {
        //        return false;
        //    }
        //    ban.TenBan = TenBan;
        //    ban.SucChua = SucChua;
        //    ql.SaveChanges();
        //    return true;
        //}

        public bool XoaBan(int idBan, ref string err)
        {
            DBMain db = new DBMain();
            string query = "Delete From BAN Where IDBan = '" + idBan + "'";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        //public void ThemHoaDonBan(int IDBan, string IDHoaDon)
        //{
        //    QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
        //    var ban = (from b in qlCF.BANs
        //               where b.IDBan == IDBan
        //               select b).SingleOrDefault();
        //    if (ban != null)
        //        ban.IDHoaDon = IDHoaDon;
        //    else
        //        return;
        //    qlCF.SaveChanges();
        //}
    }
}
