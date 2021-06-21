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
    public partial class frmSuaBan : Form
    {
        public frmSuaBan()
        {
            InitializeComponent();
        }
        public int idban;
        public string tenban;
        public int succhua;
        private void frmSuaBan_Load(object sender, EventArgs e)
        {
            txtIDBan.Enabled = false;
            txtIDBan.Text = idban.ToString();
            txtTenBan.Text = tenban;
            //cbSucChua.SelectedItem = succhua;
            cbSucChua.Text = succhua.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenBan.Text != "")
            {
                try
                {
                    BLBan.Instance.CapNhatBan(int.Parse(txtIDBan.Text), txtTenBan.Text, int.Parse(cbSucChua.SelectedItem.ToString()));
                    MessageBox.Show("Sửa thành công!");
                }
                catch
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
