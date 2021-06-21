using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMonHoc.EntityModel;

namespace ProjectMonHoc.BL_Layer
{
    class BLMonAn
    {
        private static BLMonAn instance;
        public static BLMonAn Instance
        {
            get { if (instance == null) instance = new BLMonAn(); return instance; }
            private set { instance = value; }
        }

        public List<MONAN> LayDanhMucMonAn(int tab)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            List<MONAN> lstNuoc = new List<MONAN>();
            var queryMA = from nu in ql.MONANs
                          where nu.IDDanhMuc == tab && nu.TrangThai == false
                          select nu;

            foreach (var item in queryMA.ToList())
            {
                MONAN nu = new MONAN();
                nu.IDMonAn = item.IDMonAn;
                nu.IDDanhMuc = item.IDDanhMuc;
                nu.GiaTien = item.GiaTien;
                nu.TenMon = item.TenMon;
                nu.HinhMA = item.HinhMA;
                lstNuoc.Add(nu);
            }

            return lstNuoc;
        }
        public int LayDonGia(string IDMonAn)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            int gia = (from nu in ql.MONANs
                       where nu.IDMonAn == IDMonAn
                       select nu.GiaTien).SingleOrDefault();
            return gia;
        }

        public string LayTenMonNuoc(string IDMonAn)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            string ten = (from nu in ql.MONANs
                          where nu.IDMonAn == IDMonAn
                          select nu.TenMon).SingleOrDefault();
            return ten;
        }

        public string LayIDMonNuoc(string TenMon)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            string id = (from nu in ql.MONANs
                         where nu.TenMon == TenMon
                         select nu.IDMonAn).SingleOrDefault();
            return id;
        }

        public void ThemMonAn(string tenMon, int danhMucMon, int giaMon, string pathHinh)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var m = ql.MONANs.OrderByDescending(x => x.IDMonAn).FirstOrDefault();
            int idMonNuoc = int.Parse(m.IDMonAn.Split('A')[1]);
            MONAN ma = new MONAN();
            ma.IDMonAn = idMonNuoc >= 100 ? "MA" + (idMonNuoc + 1) : "MA0" + (idMonNuoc + 1);
            ma.IDDanhMuc = danhMucMon;
            ma.TenMon = tenMon;
            ma.GiaTien = giaMon;
            ma.HinhMA = pathHinh;
            ql.MONANs.Add(ma);
            ql.SaveChanges();
        }

        //Hàm xóa món ăn dựa trên tên món sử dụng trong frmQuanLyMon
        public void XoaMonAn_TenMon(string tenMon)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var m = (from nu in ql.MONANs
                     where nu.TenMon == tenMon
                     select nu).SingleOrDefault();
            m.TrangThai = true;
            ql.SaveChanges();
        }
        public void CapNhatMon_TenMon(string tenMon, string tenMonMoi, int giaMon, string pathHinh)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var m = (from nu in ql.MONANs
                     where nu.TenMon == tenMon
                     select nu).SingleOrDefault();
            m.TenMon = tenMonMoi;
            m.GiaTien = giaMon;
            if (pathHinh != string.Empty)
            {
                m.HinhMA = pathHinh;
            }
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
