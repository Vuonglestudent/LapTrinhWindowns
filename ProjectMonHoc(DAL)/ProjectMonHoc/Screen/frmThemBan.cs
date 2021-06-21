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

namespace ProjectMonHoc.Screen
{
    public partial class frmThemBan : Form
    {
        public frmThemBan()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            dgvBan.Rows.Clear();
            var data = BLBan.Instance.LayBan();
            for (int i = 0; i < data.Count; i++)
            {
                dgvBan.Rows.Add(
                    data[i].IDBan,
                    data[i].TenBan,
                    data[i].TrangThai,
                    data[i].SucChua);
            }
            int x = dgvBan.Rows.Count;
            int t = int.Parse(dgvBan.Rows[x - 1].Cells[0].Value.ToString()) + 1;
            txtIDBan.Text = t.ToString();
        }
        private void frmThemBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtIDBan.Text != "" && txtTenBan.Text != "")
            {
                try
                {
                    //BLBan.Instance.ThemBan(int.Parse(txtIDBan.Text), txtTenBan.Text, int.Parse(cbSucChua.SelectedItem.ToString()));
                    LoadData();
                    MessageBox.Show("Thêm thành công!");
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu thông tin");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
