using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMonHoc.EntityModel;
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

        public List<MONAN> LayDanhMucNuocUong(int tab)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            List<MONAN> lstNuoc = new List<MONAN>();
            var queryNU = from nu in qlCF.MONANs
                          where nu.IDDanhMuc == tab
                          select nu;

            foreach (var item in queryNU.ToList())
            {
                MONAN nu = new MONAN();
                nu.IDMonAn = item.IDMonAn;
                nu.IDDanhMuc = item.IDDanhMuc;
                nu.GiaTien = item.GiaTien;
                nu.TenMon = item.TenMon;
                lstNuoc.Add(nu);
            }

            return lstNuoc;
        }
        public int LayDonGia(string IDMonAn)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            int gia = (from nu in qlCF.MONANs
                       where nu.IDMonAn == IDMonAn
                          select nu.GiaTien).SingleOrDefault();
            return gia;
        }

        public string LayTenMonNuoc(string IDMonNuoc)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            string ten = (from nu in qlCF.MONANs
                          where nu.IDMonAn == IDMonNuoc
                       select nu.TenMon).SingleOrDefault();
            return ten;
        }

        public string LayIDMonNuoc(string TenMon)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            string id = (from nu in qlCF.MONANs
                         where nu.TenMon == TenMon
                          select nu.IDMonAn).SingleOrDefault();
            return id;
        }

        public void ThemMonAn(string tenMon, int danhMucMon, int giaMon, string pathHinh)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var m = ql.MONANs.OrderByDescending(x => x.IDMonAn).FirstOrDefault();
            int idMonNuoc = int.Parse(m.IDMonAn.Split('U')[1]);
            MONAN ma = new MONAN();
            ma.IDMonAn = idMonNuoc>= 100 ? "NU" + (idMonNuoc + 1) : "NU0" + (idMonNuoc + 1);
            ma.IDDanhMuc = danhMucMon;
            ma.TenMon = tenMon;
            ma.GiaTien = giaMon;
            ma.HinhMA = pathHinh;
            ql.MONANs.Add(ma);
            ql.SaveChanges();
        }

        int LayIdMonNuocMoiNhat()
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var m = ql.MONANs.OrderByDescending(x => x.IDMonAn).FirstOrDefault();
            return int.Parse(m.IDMonAn.Split('U')[1]);
        }
    }
}
