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
using ProjectMonHoc.EntityModel;
using ProjectMonHoc.Screen;
using System.IO;
using System.Reflection;

namespace ProjectMonHoc
{
    public partial class frmMain : Form
    {
        public bool iSSelect;

        //ResourceManager rm = Resources.ResourceManager;
        //List<MONAN> lstCafe = new List<MONAN>();
        //List<MONAN> lstTra = new List<MONAN>();
        //List<MONAN> lstTraSua = new List<MONAN>();
        //List<MONAN> lstSinhTo = new List<MONAN>();
        //List<MONAN> lstSoda = new List<MONAN>();
        //List<MONAN> lstCacMonKhac = new List<MONAN>();
        List<BAN> lstBan = new List<BAN>();
        List<DANHMUC> listDanhMuc = new List<DANHMUC>();
        List<TabPage> listTabDanhMuc = new List<TabPage>();
        Button BanDangChon = null;

        public string loginStatus = null;
        string user;

        DataTable bill = new DataTable();

        bool xemBillBan = false;

        public frmMain()
        {
            InitializeComponent();            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadFrom();
            khoiTaoBillTam();
            tabControlBan.Enabled = false;
            tabDoUong.Enabled = false;
        }

        private void LoadFrom()
        {
            LoadDataBan();
            LoadDataDanhMuc();
            LoadMon();
        }

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
        /// <summary>
        /// Load dữ liệu từ Table BAN
        /// </summary>
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
        void LoadDataDanhMuc()
        {
            try
            {
                this.listDanhMuc = BLDanhMuc.Instance.LayTenDanhMuc();
                foreach (DANHMUC item in listDanhMuc)
                {
                    var tab = listTabDanhMuc.Where(x => x.Name == "tab" + item.TenDanhMuc).SingleOrDefault();
                    if(tab == null) AddTabDanhMuc(item);                    
                }                
            }
            catch
            {
                MessageBox.Show("Lỗi load danh mục");
            }
        }
        void LoadMon()
        {
            int number = BLDanhMuc.Instance.SoLuongDanhMuc();
            try
            {
                for (int i = 0; i < number; i++)
                {
                    List<MONAN> listMon = BLMonAn.Instance.LayDanhMucMonAn(i + 1);
                    //lstCafe = BLMonAn.Instance.LayDanhMucMonAn(i + 1);// Hàm LayDanhMucNuocUong() có tham số là index
                    Size size = new Size(157, 138);                     // của tab cần lấy danh mục bắt đầu từ 1                            
                    Point point = new Point(29, 28);
                    int count = 1;
                    foreach (MONAN item in listMon)
                    {
                        AddButtonNuoc(item, point, size, listTabDanhMuc[i]);
                        if (count % 4 != 0)
                        {
                            point.X = point.X + 177;
                        }
                        else
                        {
                            point.X = 26;
                            point.Y = point.Y + 177;
                        }
                        count++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lỗi load món nước");
            }
        }
        
        void AddButtonNuoc(MONAN item, Point local, Size size, TabPage tab)
        {
            Button newButton = new Button();
            Label newLabel = new Label();

            tab.Controls.Add(newButton);
            tab.Controls.Add(newLabel);

            newButton.Name = "btn" + item.IDMonAn;
            Image img = Image.FromFile(@"../../Images/" + item.HinhMA);
            newButton.BackgroundImage = img;
            newButton.BackgroundImageLayout = ImageLayout.Stretch;
            newButton.Location = local;
            newButton.Size = size;
            newButton.MouseDown += btnMonNuoc_Click;
            newButton.Tag = item.IDMonAn;

            newLabel.Text = item.TenMon;
            newLabel.Location = new Point(local.X, local.Y + 140);
            newLabel.Size = new Size(size.Width, 20);
            newLabel.TextAlign = ContentAlignment.MiddleCenter;
            newLabel.Name = "lb" + item.IDMonAn;
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

            newButton.Click += (s, e) =>
            {
                btnBan_Click(s, e, newButton, newLabel, item);
            };

            //thay bằng :
            //newButton.Click += btnBan_Click;
        }
        void AddTabDanhMuc(DANHMUC item)
        {
            TabPage newtabPage = new TabPage();
            tabDoUong.Controls.Add(newtabPage);
            newtabPage.Name = "tab" + item.TenDanhMuc;
            newtabPage.Text = item.TenDanhMuc.ToString();
            listTabDanhMuc.Add(newtabPage);
            
        }

        private void btnBan_Click(object sender, EventArgs e, Button btnBan, Label lbBan, BAN item)
        {
            int IDBan = item.IDBan;  //Lấy IDBan của Bàn đang được click;

            if (BLBan.Instance.TrangThai(IDBan)) //Hàm kiểm tra trạng thái bàn
            {
                if (BanDangChon != null && !xemBillBan) // Set bàn đang được chọn và rest bàn cũ.
                {
                    ChangeStateBan();
                }
                xemBillBan = true;
                this.ShowBill(IDBan);
                BanDangChon = btnBan;
            }
            else
            {
                if (xemBillBan)
                {
                    xemBillBan = false;
                }
                else if (BanDangChon != null)
                {
                    ChangeStateBan();
                }
                BanDangChon = (Button)sender;
                BanDangChon.BackColor = color.colorDangChon;
                ((Label)this.Controls.Find("lbTrangThaiBan" + IDBan,true)[0]).BackColor = color.colorDangChon;
                dgvBill.DataSource = bill;
                this.tbxTongTien.Text = this.TinhTongBill().ToString();
            }
        }

        private void ChangeStateBan()
        {
            int IDBanDangChon = int.Parse(BanDangChon.Tag.ToString()); //Lấy IDBan của Bàn được click trước đó;
            BanDangChon.BackColor = color.colorTrong; 
            ((Label)this.Controls.Find("lbTrangThaiBan" + IDBanDangChon, true)[0]).BackColor = color.colorTrong;
            ((Label)this.Controls.Find("lbTrangThaiBan" + IDBanDangChon, true)[0]).Text = "Còn trống";
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
            dgvBill.Columns["IDHoaDon"].Visible = false;
            tbxTongTien.Text = TinhTongBill().ToString() ;
        }

        private void AddMon(string IDMonAn)
        {
            bool checkNull = true; //Ban đầu giả sử món nước chưa từng được add vào bill tạm thì check = true

            for (int i = 0; i < bill.Rows.Count; i++)
                if (BLMonAn.Instance.LayIDMonNuoc(bill.Rows[i]["TenMon"].ToString()) == IDMonAn)
                {
                    checkNull = false; //Đã có trong bill tạm
                    int soLuong = int.Parse(bill.Rows[i]["SoLuong"].ToString()) + 1;
                    bill.Rows[i]["SoLuong"] = (soLuong).ToString();
                    bill.Rows[i]["ThanhTien"] = (soLuong * int.Parse(bill.Rows[i]["GiaTien"].ToString())).ToString();

                    break;
                }
            if (checkNull)
            {
                bill.Rows.Add(BLMonAn.Instance.LayTenMonNuoc(IDMonAn),
                    BLMonAn.Instance.LayDonGia(IDMonAn),"1",BLMonAn.Instance.LayDonGia(IDMonAn));
            }
            dgvBill.DataSource = bill;
            this.tbxTongTien.Text = this.TinhTongBill().ToString();
        }
        private void SubtractMon(string IDMonAn)
        {
            for (int i = 0; i < bill.Rows.Count; i++)
                if (BLMonAn.Instance.LayIDMonNuoc(bill.Rows[i]["TenMon"].ToString()) == IDMonAn)
                {
                    int soLuong = int.Parse(bill.Rows[i]["SoLuong"].ToString()) - 1;
                    bill.Rows[i]["SoLuong"] = (soLuong).ToString();
                    bill.Rows[i]["ThanhTien"] = (soLuong * int.Parse(bill.Rows[i]["GiaTien"].ToString())).ToString();
                    if (int.Parse(bill.Rows[i]["SoLuong"].ToString()) == 0)
                        bill.Rows.RemoveAt(i);
                    break;
                }
            dgvBill.DataSource = bill;
            this.tbxTongTien.Text = this.TinhTongBill().ToString();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int tienThua = int.Parse(tbxTienThua.Text);
                if (tienThua >= 0)
                {
                    int IDBanDangChon = int.Parse(BanDangChon.Tag.ToString());
                    string idHoaDon = dgvBill.Rows[0].Cells[1].Value.ToString();
                    bool check = BLHoaDon.Instance.ThanhToanHoaDon(idHoaDon);
                    if (check)
                    {
                        BLBan.Instance.ThayDoiTrangThai(IDBanDangChon);
                        ChangeStateBan();
                        cleanTien();
                    }
                }
                else
                {
                    MessageBox.Show("Số tiền thanh toán không đầy đủ!");
                }
            } 
            catch
            {
                MessageBox.Show("Thanh toán không thành công");
            }
        }

        void cleanTien()
        {
            this.tbxTienThua.ResetText();
            this.tbxTongTien.ResetText();
            this.tbxTienKhachDua.ResetText();
            this.cbbGiamGia.SelectedIndex = 0;
            this.dgvBill.DataSource = bill;
        }

        #region LOGIN
        private void menuItemDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();
        }

        public void login(byte type, string user) //hàm login theo type được gọi ở form Login nếu đăng nhập đúng
        {

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
            return sum;
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string IDHoaDon = TaoIDHoaDon();
            BLHoaDon.Instance.ThemHoaDon(IDHoaDon,BLTaiKhoan.Instance.LayIDNhanVien(user), int.Parse(BanDangChon.Tag.ToString()), time, int.Parse(tbxTongTien.Text), cbbGiamGia.SelectedText);
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                string IDMonNuoc = BLMonAn.Instance.LayIDMonNuoc(row.Cells["columnTen"].Value.ToString());
                int SoLuong = int.Parse(row.Cells["columnSoLuong"].Value.ToString());
                int GiaTien = int.Parse(row.Cells["columnThanhTien"].Value.ToString());
                BLChiTietHoaDon.Instance.ThemChiTietHoaDon(IDHoaDon, IDMonNuoc, SoLuong, GiaTien);
            }
            BanDangChon.BackColor = color.colorCoKhach;
            Label lbBanDangChon = (Label)this.Controls.Find("lbTrangThaiBan" + BanDangChon.Tag.ToString(), true)[0];
            lbBanDangChon.BackColor = color.colorCoKhach;
            lbBanDangChon.Text = "Đã có khách";
            BLBan.Instance.ThayDoiTrangThai(int.Parse(BanDangChon.Tag.ToString()));
            //BLBan.Instance.ThemHoaDonBan(int.Parse(BanDangChon.Tag.ToString()),IDHoaDon);
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

        private void tbxTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (((e.KeyChar == '.') || (e.KeyChar == '0')) && (sender as TextBox).Text == "")
            {
                e.Handled = true;
            }
        }

        private void tbxTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (tbxTienKhachDua.Text != "" && tbxTongTien.Text != "")
            {
                int tienThua = int.Parse(tbxTienKhachDua.Text) - int.Parse(tbxTongTien.Text);
                if (tienThua >= 0)
                {
                    this.tbxTienThua.Text = tienThua.ToString();
                } else
                {
                    this.tbxTienThua.ResetText();
                }
            }
        }

        private void quảnLýMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyMon frm = new frmQuanLyMon();
            this.Hide();
            frm.ShowDialog();
            this.LoadFrom();
            this.Show();
        }

        private void chỉnhSửaDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDanhMuc frmCRUDDM = new frmQuanLyDanhMuc();
            frmCRUDDM.ShowDialog();
            LoadDataDanhMuc();
        }

        private void menuItemThemUser_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frmCRUDNV = new frmQuanLyNhanVien();
            frmCRUDNV.ShowDialog();
        }
    }
}
