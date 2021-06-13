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
    public partial class frmXemHoaDon : Form
    {
        public frmXemHoaDon()
        {
            InitializeComponent();
            dtpkBatDau.Format = DateTimePickerFormat.Custom;
            dtpkBatDau.CustomFormat = "dd/MM/yyyy";
            dtpkKetThuc.Format = DateTimePickerFormat.Custom;
            dtpkKetThuc.CustomFormat = "dd/MM/yyyy";
            btnSwap.BackgroundImage = Image.FromFile(@"../../Icon/swapIcon.png");
            btnReset.BackgroundImage = Image.FromFile(@"../../Icon/resetIcon.png");
            ptbMoneyIcon.BackgroundImage = Image.FromFile(@"../../Icon/moneyIcon.png");
            ptbBillIcon.BackgroundImage = Image.FromFile(@"../../Icon/billIcon.png");
            ptbCalendarIcon.BackgroundImage = Image.FromFile(@"../../Icon/calendarIcon.png");
        }

        private void frmXemHoaDon_Load(object sender, EventArgs e)
        {
            (dgvHoaDon.Columns["NhanVien"] as DataGridViewComboBoxColumn).DataSource = BLNhanVien.Instance.LayNhanVien();
            (dgvHoaDon.Columns["Nhanvien"] as DataGridViewComboBoxColumn).DisplayMember = "Ten";
            (dgvHoaDon.Columns["Nhanvien"] as DataGridViewComboBoxColumn).ValueMember = "IDNhanVien";
            (dgvHoaDon.Columns["Nhanvien"] as DataGridViewComboBoxColumn).DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            //cập nhật giá trị 2 datetimepicker ban đầu :
            btnReset_Click(sender, e);
        }

        private void CapNhatBangHoaDon(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = BLHoaDon.Instance.LayHoaDon(dtpkBatDau.Value, dtpkKetThuc.Value);
            CapNhatTongKet();
        }

        private void CapNhatTongKet()
        {
            int DoanhThu = 0;
            foreach (DataGridViewRow hd in dgvHoaDon.Rows)
            {
                DoanhThu += int.Parse(hd.Cells["TongTien"].Value.ToString());
            }
            lbDoanhThu.Text = DoanhThu.ToString();
            lbTongSoBill.Text = dgvHoaDon.Rows.Count.ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            DateTime temp = dtpkBatDau.Value;
            dtpkBatDau.Value = dtpkKetThuc.Value;
            dtpkKetThuc.Value = temp;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpkBatDau.Value = BLHoaDon.Instance.TimeOfFirstBill();
            dtpkKetThuc.Value = BLHoaDon.Instance.TimeOfLastBill();
        }
    }
}
