using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonHoc.DTO
{
    public partial class MONAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONAN()
        {
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
        }

        public string IDMonAn { get; set; }
        public int IDDanhMuc { get; set; }
        public string TenMon { get; set; }
        public int GiaTien { get; set; }
        public string HinhMA { get; set; }
        public bool TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DANHMUC DANHMUC { get; set; }
    }
}
