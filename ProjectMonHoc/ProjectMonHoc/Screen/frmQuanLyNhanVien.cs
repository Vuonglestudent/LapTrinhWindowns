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

            var data  = BLNhanVien.Instance.LayNhanVien();
            for (int i = 0; i < data.Count; i++)
            {
                dgvNHANVIEN.Rows.Add(
                    data[i].Ho + " " + data[i].Ten, 
                    data[i].NgaySinh.ToString("dd/MM/yyyy"), 
                    data[i].Email, 
                    data[i].DiaChi, 
                    data[i].SDT, 
                    Image.FromFile(@"../../Images/" + data[i].HinhNV), 
                    data[i].IDNhanVien);
                dgvNHANVIEN.Rows[i].Height = 150;
            }
            ((DataGridViewImageColumn)dgvNHANVIEN.Columns[5]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            gbInfo.Enabled = false;
            btnReload.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
            //
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
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
            int r = dgvNHANVIEN.CurrentCell.RowIndex;
            var hoTen = dgvNHANVIEN.Rows[r].Cells[0].Value.ToString().Split(' ').ToList();
            this.txtHo.Text = hoTen[0].ToString();
            this.txtTen.Text = "";
            for(int i = 1; i< hoTen.Count; i++) 
            {
                this.txtTen.Text = this.txtTen.Text == "" ? hoTen[i].ToString() : this.txtTen.Text + " " + hoTen[i].ToString();   
            }
            this.dtpNgaySinh.Value = DateTime.ParseExact(dgvNHANVIEN.Rows[r].Cells[1].Value.ToString(), "dd/MM/yyyy", null);
            this.txtEmailNV.Text = dgvNHANVIEN.Rows[r].Cells[2].Value.ToString();
            this.txtDiaChi.Text = dgvNHANVIEN.Rows[r].Cells[3].Value.ToString();
            this.txtDienThoai.Text = dgvNHANVIEN.Rows[r].Cells[4].Value.ToString();
        }
    }
}
