using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data;
using ProjectMonHoc.EntityModel;

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
            List<BAN> lstBan = new List<BAN>();
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            var kq = from tt in qlCF.BANs
                     where tt.TrangThaiXoa == false
                   select new { tt.IDBan, tt.TenBan, tt.TrangThai , tt.SucChua};

            foreach (var item in kq.ToList())
            {
                BAN ban = new BAN();
                ban.IDBan = item.IDBan;
                ban.TenBan = item.TenBan;
                ban.TrangThai = item.TrangThai;
                ban.SucChua = item.SucChua;
                lstBan.Add(ban);
            }

            return lstBan;
        }

        public bool TrangThai(int IDBan)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            BAN kq = (from tt in qlCF.BANs
                      where tt.IDBan == IDBan
                      select tt).SingleOrDefault();                            
            return kq.TrangThai;
        }

        public DataTable LayChiTietHoaDonBan(int IDBan)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            var IDHoaDon = qlCF.HOADONs
                .Where(x => x.IDBan == IDBan)
                .Where(x => x.NgayLap < DateTime.Now)
                .Where(x => x.NgayThanhToan == null)
                .Select(x => x.IDHoaDon).SingleOrDefault();

            return BLChiTietHoaDon.Instance.LayChiTietHoaDon(IDHoaDon);
        }

        public void ThayDoiTrangThai(int idBan)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var ban = ql.BANs.Find(idBan);
            if (ban != null)
                ban.TrangThai = !ban.TrangThai;
            else return;
            ql.SaveChanges();
        }

        public bool ThemBan(int idBan, string TenBan, int SucChua)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var id = ql.BANs.OrderByDescending(x => x.IDBan).FirstOrDefault();
            BAN ban = new BAN();
            ban.TenBan = TenBan;
            ban.SucChua = SucChua;
            ql.BANs.Add(ban);
            ql.SaveChanges();
            return true;
        }
        public bool CapNhatBan(int idBan, string TenBan, int SucChua)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var ban = (from b in ql.BANs
                     where b.IDBan == idBan
                     select b).SingleOrDefault();
            if (ban == null)
            {
                return false;
            }
            ban.TenBan = TenBan;
            ban.SucChua = SucChua;
            ql.SaveChanges();
            return true;
        }
        public bool XoaBan(int idBan)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            BAN ban = new BAN();
            ban.IDBan = idBan;
            ql.BANs.Attach(ban);
            ql.BANs.Remove(ban);
            ql.SaveChanges();
            return true;
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
