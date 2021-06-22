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
    class BLMonAn
    {
        private static BLMonAn instance;
        public static BLMonAn Instance
        {
            get { if (instance == null) instance = new BLMonAn(); return instance; }
            private set { instance = value; }
        }

        public List<MONAN> LayDanhMucMonAn(int tab)
        {
            /* (EntityModels)
             * var queryMA = from nu in ql.MONANs
                          where nu.IDDanhMuc == tab && nu.TrangThai == false
                          select nu;
             */
            DBMain db = new DBMain();
            List<MONAN> lstNuoc = new List<MONAN>();
            string query = "Select * From MONAN Where IDDanhMuc = '"
                + tab + "' And TrangThai = 0";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);
            foreach (DataRow item in kq.Rows)
            {
                MONAN nu = new MONAN();
                nu.IDMonAn = item["IDMonAn"].ToString();
                nu.IDDanhMuc = (int)item["IDDanhMuc"];
                nu.GiaTien = (int)item["GiaTien"];
                nu.TenMon = item["TenMon"].ToString();
                nu.HinhMA = item["HinhMA"].ToString();
                lstNuoc.Add(nu);
            }

            return lstNuoc;
        }
        public int LayDonGia(string IDMonAn)
        {
            /*
             * int gia = (from nu in ql.MONANs
                       where nu.IDMonAn == IDMonAn
                       select nu.GiaTien).SingleOrDefault();
             */
            DBMain db = new DBMain();
            string query = "Select GiaTien " +
                "From MONAN " +
                "Where IDMonAn = '" + IDMonAn + "'";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);

            return (int)kq.Rows[0]["GiaTien"];
        }

        public string LayTenMonNuoc(string IDMonAn)
        {
            /*
             * string ten = (from nu in ql.MONANs
                          where nu.IDMonAn == IDMonAn
                          select nu.TenMon).SingleOrDefault();
             */

            DBMain db = new DBMain(); 
            string query = "Select TenMon " +
                "From MONAN " +
                "Where IDMonAn = '" + IDMonAn + "'";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);
            return kq.Rows[0]["TenMon"].ToString();
        }

        public string LayIDMonNuoc(string TenMon)
        {
            /*
             * string id = (from nu in ql.MONANs
                         where nu.TenMon == TenMon
                         select nu.IDMonAn).SingleOrDefault();
             */
            DBMain db = new DBMain();
            string query = "Select IDMonAn " +
                "From MONAN " +
                "Where TenMon = N'" + TenMon + "'";
            var kq = db.ExecuteQueryDataSet(query, CommandType.Text);
            return kq.Rows[0]["IDMonAn"].ToString();
        }

        public void ThemMonAn(string tenMon, int danhMucMon, int giaMon, string pathHinh)
        {
            //Entity
            //    QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            //    var m = ql.MONANs.OrderByDescending(x => x.IDMonAn).FirstOrDefault();
            //    int idMonNuoc = int.Parse(m.IDMonAn.Split('A')[1]);
            //    MONAN ma = new MONAN();
            //    ma.IDMonAn = idMonNuoc >= 100 ? "MA" + (idMonNuoc + 1) : "MA0" + (idMonNuoc + 1);
            //    ma.IDDanhMuc = danhMucMon;
            //    ma.TenMon = tenMon;
            //    ma.GiaTien = giaMon;
            //    ma.HinhMA = pathHinh;
            //    ql.MONANs.Add(ma);
            //    ql.SaveChanges();

            DBMain db = new DBMain();
            string ID, f = "";
            int idMoiNhat = this.LayIdMonNuocMoiNhat() + 1;
            ID = idMoiNhat >= 100 ? "MA" + idMoiNhat : "MA0" + idMoiNhat;
            System.Windows.Forms.MessageBox.Show(ID);
            string query = "Insert into MONAN (IDMonAn, IDDanhMuc, TenMon, GiaTien, HinhMA, TrangThai)" +
                " Values ('" + ID + "', " + danhMucMon.ToString() + ", N'" + tenMon + "', " + giaMon.ToString() + ", '" + pathHinh + "',0);";
            db.MyExecuteNonQuery(query, CommandType.Text, ref f);
        }

        ////Hàm xóa món ăn dựa trên tên món sử dụng trong frmQuanLyMon
        public void XoaMonAn_TenMon(string tenmon)
        {
            //Entity
            //    QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            //    var m = (from nu in ql.MONANs
            //             where nu.TenMon == tenMon
            //             select nu).SingleOrDefault();
            //    m.TrangThai = true;
            //    ql.SaveChanges();

            DBMain db = new DBMain();
            string query = "Update MONAN Set TrangThai = 1 Where TenMon = N'" + tenmon + "';";
            string f = "";
            db.MyExecuteNonQuery(query, CommandType.Text, ref f);
        }
        public void CapNhatMon_TenMon(string tenMon, string tenMonMoi, int giaMon, string pathHinh)
        {
            //Entity
            //    QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            //    var m = (from nu in ql.MONANs
            //             where nu.TenMon == tenMon
            //             select nu).SingleOrDefault();
            //    m.TenMon = tenMonMoi;
            //    m.GiaTien = giaMon;
            //    if (pathHinh != string.Empty)
            //    {
            //        m.HinhMA = pathHinh;
            //    }
            //    ql.SaveChanges();

            DBMain db = new DBMain();
            string query;
            if (pathHinh != string.Empty) 
                query = "Update MONAN Set TenMon = N'" + tenMonMoi + "', GiaTien =  " + giaMon.ToString()
                            + ", HinhMA = '" + pathHinh + "' Where TenMon = N'" + tenMon + "'";
            else
                query = "Update MONAN Set TenMon = N'" + tenMonMoi + "', GiaTien =  " + giaMon.ToString()
                         + " Where TenMon = N'" + tenMon + "'";
            string f = "";
            db.MyExecuteNonQuery(query, CommandType.Text,ref f);  
        }

        int LayIdMonNuocMoiNhat()
        {   //Entity
            //QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            //var m = ql.MONANs.OrderByDescending(x => x.IDMonAn).FirstOrDefault();
            //return int.Parse(m.IDMonAn.Split('U')[1]);

            DBMain db = new DBMain();
            string query = "Select top(1) IDMonAn From MONAN Order By IDMonAn Desc";
            string kq = db.ExecuteQueryDataSet(query, CommandType.Text).Rows[0].Field<String>("IDMonAn");
            return int.Parse(kq.Split('A')[1]);
        }
    }
}
