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
        List<BAN> lstBan = new List<BAN>();
        ResourceManager rm = Resources.ResourceManager;
        List<NUOCUONG> lstCafe = new List<NUOCUONG>();
        public frmMain()
        {
            InitializeComponent();
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
        void LoadMonNuoc()
        {
            try
            {
                LoadDanhMucCafe();
            } catch
            {
                MessageBox.Show("Lỗi load món nước");
            }
        }

        void LoadDanhMucCafe()
        {
            try
            {
                lstCafe = BLNuocUong.Instance.LayDanhMucCafe();
                Size size = new Size(157, 138);
                Point point = new Point(29, 28);
                int count = 1;
                foreach(NUOCUONG item in lstCafe)
                {
                    AddButtonNuoc(item, point, size);
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

        void AddButtonNuoc(NUOCUONG item, Point local, Size size)
        {
            Button newButton = new Button();
            Label newLabel = new Label();
            this.tabCaPhe.Controls.Add(newButton);
            this.tabCaPhe.Controls.Add(newLabel);

            newButton.Name = "btn" + item.IDMonNuoc;
            newButton.BackgroundImage = (Bitmap)rm.GetObject(item.IDMonNuoc);
            newButton.BackgroundImageLayout = ImageLayout.Stretch;
            newButton.Location = local;
            newButton.Size = size;

            newLabel.Text = item.TenMon;
            newLabel.Location = new Point(local.X, local.Y + 140);
            newLabel.Size = new Size(size.Width, 20);
            newLabel.TextAlign = ContentAlignment.MiddleCenter;

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
                newLabel.BackColor = Color.GreenYellow;
                newButton.BackColor = Color.GreenYellow;
            }
            if (item.TrangThai == false)
            {
                newLabel.Text = "Còn trống";
                newLabel.BackColor = Color.PaleTurquoise;
                newButton.BackColor = Color.PaleTurquoise;

            }

            newButton.Click += (s, e) =>
            {
                Console.WriteLine(item.IDHoaDon);
                dgvBill.DataSource = BLBan.Instance.LayChiTietHoaDonTheoBan(item.IDHoaDon);
                this.dgvBill.Columns["IDMonNuoc"].Visible = false;
            };
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataBan();
            LoadMonNuoc();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
        }
    }
}
