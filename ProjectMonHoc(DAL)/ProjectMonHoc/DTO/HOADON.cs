using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonHoc.DTO
{
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        public string IDHoaDon { get; set; }
        public int IDBan { get; set; }
        public string IDNhanVien { get; set; }
        public System.DateTime NgayLap { get; set; }
        public Nullable<System.DateTime> NgayThanhToan { get; set; }
        public int TongTien { get; set; }
        public string KhuyenMai { get; set; }

        public virtual BAN BAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
