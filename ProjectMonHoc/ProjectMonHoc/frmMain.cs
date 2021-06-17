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
using System.Drawing.Drawing2D;

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
        NHANVIEN userCurrent;

        DataTable bill = new DataTable();

        bool xemBillBan = false;

        public frmMain()
        {
            InitializeComponent();
            Rectangle r = new Rectangle(0, 0, ptbAvatar.Width, ptbAvatar.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(new Rectangle(0, 0, ptbAvatar.Width - 1, ptbAvatar.Height - 1));
            Region rg = new Region(gp);
            ptbAvatar.Region = rg;
            ptbAvatar.BackgroundImageLayout = ImageLayout.Stretch;
            pnDropDownMenuAvatar.Height = 0;


        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadFrom();
            khoiTaoBillTam();
            this.pnMain.Enabled = false;
        }

        private void LoadFrom()
        {
            LoadDataBan();
            LoadDataDanhMuc();
            LoadMon();
            LoadAvatar();
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

        #region avatar Menu dropdown
        void LoadAvatar()
        {
            Image img;
            img = userCurrent == null 
                ? Image.FromFile(@"../../Images/default.jpg") 
                : Image.FromFile(@"../../Images/" + userCurrent.HinhNV);
            ptbAvatar.BackgroundImage = img;
            lbFullName.Text = userCurrent == null
                ? "Hello"
                : "Hello \n" + userCurrent.Ho + " " + userCurrent.Ten;
            this.tmrDropdownMenu.Interval = 1;
            LoadDropDownMenuAvatar();
        }
        void LoadDropDownMenuAvatar()
        {
            CreateItemMenu("account.png", this.btnXemHoSo, null);
            CreateItemMenu("changePassword.png", this.btnChangePass, null);
        }

        void CreateItemMenu(string icon, Button btnIcon, EventHandler eventClick) 
        {
            Image img = Image.FromFile(@"../../Images/" + icon);
            btnIcon.Image = (Image)(new Bitmap(img, new Size(15, 15)));
            btnIcon.Controls.Add(new Label() { Height = 1, Dock = DockStyle.Bottom, BackColor = Color.Black });
        }
        #endregion

        #region LoadDanhMuc
        void LoadDataDanhMuc()
        {
            try
            {
                tabDoUong.Controls.Clear();
                this.listDanhMuc = BLDanhMuc.Instance.LayTenDanhMuc();
                foreach (DANHMUC item in listDanhMuc)
                {
                    AddTabDanhMuc(item);                    
                }                
            }
            catch
            {
                MessageBox.Show("Lỗi load danh mục");
            }
        }
        void AddTabDanhMuc(DANHMUC item)
        {
            TabPage newtabPage;
            var tab = listTabDanhMuc.Where(x => x.Name == item.IDDanhMuc.ToString()).SingleOrDefault();
            if (tab == null)
            {
                newtabPage = new TabPage();
                newtabPage.Name = item.IDDanhMuc.ToString();
                listTabDanhMuc.Add(newtabPage);
            }
            else newtabPage = tab;
            newtabPage.Text = item.TenDanhMuc.ToString();
            tabDoUong.Controls.Add(newtabPage);
        }
        #endregion

        #region LoadMonAn
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
                    listTabDanhMuc[i].Controls.Clear();
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
            Image img;
            try
            {
                img = Image.FromFile(@"../../Images/" + item.HinhMA);
            } catch 
            {
                img = Image.FromFile(@"../../Images/default.jpg");
            }
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
        #endregion

        #region LoadBan
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
                    if (count % 2 != 0)
                    {
                        pointBan.X = pointBan.X + 147;
                    }
                    else
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
        #endregion

        #region EventBanClick
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
        private void ShowBill(int IDBan)
        {
            dgvBill.DataSource = BLBan.Instance.LayChiTietHoaDonBan(IDBan);
            dgvBill.Columns["IDHoaDon"].Visible = false;
            tbxTongTien.Text = TinhTongBill().ToString();
        }
        #endregion

        #region EventMonClick
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
        #endregion

        #region ThanhToan
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int tienThua = int.Parse(tbxTienThua.Text.Split('$')[0]);
                if (tienThua >= 0)
                {
                    int IDBanDangChon = int.Parse(BanDangChon.Tag.ToString());
                    string idHoaDon = dgvBill.Rows[0].Cells[0].Value.ToString();
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
            this.tbxTienKhachDua.TextChanged -= tbxTienKhachDua_TextChanged;
            this.tbxTienKhachDua.ResetText();
            this.tbxTienKhachDua.TextChanged += tbxTienKhachDua_TextChanged;
            this.cbbGiamGia.SelectedIndex = 0;
            this.dgvBill.DataSource = bill;
        }
        #endregion

        #region LOGIN
        private void menuItemDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.ShowDialog();
        }

        public void login(byte type, string username) //hàm login theo type được gọi ở form Login nếu đăng nhập đúng
        {

            this.menuItemDangXuat.Enabled = true;
            this.menuItemDoiMatKhau.Enabled = true;
            this.menuItemDanhMuc.Enabled = true;
            this.menuItemDangNhap.Enabled = false;
            this.userCurrent = BLNhanVien.Instance.LayNhanVienByUserName(username);
            LoadAvatar();
            this.pnMain.Enabled = true;
            if (type == 1)
            {
                this.menuItemAdmin.Enabled = true;
            }
        }

        private void menuItemDangXuat_Click(object sender, EventArgs e)
        {
            this.menuItemDangXuat.Enabled = false;
            this.menuItemDoiMatKhau.Enabled = false;
            this.menuItemDanhMuc.Enabled = false;
            this.menuItemAdmin.Enabled = false;
            this.menuItemDangNhap.Enabled = true;
            this.pnMain.Enabled = false;
            this.userCurrent = null;
            LoadAvatar();
            MessageBox.Show("Đã đăng xuất!");
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

        string TinhTongBill()
        {
            int sum = 0;
            foreach (DataGridViewRow row in dgvBill.Rows)
                sum = sum + int.Parse(row.Cells["ThanhTien"].Value.ToString());
            return sum + "$";
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            string IDHoaDon = TaoIDHoaDon();
            BLHoaDon.Instance.ThemHoaDon(
                IDHoaDon, 
                userCurrent.IDNhanVien, 
                int.Parse(BanDangChon.Tag.ToString()), 
                time, 
                int.Parse(tbxTongTien.Text.Split('$')[0]), 
                cbbGiamGia.SelectedText
            );
            foreach (DataGridViewRow row in dgvBill.Rows)
            {
                string IDMonNuoc = BLMonAn.Instance.LayIDMonNuoc(row.Cells["TenMon"].Value.ToString());
                int SoLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                int GiaTien = int.Parse(row.Cells["ThanhTien"].Value.ToString());
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

        #region event frm
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
            int tienKhachDua = tbxTienKhachDua.Text != "$" 
                ? int.Parse(tbxTienKhachDua.Text.Split('$')[0].ToString()) 
                : 0;
            int tongTien = int.Parse(tbxTongTien.Text.Split('$')[0].ToString());
            if (tienKhachDua.ToString() != "" && tongTien.ToString() != "")
            {
                float tienThua = tienKhachDua - tongTien;
                if (tienThua >= 0)
                {
                    this.tbxTienThua.Text = tienThua.ToString() + "$";
                } else
                {
                    this.tbxTienThua.ResetText();
                }
            }
            tbxTienKhachDua.Text = tienKhachDua + "$";
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

        private void xemHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemHoaDon frmHoaDon = new frmXemHoaDon();
            frmHoaDon.ShowDialog();
        }
        #endregion

        #region eventAvatarMenu
        private void ptbAvatar_MouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    {
                        pnDropDownMenuAvatar.Height = 0;
                        this.tmrDropdownMenu.Enabled = true;
                        this.pnMain.Click += eventClick;
                    }
                    break;
            }
        }

        private void eventClick(object sender, EventArgs e)
        {
            tmrDropdownMenu.Enabled = false;
            pnDropDownMenuAvatar.Height = 0;
            this.pnMain.Click -= eventClick;
        }

        private void tmrDropdownMenu_Tick(object sender, EventArgs e)
        {
            while (pnDropDownMenuAvatar.Height< 100)
            {
                if (pnDropDownMenuAvatar.Height < 100)
                {
                    pnDropDownMenuAvatar.Height = pnDropDownMenuAvatar.Height + 5;
                }
                break;
            }
        }

        private void btnXemHoSo_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword changePassword = new frmChangePassword();
            changePassword.ShowDialog();
        }
    }
}
