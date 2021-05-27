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
            return ql.DANHMUCs.Where(x => x.TrangThai == false).Count();
        }

        public DataTable LayDanhMucMon()
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var dmm = ql.DANHMUCs.Where(x => x.TrangThai == false).Select(x => x);

            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("IDDanhMuc"),
                new DataColumn("TenDanhMuc")
            });

            foreach (var i in dmm)
            {
                dt.Rows.Add(i.IDDanhMuc, i.TenDanhMuc);
            }

            return dt;
        }
        public List<DANHMUC> LayTenDanhMuc()
        {
            List<DANHMUC> lstTabDanhMuc = new List<DANHMUC>();
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var tdm = from dm in ql.DANHMUCs
                      where dm.TrangThai == false
                      select new { dm.TenDanhMuc };
            foreach (var item in tdm.ToList())
            {
                DANHMUC dm = new DANHMUC();
                dm.TenDanhMuc = item.TenDanhMuc;
                lstTabDanhMuc.Add(dm);
            }
            return lstTabDanhMuc;
        }
        public bool ThemDanhMuc(int IDDanhMuc, string TenDanhMuc)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            DANHMUC dm = new DANHMUC();
            dm.IDDanhMuc = IDDanhMuc;
            dm.TenDanhMuc = TenDanhMuc;
            ql.DANHMUCs.Add(dm);
            ql.SaveChanges();
            return true;
        }
        public bool CapNhatDanhMuc(int IDDanhMuc, string TenDanhMuc)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var dmQuery = (from item
                           in ql.DANHMUCs
                           where item.IDDanhMuc == IDDanhMuc
                           select item).SingleOrDefault();
            if (dmQuery == null)
            {
                return false;
            }
            dmQuery.TenDanhMuc = TenDanhMuc;
            ql.SaveChanges();
            return true;
        }
        public bool XoaDanhMuc(int IDDanhMuc)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var query = ql.DANHMUCs.Find(IDDanhMuc);
            if ( query != null)
            {
                ql.DANHMUCs.Remove(query);
                ql.SaveChanges();
            }
            return true;
        }
    }
}
