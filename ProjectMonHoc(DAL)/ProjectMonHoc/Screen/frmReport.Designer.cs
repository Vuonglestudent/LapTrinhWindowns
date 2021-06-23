
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportCTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNH = new ProjectMonHoc.EntityModel.QLNH();
            this.rpvCTHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportCTHDTableAdapter = new ProjectMonHoc.EntityModel.QLNHTableAdapters.ReportCTHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportCTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNH)).BeginInit();
            this.SuspendLayout();
            // 
            // reportCTHDBindingSource
            // 
            this.reportCTHDBindingSource.DataMember = "ReportCTHD";
            this.reportCTHDBindingSource.DataSource = this.qLNH;
            // 
            // qLNH
            // 
            this.qLNH.DataSetName = "QLNH";
            this.qLNH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvCTHD
            // 
            reportDataSource2.Name = "DataSQL";
            reportDataSource2.Value = this.reportCTHDBindingSource;
            this.rpvCTHD.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvCTHD.LocalReport.ReportEmbeddedResource = "ProjectMonHoc.Screen.ReportCTHD.rdlc";
            this.rpvCTHD.Location = new System.Drawing.Point(2, 3);
            this.rpvCTHD.Name = "rpvCTHD";
            this.rpvCTHD.ServerReport.BearerToken = null;
            this.rpvCTHD.Size = new System.Drawing.Size(662, 558);
            this.rpvCTHD.TabIndex = 1;
            // 
            // reportCTHDTableAdapter
            // 
            this.reportCTHDTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 564);
            this.Controls.Add(this.rpvCTHD);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReport";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportCTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource reportCTHDBindingSource;
        private EntityModel.QLNH qLNH;
        private Microsoft.Reporting.WinForms.ReportViewer rpvCTHD;
        private EntityModel.QLNHTableAdapters.ReportCTHDTableAdapter reportCTHDTableAdapter;
    }
}