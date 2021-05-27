using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectMonHoc.EntityModel;
using System.Drawing;

namespace ProjectMonHoc.BL_Layer
{
    class BLNhanVien
    {
        private static BLNhanVien instance;
        public static BLNhanVien Instance
        {
            get { if (instance == null) instance = new BLNhanVien(); return instance; }
            private set { instance = value; }
        }
        public int SoLuongNhanVien()
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            return ql.NHANVIENs.Count();
        }
        public List<NHANVIEN> LayNhanVien()
        {
            QuanLyNhaHangProjectEntities qlbhEntity = new QuanLyNhaHangProjectEntities();
            var nvs = qlbhEntity.NHANVIENs.Where(x => x.TrangThai == false).Select(x => x);
            List<NHANVIEN> lstNV = new List<NHANVIEN>();
            
            foreach (var p in nvs)
            {
                NHANVIEN nv = new NHANVIEN();
                nv.IDNhanVien = p.IDNhanVien;
                nv.Ho = p.Ho;
                nv.Ten = p.Ten;
                //nv.IDCongViec = p.IDCongViec;
                nv.NgaySinh = p.NgaySinh;
                nv.Email = p.Email;
                nv.DiaChi = p.DiaChi;
                nv.SDT = p.SDT;
                nv.HinhNV = p.HinhNV;
                lstNV.Add(nv);
            }
            return lstNV;
        }
        public bool ThemNhanVien(string IDNhanVien, int IDCongViec, string Ho, string Ten, string Email, DateTime NgaySinh, string DiaChi, string DienThoai, string HinhNV)
        {
            QuanLyNhaHangProjectEntities qlbhEntity = new QuanLyNhaHangProjectEntities();

            NHANVIEN nv = new NHANVIEN();
            nv.IDNhanVien = IDNhanVien;
            nv.IDCongViec = IDCongViec;
            nv.Ho = Ho;
            nv.Ten = Ten;
            nv.Email = Email;
            nv.NgaySinh = NgaySinh;
            nv.DiaChi = DiaChi;
            nv.SDT = DienThoai;
            nv.HinhNV = HinhNV;
            qlbhEntity.NHANVIENs.Add(nv);
            qlbhEntity.SaveChanges();
            return true;
        }
        public bool XoaNhanVien( string IDNhanVien)
        {
            QuanLyNhaHangProjectEntities qlbhEntity = new QuanLyNhaHangProjectEntities();
            NHANVIEN nv = new NHANVIEN();
            nv.IDNhanVien = IDNhanVien;
            qlbhEntity.NHANVIENs.Attach(nv);
            qlbhEntity.NHANVIENs.Remove(nv);
            qlbhEntity.SaveChanges();
            return true;
        }
        public bool CapNhatNhanVien(string IDNhanVien, int IDCongViec, string Ho, string Ten, string Email, DateTime NgaySinh, string DiaChi, string DienThoai, string HinhNV)
        {
            QuanLyNhaHangProjectEntities qlbhEntity = new QuanLyNhaHangProjectEntities();
            var nvq = (from nv in qlbhEntity.NHANVIENs
                           where nv.IDNhanVien == IDNhanVien
                           select nv).SingleOrDefault();
            if (nvq == null)
            {
                return false;
            }
            nvq.IDNhanVien = IDNhanVien;
            nvq.IDCongViec = IDCongViec;
            nvq.Ho = Ho;
            nvq.Ten = Ten;
            nvq.Email = Email;
            nvq.NgaySinh = NgaySinh;
            nvq.DiaChi = DiaChi;
            nvq.SDT = DienThoai;
            nvq.HinhNV = HinhNV;
            qlbhEntity.SaveChanges();
            return true;
        }
    }
}
