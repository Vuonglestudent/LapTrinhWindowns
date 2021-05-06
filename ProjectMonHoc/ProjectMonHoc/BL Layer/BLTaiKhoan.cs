using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonHoc.BL_Layer
{
    class BLTaiKhoan
    {
        private static BLTaiKhoan instance;
        public static BLTaiKhoan Instance
        {
            get { if (instance == null) instance = new BLTaiKhoan(); return instance; }
            private set { instance = value; }
        }

        public byte checkLogin (string taikhoan, string matkhau)
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            TAIKHOAN tk = null;
            tk = (from TK in qlCF.TAIKHOANs
                           where TK.TaiKhoan1 == taikhoan && TK.MatKhau == matkhau
                           select TK).SingleOrDefault();
            if (tk == null)
                return 0;
            if (tk.LoaiTaiKhoan == 1) return 1;
            return 2;
        }
        public string LayIDNhanVien(string taikhoan)
        {
            QuanLyCafeDataContext qlCF = new QuanLyCafeDataContext();
            TAIKHOAN tk = (from TK in qlCF.TAIKHOANs
                         where TK.TaiKhoan1 == taikhoan
                         select TK).SingleOrDefault();
            if (tk != null)   
                return tk.IDNhanVien;
            return "";
        }
    }
}
