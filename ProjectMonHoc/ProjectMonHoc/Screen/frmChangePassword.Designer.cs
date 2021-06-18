
namespace ProjectMonHoc.Screen
{
    partial class frmChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnConfrim = new System.Windows.Forms.Panel();
            this.pbConfrim = new System.Windows.Forms.PictureBox();
            this.txtConfrim = new System.Windows.Forms.TextBox();
            this.pnNew = new System.Windows.Forms.Panel();
            this.pbNew = new System.Windows.Forms.PictureBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.pnOld = new System.Windows.Forms.Panel();
            this.pbOld = new System.Windows.Forms.PictureBox();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnConfrim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfrim)).BeginInit();
            this.pnNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNew)).BeginInit();
            this.pnOld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOld)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ProjectMonHoc.Properties.Resources.background;
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 235);
            this.panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(303, 179);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(79, 33);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(388, 179);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(79, 33);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pnConfrim);
            this.groupBox1.Controls.Add(this.pnNew);
            this.groupBox1.Controls.Add(this.pnOld);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi Mật Khẩu";
            // 
            // pnConfrim
            // 
            this.pnConfrim.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnConfrim.Controls.Add(this.pbConfrim);
            this.pnConfrim.Controls.Add(this.txtConfrim);
            this.pnConfrim.Location = new System.Drawing.Point(183, 106);
            this.pnConfrim.Name = "pnConfrim";
            this.pnConfrim.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.pnConfrim.Size = new System.Drawing.Size(250, 34);
            this.pnConfrim.TabIndex = 6;
            // 
            // pbConfrim
            // 
            this.pbConfrim.BackgroundImage = global::ProjectMonHoc.Properties.Resources.hiddenPass;
            this.pbConfrim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbConfrim.Location = new System.Drawing.Point(225, 6);
            this.pbConfrim.Name = "pbConfrim";
            this.pbConfrim.Size = new System.Drawing.Size(21, 22);
            this.pbConfrim.TabIndex = 4;
            this.pbConfrim.TabStop = false;
            this.pbConfrim.Click += new System.EventHandler(this.pbConfrim_Click);
            // 
            // txtConfrim
            // 
            this.txtConfrim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfrim.Location = new System.Drawing.Point(11, 6);
            this.txtConfrim.Name = "txtConfrim";
            this.txtConfrim.Size = new System.Drawing.Size(208, 22);
            this.txtConfrim.TabIndex = 2;
            this.txtConfrim.UseSystemPasswordChar = true;
            // 
            // pnNew
            // 
            this.pnNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnNew.Controls.Add(this.pbNew);
            this.pnNew.Controls.Add(this.txtNew);
            this.pnNew.Location = new System.Drawing.Point(183, 66);
            this.pnNew.Name = "pnNew";
            this.pnNew.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.pnNew.Size = new System.Drawing.Size(250, 34);
            this.pnNew.TabIndex = 6;
            // 
            // pbNew
            // 
            this.pbNew.BackgroundImage = global::ProjectMonHoc.Properties.Resources.hiddenPass;
            this.pbNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNew.Location = new System.Drawing.Point(225, 6);
            this.pbNew.Name = "pbNew";
            this.pbNew.Size = new System.Drawing.Size(21, 22);
            this.pbNew.TabIndex = 4;
            this.pbNew.TabStop = false;
            this.pbNew.Click += new System.EventHandler(this.pbNew_Click);
            // 
            // txtNew
            // 
            this.txtNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNew.Location = new System.Drawing.Point(11, 6);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(208, 22);
            this.txtNew.TabIndex = 1;
            this.txtNew.UseSystemPasswordChar = true;
            // 
            // pnOld
            // 
            this.pnOld.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnOld.Controls.Add(this.pbOld);
            this.pnOld.Controls.Add(this.txtOld);
            this.pnOld.Location = new System.Drawing.Point(183, 28);
            this.pnOld.Name = "pnOld";
            this.pnOld.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.pnOld.Size = new System.Drawing.Size(250, 34);
            this.pnOld.TabIndex = 5;
            // 
            // pbOld
            // 
            this.pbOld.BackgroundImage = global::ProjectMonHoc.Properties.Resources.hiddenPass;
            this.pbOld.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOld.Location = new System.Drawing.Point(225, 6);
            this.pbOld.Name = "pbOld";
            this.pbOld.Size = new System.Drawing.Size(21, 22);
            this.pbOld.TabIndex = 4;
            this.pbOld.TabStop = false;
            this.pbOld.Click += new System.EventHandler(this.pbOld_Click);
            // 
            // txtOld
            // 
            this.txtOld.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOld.Location = new System.Drawing.Point(11, 6);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(208, 22);
            this.txtOld.TabIndex = 0;
            this.txtOld.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Xác Nhận Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu Mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu Cũ";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 223);
            this.Controls.Add(this.panel1);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnConfrim.ResumeLayout(false);
            this.pnConfrim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfrim)).EndInit();
            this.pnNew.ResumeLayout(false);
            this.pnNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNew)).EndInit();
            this.pnOld.ResumeLayout(false);
            this.pnOld.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Panel pnOld;
        private System.Windows.Forms.PictureBox pbOld;
        private System.Windows.Forms.Panel pnConfrim;
        private System.Windows.Forms.PictureBox pbConfrim;
        private System.Windows.Forms.TextBox txtConfrim;
        private System.Windows.Forms.Panel pnNew;
        private System.Windows.Forms.PictureBox pbNew;
        private System.Windows.Forms.TextBox txtNew;
    }
}