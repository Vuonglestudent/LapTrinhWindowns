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
    public partial class frmReport : Form
    {
        DateTime batDau;
        DateTime ketThuc;
        public frmReport(DateTime batDau, DateTime ketThuc)
        {
            InitializeComponent();
            this.batDau = batDau;
            this.ketThuc = ketThuc;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            this.qLNH.EnforceConstraints = false;
            //this.reportCTHDTableAdapter.ClearBeforeFill = false;
            this.reportCTHDTableAdapter.Fill(this.qLNH.ReportCTHD, this.batDau, this.ketThuc);
            this.rpvCTHD.RefreshReport();
        }
    }
}
