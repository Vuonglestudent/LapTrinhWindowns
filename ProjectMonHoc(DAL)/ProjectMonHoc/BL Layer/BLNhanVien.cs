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
                nv.IDCongViec = p.IDCongViec;
                nv.NgaySinh = p.NgaySinh;
                nv.Email = p.Email;
                nv.DiaChi = p.DiaChi;
                nv.SDT = p.SDT;
                nv.HinhNV = p.HinhNV;
                lstNV.Add(nv);
            }
            return lstNV;
        }
        public NHANVIEN LayNhanVienByUserName(string username)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var query = ql.TAIKHOANs.Where(x => x.TaiKhoan1 == username)
                .Join(ql.NHANVIENs, x => x.IDNhanVien, y => y.IDNhanVien, (x, y) => y)
                .SingleOrDefault();
            NHANVIEN nv = new NHANVIEN();
            if (query != null)
            {
                nv.IDNhanVien = query.IDNhanVien;
                nv.Ho = query.Ho;
                nv.Ten = query.Ten;
                nv.DiaChi = query.DiaChi;
                nv.NgaySinh = query.NgaySinh;
                nv.Email = query.Email;
                nv.SDT = query.SDT;
                nv.IDCongViec = query.IDCongViec;
                nv.HinhNV = query.HinhNV;
            }
            return nv;
        }
        public bool ThemNhanVien(string IDNhanVien, string Ho, int IDCongViec, string Ten, string Email, DateTime NgaySinh, string DiaChi, string DienThoai, string HinhNV)
        {
            QuanLyNhaHangProjectEntities qlbhEntity = new QuanLyNhaHangProjectEntities();
            var m = qlbhEntity.NHANVIENs.OrderByDescending(x => x.IDNhanVien).FirstOrDefault();
            int idNhanVien = int.Parse(m.IDNhanVien.Split('V')[1]);
            NHANVIEN nv = new NHANVIEN();
            nv.IDNhanVien = idNhanVien >= 100 ? "NV" + (idNhanVien + 1) : "NV0" + (idNhanVien + 1);
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
        public bool CapNhatNhanVien(string IDNhanVien, string Ho, int IDCongViec, string Ten, string Email, DateTime NgaySinh, string DiaChi, string DienThoai, string HinhNV)
        {
            QuanLyNhaHangProjectEntities qlbhEntity = new QuanLyNhaHangProjectEntities();
            var nvq = (from nv in qlbhEntity.NHANVIENs
                           where nv.IDNhanVien == IDNhanVien
                           select nv).SingleOrDefault();
            if (nvq == null)
            {
                return false;
            }
            nvq.IDCongViec = IDCongViec;
            nvq.Ho = Ho;
            nvq.Ten = Ten;
            nvq.Email = Email;
            nvq.NgaySinh = NgaySinh;
            nvq.DiaChi = DiaChi;
            nvq.SDT = DienThoai;
            if (HinhNV != string.Empty)
            {
                nvq.HinhNV = HinhNV;
            }
            qlbhEntity.SaveChanges();
            return true;
        }
    }
}
