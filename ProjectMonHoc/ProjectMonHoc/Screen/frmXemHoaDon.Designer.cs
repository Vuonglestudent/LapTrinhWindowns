
namespace ProjectMonHoc.Screen
{
    partial class frmXemHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpkKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeight = 40;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NhanVien,
            this.NgayLap,
            this.NgayThanhToan,
            this.TongTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(14, 63);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowTemplate.Height = 40;
            this.dgvHoaDon.Size = new System.Drawing.Size(1300, 600);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "IDHoaDon";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NhanVien
            // 
            this.NhanVien.DataPropertyName = "NhanVien";
            this.NhanVien.HeaderText = "Nhân Viên";
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.ReadOnly = true;
            this.NhanVien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NhanVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NgayLap
            // 
            this.NgayLap.DataPropertyName = "NgayLap";
            dataGridViewCellStyle4.Format = "g";
            dataGridViewCellStyle4.NullValue = null;
            this.NgayLap.DefaultCellStyle = dataGridViewCellStyle4;
            this.NgayLap.HeaderText = "Thời gian tạo";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.ReadOnly = true;
            // 
            // NgayThanhToan
            // 
            this.NgayThanhToan.DataPropertyName = "NgayThanhToan";
            this.NgayThanhToan.HeaderText = "Thời gian t.toán";
            this.NgayThanhToan.Name = "NgayThanhToan";
            this.NgayThanhToan.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F);
            this.label1.Location = new System.Drawing.Point(41, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xem các hóa đơn từ ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 16F);
            this.label2.Location = new System.Drawing.Point(443, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "đến ngày :";
            // 
            // dtpkBatDau
            // 
            this.dtpkBatDau.Font = new System.Drawing.Font("Calibri", 16F);
            this.dtpkBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkBatDau.Location = new System.Drawing.Point(299, 16);
            this.dtpkBatDau.Name = "dtpkBatDau";
            this.dtpkBatDau.Size = new System.Drawing.Size(124, 34);
            this.dtpkBatDau.TabIndex = 3;
            this.dtpkBatDau.Value = new System.DateTime(2021, 6, 12, 0, 0, 0, 0);
            this.dtpkBatDau.ValueChanged += new System.EventHandler(this.CapNhatBangHoaDon);
            // 
            // dtpkKetThuc
            // 
            this.dtpkKetThuc.Font = new System.Drawing.Font("Calibri", 16F);
            this.dtpkKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkKetThuc.Location = new System.Drawing.Point(555, 16);
            this.dtpkKetThuc.Name = "dtpkKetThuc";
            this.dtpkKetThuc.Size = new System.Drawing.Size(124, 34);
            this.dtpkKetThuc.TabIndex = 4;
            this.dtpkKetThuc.ValueChanged += new System.EventHandler(this.CapNhatBangHoaDon);
            // 
            // btnSwap
            // 
            this.btnSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwap.FlatAppearance.BorderSize = 0;
            this.btnSwap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwap.Location = new System.Drawing.Point(710, 17);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(37, 33);
            this.btnSwap.TabIndex = 5;
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(764, 17);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(37, 33);
            this.btnReset.TabIndex = 6;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmXemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 677);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.dtpkKetThuc);
            this.Controls.Add(this.dtpkBatDau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHoaDon);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmXemHoaDon";
            this.Text = "frmXemHoaDon";
            this.Load += new System.EventHandler(this.frmXemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkBatDau;
        private System.Windows.Forms.DateTimePicker dtpkKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnReset;
    }
}