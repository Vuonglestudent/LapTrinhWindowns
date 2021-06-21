using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonHoc.DTO
{
    public partial class BAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAN()
        {
            this.HOADONs = new HashSet<HOADON>();
        }

        public int IDBan { get; set; }
        public string TenBan { get; set; }
        public bool TrangThai { get; set; }
        public int SucChua { get; set; }
        public bool TrangThaiXoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
