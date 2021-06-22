using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMonHoc.DTO;
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
            /* (EntityModels)
             * ql.DANHMUCs.Where(x => x.TrangThai == false).Count()
             */
            DBMain db = new DBMain();
            string query = "Select * From DANHMUC Where TrangThai = 0";
            int count = 0;
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);
            foreach(DataRow item in kq.Rows)
            {
                if(item != null)
                {
                    count++;
                }
            }
            return count;
        }
        
        //public DataTable LayDanhMucMon()
        //{
        //    QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
        //    var dmm = ql.DANHMUCs.Where(x => x.TrangThai == false).Select(x => x);

        //    DataTable dt = new DataTable();

        //    dt.Columns.AddRange(new DataColumn[]
        //    {
        //        new DataColumn("IDDanhMuc"),
        //        new DataColumn("TenDanhMuc")
        //    });

        //    foreach (var i in dmm)
        //    {
        //        dt.Rows.Add(i.IDDanhMuc, i.TenDanhMuc);
        //    }

        //    return dt;
        //}
        public List<DANHMUC> LayTenDanhMuc()
        {
            /* (EntityModels)
            var tdm = from dm in ql.DANHMUCs
                      where dm.TrangThai == false
                      select new { dm.IDDanhMuc, dm.TenDanhMuc };
            */

            List<DANHMUC> lstTabDanhMuc = new List<DANHMUC>();
            DBMain db = new DBMain();
            string query = "Select IDDanhMuc, TenDanhMuc From DANHMUC Where TrangThai = 0";
            var tdm = db.ExecuteQueryDataSet(query, CommandType.Text);

            foreach (DataRow item in tdm.Rows)
            {
                DANHMUC dm = new DANHMUC();
                dm.IDDanhMuc = (int)item["IDDanhMuc"];
                dm.TenDanhMuc = item["TenDanhMuc"].ToString();
                lstTabDanhMuc.Add(dm);
            }
            return lstTabDanhMuc;
        }
        public bool ThemDanhMuc(int id, string tendm, ref string err)
        {
            DBMain db = new DBMain();
            string query = "insert into DANHMUC values (N'" + tendm + "', '0')";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        public bool CapNhatDanhMuc(int id, string tendm, ref string err)
        {
            DBMain db = new DBMain();
            string query = "update DANHMUC set TenDanhMuc = N'" + tendm + "' where IDDanhMuc = '" + id + "'";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        public bool XoaDanhMuc(int id, ref string err)
        {
            DBMain db = new DBMain();
            string query = "delete from DANHMUC where IDDanhMuc = '" + id + "'";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        //public bool ThemDanhMuc(int IDDanhMuc, string TenDanhMuc)
        //{
        //    QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
        //    var dmQuery = (from item
        //                   in ql.DANHMUCs
        //                   where item.IDDanhMuc == IDDanhMuc
        //                   select item).SingleOrDefault();
        //    if (dmQuery == null)
        //    {
        //        DANHMUC dmuc = new DANHMUC();
        //        dmuc.TenDanhMuc = TenDanhMuc;
        //        ql.DANHMUCs.Add(dmuc);
        //        ql.SaveChanges();
        //    }
        //    else if (dmQuery != null)
        //    {
        //        DANHMUC dm = new DANHMUC();
        //        dm.TenDanhMuc = TenDanhMuc;
        //        ql.SaveChanges();
        //    }

        //    return true;
        //}
        //public bool CapNhatDanhMuc(int IDDanhMuc, string TenDanhMuc)
        //{
        //    QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
        //    var dmQuery = (from item
        //                   in ql.DANHMUCs
        //                   where item.IDDanhMuc == IDDanhMuc
        //                   select item).SingleOrDefault();
        //    if (dmQuery == null)
        //    {
        //        return false;
        //    }
        //    dmQuery.TenDanhMuc = TenDanhMuc;
        //    ql.SaveChanges();
        //    return true;
        //}
        //public bool XoaDanhMuc(int IDDanhMuc)
        //{
        //    QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
        //    var dmQuery = (from item
        //                   in ql.DANHMUCs
        //                   where item.IDDanhMuc == IDDanhMuc
        //                   select item).SingleOrDefault();
        //    if ( dmQuery != null)
        //    {
        //        ql.DANHMUCs.Attach(dmQuery);
        //        ql.DANHMUCs.Remove(dmQuery);
        //        ql.SaveChanges();
        //    }
        //    return true;
        //}
    }
}
