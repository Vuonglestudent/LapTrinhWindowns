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
    public partial class frmQuanLyNhanVien : Form
    {
        bool Them;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvNHANVIEN.DataSource = BLNhanVien.Instance.LayNhanVien();
                dgvNHANVIEN.AutoResizeColumns();
                foreach (Control tb in panel1.Controls)
                {
                    if (tb is TextBox)
                    {
                        tb.ResetText();
                    }
                }
                dgvNHANVIEN_CellClick(null, null);
                this.btnLuu.Enabled = false;
                this.btnHuy.Enabled = false;
                this.panel1.Enabled = false;
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;                
                this.txtIDNV.Focus();
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG. Lỗi rồi!!!");
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvNHANVIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNHANVIEN.CurrentCell.RowIndex;

            this.txtIDNV.Text = dgvNHANVIEN.Rows[r].Cells[0].Value.ToString();
            this.txtIDCongViec.Text = dgvNHANVIEN.Rows[r].Cells[1].Value.ToString();
            this.txtHo.Text = dgvNHANVIEN.Rows[r].Cells[2].Value.ToString();
            this.txtTen.Text = dgvNHANVIEN.Rows[r].Cells[3].Value.ToString();
            this.txtEmailNV.Text = dgvNHANVIEN.Rows[r].Cells[4].Value.ToString();
            this.dtpNgaySinh.Value = DateTime.Parse(dgvNHANVIEN.Rows[r].Cells[5].Value.ToString());
            this.txtDiaChi.Text = dgvNHANVIEN.Rows[r].Cells[6].Value.ToString();
            this.txtDienThoai.Text = dgvNHANVIEN.Rows[r].Cells[7].Value.ToString();
            this.txtHinh.Text = dgvNHANVIEN.Rows[r].Cells[8].Value.ToString();
        }
        private void FormChinhSuaNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            // Xóa trống các đối tượng trong Panel 
            foreach (Control tb in panel1.Controls)
            {
                if (tb is TextBox)
                    tb.ResetText();
            }
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;

            this.txtIDNV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvNHANVIEN_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.txtIDNV.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int r = dgvNHANVIEN.CurrentCell.RowIndex;
                string strIDNV = dgvNHANVIEN.Rows[r].Cells[0].Value.ToString();
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {

                    BLNhanVien.Instance.XoaNhanVien(strIDNV);

                    // Cập nhật lại DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Control tb in panel1.Controls)
            {
                if (tb is TextBox)
                    tb.ResetText();
            }
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.panel1.Enabled = false;
            dgvNHANVIEN_CellClick(null, null);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh 
                    BLNhanVien.Instance.ThemNhanVien(this.txtIDNV.Text, int.Parse(txtIDCongViec.Text), this.txtHo.Text, txtTen.Text, this.txtEmailNV.Text, dtpNgaySinh.Value, txtDiaChi.Text, txtDienThoai.Text, this.txtHinh.Text);
                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            if (!Them)
            {
                // Thực hiện lệnh ;
                BLNhanVien.Instance.CapNhatNhanVien(this.txtIDNV.Text, int.Parse(txtIDCongViec.Text), this.txtHo.Text, txtTen.Text, this.txtEmailNV.Text, dtpNgaySinh.Value, txtDiaChi.Text, txtDienThoai.Text, this.txtHinh.Text);
                // Load lại dữ liệu trên DataGridView 
                LoadData();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
        }
    }
}
