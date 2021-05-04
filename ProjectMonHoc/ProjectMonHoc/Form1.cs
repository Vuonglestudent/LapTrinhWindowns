using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectMonHoc.BL_Layer;
namespace ProjectMonHoc
{
    public partial class Form1 : Form
    {
        private List<Button> DSBan;
        private List<Label> TrangThaiBan = new List<Label>();
        public bool iSSelect;
        BLBan dbBan = new BLBan();
        public Form1()
        {
            InitializeComponent();
            DSBan = new List<Button> { btnBan1, btnBan2, btnBan3, btnBan4, btnBan5, btnBan6, btnBan7, btnBan8, btnBan9, btnBan10 };
            TrangThaiBan = new List<Label> { lbTrangThaiBan1, lbTrangThaiBan2, lbTrangThaiBan3, lbTrangThaiBan4, lbTrangThaiBan5,
                                            lbTrangThaiBan6, lbTrangThaiBan7, lbTrangThaiBan8, lbTrangThaiBan9, lbTrangThaiBan10};
        }
        /// <summary>
        /// Load dữ liệu từ Table BAN
        /// </summary>
        void LoadDataBan()
        {
            try
            {
                dgvBan.DataSource = dbBan.LayBan();
                //Lấy dữ liệu từ Collumn TenBan
                btnBan1.Text = dgvBan.Rows[0].Cells[1].Value.ToString();
                btnBan2.Text = dgvBan.Rows[1].Cells[1].Value.ToString();
                btnBan3.Text = dgvBan.Rows[2].Cells[1].Value.ToString();
                btnBan4.Text = dgvBan.Rows[3].Cells[1].Value.ToString();
                btnBan5.Text = dgvBan.Rows[4].Cells[1].Value.ToString();
                btnBan6.Text = dgvBan.Rows[5].Cells[1].Value.ToString();
                btnBan7.Text = dgvBan.Rows[6].Cells[1].Value.ToString();
                btnBan8.Text = dgvBan.Rows[7].Cells[1].Value.ToString();
                btnBan9.Text = dgvBan.Rows[8].Cells[1].Value.ToString();
                btnBan10.Text = dgvBan.Rows[9].Cells[1].Value.ToString();
                //Lấy dữ liệu từ Collumn TrangThai
                lbTrangThaiBan1.Text = dgvBan.Rows[0].Cells[2].Value.ToString();
                lbTrangThaiBan2.Text = dgvBan.Rows[1].Cells[2].Value.ToString();
                lbTrangThaiBan3.Text = dgvBan.Rows[2].Cells[2].Value.ToString();
                lbTrangThaiBan4.Text = dgvBan.Rows[3].Cells[2].Value.ToString();
                lbTrangThaiBan5.Text = dgvBan.Rows[4].Cells[2].Value.ToString();
                lbTrangThaiBan6.Text = dgvBan.Rows[5].Cells[2].Value.ToString();
                lbTrangThaiBan7.Text = dgvBan.Rows[6].Cells[2].Value.ToString();
                lbTrangThaiBan8.Text = dgvBan.Rows[7].Cells[2].Value.ToString(); 
                lbTrangThaiBan9.Text = dgvBan.Rows[8].Cells[2].Value.ToString();
                lbTrangThaiBan10.Text = dgvBan.Rows[9].Cells[2].Value.ToString();
                foreach(Label trangthai in TrangThaiBan)
                {
                    if (trangthai.Text == "True")
                    {
                        trangthai.Text = "Đã có khách";
                    }
                    if (trangthai.Text == "False")
                    {
                        trangthai.Text = "Còn trống";
                    }
                }
            }
            catch
            {
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BoChonAll();
            LoadDataBan();
            TrangThaiBan.ForEach(trangthai => trangthai.Enabled = false);
        }
        /// <summary>
        /// Bỏ chọn tất cả các bàn
        /// </summary>
        private void BoChonAll()
        {
            DSBan.ForEach(ban => ban.BackColor = Color.PaleTurquoise);
            TrangThaiBan.ForEach(trangthai => trangthai.BackColor = Color.PaleTurquoise);
        }       
        private void btnBan1_Click(object sender, EventArgs e)
        {           
            if (btnBan1.BackColor == Color.GreenYellow)
            {          
                BoChonAll();               
            }
            else
            {               
                BoChonAll();
                btnBan1.BackColor = Color.GreenYellow;
                lbTrangThaiBan1.BackColor = Color.GreenYellow;
            }
        }

        private void btnBan2_Click(object sender, EventArgs e)
        {
            
            if (btnBan2.BackColor == Color.GreenYellow)
            {
                BoChonAll();
            }
            else
            {
                BoChonAll();
                btnBan2.BackColor = Color.GreenYellow;
                lbTrangThaiBan2.BackColor = Color.GreenYellow;
            }
        }

        private void btnBan3_Click(object sender, EventArgs e)
        {           
            if (btnBan3.BackColor == Color.GreenYellow)
            {
                BoChonAll();
            }
            else
            {
                BoChonAll();
                btnBan3.BackColor = Color.GreenYellow;
                lbTrangThaiBan3.BackColor = Color.GreenYellow;
            }
        }

        private void btnBan4_Click(object sender, EventArgs e)
        {
            
            if (btnBan4.BackColor == Color.GreenYellow)
            {
                BoChonAll();
            }
            else
            {
                BoChonAll();
                btnBan4.BackColor = Color.GreenYellow;
                lbTrangThaiBan4.BackColor = Color.GreenYellow;
            }
        }

        private void btnBan5_Click(object sender, EventArgs e)
        {           
            if (btnBan5.BackColor == Color.GreenYellow)
            {
                BoChonAll();
            }
            else
            {
                BoChonAll();
                btnBan5.BackColor = Color.GreenYellow;
                lbTrangThaiBan5.BackColor = Color.GreenYellow;
            }
        }

        private void btnBan6_Click(object sender, EventArgs e)
        {           
            if (btnBan6.BackColor == Color.GreenYellow)
            {
                BoChonAll();
            }
            else
            {
                BoChonAll();
                btnBan6.BackColor = Color.GreenYellow;
                lbTrangThaiBan6.BackColor = Color.GreenYellow;
            }
        }

        private void btnBan7_Click(object sender, EventArgs e)
        {           
            if (btnBan7.BackColor == Color.GreenYellow)
            {
                BoChonAll();
            }
            else
            {
                BoChonAll();
                btnBan7.BackColor = Color.GreenYellow;
                lbTrangThaiBan7.BackColor = Color.GreenYellow;
            }
        }

        private void btnBan8_Click(object sender, EventArgs e)
        {           
            if (btnBan8.BackColor == Color.GreenYellow)
            {
                BoChonAll();
            }
            else
            {
                BoChonAll();
                btnBan8.BackColor = Color.GreenYellow; 
                lbTrangThaiBan8.BackColor = Color.GreenYellow;
            }
        }

        private void btnBan9_Click(object sender, EventArgs e)
        {
            
            if (btnBan9.BackColor == Color.GreenYellow)
            {
                BoChonAll();
            }
            else
            {
                BoChonAll();
                btnBan9.BackColor = Color.GreenYellow;
                lbTrangThaiBan9.BackColor = Color.GreenYellow;
            }
        }

        private void btnBan10_Click(object sender, EventArgs e)
        {
            if (btnBan10.BackColor == Color.GreenYellow)
            {
                BoChonAll();
            }
            else
            {
                BoChonAll();
                btnBan10.BackColor = Color.GreenYellow;
                lbTrangThaiBan10.BackColor = Color.GreenYellow;
            }
        }
    }
}
