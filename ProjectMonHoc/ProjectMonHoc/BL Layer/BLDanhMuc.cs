using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMonHoc.EntityModel;
namespace ProjectMonHoc.BL_Layer
{
    class BLDanhMuc
    {
        private static BLDanhMuc instance;
        public static BLDanhMuc Instance
        {
            get { if (instance == null) instance = new BLDanhMuc(); return instance; }
            private set { instance = value; }
        }

        public int SoLuongDanhMuc()
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            return ql.DANHMUCs.Count();
        }
    }
}
