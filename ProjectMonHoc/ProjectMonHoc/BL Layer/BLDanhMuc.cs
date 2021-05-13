using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable LayDanhMucMon()
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var dmm = ql.DANHMUCs.Select(x => x);

            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("IDDanhMuc"),
                new DataColumn("TenDanhMuc")
            });

            foreach(var i in dmm)
            {
                dt.Rows.Add(i.IDDanhMuc, i.TenDanhMuc);
            }

            return dt;
        }
    }
}
