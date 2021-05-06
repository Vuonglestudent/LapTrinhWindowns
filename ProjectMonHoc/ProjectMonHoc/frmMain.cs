using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMonHoc.BL_Layer;
using ProjectMonHoc.Properties;

namespace ProjectMonHoc
{
    public partial class frmMain : Form
    {
        public bool iSSelect;
        ResourceManager rm = Resources.ResourceManager;

        List<NUOCUONG> lstCafe = new List<NUOCUONG>();
        List<NUOCUONG> lstTra = new List<NUOCUONG>();
        List<NUOCUONG> lstTraSua = new List<NUOCUONG>();
        List<BAN> lstBan = new List<BAN>();

        Button BanDangChon = null;
        List<CHITIETHOADON> billTam = new List<CHITIETHOADON>();
        //HOADON hoaDonTam = new HOADON();

        public string loginStatus = null;
        string user;

        DataTable bill = new DataTable();

        bool xemBillBan = false;

        public frmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load dữ liệu từ Table BAN
        /// </summary>
        
        void khoiTaoBillTam()
        {
            bill.Columns.AddRange(new DataColumn[]
            {
            new DataColumn("TenMon"),
            new DataColumn("GiaTien"),
            new DataColumn("SoLuong"),
            new DataColumn("ThanhTien"),
            });
        }

        void LoadDataBan()
        {
            try
            {
                this.lstBan = BLBan.Instance.LayBan();
                Point pointBan = new Point(18, 35);
                Size sizeBan = new Size(132, 125);
                int count = 1;
                foreach (BAN item in lstBan)
                {
                    AddButtonAndLabelBan(item, pointBan, sizeBan);
                    if (count%2 != 0)
                    {
                        pointBan.X = pointBan.X + 147;
                    } else
                    {
                        pointBan.X = pointBan.X - 147;
                        pointBan.Y = pointBan.Y + 147;
                    }
                    count++;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi load bàn");
            }
        }
        void LoadMonNuoc()
        {
            try
            {
                LoadDanhMucCafe();
                LoadDanhMucTra();
                LoadDanhMucTraSua();
            } catch
            {
                MessageBox.Show("Lỗi load món nước");
            }
        }

        void LoadDanhMucCafe()
        {
            try
            {
                lstCafe = BLNuocUong.Instance.LayDanhMucNuocUong(1);// Hàm LayDanhMucNuocUong() có tham số là index
                Size size = new Size(157, 138);                     // của tab cần lấy danh mục bắt đầu từ 1                            
                Point point = new Point(29, 28);
                int count = 1;
                foreach(NUOCUONG item in lstCafe)
                {
                    AddButtonNuoc(item, point, size, this.tabCaPhe);
                    if(count % 4 != 0)
                    {
                        point.X = point.X + 177;
                    } else
                    {
                        point.X = 26;
                        point.Y = point.Y + 177;
                    }
                    count++;
                }
            } catch
            {
                MessageBox.Show("Lỗi load danh mục cafe");
            }
        }
        void LoadDanhMucTra()
        {
            try
            {
                lstTra = BLNuocUong.Instance.LayDanhMucNuocUong(2);// Hàm LayDanhMucNuocUong() có tham số là index
                Size size = new Size(157, 138);                    // của tab cần lấy danh mục bắt đầu từ 1(caphe)
                Point point = new Point(29, 28);
                int count = 1;
                foreach(NUOCUONG item in lstTra)
                {
                    AddButtonNuoc(item, point, size, this.tabTra);
                    if(count % 4 != 0)
                    {
                        point.X = point.X + 177;
                    } else
                    {
                        point.X = 26;
                        point.Y = point.Y + 177;
                    }
                    count++;
                }
            } catch
            {
                MessageBox.Show("Lỗi load danh mục Trà");
            }
        }
        void LoadDanhMucTraSua()
        {
            try
            {
                lstTra = BLNuocUong.Instance.LayDanhMucNuocUong(3);// Hàm LayDanhMucNuocUong() có tham số là index
                Size size = new Size(157, 138);                    // của tab cần lấy danh mục bắt đầu từ 1(caphe)
                Point point = new Point(29, 28);
                int count = 1;
                foreach(NUOCUONG item in lstTra)
                {
                    AddButtonNuoc(item, point, size, this.tabTraSua);
                    if(count % 4 != 0)
                    {
                        point.X = point.X + 177;
                    } else
                    {
                        point.X = 26;
                        point.Y = point.Y + 177;
                    }
                    count++;
                }
            } catch
            {
                MessageBox.Show("Lỗi load danh mục Trà Sữa");
            }
        }

        

        void AddButtonNuoc(NUOCUONG item, Point local, Size size, TabPage tab)
        {
            Button newButton = new Button();
            Label newLabel = new Label();
            tab.Controls.Add(newButton);
            tab.Controls.Add(newLabel);

            newButton.Name = "btn" + item.IDMonNuoc;
            newButton.BackgroundImage = (Bitmap)rm.GetObject(item.IDMonNuoc);
            newButton.BackgroundImageLayout = ImageLayout.Stretch;
            newButton.Location = local;
            newButton.Size = size;
            newButton.MouseDown += btnMonNuoc_Click;
            newButton.Tag = item.IDMonNuoc;

            newLabel.Text = item.TenMon;
            newLabel.Location = new Point(local.X, local.Y + 140);
            newLabel.Size = new Size(size.Width, 20);
            newLabel.TextAlign = ContentAlignment.MiddleCenter;
            newLabel.Name = "lb" + item.IDMonNuoc;
        }

        void AddButtonAndLabelBan(BAN item, Point local, Size size)
        {
            Button newButton = new Button();
            Label newLabel = new Label();
            this.tabBan.Controls.Add(newLabel);
            this.tabBan.Controls.Add(newButton);
            newButton.Location = local;
            newButton.Name = "btnBan" + item.IDBan;
            newButton.Size = size;
            newButton.Tag = item.IDBan;
            newButton.Text = item.TenBan;
            newButton.TextAlign = ContentAlignment.TopCenter;
            newButton.UseVisualStyleBackColor = false;
            newLabel.AutoSize = true;
            newLabel.Enabled = false;
            Point localLabel = new Point(local.X + 14, local.Y + 43);
            newLabel.Location = localLabel;
            newLabel.Name = "lbTrangThaiBan" + item.IDBan;
            newLabel.Size = new Size(56, 23);
            if (item.TrangThai == true)
            {
                newLabel.Text = "Đã có khách";
                newLabel.BackColor = color.colorCoKhach;
                newButton.BackColor = color.colorCoKhach;
            }
            if (item.TrangThai == false)
            {
                newLabel.Text = "Còn trống";
                newLabel.BackColor = color.colorTrong;
                newButton.BackColor = color.colorTrong;

            }

            //Tạm comment

            //newButton.Click += (s, e) =>
            //{
            //    Console.WriteLine(item.IDHoaDon);
            //    dgvBill.DataSource = BLBan.Instance.LayChiTietHoaDonBan(item.IDBan);
            //    this.dgvBill.Columns["IDMonNuoc"].Visible = false;
            //};

            //thay bằng :
            newButton.Click += btnBan_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataBan();
            LoadMonNuoc();
            khoiTaoBillTam();
            tabDoUong.Enabled = false;
            tabControlBan.Enabled = false;
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            int IDBan = int.Parse(((Button)sender).Tag.ToString()); //Lấy IDBan của Bàn được click;

            if (BLBan.Instance.TrangThai(IDBan)) //Hàm kiểm tra trạng thái
            {
                if (BanDangChon != null)
                {
                    int IDBanDangChon = int.Parse(BanDangChon.Tag.ToString()); //Lấy IDBan của Bàn được click;
                    BanDangChon.BackColor = color.colorTrong;                  //của IDBan được Click :))
                    ((Label)this.Controls.Find("lbTrangThaiBan" + IDBanDangChon, true)[0]).BackColor = color.colorTrong;
                    BanDangChon = null;
                }                                           
                this.ShowBill(IDBan);
                xemBillBan = true;
            }
            else
            {
                if (xemBillBan)
                {
                    dgvBill.Rows.Clear();
                    xemBillBan = false;
                }
                if (BanDangChon != null)
                {
                    int IDBanDangChon = int.Parse(BanDangChon.Tag.ToString()); //Lấy IDBan của Bàn được click;
                    BanDangChon.BackColor = color.colorTrong;
                    ((Label)this.Controls.Find("lbTrangThaiBan" + IDBanDangChon, true)[0]).BackColor = color.colorTrong;
                }
                BanDangChon = (Button)sender;
                BanDangChon.BackColor = color.colorDangChon;
                ((Label)this.Controls.Find("lbTrangThaiBan" + IDBan,true)[0]).BackColor = color.colorDangChon;
                dgvBill.DataSource = bill;
                this.tbxTongTien.Text = this.TinhTongBill().ToString();
                MessageBox.Show(this.TinhTongBill().ToString());
            }
        }

        private void btnMonNuoc_Click(object sender, MouseEventArgs e)
        {
            if (BanDangChon != null)
            {
                string IDNuocUong = ((Button)sender).Tag.ToString();
                switch (e.Button)
                {

                    case MouseButtons.Left:
                        // Left click
                        this.AddMon(IDNuocUong);
                        break;

                    default:
                        // Right click
                        this.SubtractMon(IDNuocUong);
                        break;
                }
            }
        }



        private void ShowBill(int IDBan)
        {
            dgvBill.DataSource = BLBan.Instance.LayChiTietHoaDonBan(IDBan);
            tbxTongTien.Text = TinhTongBill().ToString() ;
        }

        private void AddMon(string IDMonNuoc)
        {
            bool checkNull = true; //Ban đầu giả sử món nước chưa từng được add vào bill tạm thì check = true

            for (int i = 0; i < bill.Rows.Count; i++)           
                if (BLNuocUong.Instance.LayIDMonNuoc(bill.Rows[i].Field<string>("TenMon")) == IDMonNuoc)
                {
                    checkNull = false; //Đã có trong bill tạm
                    bill.Rows[i].SetField<string>("SoLuong", (int.Parse(bill.Rows[i].Field<string>("SoLuong")) + 1).ToString());
                    bill.Rows[i].SetField<string>("ThanhTien", (int.Parse(bill.Rows[i].Field<string>("SoLuong")) * int.Parse(bill.Rows[i].Field<string>("GiaTien"))).ToString());
                    break;
                }    
            if (checkNull)
            {
                bill.Rows.Add(BLNuocUong.Instance.LayTenMonNuoc(IDMonNuoc),
                    BLNuocUong.Instance.LayDonGia(IDMonNuoc),"1",BLNuocUong.Instance.LayDonGia(IDMonNuoc));
            }
            dgvBill.DataSource = bill;
            this.tbxTongTien.Text = this.TinhTongBill().ToString();
        }
        private void SubtractMon(string IDMonNuoc)
        {
            for (int i = 0; i < bill.Rows.Count; i++)
                if (BLNuocUong.Instance.LayIDMonNuoc(bill.Rows[i].Field<string>("TenMon")) == IDMonNuoc)
                {
                    bill.Rows[i].SetField<string>("SoLuong", (int.Parse(bill.Rows[i].Field<string>("SoLuong")) - 1).ToString());
                    bill.Rows[i].SetField<string>("ThanhTien", (int.Parse(bill.Rows[i].Field<string>("SoLuong")) * int.Parse(bill.Rows[i].Field<string>("GiaTien"))).ToString());
                    if (int.Parse(bill.Rows[i].Field<string>("SoLuong")) == 0)
                        bill.Rows.RemoveAt(i);
                    break;
                }
            dgvBill.DataSource = bill;
            this.tbxTongTien.Text = this.TinhTongBill().ToString();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
        }
        #region LOGIN
        private void menuItemDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();
        }

        public void login(byte type, string user) //hàm login theo type được gọi ở form Login nếu đăng nhập đúng
        {
            MessageBox.Show("Đăng nhập thành công!");
            this.menuItemDangXuat.Enabled = true;
            this.menuItemDoiMatKhau.Enabled = true;
            this.menuItemDanhMuc.Enabled = true;
            this.menuItemDangNhap.Enabled = false;
            this.user = user;
            if (type == 1)
            {
                menuItemAdmin.Enabled = true;
            }
            tabDoUong.Enabled = true;
            tabControlBan.Enabled = true;
        }

        private void menuItemDangXuat_Click(object sender, EventArgs e)
        {
            this.menuItemDangXuat.Enabled = false;
            this.menuItemDoiMatKhau.Enabled = false;
            this.menuItemDanhMuc.Enabled = false;
            this.menuItemDangNhap.Enabled = true;
            this.user = "";
            MessageBox.Show("Đã đăng xuất!");
            tabDoUong.Enabled = false;
            tabControlBan.Enabled = false;
        }
        #endregion

        #region BILL

        private void btnHuyBill_Click(object sender, EventArgs e)
        {
            if (!xemBillBan)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa bill hiện tại không?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bill.Rows.Clear();
                }
            }
        }

        int TinhTongBill()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dgvBill.Rows)
                sum = sum + int.Parse(row.Cells["columnThanhTien"].Value.ToString());
            MessageBox.Show(sum.ToString());
            return sum;
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string IDHoaDon = TaoIDHoaDon();
            BLHoaDon.Instance.ThemHoaDon(IDHoaDon,BLTaiKhoan.Instance.LayIDNhanVien(user), time, int.Parse(tbxTongTien.Text), cbbGiamGia.SelectedText);
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                string IDMonNuoc = BLNuocUong.Instance.LayIDMonNuoc(row.Cells["columnTen"].Value.ToString());
                int SoLuong = int.Parse(row.Cells["columnSoLuong"].Value.ToString());
                int GiaTien = int.Parse(row.Cells["columnThanhTien"].Value.ToString());
                BLChiTietHoaDon.Instance.ThemChiTietHoaDon(IDHoaDon, IDMonNuoc, SoLuong, GiaTien);
            }
            BanDangChon.BackColor = color.colorCoKhach;
            Label lbBanDangChon = (Label)this.Controls.Find("lbTrangThaiBan" + BanDangChon.Tag.ToString(), true)[0];
            lbBanDangChon.BackColor = color.colorCoKhach;
            lbBanDangChon.Text = "Đã có khách";
            BLBan.Instance.ThayDoiTrangThai(int.Parse(BanDangChon.Tag.ToString()));
            BLBan.Instance.ThemHoaDonBan(int.Parse(BanDangChon.Tag.ToString()),IDHoaDon);
            BanDangChon = null;
            bill.Rows.Clear();
        }

        private string TaoIDHoaDon()
        {
            string IDHoaDon = "";
            Random random = new Random();
            int length = 10;
            char letter;

            for (int i = 0; i < length; i++)
            {
                byte numberOrChar = byte.Parse(random.Next(1, 3).ToString());
                if (numberOrChar == 1)
                {
                    int num = random.Next(0, 10);
                    IDHoaDon += num.ToString();
                }
                else
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    IDHoaDon += letter;
                }
                
            }
            return IDHoaDon;
        }

        #endregion


    }
}
