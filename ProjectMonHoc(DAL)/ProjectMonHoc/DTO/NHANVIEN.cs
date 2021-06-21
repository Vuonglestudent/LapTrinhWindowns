using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonHoc.DTO
{
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.HOADONs = new HashSet<HOADON>();
        }

        public string IDNhanVien { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string HinhNV { get; set; }
        public int IDCongViec { get; set; }
        public bool TrangThai { get; set; }

        public virtual CONGVIEC CONGVIEC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
        public virtual TAIKHOAN TAIKHOAN { get; set; }
    }
}
