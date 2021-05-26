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
    public partial class FormChinhSuaDanhMuc : Form
    {
        bool Them;
        public FormChinhSuaDanhMuc()
        {
            InitializeComponent();
        }
        void LoadDataDanhMuc()
        {
            dataGridView1.DataSource = BLDanhMuc.Instance.LayDanhMucMon();
            dataGridView1_CellClick(null, null);
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }
        private void FormChinhSuaDanhMuc_Load(object sender, EventArgs e)
        {
            LoadDataDanhMuc();
        }

        private void txtIDDanhMuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtIDDanhMuc.Text = (BLDanhMuc.Instance.SoLuongDanhMuc() + 1).ToString();
            txtTenDanhMuc.ResetText();
            txtTenDanhMuc.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            txtIDDanhMuc.Focus();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLDanhMuc.Instance.ThemDanhMuc(int.Parse(txtIDDanhMuc.Text), txtTenDanhMuc.Text);
                    LoadDataDanhMuc();
                    MessageBox.Show("Đã thêm xong");
                }
                catch
                {
                    MessageBox.Show("Không thêm được, lỗi rồi!");
                }
            }
            else if (!Them)
            {
                try
                {
                    BLDanhMuc.Instance.CapNhatDanhMuc(int.Parse(txtIDDanhMuc.Text), txtTenDanhMuc.Text);
                    LoadDataDanhMuc();
                    MessageBox.Show("Đã sửa xong");
                }
                catch
                {
                    MessageBox.Show("Không sửa được, lỗi rồi!");
                }
            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dataGridView1_CellClick(null, null);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            dataGridView1_CellClick(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;
                int IDDanhMuc = int.Parse(dataGridView1.Rows[r].Cells[0].Value.ToString());
                DialogResult traloi;
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    BLDanhMuc.Instance.XoaDanhMuc(IDDanhMuc);
                    LoadDataDanhMuc();
                    MessageBox.Show("Đã xóa xong!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            txtIDDanhMuc.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
            txtTenDanhMuc.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
        }

        private void FormChinhSuaDanhMuc_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
