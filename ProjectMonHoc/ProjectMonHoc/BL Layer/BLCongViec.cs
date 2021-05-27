using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMonHoc.EntityModel;
namespace ProjectMonHoc.BL_Layer
{
    class BLCongViec
    {
        private static BLCongViec instance;
        public static BLCongViec Instance
        {
            get { if (instance == null) instance = new BLCongViec(); return instance; }
            private set { instance = value; }
        }

        public DataTable LayCongViecCB()
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var queryCV = ql.CONGVIECs.Select(x => x);

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID"),
                new DataColumn("TenCongViec")
            });

            foreach(var i in queryCV)
            {
                dt.Rows.Add(i.IDCongViec, i.TenCongViec);
            }
            return dt;
        }
    }
}
