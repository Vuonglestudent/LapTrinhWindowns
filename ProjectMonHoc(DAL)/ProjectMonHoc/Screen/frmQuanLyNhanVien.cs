using System;
using System.IO;
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
        string err;
        Image imgFile;
        string pathImg;
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        void LoadData() 
        {
            dgvNHANVIEN.Rows.Clear();
            var data = BLNhanVien.Instance.LayNhanVien();
            for (int i = 0; i < data.Count; i++)
            {
                dgvNHANVIEN.Rows.Add(
                    data[i].IDNhanVien,
                    data[i].Ho + " " + data[i].Ten,
                    data[i].IDCongViec,
                    data[i].NgaySinh.ToString("dd/MM/yyyy"),
                    data[i].Email,
                    data[i].DiaChi,
                    data[i].SDT,
                    Image.FromFile(@"../../Images/" + data[i].HinhNV));
                dgvNHANVIEN.Rows[i].Height = 150;
            }
            ((DataGridViewImageColumn)dgvNHANVIEN.Columns[7]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            for (int i = 0; i < dgvNHANVIEN.Rows.Count; i++)
            {
                int x = (int)(dgvNHANVIEN.Rows[i].Cells[2].Value);
                switch(x)
                {
                    case 1:
                        dgvNHANVIEN.Rows[i].Cells[2].Value = "Quản lý";
                        break;
                    case 2:
                        dgvNHANVIEN.Rows[i].Cells[2].Value = "Nhân viên bán hàng";
                        break;
                    case 3:
                        dgvNHANVIEN.Rows[i].Cells[2].Value = "Nhân viên phục vụ";
                        break;
                    case 4:
                        dgvNHANVIEN.Rows[i].Cells[2].Value = "Bảo vệ";
                        break;
                    case 5:
                        dgvNHANVIEN.Rows[i].Cells[2].Value = "Nhân viên vệ sinh";
                        break;
                }
            }
            gbInfo.Enabled = false;
            btnReload.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            //dgvNHANVIEN_CellClick(null, null);
        }
        private void dgvNHANVIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNHANVIEN.CurrentCell.RowIndex;
            var hoTen = dgvNHANVIEN.Rows[r].Cells[1].Value.ToString().Split(' ').ToList();
            this.txtIDNhanVien.Text = dgvNHANVIEN.Rows[r].Cells[0].Value.ToString();
            this.txtHo.Text = hoTen[0].ToString();
            this.txtTen.Text = "";
            for (int i = 1; i < hoTen.Count; i++)
            {
                this.txtTen.Text = this.txtTen.Text == "" ? hoTen[i].ToString() : this.txtTen.Text + " " + hoTen[i].ToString();
            }
            this.cbIDCongViec.Text = dgvNHANVIEN.Rows[r].Cells[2].Value.ToString();
            this.dtpNgaySinh.Value = DateTime.ParseExact(dgvNHANVIEN.Rows[r].Cells[3].Value.ToString(), "dd/MM/yyyy", null);
            this.txtEmailNV.Text = dgvNHANVIEN.Rows[r].Cells[4].Value.ToString();
            this.txtDiaChi.Text = dgvNHANVIEN.Rows[r].Cells[5].Value.ToString();
            this.txtDienThoai.Text = dgvNHANVIEN.Rows[r].Cells[6].Value.ToString();
            this.pbImageUser.BackgroundImage = (Bitmap)(dgvNHANVIEN.Rows[r].Cells[7].Value);
            pbImageUser.BackgroundImageLayout = ImageLayout.Stretch;
            pathImg = dgvNHANVIEN.Rows[r].Cells[0].Value.ToString() + ".jpg";
            imgFile = (Bitmap)(dgvNHANVIEN.Rows[r].Cells[7].Value);
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNHANVIEN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                imgFile = Bitmap.FromFile(f.FileName);
                pbImageUser.BackgroundImage = imgFile;
                pbImageUser.BackgroundImageLayout = ImageLayout.Stretch;
                pathImg = f.SafeFileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            btnHuy.Enabled = btnLuu.Enabled = true;
            btnSua.Enabled = btnThem.Enabled = false;
            gbInfo.Enabled = true;
            txtIDNhanVien.Enabled = true;
            txtHo.Text = txtTen.Text = txtEmailNV.Text = txtDiaChi.Text = txtDienThoai.Text = "";
            pbImageUser.BackgroundImage = null;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            btnHuy.Enabled = btnLuu.Enabled = true;
            btnSua.Enabled = btnThem.Enabled = false;
            gbInfo.Enabled = true;
            txtIDNhanVien.Enabled = false;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.Enabled = btnLuu.Enabled = false;
            btnSua.Enabled = btnThem.Enabled = true;
            gbInfo.Enabled = false;
            txtIDNhanVien.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtHo.Text != "" && txtTen.Text != "" && txtEmailNV.Text != "" &&
                txtDienThoai.Text != "" && txtIDNhanVien.Text != "" && imgFile != null && pathImg != null)
            {
                if (Them)
                {
                    try
                    {
                        string s = txtIDNhanVien.Text + txtHo.Text + (cbIDCongViec.SelectedIndex + 1) + txtTen.Text +
                                                              txtEmailNV.Text + dtpNgaySinh.Value + txtDiaChi.Text + txtDienThoai.Text + pathImg;
                        MessageBox.Show(s);
                        imgFile.Save(@"../../Images/" + pathImg);
                        BLNhanVien.Instance.ThemNhanVien(txtIDNhanVien.Text, txtHo.Text, cbIDCongViec.SelectedIndex + 1, txtTen.Text,
                                                              txtEmailNV.Text, dtpNgaySinh.Value, txtDiaChi.Text, txtDienThoai.Text, pathImg, ref err);
                        LoadData();
                        MessageBox.Show("Thêm thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
                else
                {
                    try
                    {
                        if (imgFile == (Bitmap)dgvNHANVIEN.CurrentRow.Cells[7].Value)
                        {
                            BLNhanVien.Instance.CapNhatNhanVien(txtIDNhanVien.Text, txtHo.Text, cbIDCongViec.SelectedIndex + 1, txtTen.Text,
                                                             txtEmailNV.Text, dtpNgaySinh.Value, txtDiaChi.Text, txtDienThoai.Text, pathImg, ref err);
                        }
                        else
                        {
                            imgFile.Save(@"../../Images/" + pathImg);
                            BLNhanVien.Instance.CapNhatNhanVien(txtIDNhanVien.Text, txtHo.Text, cbIDCongViec.SelectedIndex + 1, txtTen.Text,
                                                             txtEmailNV.Text, dtpNgaySinh.Value, txtDiaChi.Text, txtDienThoai.Text, pathImg, ref err);
                        }
                    
                        LoadData();
                        MessageBox.Show("Sửa thành công");
                    }
                    catch
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
            }
            else
            {
                MessageBox.Show("Thiếu thông tin");
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNHANVIEN.SelectedCells.Count == 1)
            {
                string IDNhanVien = dgvNHANVIEN.CurrentRow.Cells[0].Value.ToString();
                string question = "Bạn có muốn xóa nhân viên " + IDNhanVien + " không ?";
                DialogResult traloi = MessageBox.Show(question, "Confirm", MessageBoxButtons.YesNo);
                if (traloi == DialogResult.Yes)
                {
                    BLNhanVien.Instance.XoaNhanVien(dgvNHANVIEN.CurrentRow.Cells[0].Value.ToString(), ref err);
                    LoadData();
                    MessageBox.Show("Đã xóa xong");
                }
            }
        }
    }
}
