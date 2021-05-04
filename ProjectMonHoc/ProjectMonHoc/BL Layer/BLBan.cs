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
        public IQueryable LayBan()
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            IQueryable kq = from tt in qlCF.BANs
                   select new { tt.IDBan, tt.TenBan, tt.TrangThai, tt.IDHoaDon };
            return kq;
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
    }
}
