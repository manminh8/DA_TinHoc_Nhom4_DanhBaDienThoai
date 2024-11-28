namespace QLDanhBa
{
    partial class fDanhBa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDanhBa));
            this.dgvDanhBa = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblDanhBaGhiChu = new System.Windows.Forms.Label();
            this.txtDanhBaGhiChu = new System.Windows.Forms.TextBox();
            this.lblDanhBaEmail = new System.Windows.Forms.Label();
            this.txtDanhBaEmail = new System.Windows.Forms.TextBox();
            this.lblDanhBaTenCoQua = new System.Windows.Forms.Label();
            this.txtDanhBaTenCoQuan = new System.Windows.Forms.TextBox();
            this.lblDanhBaTen = new System.Windows.Forms.Label();
            this.txtDanhBaTen = new System.Windows.Forms.TextBox();
            this.lblDanhBaSDT = new System.Windows.Forms.Label();
            this.txtDanhBaSdt = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencoquan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsDanhBaXuatDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaLuuDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaThemLienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaDong = new System.Windows.Forms.ToolStripMenuItem();
            this.danhBạToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhBa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhBa
            // 
            this.dgvDanhBa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhBa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdt,
            this.ten,
            this.tencoquan,
            this.email,
            this.ghichu});
            this.dgvDanhBa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhBa.Location = new System.Drawing.Point(0, 289);
            this.dgvDanhBa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhBa.Name = "dgvDanhBa";
            this.dgvDanhBa.RowHeadersWidth = 51;
            this.dgvDanhBa.RowTemplate.Height = 24;
            this.dgvDanhBa.Size = new System.Drawing.Size(897, 219);
            this.dgvDanhBa.TabIndex = 0;
            this.dgvDanhBa.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhBa_RowEnter);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QLDanhBa.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(408, 151);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 33);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QLDanhBa.Properties.Resources.wrench;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(408, 95);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 33);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(5, 42);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(71, 20);
            this.lblTimKiem.TabIndex = 9;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(169, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 26);
            this.textBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tên",
            "Số điện thoại"});
            this.comboBox1.Location = new System.Drawing.Point(80, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 28);
            this.comboBox1.TabIndex = 11;
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ Giúp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhBạToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblDanhBaGhiChu
            // 
            this.lblDanhBaGhiChu.AutoSize = true;
            this.lblDanhBaGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhBaGhiChu.Location = new System.Drawing.Point(518, 226);
            this.lblDanhBaGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhBaGhiChu.Name = "lblDanhBaGhiChu";
            this.lblDanhBaGhiChu.Size = new System.Drawing.Size(64, 20);
            this.lblDanhBaGhiChu.TabIndex = 20;
            this.lblDanhBaGhiChu.Text = "Ghi chú";
            // 
            // txtDanhBaGhiChu
            // 
            this.txtDanhBaGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanhBaGhiChu.Location = new System.Drawing.Point(622, 226);
            this.txtDanhBaGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtDanhBaGhiChu.Name = "txtDanhBaGhiChu";
            this.txtDanhBaGhiChu.Size = new System.Drawing.Size(264, 26);
            this.txtDanhBaGhiChu.TabIndex = 19;
            // 
            // lblDanhBaEmail
            // 
            this.lblDanhBaEmail.AutoSize = true;
            this.lblDanhBaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhBaEmail.Location = new System.Drawing.Point(518, 164);
            this.lblDanhBaEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhBaEmail.Name = "lblDanhBaEmail";
            this.lblDanhBaEmail.Size = new System.Drawing.Size(48, 20);
            this.lblDanhBaEmail.TabIndex = 18;
            this.lblDanhBaEmail.Text = "Email";
            // 
            // txtDanhBaEmail
            // 
            this.txtDanhBaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanhBaEmail.Location = new System.Drawing.Point(622, 164);
            this.txtDanhBaEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtDanhBaEmail.Name = "txtDanhBaEmail";
            this.txtDanhBaEmail.Size = new System.Drawing.Size(264, 26);
            this.txtDanhBaEmail.TabIndex = 17;
            // 
            // lblDanhBaTenCoQua
            // 
            this.lblDanhBaTenCoQua.AutoSize = true;
            this.lblDanhBaTenCoQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhBaTenCoQua.Location = new System.Drawing.Point(518, 101);
            this.lblDanhBaTenCoQua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhBaTenCoQua.Name = "lblDanhBaTenCoQua";
            this.lblDanhBaTenCoQua.Size = new System.Drawing.Size(97, 20);
            this.lblDanhBaTenCoQua.TabIndex = 16;
            this.lblDanhBaTenCoQua.Text = "Tên cơ quan";
            // 
            // txtDanhBaTenCoQuan
            // 
            this.txtDanhBaTenCoQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanhBaTenCoQuan.Location = new System.Drawing.Point(622, 101);
            this.txtDanhBaTenCoQuan.Margin = new System.Windows.Forms.Padding(2);
            this.txtDanhBaTenCoQuan.Name = "txtDanhBaTenCoQuan";
            this.txtDanhBaTenCoQuan.Size = new System.Drawing.Size(264, 26);
            this.txtDanhBaTenCoQuan.TabIndex = 15;
            // 
            // lblDanhBaTen
            // 
            this.lblDanhBaTen.AutoSize = true;
            this.lblDanhBaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhBaTen.Location = new System.Drawing.Point(518, 42);
            this.lblDanhBaTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhBaTen.Name = "lblDanhBaTen";
            this.lblDanhBaTen.Size = new System.Drawing.Size(36, 20);
            this.lblDanhBaTen.TabIndex = 14;
            this.lblDanhBaTen.Text = "Tên";
            // 
            // txtDanhBaTen
            // 
            this.txtDanhBaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanhBaTen.Location = new System.Drawing.Point(622, 42);
            this.txtDanhBaTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtDanhBaTen.Name = "txtDanhBaTen";
            this.txtDanhBaTen.Size = new System.Drawing.Size(264, 26);
            this.txtDanhBaTen.TabIndex = 13;
            // 
            // lblDanhBaSDT
            // 
            this.lblDanhBaSDT.AutoSize = true;
            this.lblDanhBaSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhBaSDT.Location = new System.Drawing.Point(5, 144);
            this.lblDanhBaSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDanhBaSDT.Name = "lblDanhBaSDT";
            this.lblDanhBaSDT.Size = new System.Drawing.Size(102, 20);
            this.lblDanhBaSDT.TabIndex = 22;
            this.lblDanhBaSDT.Text = "Số điện thoại";
            // 
            // txtDanhBaSdt
            // 
            this.txtDanhBaSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanhBaSdt.Location = new System.Drawing.Point(123, 138);
            this.txtDanhBaSdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtDanhBaSdt.Name = "txtDanhBaSdt";
            this.txtDanhBaSdt.Size = new System.Drawing.Size(264, 26);
            this.txtDanhBaSdt.TabIndex = 21;
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
            // cmsDanhBaXuatDuLieu
            // 
            this.cmsDanhBaXuatDuLieu.Name = "cmsDanhBaXuatDuLieu";
            this.cmsDanhBaXuatDuLieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.cmsDanhBaXuatDuLieu.Size = new System.Drawing.Size(184, 22);
            this.cmsDanhBaXuatDuLieu.Text = "Xuất Dữ Liệu";
            this.cmsDanhBaXuatDuLieu.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // cmsDanhBaLuuDuLieu
            // 
            this.cmsDanhBaLuuDuLieu.Name = "cmsDanhBaLuuDuLieu";
            this.cmsDanhBaLuuDuLieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.cmsDanhBaLuuDuLieu.Size = new System.Drawing.Size(184, 22);
            this.cmsDanhBaLuuDuLieu.Text = "Lưu Dữ Liệu";
            this.cmsDanhBaLuuDuLieu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmsDanhBaThemLienHe
            // 
            this.cmsDanhBaThemLienHe.Name = "cmsDanhBaThemLienHe";
            this.cmsDanhBaThemLienHe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.cmsDanhBaThemLienHe.Size = new System.Drawing.Size(184, 22);
            this.cmsDanhBaThemLienHe.Text = "Thêm liên hệ";
            this.cmsDanhBaThemLienHe.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmsDanhBaDong
            // 
            this.cmsDanhBaDong.Name = "cmsDanhBaDong";
            this.cmsDanhBaDong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.cmsDanhBaDong.Size = new System.Drawing.Size(184, 22);
            this.cmsDanhBaDong.Text = "Đóng";
            // 
            // danhBạToolStripMenuItem
            // 
            this.danhBạToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsDanhBaXuatDuLieu,
            this.cmsDanhBaLuuDuLieu,
            this.cmsDanhBaThemLienHe,
            this.cmsDanhBaDong});
            this.danhBạToolStripMenuItem.Name = "danhBạToolStripMenuItem";
            this.danhBạToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.danhBạToolStripMenuItem.Text = "Danh Bạ";
            // 
            // fDanhBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 508);
            this.Controls.Add(this.lblDanhBaSDT);
            this.Controls.Add(this.txtDanhBaSdt);
            this.Controls.Add(this.lblDanhBaGhiChu);
            this.Controls.Add(this.txtDanhBaGhiChu);
            this.Controls.Add(this.lblDanhBaEmail);
            this.Controls.Add(this.txtDanhBaEmail);
            this.Controls.Add(this.lblDanhBaTenCoQua);
            this.Controls.Add(this.txtDanhBaTenCoQuan);
            this.Controls.Add(this.lblDanhBaTen);
            this.Controls.Add(this.txtDanhBaTen);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvDanhBa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fDanhBa";
            this.Text = "Danh Bạ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhBa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.DataGridView dgvDanhBa;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblDanhBaGhiChu;
        private System.Windows.Forms.TextBox txtDanhBaGhiChu;
        private System.Windows.Forms.Label lblDanhBaEmail;
        private System.Windows.Forms.TextBox txtDanhBaEmail;
        private System.Windows.Forms.Label lblDanhBaTenCoQua;
        private System.Windows.Forms.TextBox txtDanhBaTenCoQuan;
        private System.Windows.Forms.Label lblDanhBaTen;
        private System.Windows.Forms.TextBox txtDanhBaTen;
        private System.Windows.Forms.Label lblDanhBaSDT;
        private System.Windows.Forms.TextBox txtDanhBaSdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencoquan;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.ToolStripMenuItem danhBạToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsDanhBaXuatDuLieu;
        private System.Windows.Forms.ToolStripMenuItem cmsDanhBaLuuDuLieu;
        private System.Windows.Forms.ToolStripMenuItem cmsDanhBaThemLienHe;
        private System.Windows.Forms.ToolStripMenuItem cmsDanhBaDong;
    }
}

