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
            this.dgvChiTietNhom = new System.Windows.Forms.DataGridView();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoaThanhVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhóm";
            // 
            // txtTennhom
            // 
            this.txtTennhom.Location = new System.Drawing.Point(160, 12);
            this.txtTennhom.Name = "txtTennhom";
            this.txtTennhom.Size = new System.Drawing.Size(205, 20);
            this.txtTennhom.TabIndex = 1;
            // 
            // btnThemThanhVien
            // 
            this.btnThemThanhVien.Location = new System.Drawing.Point(121, 107);
            this.btnThemThanhVien.Name = "btnThemThanhVien";
            this.btnThemThanhVien.Size = new System.Drawing.Size(118, 23);
            this.btnThemThanhVien.TabIndex = 2;
            this.btnThemThanhVien.Text = "Thêm Thành Viên";
            this.btnThemThanhVien.UseVisualStyleBackColor = true;
            this.btnThemThanhVien.Click += new System.EventHandler(this.btnThemThanhVien_Click);
            // 
            // dgvChiTietNhom
            // 
            this.dgvChiTietNhom.AllowUserToAddRows = false;
            this.dgvChiTietNhom.AllowUserToDeleteRows = false;
            this.dgvChiTietNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietNhom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChiTietNhom.Location = new System.Drawing.Point(0, 259);
            this.dgvChiTietNhom.Name = "dgvChiTietNhom";
            this.dgvChiTietNhom.ReadOnly = true;
            this.dgvChiTietNhom.Size = new System.Drawing.Size(487, 191);
            this.dgvChiTietNhom.TabIndex = 3;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(358, 190);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(70, 190);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 25);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoaThanhVien
            // 
            this.btnXoaThanhVien.Location = new System.Drawing.Point(267, 107);
            this.btnXoaThanhVien.Name = "btnXoaThanhVien";
            this.btnXoaThanhVien.Size = new System.Drawing.Size(118, 23);
            this.btnXoaThanhVien.TabIndex = 6;
            this.btnXoaThanhVien.Text = "Xóa Thành Viên";
            this.btnXoaThanhVien.UseVisualStyleBackColor = true;
            this.btnXoaThanhVien.Click += new System.EventHandler(this.btnXoaThanhVien_Click);
            // 
            // fChiTietNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.btnXoaThanhVien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dgvChiTietNhom);
            this.Controls.Add(this.btnThemThanhVien);
            this.Controls.Add(this.txtTennhom);
            this.Controls.Add(this.label1);
            this.Name = "fChiTietNhom";
            this.Text = "fChiTietNhom";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTennhom;
        private System.Windows.Forms.Button btnThemThanhVien;
        private System.Windows.Forms.DataGridView dgvChiTietNhom;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoaThanhVien;
    }
}