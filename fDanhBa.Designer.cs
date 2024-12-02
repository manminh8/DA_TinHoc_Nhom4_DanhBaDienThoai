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
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencoquan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.danhBạToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaXuatDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaLuuDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaThemLienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaDong = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnReFresh = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhBa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhBa
            // 
            this.dgvDanhBa.AllowUserToAddRows = false;
            this.dgvDanhBa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhBa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdt,
            this.ten,
            this.tencoquan,
            this.email,
            this.ghichu});
            this.dgvDanhBa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhBa.Location = new System.Drawing.Point(0, 167);
            this.dgvDanhBa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDanhBa.Name = "dgvDanhBa";
            this.dgvDanhBa.RowHeadersWidth = 51;
            this.dgvDanhBa.RowTemplate.Height = 24;
            this.dgvDanhBa.Size = new System.Drawing.Size(729, 242);
            this.dgvDanhBa.TabIndex = 0;
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
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(9, 47);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(71, 20);
            this.lblTimKiem.TabIndex = 9;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(233, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 26);
            this.textBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tên",
            "Số điện thoại"});
            this.comboBox1.Location = new System.Drawing.Point(87, 40);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 28);
            this.comboBox1.TabIndex = 11;
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
            this.cmsDanhBaDong.Click += new System.EventHandler(this.cmsDanhBaDong_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(729, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnReFresh
            // 
            this.btnReFresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReFresh.Image = global::QLDanhBa.Properties.Resources.restart;
            this.btnReFresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReFresh.Location = new System.Drawing.Point(359, 104);
            this.btnReFresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnReFresh.Name = "btnReFresh";
            this.btnReFresh.Size = new System.Drawing.Size(112, 33);
            this.btnReFresh.TabIndex = 23;
            this.btnReFresh.Text = "Làm mới";
            this.btnReFresh.UseVisualStyleBackColor = true;
            this.btnReFresh.Click += new System.EventHandler(this.btnReFresh_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QLDanhBa.Properties.Resources.wrench;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(43, 104);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(96, 33);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QLDanhBa.Properties.Resources.delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(191, 104);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(96, 33);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fDanhBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 409);
            this.Controls.Add(this.btnReFresh);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvDanhBa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnReFresh;
    }
}

