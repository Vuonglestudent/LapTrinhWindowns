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
        public IQueryable TrangThai()
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            IQueryable kq = from tt in qlCF.BANs
                            select new { tt.TrangThai };
                            
            return kq;
        }
        public bool CapNhatBan(int IDBan, string TenBan, bool TrangThai, string IDHoaDon)
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            var queryBan = (from ban in qlCF.BANs
                            where ban.IDBan == IDBan
                            select ban).SingleOrDefault();
            if (queryBan is null)
            {
                return false;
            }
            queryBan.IDBan = IDBan;
            queryBan.TenBan = TenBan;
            queryBan.TrangThai = TrangThai;
            queryBan.IDHoaDon = IDHoaDon;
            qlCF.SubmitChanges();
            return true;
        }

        public IQueryable LayChiTietHoaDonTheoBan(string IDHoaDon)
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            var queryCTHoaDon = from cthd in qlCF.CHITIETHOADONs join mn in qlCF.NUOCUONGs on cthd.IDMonNuoc equals mn.IDMonNuoc
                                where cthd.IDHoaDon == IDHoaDon
                                select new { mn.IDMonNuoc , mn.TenMon , mn.GiaTien, cthd.SoLuong, ThanhTien = cthd.GiaTien};
            return queryCTHoaDon;
        }
    }
}
