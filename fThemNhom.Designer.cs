﻿namespace QLDanhBa
{
    partial class fThemNhom
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
            this.txtTenNhom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThemNhom = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemThanhVien = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNhom
            // 
            this.txtTenNhom.Location = new System.Drawing.Point(83, 43);
            this.txtTenNhom.Name = "txtTenNhom";
            this.txtTenNhom.Size = new System.Drawing.Size(100, 20);
            this.txtTenNhom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Nhóm";
            // 
            // dgvThemNhom
            // 
            this.dgvThemNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThemNhom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThemNhom.Location = new System.Drawing.Point(0, 219);
            this.dgvThemNhom.Name = "dgvThemNhom";
            this.dgvThemNhom.Size = new System.Drawing.Size(541, 315);
            this.dgvThemNhom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh bạ đã chọn";
            // 
            // btnThemThanhVien
            // 
            this.btnThemThanhVien.Location = new System.Drawing.Point(288, 41);
            this.btnThemThanhVien.Name = "btnThemThanhVien";
            this.btnThemThanhVien.Size = new System.Drawing.Size(118, 23);
            this.btnThemThanhVien.TabIndex = 4;
            this.btnThemThanhVien.Text = "Thêm Thành Viên";
            this.btnThemThanhVien.UseVisualStyleBackColor = true;
            this.btnThemThanhVien.Click += new System.EventHandler(this.btnThemThanhVien_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(250, 140);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(375, 138);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 25);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // fThemNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 534);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemThanhVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvThemNhom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenNhom);
            this.Name = "fThemNhom";
            this.Text = "fThemNhom";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThemNhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNhom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThemNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemThanhVien;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}