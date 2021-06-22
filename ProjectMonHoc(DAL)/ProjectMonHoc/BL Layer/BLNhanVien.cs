using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProjectMonHoc.EntityModel;
using System.Drawing;
using ProjectMonHoc.DTO;

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
        //public int SoLuongNhanVien()
        //{
        //    //QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
        //    //return ql.NHANVIENs.Count();
        //}
        //public List<NHANVIEN> LayNhanVien()
        //{
        //    //QuanLyNhaHangProjectEntities qlbhEntity = new QuanLyNhaHangProjectEntities();
        //    //var nvs = qlbhEntity.NHANVIENs.Where(x => x.TrangThai == false).Select(x => x);
        //    List<NHANVIEN> lstNV = new List<NHANVIEN>();

        //    foreach (var p in nvs)
        //    {
        //        NHANVIEN nv = new NHANVIEN();
        //        nv.IDNhanVien = p.IDNhanVien;
        //        nv.Ho = p.Ho;
        //        nv.Ten = p.Ten;
        //        nv.IDCongViec = p.IDCongViec;
        //        nv.NgaySinh = p.NgaySinh;
        //        nv.Email = p.Email;
        //        nv.DiaChi = p.DiaChi;
        //        nv.SDT = p.SDT;
        //        nv.HinhNV = p.HinhNV;
        //        lstNV.Add(nv);
        //    }
        //    return lstNV;
        //}
        public List<NHANVIEN> LayNhanVien()
        {
            List<NHANVIEN> lstNhanVien = new List<NHANVIEN>();
            DBMain db = new DBMain();
            string query = "select * from NHANVIEN";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);
            foreach (DataRow item in kq.Rows)
            {
                NHANVIEN nv = new NHANVIEN();
                nv.IDNhanVien = item["IDNhanVien"].ToString();
                nv.Ho = item["Ho"].ToString();
                nv.Ten = item["Ten"].ToString();
                nv.NgaySinh = (DateTime)item["NgaySinh"];
                nv.SDT = item["SDT"].ToString();
                nv.DiaChi = item["DiaChi"].ToString();
                nv.Email = item["Email"].ToString();
                nv.HinhNV = item["HinhNV"].ToString();
                nv.IDCongViec = (int)item["IDCongViec"];
                lstNhanVien.Add(nv);
            }

            return lstNhanVien;
        }
        public bool ThemNhanVien(string IDNhanVien, string Ho, int IDCongViec, string Ten, string Email, DateTime NgaySinh, string DiaChi, string DienThoai, string HinhNV, ref string err)
        {
            DBMain db = new DBMain();
            string query = "insert into NHANVIEN values (N'" + IDNhanVien + "', N'" + Ho + "', N'" + Ten + "', '" + NgaySinh + "', '" +
                                                            DienThoai + "', N'" + DiaChi + "', N'" + Email + "', N'" + HinhNV + "', '" + IDCongViec + "', '0')";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        public bool CapNhatNhanVien(string IDNhanVien, string Ho, int IDCongViec, string Ten, string Email, DateTime NgaySinh, string DiaChi, string DienThoai, string HinhNV, ref string err)
        {
            DBMain db = new DBMain();
            string query = "update NHANVIEN set Ho = N'" + Ho + "', Ten = N'" + Ten + "', NgaySinh = '" + NgaySinh + "', SDT = '" +
                                                            DienThoai + "', DiaChi = N'" + DiaChi + "', Email = N'" + Email + "', HinhNV = N'" + HinhNV + "', IDCongViec = '" + IDCongViec + "', TrangThai = '0' " +
                                                            "where IDNhanVien = '" + IDNhanVien + "'";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        public bool XoaNhanVien(string IDNhanVien, ref string err)
        {
            DBMain db = new DBMain();
            string query = "Delete from NHANVIEN where IDNhanVien = '" + IDNhanVien + "'";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        public NHANVIEN LayNhanVienByUserName(string username)
        {
            /*
             * var query = ql.TAIKHOANs.Where(x => x.TaiKhoan1 == username)
                .Join(ql.NHANVIENs, x => x.IDNhanVien, y => y.IDNhanVien, (x, y) => y)
                .SingleOrDefault();
             */
            DBMain db = new DBMain();
            string query = "Select NHANVIEN.IDNhanVien, Ho, Ten, DiaChi, NgaySinh, Email, SDT, IDCongViec, HinhNV " +
                "From NHANVIEN join TAIKHOAN on NHANVIEN.IDNhanVien = TAIKHOAN.IDNhanVien " +
                "Where TAIKHOAN.TaiKhoan = '" + username + "'";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);
            NHANVIEN nv = new NHANVIEN();
            if (kq != null)
            {
                nv.IDNhanVien = kq.Rows[0]["IDNhanVien"].ToString();
                nv.Ho = kq.Rows[0]["Ho"].ToString();
                nv.Ten = kq.Rows[0]["Ten"].ToString();
                nv.DiaChi = kq.Rows[0]["DiaChi"].ToString();
                nv.NgaySinh = (DateTime)kq.Rows[0]["NgaySinh"];
                nv.Email = kq.Rows[0]["Email"].ToString();
                nv.SDT = kq.Rows[0]["SDT"].ToString();
                nv.IDCongViec = (int)kq.Rows[0]["IDCongViec"];
                nv.HinhNV = kq.Rows[0]["HinhNV"].ToString();
            }
            return nv;
        }
        //public bool ThemNhanVien(string IDNhanVien, string Ho, int IDCongViec, string Ten, string Email, DateTime NgaySinh, string DiaChi, string DienThoai, string HinhNV)
        //{
        //    QuanLyNhaHangProjectEntities qlbhEntity = new QuanLyNhaHangProjectEntities();
        //    var m = qlbhEntity.NHANVIENs.OrderByDescending(x => x.IDNhanVien).FirstOrDefault();
        //    int idNhanVien = int.Parse(m.IDNhanVien.Split('V')[1]);
        //    NHANVIEN nv = new NHANVIEN();
        //    nv.IDNhanVien = idNhanVien >= 100 ? "NV" + (idNhanVien + 1) : "NV0" + (idNhanVien + 1);
        //    nv.IDCongViec = IDCongViec;
        //    nv.Ho = Ho;
        //    nv.Ten = Ten;
        //    nv.Email = Email;
        //    nv.NgaySinh = NgaySinh;
        //    nv.DiaChi = DiaChi;
        //    nv.SDT = DienThoai;
        //    nv.HinhNV = HinhNV;
        //    qlbhEntity.NHANVIENs.Add(nv);
        //    qlbhEntity.SaveChanges();
        //    return true;
        //}
        //public bool XoaNhanVien( string IDNhanVien)
        //{
        //    QuanLyNhaHangProjectEntities qlbhEntity = new QuanLyNhaHangProjectEntities();
        //    NHANVIEN nv = new NHANVIEN();
        //    nv.IDNhanVien = IDNhanVien;
        //    qlbhEntity.NHANVIENs.Attach(nv);
        //    qlbhEntity.NHANVIENs.Remove(nv);
        //    qlbhEntity.SaveChanges();
        //    return true;
        //}
        //public bool CapNhatNhanVien(string IDNhanVien, string Ho, int IDCongViec, string Ten, string Email, DateTime NgaySinh, string DiaChi, string DienThoai, string HinhNV)
        //{
        //    QuanLyNhaHangProjectEntities qlbhEntity = new QuanLyNhaHangProjectEntities();
        //    var nvq = (from nv in qlbhEntity.NHANVIENs
        //                   where nv.IDNhanVien == IDNhanVien
        //                   select nv).SingleOrDefault();
        //    if (nvq == null)
        //    {
        //        return false;
        //    }
        //    nvq.IDCongViec = IDCongViec;
        //    nvq.Ho = Ho;
        //    nvq.Ten = Ten;
        //    nvq.Email = Email;
        //    nvq.NgaySinh = NgaySinh;
        //    nvq.DiaChi = DiaChi;
        //    nvq.SDT = DienThoai;
        //    if (HinhNV != string.Empty)
        //    {
        //        nvq.HinhNV = HinhNV;
        //    }
        //    qlbhEntity.SaveChanges();
        //    return true;
        //}
    }
}
