
namespace ProjectMonHoc.Screen
{
    partial class frmProfile
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.pbAvatar2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnName = new System.Windows.Forms.Panel();
            this.pbOld = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pbAvatar1 = new System.Windows.Forms.PictureBox();
            this.pnPhone = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar2)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar1)).BeginInit();
            this.pnPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.pnPhone);
            this.panel2.Controls.Add(this.dtpNgaySinh);
            this.panel2.Controls.Add(this.pbAvatar2);
            this.panel2.Location = new System.Drawing.Point(-13, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 552);
            this.panel2.TabIndex = 0;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(266, 128);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(235, 29);
            this.dtpNgaySinh.TabIndex = 52;
            // 
            // pbAvatar2
            // 
            this.pbAvatar2.BackColor = System.Drawing.SystemColors.Control;
            this.pbAvatar2.BackgroundImage = global::ProjectMonHoc.Properties.Resources._default;
            this.pbAvatar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatar2.Location = new System.Drawing.Point(38, 3);
            this.pbAvatar2.Name = "pbAvatar2";
            this.pbAvatar2.Size = new System.Drawing.Size(172, 173);
            this.pbAvatar2.TabIndex = 2;
            this.pbAvatar2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjectMonHoc.Properties.Resources.background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pnName);
            this.panel1.Controls.Add(this.pbAvatar1);
            this.panel1.Location = new System.Drawing.Point(-13, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 153);
            this.panel1.TabIndex = 2;
            // 
            // pnName
            // 
            this.pnName.BackColor = System.Drawing.Color.Transparent;
            this.pnName.Controls.Add(this.pbOld);
            this.pnName.Controls.Add(this.txtName);
            this.pnName.Location = new System.Drawing.Point(266, 101);
            this.pnName.Name = "pnName";
            this.pnName.Size = new System.Drawing.Size(235, 34);
            this.pnName.TabIndex = 6;
            this.pnName.Paint += new System.Windows.Forms.PaintEventHandler(this.pnName_Paint);
            // 
            // pbOld
            // 
            this.pbOld.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbOld.BackgroundImage = global::ProjectMonHoc.Properties.Resources.account;
            this.pbOld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOld.Location = new System.Drawing.Point(210, 6);
            this.pbOld.Name = "pbOld";
            this.pbOld.Size = new System.Drawing.Size(21, 22);
            this.pbOld.TabIndex = 4;
            this.pbOld.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(11, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 22);
            this.txtName.TabIndex = 0;
            // 
            // pbAvatar1
            // 
            this.pbAvatar1.BackgroundImage = global::ProjectMonHoc.Properties.Resources._default;
            this.pbAvatar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatar1.Location = new System.Drawing.Point(38, 46);
            this.pbAvatar1.Name = "pbAvatar1";
            this.pbAvatar1.Size = new System.Drawing.Size(172, 173);
            this.pbAvatar1.TabIndex = 1;
            this.pbAvatar1.TabStop = false;
            // 
            // pnPhone
            // 
            this.pnPhone.BackColor = System.Drawing.Color.Transparent;
            this.pnPhone.Controls.Add(this.pictureBox1);
            this.pnPhone.Controls.Add(this.textBox1);
            this.pnPhone.Location = new System.Drawing.Point(266, 203);
            this.pnPhone.Name = "pnPhone";
            this.pnPhone.Size = new System.Drawing.Size(235, 34);
            this.pnPhone.TabIndex = 53;
            this.pnPhone.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPhone_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImage = global::ProjectMonHoc.Properties.Resources.account;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(210, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 0;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfile";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnName.ResumeLayout(false);
            this.pnName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar1)).EndInit();
            this.pnPhone.ResumeLayout(false);
            this.pnPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbAvatar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAvatar1;
        private System.Windows.Forms.Panel pnName;
        private System.Windows.Forms.PictureBox pbOld;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Panel pnPhone;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}