using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonHoc.BL_Layer
{
    class BLNuocUong
    {
        private static BLNuocUong instance;
        public static BLNuocUong Instance
        {
            get { if (instance == null) instance = new BLNuocUong(); return instance; }
            private set { instance = value; }
        }

        public List<NUOCUONG> LayDanhMucCafe()
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            List<NUOCUONG> lstNuoc = new List<NUOCUONG>();
            var queryNU = from nu in qlCF.NUOCUONGs
                          where nu.IDDanhMuc == 1
                          select nu;

            foreach (var item in queryNU.ToList())
            {
                NUOCUONG nu = new NUOCUONG();
                nu.IDMonNuoc = item.IDMonNuoc;
                nu.IDDanhMuc = item.IDDanhMuc;
                nu.GiaTien = item.GiaTien;
                nu.TenMon = item.TenMon;
                lstNuoc.Add(nu);
            }

            return lstNuoc;
        }
    }
}
