
namespace ProjectMonHoc
{
    partial class frmLogin
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
            this.tbxTK = new System.Windows.Forms.TextBox();
            this.tbxMK = new System.Windows.Forms.TextBox();
            this.Loggin = new System.Windows.Forms.GroupBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Loggin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxTK
            // 
            this.tbxTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTK.Location = new System.Drawing.Point(143, 93);
            this.tbxTK.Name = "tbxTK";
            this.tbxTK.Size = new System.Drawing.Size(232, 24);
            this.tbxTK.TabIndex = 1;
            this.tbxTK.Text = "vuong";
            this.tbxTK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMK_KeyDown);
            // 
            // tbxMK
            // 
            this.tbxMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMK.Location = new System.Drawing.Point(143, 155);
            this.tbxMK.Name = "tbxMK";
            this.tbxMK.Size = new System.Drawing.Size(232, 24);
            this.tbxMK.TabIndex = 3;
            this.tbxMK.Text = "admin";
            this.tbxMK.UseSystemPasswordChar = true;
            this.tbxMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMK_KeyDown);
            // 
            // Loggin
            // 
            this.Loggin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Loggin.Controls.Add(this.pictureBox5);
            this.Loggin.Controls.Add(this.pictureBox4);
            this.Loggin.Controls.Add(this.btnDangNhap);
            this.Loggin.Controls.Add(this.tbxMK);
            this.Loggin.Controls.Add(this.tbxTK);
            this.Loggin.Location = new System.Drawing.Point(-12, 262);
            this.Loggin.Name = "Loggin";
            this.Loggin.Size = new System.Drawing.Size(459, 263);
            this.Loggin.TabIndex = 4;
            this.Loggin.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangNhap.Location = new System.Drawing.Point(263, 194);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(151, 47);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjectMonHoc.Properties.Resources.Login_background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(-15, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 305);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProjectMonHoc.Properties.Resources._lock;
            this.pictureBox5.Location = new System.Drawing.Point(75, 141);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 70;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProjectMonHoc.Properties.Resources.Boss_3_512;
            this.pictureBox4.Location = new System.Drawing.Point(75, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 71;
            this.pictureBox4.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Loggin);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Loggin.ResumeLayout(false);
            this.Loggin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxTK;
        private System.Windows.Forms.TextBox tbxMK;
        private System.Windows.Forms.GroupBox Loggin;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}