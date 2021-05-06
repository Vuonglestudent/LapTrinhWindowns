using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data;

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
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
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
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            BAN kq = (from tt in qlCF.BANs
                      where tt.IDBan == IDBan
                      select tt).SingleOrDefault();                            
            return kq.TrangThai;
        }

        public IQueryable LayChiTietHoaDonBan(int IDBan)
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            string IDHoaDon = (from ban in qlCF.BANs
                               where ban.IDBan == IDBan
                               select ban.IDHoaDon).SingleOrDefault();
            return BLChiTietHoaDon.Instance.LayChiTietHoaDon(IDHoaDon);
        }

        public string LayTongTien(int IDBan)
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            var IDHoaDon = (from ban in qlCF.BANs
                         where ban.IDBan == IDBan
                         select ban.IDHoaDon);
            var TT = from hd in qlCF.HOADONs
                         where hd.IDHoaDon == IDHoaDon.SingleOrDefault()
                         select hd.TongTien;
            return TT.ToString();
        }

        internal void ThayDoiTrangThai(int IDBan)
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            var ban = (from b in qlCF.BANs
                   where b.IDBan == IDBan
                   select b).SingleOrDefault();
            if (ban != null)
                ban.TrangThai = !ban.TrangThai;
            else return;
            qlCF.SubmitChanges();
        }

        internal void ThemHoaDonBan(int IDBan, string IDHoaDon)
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            var ban = (from b in qlCF.BANs
                       where b.IDBan == IDBan
                       select b).SingleOrDefault();
            if (ban != null)
                ban.IDHoaDon = IDHoaDon;
            else
                return;
            qlCF.SubmitChanges();
        }
    }
}
