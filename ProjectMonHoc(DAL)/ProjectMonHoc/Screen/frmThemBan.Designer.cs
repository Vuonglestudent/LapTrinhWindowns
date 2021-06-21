
namespace ProjectMonHoc.Screen
{
    partial class frmThemBan
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
            this.txtIDBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.cbSucChua = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.IDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Bàn mới";
            // 
            // txtIDBan
            // 
            this.txtIDBan.Location = new System.Drawing.Point(134, 31);
            this.txtIDBan.Multiline = true;
            this.txtIDBan.Name = "txtIDBan";
            this.txtIDBan.Size = new System.Drawing.Size(149, 24);
            this.txtIDBan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sức chứa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên bàn mới";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(134, 89);
            this.txtTenBan.Multiline = true;
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(149, 24);
            this.txtTenBan.TabIndex = 5;
            // 
            // cbSucChua
            // 
            this.cbSucChua.FormattingEnabled = true;
            this.cbSucChua.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.cbSucChua.Location = new System.Drawing.Point(445, 34);
            this.cbSucChua.Name = "cbSucChua";
            this.cbSucChua.Size = new System.Drawing.Size(121, 21);
            this.cbSucChua.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SpringGreen;
            this.btnThem.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(150, 128);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 42);
            this.btnThem.TabIndex = 78;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(331, 128);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(133, 42);
            this.btnHuy.TabIndex = 81;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvBan
            // 
            this.dgvBan.AllowUserToAddRows = false;
            this.dgvBan.AllowUserToDeleteRows = false;
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBan,
            this.TenBan,
            this.TrangThai,
            this.SucChua});
            this.dgvBan.Location = new System.Drawing.Point(12, 188);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.Size = new System.Drawing.Size(596, 208);
            this.dgvBan.TabIndex = 82;
            // 
            // IDBan
            // 
            this.IDBan.DataPropertyName = "IDBan";
            this.IDBan.HeaderText = "ID Bàn";
            this.IDBan.Name = "IDBan";
            this.IDBan.Width = 140;
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TenBan";
            this.TenBan.HeaderText = "Tên Bàn";
            this.TenBan.Name = "TenBan";
            this.TenBan.Width = 140;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 140;
            // 
            // SucChua
            // 
            this.SucChua.DataPropertyName = "SucChua";
            this.SucChua.HeaderText = "Sức chứa";
            this.SucChua.Name = "SucChua";
            this.SucChua.Width = 140;
            // 
            // frmThemBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 403);
            this.Controls.Add(this.dgvBan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbSucChua);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDBan);
            this.Controls.Add(this.label1);
            this.Name = "frmThemBan";
            this.Text = "frmThemBan";
            this.Load += new System.EventHandler(this.frmThemBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.ComboBox cbSucChua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SucChua;
    }
}