namespace QLDanhBa
{
    partial class fNhom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhom));
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhom = new System.Windows.Forms.DataGridView();
            this.ColumnTenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(12, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 39);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm Nhóm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhom
            // 
            this.dgvNhom.AllowUserToAddRows = false;
            this.dgvNhom.AllowUserToDeleteRows = false;
            this.dgvNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTenNhom});
            this.dgvNhom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhom.Location = new System.Drawing.Point(0, 105);
            this.dgvNhom.Name = "dgvNhom";
            this.dgvNhom.Size = new System.Drawing.Size(281, 396);
            this.dgvNhom.TabIndex = 1;
            // 
            // ColumnTenNhom
            // 
            this.ColumnTenNhom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnTenNhom.DataPropertyName = "Tennhom";
            this.ColumnTenNhom.HeaderText = "Tên Nhóm";
            this.ColumnTenNhom.MinimumWidth = 55;
            this.ColumnTenNhom.Name = "ColumnTenNhom";
            this.ColumnTenNhom.Width = 150;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(98, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 39);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa nhóm";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(184, 12);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(80, 39);
            this.btnXemChiTiet.TabIndex = 3;
            this.btnXemChiTiet.Text = "Xem Nhóm";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // fNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 501);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvNhom);
            this.Controls.Add(this.btnThem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fNhom";
            this.Text = "Nhóm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNhom;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenNhom;
        private System.Windows.Forms.Button btnXemChiTiet;
    }
}