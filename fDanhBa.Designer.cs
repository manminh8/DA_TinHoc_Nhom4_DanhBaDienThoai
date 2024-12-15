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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.danhBạToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhBạToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaXuatDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaThemLienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaDong = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnTuyChon = new System.Windows.Forms.Button();
            this.btnThungRac = new System.Windows.Forms.Button();
            this.btnNhom = new System.Windows.Forms.Button();
            this.btnShowDBYT = new System.Windows.Forms.Button();
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
            this.dgvDanhBa.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhBa.Name = "dgvDanhBa";
            this.dgvDanhBa.RowHeadersWidth = 51;
            this.dgvDanhBa.RowTemplate.Height = 24;
            this.dgvDanhBa.Size = new System.Drawing.Size(712, 242);
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
            this.lblTimKiem.Location = new System.Drawing.Point(115, 53);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(71, 20);
            this.lblTimKiem.TabIndex = 9;
            this.lblTimKiem.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(322, 46);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(265, 26);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tên",
            "Số điện thoại",
            "Tên cơ quan"});
            this.comboBox1.Location = new System.Drawing.Point(193, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 28);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // danhBạToolStripMenuItem
            // 
            this.danhBạToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtDanhBạToolStripMenuItem,
            this.cmsDanhBaXuatDuLieu,
            this.cmsDanhBaThemLienHe,
            this.cmsDanhBaDong});
            this.danhBạToolStripMenuItem.Name = "danhBạToolStripMenuItem";
            this.danhBạToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.danhBạToolStripMenuItem.Text = "Danh Bạ";
            // 
            // xuấtDanhBạToolStripMenuItem
            // 
            this.xuấtDanhBạToolStripMenuItem.Name = "xuấtDanhBạToolStripMenuItem";
            this.xuấtDanhBạToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.xuấtDanhBạToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.xuấtDanhBạToolStripMenuItem.Text = "Lưu danh bạ";
            this.xuấtDanhBạToolStripMenuItem.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmsDanhBaXuatDuLieu
            // 
            this.cmsDanhBaXuatDuLieu.Name = "cmsDanhBaXuatDuLieu";
            this.cmsDanhBaXuatDuLieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.cmsDanhBaXuatDuLieu.Size = new System.Drawing.Size(187, 22);
            this.cmsDanhBaXuatDuLieu.Text = "Xuất danh bạ";
            this.cmsDanhBaXuatDuLieu.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // cmsDanhBaThemLienHe
            // 
            this.cmsDanhBaThemLienHe.Name = "cmsDanhBaThemLienHe";
            this.cmsDanhBaThemLienHe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.cmsDanhBaThemLienHe.Size = new System.Drawing.Size(187, 22);
            this.cmsDanhBaThemLienHe.Text = "Thêm liên hệ";
            this.cmsDanhBaThemLienHe.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmsDanhBaDong
            // 
            this.cmsDanhBaDong.Name = "cmsDanhBaDong";
            this.cmsDanhBaDong.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.cmsDanhBaDong.Size = new System.Drawing.Size(187, 22);
            this.cmsDanhBaDong.Text = "Đóng";
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
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnTuyChon
            // 
            this.btnTuyChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuyChon.Image = global::QLDanhBa.Properties.Resources.option;
            this.btnTuyChon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTuyChon.Location = new System.Drawing.Point(537, 107);
            this.btnTuyChon.Margin = new System.Windows.Forms.Padding(2);
            this.btnTuyChon.Name = "btnTuyChon";
            this.btnTuyChon.Size = new System.Drawing.Size(124, 35);
            this.btnTuyChon.TabIndex = 14;
            this.btnTuyChon.Text = "Tùy chọn";
            this.btnTuyChon.UseVisualStyleBackColor = true;
            this.btnTuyChon.Click += new System.EventHandler(this.btnTuyChon_Click);
            // 
            // btnThungRac
            // 
            this.btnThungRac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThungRac.Image = global::QLDanhBa.Properties.Resources.delete;
            this.btnThungRac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThungRac.Location = new System.Drawing.Point(374, 107);
            this.btnThungRac.Margin = new System.Windows.Forms.Padding(2);
            this.btnThungRac.Name = "btnThungRac";
            this.btnThungRac.Size = new System.Drawing.Size(124, 35);
            this.btnThungRac.TabIndex = 13;
            this.btnThungRac.Text = "Thùng rác";
            this.btnThungRac.UseVisualStyleBackColor = true;
            this.btnThungRac.Click += new System.EventHandler(this.btnThungRac_Click);
            // 
            // btnNhom
            // 
            this.btnNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhom.Location = new System.Drawing.Point(206, 107);
            this.btnNhom.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhom.Name = "btnNhom";
            this.btnNhom.Size = new System.Drawing.Size(124, 35);
            this.btnNhom.TabIndex = 15;
            this.btnNhom.Text = "Nhóm";
            this.btnNhom.UseVisualStyleBackColor = true;
            this.btnNhom.Click += new System.EventHandler(this.btnNhom_Click);
            // 
            // btnShowDBYT
            // 
            this.btnShowDBYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDBYT.Image = global::QLDanhBa.Properties.Resources.delete;
            this.btnShowDBYT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowDBYT.Location = new System.Drawing.Point(34, 109);
            this.btnShowDBYT.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowDBYT.Name = "btnShowDBYT";
            this.btnShowDBYT.Size = new System.Drawing.Size(124, 33);
            this.btnShowDBYT.TabIndex = 16;
            this.btnShowDBYT.Text = "Danh bạ yêu thích";
            this.btnShowDBYT.UseVisualStyleBackColor = true;
            // 
            // fDanhBa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 409);
            this.Controls.Add(this.btnShowDBYT);
            this.Controls.Add(this.btnNhom);
            this.Controls.Add(this.btnTuyChon);
            this.Controls.Add(this.btnThungRac);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.dgvDanhBa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fDanhBa";
            this.Text = "Danh Bạ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fDanhBa_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhBa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvDanhBa;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencoquan;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.ToolStripMenuItem danhBạToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsDanhBaXuatDuLieu;
        private System.Windows.Forms.ToolStripMenuItem cmsDanhBaThemLienHe;
        private System.Windows.Forms.ToolStripMenuItem cmsDanhBaDong;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xuấtDanhBạToolStripMenuItem;
        private System.Windows.Forms.Button btnThungRac;
        private System.Windows.Forms.Button btnTuyChon;
        private System.Windows.Forms.Button btnNhom;
        private System.Windows.Forms.Button btnShowDBYT;
    }
}

