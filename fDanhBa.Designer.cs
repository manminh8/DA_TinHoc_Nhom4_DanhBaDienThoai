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
            this.email = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbTimKiem = new System.Windows.Forms.ComboBox();
            this.danhBạToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtDanhBạToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaXuatDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaThemLienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDanhBaDong = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnChiaSe = new System.Windows.Forms.Button();
            this.btnShowDBYT = new System.Windows.Forms.Button();
            this.btnNhom = new System.Windows.Forms.Button();
            this.btnTuyChon = new System.Windows.Forms.Button();
            this.btnThungRac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhBa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhBa
            // 
            this.dgvDanhBa.AllowUserToAddRows = false;
            this.dgvDanhBa.AllowUserToDeleteRows = false;
            this.dgvDanhBa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhBa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdt,
            this.ten,
            this.tencoquan,
            this.email,
            this.ghichu,
            this.DanhSach});
            resources.ApplyResources(this.dgvDanhBa, "dgvDanhBa");
            this.dgvDanhBa.MultiSelect = false;
            this.dgvDanhBa.Name = "dgvDanhBa";
            this.dgvDanhBa.RowTemplate.Height = 24;
            this.dgvDanhBa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhBa_CellClick);
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "Sdt";
            resources.ApplyResources(this.sdt, "sdt");
            this.sdt.Name = "sdt";
            // 
            // ten
            // 
            this.ten.DataPropertyName = "Ten";
            resources.ApplyResources(this.ten, "ten");
            this.ten.Name = "ten";
            // 
            // tencoquan
            // 
            this.tencoquan.DataPropertyName = "Tencoquan";
            resources.ApplyResources(this.tencoquan, "tencoquan");
            this.tencoquan.Name = "tencoquan";
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            resources.ApplyResources(this.email, "email");
            this.email.Name = "email";
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "Ghichu";
            resources.ApplyResources(this.ghichu, "ghichu");
            this.ghichu.Name = "ghichu";
            // 
            // DanhSach
            // 
            this.DanhSach.DataPropertyName = "Danhsach";
            resources.ApplyResources(this.DanhSach, "DanhSach");
            this.DanhSach.Name = "DanhSach";
            // 
            // lblTimKiem
            // 
            resources.ApplyResources(this.lblTimKiem, "lblTimKiem");
            this.lblTimKiem.Name = "lblTimKiem";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cbbTimKiem
            // 
            resources.ApplyResources(this.cbbTimKiem, "cbbTimKiem");
            this.cbbTimKiem.FormattingEnabled = true;
            this.cbbTimKiem.Items.AddRange(new object[] {
            resources.GetString("cbbTimKiem.Items"),
            resources.GetString("cbbTimKiem.Items1"),
            resources.GetString("cbbTimKiem.Items2"),
            resources.GetString("cbbTimKiem.Items3"),
            resources.GetString("cbbTimKiem.Items4")});
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // danhBạToolStripMenuItem
            // 
            this.danhBạToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtDanhBạToolStripMenuItem,
            this.cmsDanhBaXuatDuLieu,
            this.cmsDanhBaThemLienHe,
            this.cmsDanhBaDong});
            this.danhBạToolStripMenuItem.Name = "danhBạToolStripMenuItem";
            resources.ApplyResources(this.danhBạToolStripMenuItem, "danhBạToolStripMenuItem");
            // 
            // xuấtDanhBạToolStripMenuItem
            // 
            this.xuấtDanhBạToolStripMenuItem.Name = "xuấtDanhBạToolStripMenuItem";
            resources.ApplyResources(this.xuấtDanhBạToolStripMenuItem, "xuấtDanhBạToolStripMenuItem");
            this.xuấtDanhBạToolStripMenuItem.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmsDanhBaXuatDuLieu
            // 
            this.cmsDanhBaXuatDuLieu.Name = "cmsDanhBaXuatDuLieu";
            resources.ApplyResources(this.cmsDanhBaXuatDuLieu, "cmsDanhBaXuatDuLieu");
            this.cmsDanhBaXuatDuLieu.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // cmsDanhBaThemLienHe
            // 
            this.cmsDanhBaThemLienHe.Name = "cmsDanhBaThemLienHe";
            resources.ApplyResources(this.cmsDanhBaThemLienHe, "cmsDanhBaThemLienHe");
            this.cmsDanhBaThemLienHe.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cmsDanhBaDong
            // 
            this.cmsDanhBaDong.Name = "cmsDanhBaDong";
            resources.ApplyResources(this.cmsDanhBaDong, "cmsDanhBaDong");
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            resources.ApplyResources(this.trợGiúpToolStripMenuItem, "trợGiúpToolStripMenuItem");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhBạToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // btnChiaSe
            // 
            resources.ApplyResources(this.btnChiaSe, "btnChiaSe");
            this.btnChiaSe.Image = global::QLDanhBa.Properties.Resources.share;
            this.btnChiaSe.Name = "btnChiaSe";
            this.btnChiaSe.UseVisualStyleBackColor = true;
            this.btnChiaSe.Click += new System.EventHandler(this.btnChiaSe_Click);
            // 
            // btnShowDBYT
            // 
            resources.ApplyResources(this.btnShowDBYT, "btnShowDBYT");
            this.btnShowDBYT.Image = global::QLDanhBa.Properties.Resources.delete;
            this.btnShowDBYT.Name = "btnShowDBYT";
            this.btnShowDBYT.UseVisualStyleBackColor = true;
            this.btnShowDBYT.Click += new System.EventHandler(this.btnShowDBYT_Click);
            // 
            // btnNhom
            // 
            resources.ApplyResources(this.btnNhom, "btnNhom");
            this.btnNhom.Image = global::QLDanhBa.Properties.Resources.people;
            this.btnNhom.Name = "btnNhom";
            this.btnNhom.UseVisualStyleBackColor = true;
            this.btnNhom.Click += new System.EventHandler(this.btnNhom_Click);
            // 
            // btnTuyChon
            // 
            resources.ApplyResources(this.btnTuyChon, "btnTuyChon");
            this.btnTuyChon.Image = global::QLDanhBa.Properties.Resources.option;
            this.btnTuyChon.Name = "btnTuyChon";
            this.btnTuyChon.UseVisualStyleBackColor = true;
            this.btnTuyChon.Click += new System.EventHandler(this.btnTuyChon_Click);
            // 
            // btnThungRac
            // 
            resources.ApplyResources(this.btnThungRac, "btnThungRac");
            this.btnThungRac.Image = global::QLDanhBa.Properties.Resources.delete;
            this.btnThungRac.Name = "btnThungRac";
            this.btnThungRac.UseVisualStyleBackColor = true;
            this.btnThungRac.Click += new System.EventHandler(this.btnThungRac_Click);
            // 
            // fDanhBa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChiaSe);
            this.Controls.Add(this.btnShowDBYT);
            this.Controls.Add(this.btnNhom);
            this.Controls.Add(this.btnTuyChon);
            this.Controls.Add(this.btnThungRac);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cbbTimKiem);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.dgvDanhBa);
            this.Name = "fDanhBa";
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
        private System.Windows.Forms.ComboBox cbbTimKiem;
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
        private System.Windows.Forms.Button btnChiaSe;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencoquan;
        private System.Windows.Forms.DataGridViewLinkColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhSach;
    }
}

