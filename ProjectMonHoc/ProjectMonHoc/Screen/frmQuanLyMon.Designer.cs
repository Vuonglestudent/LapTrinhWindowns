
namespace ProjectMonHoc.Screen
{
    partial class frmQuanLyMon
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
            this.cbDanhMucMon = new System.Windows.Forms.ComboBox();
            this.dgvQLMonAn = new System.Windows.Forms.DataGridView();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hinh = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numGiaTien = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDanhMucMon
            // 
            this.cbDanhMucMon.FormattingEnabled = true;
            this.cbDanhMucMon.Location = new System.Drawing.Point(399, 38);
            this.cbDanhMucMon.Name = "cbDanhMucMon";
            this.cbDanhMucMon.Size = new System.Drawing.Size(375, 21);
            this.cbDanhMucMon.TabIndex = 0;
            // 
            // dgvQLMonAn
            // 
            this.dgvQLMonAn.AllowUserToAddRows = false;
            this.dgvQLMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.GiaMon,
            this.Hinh});
            this.dgvQLMonAn.Location = new System.Drawing.Point(399, 74);
            this.dgvQLMonAn.Name = "dgvQLMonAn";
            this.dgvQLMonAn.Size = new System.Drawing.Size(375, 329);
            this.dgvQLMonAn.TabIndex = 1;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            // 
            // GiaMon
            // 
            this.GiaMon.DataPropertyName = "GiaTien";
            this.GiaMon.HeaderText = "Giá Tiền";
            this.GiaMon.Name = "GiaMon";
            this.GiaMon.ReadOnly = true;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "HinhNU";
            this.Hinh.HeaderText = "Hình Món";
            this.Hinh.Name = "Hinh";
            this.Hinh.ReadOnly = true;
            this.Hinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(97, 38);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(179, 20);
            this.txtTenMon.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên món";
            // 
            // numGiaTien
            // 
            this.numGiaTien.Location = new System.Drawing.Point(97, 74);
            this.numGiaTien.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numGiaTien.Name = "numGiaTien";
            this.numGiaTien.Size = new System.Drawing.Size(179, 20);
            this.numGiaTien.TabIndex = 4;
            this.numGiaTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá tiền";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(15, 155);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Text = "Choose File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::ProjectMonHoc.Properties.Resources._default;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(97, 117);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(179, 110);
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(15, 273);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(75, 23);
            this.btnThemMon.TabIndex = 8;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // frmQuanLyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numGiaTien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.dgvQLMonAn);
            this.Controls.Add(this.cbDanhMucMon);
            this.Name = "frmQuanLyMon";
            this.Text = "frmQuanLyMon";
            this.Load += new System.EventHandler(this.frmQuanLyMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDanhMucMon;
        private System.Windows.Forms.DataGridView dgvQLMonAn;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numGiaTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMon;
        private System.Windows.Forms.DataGridViewImageColumn Hinh;
        private System.Windows.Forms.Button btnThemMon;
    }
}