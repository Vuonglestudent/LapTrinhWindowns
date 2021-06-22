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

namespace ProjectMonHoc.Screen
{
    public partial class frmQuanLyMon : Form
    {
        ResourceManager rm = Resources.ResourceManager;
        Image imgFile;
        string pathImg;

        public frmQuanLyMon()
        {
            InitializeComponent();
            cbDanhMucMon.DataSource = BLDanhMuc.Instance.LayDanhMucMon();
            cbDanhMucMon.DisplayMember = "TenDanhMuc";
            cbDanhMucMon.ValueMember = "IDDanhMuc";
            LoadIcon();
        }

        public void LoadIcon()
        {
            Size btnSize = new Size(30, 30);
            this.ptbGiaTien.Image = (Image)(new Bitmap(Image.FromFile(@"../../Icon/costIcon.png"),btnSize));
            this.ptbHinhAnh.Image = (Image)(new Bitmap(Image.FromFile(@"../../Icon/imageIcon.png"), btnSize));
            this.ptbTenMon.Image = (Image)(new Bitmap(Image.FromFile(@"../../Icon/foodIcon.png"), btnSize));
            this.btnSuaMon.Image = (Image)(new Bitmap(Image.FromFile(@"../../Icon/editDataIcon.png"), btnSize));
            this.btnThemMon.Image = (Image)(new Bitmap(Image.FromFile(@"../../Icon/addIcon.png"), btnSize));
            this.btnXoaMon.Image = (Image)(new Bitmap(Image.FromFile(@"../../Icon/trashcanIcon.png"), btnSize));
            this.btnSelectFile.Image = (Image)(new Bitmap(Image.FromFile(@"../../Icon/imageIcon.png"), btnSize));
            this.pbImage.BackgroundImage = Image.FromFile(@"../../Icon/imageIcon.png");
        }

        void LoadData (int idDanhMuc)
        {
            try
            {
                lbTenMon.Rows.Clear();
                var mn = BLMonAn.Instance.LayDanhMucMonAn(idDanhMuc);
                for (int i = 0; i < mn.Count; i++)
                {
                    lbTenMon.Rows.Add(mn[i].TenMon, mn[i].GiaTien, Image.FromFile(@"../../Images/" + mn[i].HinhMA));
                    lbTenMon.Rows[i].Height = 200;
                }
                ((DataGridViewImageColumn)lbTenMon.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            }
            catch
            {
                MessageBox.Show("Lỗi load món");
            }
        }

        private void frmQuanLyMon_Load(object sender, EventArgs e)
        {
            int dm = int.Parse(cbDanhMucMon.SelectedValue.ToString());
            LoadData(dm);
            this.cbDanhMucMon.SelectedValueChanged += cbDanhMucMon_SelectedValueChanged;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                imgFile = Bitmap.FromFile(f.FileName);
                pbImage.BackgroundImage = imgFile;
                pbImage.BackgroundImageLayout = ImageLayout.Stretch;
                pathImg = f.SafeFileName;               
            }
        }

        private void cbDanhMucMon_SelectedValueChanged(object sender, EventArgs e)
        {
            int dm = int.Parse(cbDanhMucMon.SelectedValue.ToString());
            LoadData(dm);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text != "" && numGiaTien.Value != 0 && imgFile != null)
            {
                MessageBox.Show("Đang thêm món");
                int dm = int.Parse(cbDanhMucMon.SelectedValue.ToString());
                try
                {
                    imgFile.Save(@"../../Images/" + pathImg);
                    MessageBox.Show(pathImg);
                    BLMonAn.Instance.ThemMonAn(txtTenMon.Text, dm, int.Parse(numGiaTien.Value.ToString()), pathImg);
                    LoadData(dm);
                }
                catch
                {
                    MessageBox.Show("Không thể lưu hình ảnh vào hệ thống, vui lòng thử lại sau!");
                }
            }
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            if (lbTenMon.SelectedCells.Count == 1)
            {
                string tenMon = lbTenMon.CurrentRow.Cells[0].Value.ToString();
                string question = "Bạn có muốn xóa món " + tenMon + " không ?";
                DialogResult traloi = MessageBox.Show(question, "Confirm", MessageBoxButtons.YesNo);
                if (traloi == DialogResult.Yes)
                {
                    BLMonAn.Instance.XoaMonAn_TenMon(tenMon);
                    int dm = int.Parse(cbDanhMucMon.SelectedValue.ToString());
                    LoadData(dm);
                }    
            }    
        }

        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            DataGridViewRow m = lbTenMon.CurrentRow;
            if ((Bitmap)pbImage.BackgroundImage != (Bitmap)m.Cells[2].Value)
            {
                try
                {
                    imgFile.Save(@"../../Images/" + pathImg);
                    BLMonAn.Instance.CapNhatMon_TenMon(m.Cells[0].Value.ToString(), txtTenMon.Text, int.Parse(numGiaTien.Value.ToString()), pathImg);
                }
                catch
                {
                    MessageBox.Show("Không thể lưu hình ảnh vào hệ thống, vui lòng thử lại sau!");
                }
            }
            else
            {
                BLMonAn.Instance.CapNhatMon_TenMon(m.Cells[0].Value.ToString(), txtTenMon.Text, int.Parse(numGiaTien.Value.ToString()), string.Empty);
            }
            int dm = int.Parse(cbDanhMucMon.SelectedValue.ToString());
            LoadData(dm);
        }

        private void dgvQLMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow m = lbTenMon.CurrentRow;
            txtTenMon.Text = m.Cells[0].Value.ToString();
            numGiaTien.Value = decimal.Parse(m.Cells[1].Value.ToString());
            pbImage.BackgroundImage = (Bitmap)m.Cells[2].Value;
            pbImage.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
