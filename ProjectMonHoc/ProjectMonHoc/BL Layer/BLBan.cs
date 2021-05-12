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
                   select new { tt.IDBan, tt.TenBan, tt.TrangThai , tt.IDHoaDon};

            foreach (var item in kq.ToList())
            {
                BAN ban = new BAN();
                ban.IDBan = item.IDBan;
                ban.TenBan = item.TenBan;
                ban.TrangThai = item.TrangThai;
                ban.IDHoaDon = item.IDHoaDon;
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
            var IDHoaDon = qlCF.BANs.Find(IDBan);

            return BLChiTietHoaDon.Instance.LayChiTietHoaDon(IDHoaDon.IDHoaDon);
        }

        public void ThayDoiTrangThai(int IDBan)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            var ban = (from b in qlCF.BANs
                   where b.IDBan == IDBan
                   select b).SingleOrDefault();
            if (ban != null)
                ban.TrangThai = !ban.TrangThai;
            else return;
            qlCF.SaveChanges();
        }

        public void DaThanhToanBan(int idBan)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var ban = ql.BANs.Find(idBan);

            if (ban != null)
            {
                ban.TrangThai = false;
                ban.IDHoaDon = null;
                ql.SaveChanges();
            }
        }

        public void ThemHoaDonBan(int IDBan, string IDHoaDon)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            var ban = (from b in qlCF.BANs
                       where b.IDBan == IDBan
                       select b).SingleOrDefault();
            if (ban != null)
                ban.IDHoaDon = IDHoaDon;
            else
                return;
            qlCF.SaveChanges();
        }
    }
}
