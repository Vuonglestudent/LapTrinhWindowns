
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTK = new System.Windows.Forms.TextBox();
            this.tbxMK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Loggin = new System.Windows.Forms.GroupBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.Loggin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản :";
            // 
            // tbxTK
            // 
            this.tbxTK.Location = new System.Drawing.Point(139, 45);
            this.tbxTK.Name = "tbxTK";
            this.tbxTK.Size = new System.Drawing.Size(232, 31);
            this.tbxTK.TabIndex = 1;
            this.tbxTK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMK_KeyDown);
            // 
            // tbxMK
            // 
            this.tbxMK.Location = new System.Drawing.Point(139, 107);
            this.tbxMK.Name = "tbxMK";
            this.tbxMK.Size = new System.Drawing.Size(232, 31);
            this.tbxMK.TabIndex = 3;
            this.tbxMK.UseSystemPasswordChar = true;
            this.tbxMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxMK_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu :";
            // 
            // Loggin
            // 
            this.Loggin.Controls.Add(this.btnDangNhap);
            this.Loggin.Controls.Add(this.tbxMK);
            this.Loggin.Controls.Add(this.label2);
            this.Loggin.Controls.Add(this.tbxTK);
            this.Loggin.Controls.Add(this.label1);
            this.Loggin.Location = new System.Drawing.Point(12, 12);
            this.Loggin.Name = "Loggin";
            this.Loggin.Size = new System.Drawing.Size(400, 207);
            this.Loggin.TabIndex = 4;
            this.Loggin.TabStop = false;
            this.Loggin.Text = "Login";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(253, 155);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(118, 31);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 229);
            this.Controls.Add(this.Loggin);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Loggin.ResumeLayout(false);
            this.Loggin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTK;
        private System.Windows.Forms.TextBox tbxMK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Loggin;
        private System.Windows.Forms.Button btnDangNhap;
    }
}