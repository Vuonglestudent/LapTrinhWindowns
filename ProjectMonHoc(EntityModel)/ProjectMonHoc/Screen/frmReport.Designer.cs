
namespace ProjectMonHoc.Screen
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvCTHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qLNH = new ProjectMonHoc.EntityModel.QLNH();
            this.reportCTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportCTHDTableAdapter = new ProjectMonHoc.EntityModel.QLNHTableAdapters.ReportCTHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportCTHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvCTHD
            // 
            reportDataSource1.Name = "DataSQL";
            reportDataSource1.Value = this.reportCTHDBindingSource;
            this.rpvCTHD.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvCTHD.LocalReport.ReportEmbeddedResource = "ProjectMonHoc.Screen.ReportCTHD.rdlc";
            this.rpvCTHD.Location = new System.Drawing.Point(0, 0);
            this.rpvCTHD.Name = "rpvCTHD";
            this.rpvCTHD.ServerReport.BearerToken = null;
            this.rpvCTHD.Size = new System.Drawing.Size(662, 558);
            this.rpvCTHD.TabIndex = 0;
            // 
            // qLNH
            // 
            this.qLNH.DataSetName = "QLNH";
            this.qLNH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportCTHDBindingSource
            // 
            this.reportCTHDBindingSource.DataMember = "ReportCTHD";
            this.reportCTHDBindingSource.DataSource = this.qLNH;
            // 
            // reportCTHDTableAdapter
            // 
            this.reportCTHDTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 559);
            this.Controls.Add(this.rpvCTHD);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportCTHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvCTHD;
        private System.Windows.Forms.BindingSource reportCTHDBindingSource;
        private EntityModel.QLNH qLNH;
        private EntityModel.QLNHTableAdapters.ReportCTHDTableAdapter reportCTHDTableAdapter;
    }
}