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
        }

        void LoadData (int idDanhMuc)
        {
            try
            {
                dgvQLMonAn.Rows.Clear();
                var mn = BLNuocUong.Instance.LayDanhMucNuocUong(idDanhMuc);
                for (int i = 0; i < mn.Count; i++)
                {
                    dgvQLMonAn.Rows.Add(mn[i].TenMon, mn[i].GiaTien, Image.FromFile(@"../../Images/" + mn[i].IDMonAn + ".jpg"));
                    dgvQLMonAn.Rows[i].Height = 100;
                }
                ((DataGridViewImageColumn)dgvQLMonAn.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Stretch;
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
                int dm = int.Parse(cbDanhMucMon.SelectedValue.ToString());
                BLNuocUong.Instance.ThemMonAn(txtTenMon.Text, dm, int.Parse(numGiaTien.Value.ToString()), pathImg);
                imgFile.Save(@"../../Images/" + pathImg);
            }
        }
    }
}
