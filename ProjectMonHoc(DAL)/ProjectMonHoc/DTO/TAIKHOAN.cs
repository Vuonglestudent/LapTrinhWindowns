using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonHoc.DTO
{
    public partial class TAIKHOAN
    {
        public string IDNhanVien { get; set; }
        public string TaiKhoan1 { get; set; }
        public string MatKhau { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
