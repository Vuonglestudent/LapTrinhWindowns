﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMonHoc.EntityModel;
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
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            TAIKHOAN tk = null;
            tk = (from TK in qlCF.TAIKHOANs
                           where TK.TaiKhoan1 == taikhoan && TK.MatKhau == matkhau
                           select TK).SingleOrDefault();
            if (tk == null)
                return 0;
            if (tk != null) return 1;
            return 0;
        }
        public string LayIDNhanVien(string taikhoan)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            TAIKHOAN tk = (from TK in qlCF.TAIKHOANs
                         where TK.TaiKhoan1 == taikhoan
                         select TK).SingleOrDefault();
            if (tk != null)   
                return tk.IDNhanVien;
            return "";
        }
    }
}
