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

        public List<NUOCUONG> LayDanhMucNuocUong(int tab)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            List<NUOCUONG> lstNuoc = new List<NUOCUONG>();
            var queryNU = from nu in qlCF.NUOCUONGs
                          where nu.IDDanhMuc == tab
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
        public int LayDonGia(string IDMonNuoc)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            int gia = (from nu in qlCF.NUOCUONGs
                          where nu.IDMonNuoc == IDMonNuoc
                          select nu.GiaTien).SingleOrDefault();
            return gia;
        }

        public string LayTenMonNuoc(string IDMonNuoc)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            string ten = (from nu in qlCF.NUOCUONGs
                       where nu.IDMonNuoc == IDMonNuoc
                       select nu.TenMon).SingleOrDefault();
            return ten;
        }

        public string LayIDMonNuoc(string TenMon)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            string id = (from nu in qlCF.NUOCUONGs
                          where nu.TenMon == TenMon
                          select nu.IDMonNuoc).SingleOrDefault();
            return id;
        }

        public void ThemMonAn(string tenMon, int danhMucMon, int giaMon, string pathHinh)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var m = ql.NUOCUONGs.OrderByDescending(x => x.IDMonNuoc).FirstOrDefault();
            int idMonNuoc = int.Parse(m.IDMonNuoc.Split('U')[1]);
            NUOCUONG ma = new NUOCUONG();
            ma.IDMonNuoc = idMonNuoc>= 100 ? "NU" + (idMonNuoc + 1) : "NU0" + (idMonNuoc + 1);
            ma.IDDanhMuc = danhMucMon;
            ma.TenMon = tenMon;
            ma.GiaTien = giaMon;
            ma.HinhNU = pathHinh;
            ql.NUOCUONGs.Add(ma);
            ql.SaveChanges();
        }

        int LayIdMonNuocMoiNhat()
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var m = ql.NUOCUONGs.OrderByDescending(x => x.IDMonNuoc).FirstOrDefault();
            return int.Parse(m.IDMonNuoc.Split('U')[1]);
        }
    }
}
