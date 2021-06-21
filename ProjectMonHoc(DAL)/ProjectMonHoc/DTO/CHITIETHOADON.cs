using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonHoc.DTO
{
    public partial class CHITIETHOADON
    {
        public string IDHoaDon { get; set; }
        public string IDMonAn { get; set; }
        public int SoLuong { get; set; }

        public virtual HOADON HOADON { get; set; }
        public virtual MONAN MONAN { get; set; }
    }
}
