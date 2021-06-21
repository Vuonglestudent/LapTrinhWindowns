using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMonHoc.Screen
{
    public partial class frmChiTietHoaDon : Form
    {
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        public frmChiTietHoaDon(List<string> IDbills)
        {
            InitializeComponent();
            Bill bill;
            int x = (panelBills.Width - Bill.Intance.Width) / 2;
            int y = 10;
            foreach (string IDbill in IDbills)
            {
                bill = new Bill(IDbill);
                this.panelBills.Controls.Add(bill);
                bill.Location = new Point(x, y);
                y += bill.Height + 10;
            }    
        }

        public frmChiTietHoaDon(string IDbill)
        {
            InitializeComponent();
            Bill bill = new Bill(IDbill);
            this.panelBills.Controls.Add(bill);
            bill.Location = new Point((panelBills.Width - Bill.Intance.Width) / 2, 10);
            Height = 90 + bill.Height;
        }
    }
}
