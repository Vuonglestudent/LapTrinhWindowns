using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMonHoc.EntityModel;

namespace ProjectMonHoc.BL_Layer
{
    class BLHoaDon
    {
        private static BLHoaDon instance;
        public static BLHoaDon Instance
        {
            get { if (instance == null) instance = new BLHoaDon(); return instance; }
            private set { instance = value; }
        }

        public void ThemHoaDon (string IDHoaDon,string IDNhanVien, int IDBan, DateTime NgayLap, int tongTien, string khuyenMai)
        {
            QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            HOADON hoadon = new HOADON();
            hoadon.IDNhanVien = IDNhanVien;
            hoadon.NgayLap = NgayLap;
            hoadon.TongTien = tongTien;
            hoadon.KhuyenMai = khuyenMai;
            hoadon.IDBan = IDBan;
            hoadon.IDHoaDon = IDHoaDon;
            qlCF.HOADONs.Add(hoadon);
            try
            {
                qlCF.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại!");
            }
}

        public bool ThanhToanHoaDon(string idHoaDon)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            var hd = ql.HOADONs.Find(idHoaDon);

            if (hd != null)
            {
                hd.NgayThanhToan = DateTime.Now;
                ql.SaveChanges();
            }
            return true;

        }

        public HOADON LayHoaDonID(string ID) //Không sử dụng
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            
            var hoadon = (ql.HOADONs.Where(x=> x.IDHoaDon == ID).Select(x => x)).SingleOrDefault();
            return hoadon;
        }    

        //Hàm lấy bảng các hóa đơn từ ngày batdau đến ngày ketthuc, kích hoạt khi thay đổi value dateTimePicker
        public DataTable LayHoaDon(DateTime batdau, DateTime ketthuc)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("IDHoaDon"),
                new DataColumn("NhanVien"),
                new DataColumn("NgayLap"),
                new DataColumn("NgayThanhToan"),
                new DataColumn("TongTien")
            });
            DateTime kt = ketthuc.AddDays(1);
            var hoadon = ql.HOADONs.OrderBy(x=>x.NgayLap).Where(x=>(x.NgayLap < kt.Date && x.NgayLap >= batdau.Date)).Select(x=>x);
            foreach (HOADON hd in hoadon)
            {
                string ngaylap = hd.NgayLap.ToString("HH:mm   dd/MM/yyyy");
                string ngaythanhtoan;
                if (hd.NgayThanhToan != null)
                {
                    ngaythanhtoan = hd.NgayThanhToan.GetValueOrDefault().ToString("HH:mm   dd/MM/yyyy");
                }
                else ngaythanhtoan = "";
                dt.Rows.Add(hd.IDHoaDon, hd.IDNhanVien, ngaylap, ngaythanhtoan, hd.TongTien);
            }
            return dt;
        }

        //Hàm lấy thời gian lập của bill sớm nhất
        public DateTime TimeOfFirstBill()
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            DateTime result = ql.HOADONs.OrderBy(x => x.NgayLap).Select(x=>x.NgayLap).FirstOrDefault();
            if (result != default)
            {
                return result.Date;
            }
            return DateTime.Now.Date;
        }
        
        //Hàm lấy thời gian lập của bill gần nhất
        public DateTime TimeOfLastBill()
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            DateTime result = ql.HOADONs.OrderByDescending(x => x.NgayLap).Select(x=>x.NgayLap).FirstOrDefault();
            if (result != default)
            {
                return result.AddDays(1).Date;
            }
            return DateTime.Now.Date;
        }

        //2 hàm trên hỗ trợ việc đưa thời gian vào 2 datetimepicker khi mới mở form
   
        
        public bool CheckExist()
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            if (ql.HOADONs.Count() > 0)
                return true;
            return false;
        }

        public DateTime layNgayLap(string ID)
        {
            QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            DateTime result = ql.HOADONs.Where(x => x.IDHoaDon == ID).Select(x => x.NgayLap).FirstOrDefault();
            if (result != default)
            {
                return result;
            }
            return DateTime.Now;
        }

    }
}
