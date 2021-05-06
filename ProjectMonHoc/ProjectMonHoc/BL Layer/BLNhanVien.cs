using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonHoc.BL_Layer
{
    class BLNhanVien
    {
        private BLNhanVien instance;
        public BLNhanVien Instance
        {
            get { if (instance == null) instance = new BLNhanVien(); return instance; }
            private set { instance = value; }
        }
        
    }
}
