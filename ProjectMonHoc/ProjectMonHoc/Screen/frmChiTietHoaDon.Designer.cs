
namespace ProjectMonHoc.Screen
{
    partial class frmChiTietHoaDon
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
            this.panelBills = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelBills
            // 
            this.panelBills.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBills.AutoScroll = true;
            this.panelBills.Location = new System.Drawing.Point(12, 12);
            this.panelBills.Name = "panelBills";
            this.panelBills.Size = new System.Drawing.Size(561, 732);
            this.panelBills.TabIndex = 0;
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 771);
            this.Controls.Add(this.panelBills);
            this.Name = "frmChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBills;
    }
}