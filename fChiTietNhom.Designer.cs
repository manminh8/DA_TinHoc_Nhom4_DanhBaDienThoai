﻿namespace QLDanhBa
{
    partial class fChiTietNhom
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
            this.txtTennhom = new System.Windows.Forms.TextBox();
            this.btnThemThanhVien = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoaThanhVien = new System.Windows.Forms.Button();
            this.dgvChiTietNhom = new System.Windows.Forms.DataGridView();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencoquan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm";
            // 
            // txtTennhom
            // 
            this.txtTennhom.Location = new System.Drawing.Point(146, 29);
            this.txtTennhom.Name = "txtTennhom";
            this.txtTennhom.Size = new System.Drawing.Size(205, 20);
            this.txtTennhom.TabIndex = 1;
            // 
            // btnThemThanhVien
            // 
            this.btnThemThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThanhVien.Location = new System.Drawing.Point(59, 107);
            this.btnThemThanhVien.Name = "btnThemThanhVien";
            this.btnThemThanhVien.Size = new System.Drawing.Size(133, 35);
            this.btnThemThanhVien.TabIndex = 2;
            this.btnThemThanhVien.Text = "Thêm Thành Viên";
            this.btnThemThanhVien.UseVisualStyleBackColor = true;
            this.btnThemThanhVien.Click += new System.EventHandler(this.btnThemThanhVien_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(290, 190);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 32);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(70, 190);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 32);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoaThanhVien
            // 
            this.btnXoaThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThanhVien.Location = new System.Drawing.Point(268, 107);
            this.btnXoaThanhVien.Name = "btnXoaThanhVien";
            this.btnXoaThanhVien.Size = new System.Drawing.Size(134, 35);
            this.btnXoaThanhVien.TabIndex = 6;
            this.btnXoaThanhVien.Text = "Xóa Thành Viên";
            this.btnXoaThanhVien.UseVisualStyleBackColor = true;
            this.btnXoaThanhVien.Click += new System.EventHandler(this.btnXoaThanhVien_Click);
            // 
            // dgvChiTietNhom
            // 
            this.dgvChiTietNhom.AllowUserToAddRows = false;
            this.dgvChiTietNhom.AllowUserToDeleteRows = false;
            this.dgvChiTietNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdt,
            this.ten,
            this.tencoquan,
            this.email,
            this.ghichu,
            this.DanhSach});
            this.dgvChiTietNhom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChiTietNhom.Location = new System.Drawing.Point(0, 240);
            this.dgvChiTietNhom.Margin = new System.Windows.Forms.Padding(2);
            this.dgvChiTietNhom.MultiSelect = false;
            this.dgvChiTietNhom.Name = "dgvChiTietNhom";
            this.dgvChiTietNhom.RowHeadersWidth = 51;
            this.dgvChiTietNhom.RowTemplate.Height = 24;
            this.dgvChiTietNhom.Size = new System.Drawing.Size(487, 210);
            this.dgvChiTietNhom.TabIndex = 7;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "Sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "Ten";
            this.ten.HeaderText = "Tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 125;
            // 
            // tencoquan
            // 
            this.tencoquan.DataPropertyName = "Tencoquan";
            this.tencoquan.HeaderText = "Tên cơ quan";
            this.tencoquan.MinimumWidth = 6;
            this.tencoquan.Name = "tencoquan";
            this.tencoquan.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.email.Width = 150;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "Ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 350;
            // 
            // DanhSach
            // 
            this.DanhSach.DataPropertyName = "Danhsach";
            this.DanhSach.HeaderText = "Danhsach";
            this.DanhSach.MinimumWidth = 2;
            this.DanhSach.Name = "DanhSach";
            this.DanhSach.Visible = false;
            this.DanhSach.Width = 2;
            // 
            // fChiTietNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.dgvChiTietNhom);
            this.Controls.Add(this.btnXoaThanhVien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemThanhVien);
            this.Controls.Add(this.txtTennhom);
            this.Controls.Add(this.label1);
            this.Name = "fChiTietNhom";
            this.ShowIcon = false;
            this.Text = "Chi Tiết Nhóm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTennhom;
        private System.Windows.Forms.Button btnThemThanhVien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoaThanhVien;
        public System.Windows.Forms.DataGridView dgvChiTietNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencoquan;
        private System.Windows.Forms.DataGridViewLinkColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhSach;
    }
}