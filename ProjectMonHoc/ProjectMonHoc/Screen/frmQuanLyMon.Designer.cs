
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDanhMucMon
            // 
            this.cbDanhMucMon.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMucMon.FormattingEnabled = true;
            this.cbDanhMucMon.Location = new System.Drawing.Point(692, 34);
            this.cbDanhMucMon.Margin = new System.Windows.Forms.Padding(5);
            this.cbDanhMucMon.MinimumSize = new System.Drawing.Size(240, 0);
            this.cbDanhMucMon.Name = "cbDanhMucMon";
            this.cbDanhMucMon.Size = new System.Drawing.Size(240, 34);
            this.cbDanhMucMon.TabIndex = 0;
            // 
            // dgvQLMonAn
            // 
            this.dgvQLMonAn.AllowUserToAddRows = false;
            this.dgvQLMonAn.AllowUserToDeleteRows = false;
            this.dgvQLMonAn.AllowUserToResizeColumns = false;
            this.dgvQLMonAn.AllowUserToResizeRows = false;
            this.dgvQLMonAn.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLMonAn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvQLMonAn.ColumnHeadersHeight = 45;
            this.dgvQLMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvQLMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenMon,
            this.GiaMon,
            this.Hinh});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLMonAn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLMonAn.GridColor = System.Drawing.Color.White;
            this.dgvQLMonAn.Location = new System.Drawing.Point(26, 99);
            this.dgvQLMonAn.Margin = new System.Windows.Forms.Padding(5);
            this.dgvQLMonAn.Name = "dgvQLMonAn";
            this.dgvQLMonAn.RowHeadersVisible = false;
            this.dgvQLMonAn.RowTemplate.Height = 303;
            this.dgvQLMonAn.Size = new System.Drawing.Size(906, 644);
            this.dgvQLMonAn.TabIndex = 1;
            this.dgvQLMonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLMonAn_CellClick);
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            this.TenMon.Width = 436;
            // 
            // GiaMon
            // 
            this.GiaMon.DataPropertyName = "GiaTien";
            this.GiaMon.HeaderText = "Giá Tiền";
            this.GiaMon.Name = "GiaMon";
            this.GiaMon.ReadOnly = true;
            this.GiaMon.Width = 250;
            // 
            // Hinh
            // 
            this.Hinh.DataPropertyName = "HinhNU";
            this.Hinh.HeaderText = "Hình Món";
            this.Hinh.Name = "Hinh";
            this.Hinh.ReadOnly = true;
            this.Hinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Hinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Hinh.Width = 200;
            // 
            // txtTenMon
            // 
            this.txtTenMon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenMon.Font = new System.Drawing.Font("Calibri", 16F);
            this.txtTenMon.Location = new System.Drawing.Point(176, 62);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(296, 27);
            this.txtTenMon.TabIndex = 2;
            this.txtTenMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên món";
            // 
            // numGiaTien
            // 
            this.numGiaTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numGiaTien.Font = new System.Drawing.Font("Calibri", 16F);
            this.numGiaTien.Location = new System.Drawing.Point(176, 136);
            this.numGiaTien.Margin = new System.Windows.Forms.Padding(5);
            this.numGiaTien.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numGiaTien.Name = "numGiaTien";
            this.numGiaTien.Size = new System.Drawing.Size(298, 30);
            this.numGiaTien.TabIndex = 4;
            this.numGiaTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá tiền";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnSelectFile.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.Location = new System.Drawing.Point(261, 542);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(133, 42);
            this.btnSelectFile.TabIndex = 6;
            this.btnSelectFile.Text = "Choose File";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::ProjectMonHoc.Properties.Resources._default;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(174, 264);
            this.pbImage.Margin = new System.Windows.Forms.Padding(5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(298, 268);
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.SpringGreen;
            this.btnThemMon.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Location = new System.Drawing.Point(51, 755);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(133, 42);
            this.btnThemMon.TabIndex = 8;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hình ảnh :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pbImage);
            this.groupBox1.Controls.Add(this.btnSelectFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numGiaTien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 636);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.Tomato;
            this.btnXoaMon.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.Location = new System.Drawing.Point(234, 755);
            this.btnXoaMon.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(133, 42);
            this.btnXoaMon.TabIndex = 11;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSuaMon.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMon.Location = new System.Drawing.Point(415, 755);
            this.btnSuaMon.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(133, 42);
            this.btnSuaMon.TabIndex = 12;
            this.btnSuaMon.Text = "Sửa";
            this.btnSuaMon.UseVisualStyleBackColor = false;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvQLMonAn);
            this.groupBox2.Controls.Add(this.cbDanhMucMon);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(617, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(955, 767);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // frmQuanLyMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 813);
            this.Controls.Add(this.btnSuaMon);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmQuanLyMon";
            this.Text = "frmQuanLyMon";
            this.Load += new System.EventHandler(this.frmQuanLyMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGiaTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMon;
        private System.Windows.Forms.DataGridViewImageColumn Hinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}