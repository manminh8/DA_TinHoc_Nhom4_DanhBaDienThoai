namespace QLDanhBa
{
    partial class fThemThanhVienNhom
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
            this.dgvDanhBaTV = new System.Windows.Forms.DataGridView();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencoquan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhBaTV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhBaTV
            // 
            this.dgvDanhBaTV.AllowUserToAddRows = false;
            this.dgvDanhBaTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhBaTV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdt,
            this.ten,
            this.tencoquan,
            this.email,
            this.ghichu});
            this.dgvDanhBaTV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhBaTV.Location = new System.Drawing.Point(0, 208);
            this.dgvDanhBaTV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhBaTV.Name = "dgvDanhBaTV";
            this.dgvDanhBaTV.RowHeadersWidth = 51;
            this.dgvDanhBaTV.RowTemplate.Height = 24;
            this.dgvDanhBaTV.Size = new System.Drawing.Size(504, 242);
            this.dgvDanhBaTV.TabIndex = 1;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(51, 105);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(94, 32);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(309, 105);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 32);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chọn liên hệ để thêm";
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sdt.DataPropertyName = "Sdt";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 95;
            // 
            // ten
            // 
            this.ten.DataPropertyName = "Ten";
            this.ten.HeaderText = "Tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 90;
            // 
            // tencoquan
            // 
            this.tencoquan.DataPropertyName = "Tencoquan";
            this.tencoquan.HeaderText = "Tên cơ quan";
            this.tencoquan.MinimumWidth = 6;
            this.tencoquan.Name = "tencoquan";
            this.tencoquan.Width = 91;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.email.Width = 90;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "Ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.MinimumWidth = 6;
            this.ghichu.Name = "ghichu";
            this.ghichu.Width = 90;
            // 
            // fThemThanhVienNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dgvDanhBaTV);
            this.Name = "fThemThanhVienNhom";
            this.ShowIcon = false;
            this.Text = "Thêm Thành Viên Nhóm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhBaTV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDanhBaTV;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencoquan;
        private System.Windows.Forms.DataGridViewLinkColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}