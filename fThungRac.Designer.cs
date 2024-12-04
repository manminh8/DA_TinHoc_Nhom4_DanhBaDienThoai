namespace QLDanhBa
{
    partial class fThungRac
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
            this.dgvThungRac = new System.Windows.Forms.DataGridView();
            this.btnKhoiPhuc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThungRac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThungRac
            // 
            this.dgvThungRac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThungRac.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvThungRac.Location = new System.Drawing.Point(0, 0);
            this.dgvThungRac.Name = "dgvThungRac";
            this.dgvThungRac.Size = new System.Drawing.Size(800, 313);
            this.dgvThungRac.TabIndex = 0;
            // 
            // btnKhoiPhuc
            // 
            this.btnKhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoiPhuc.Location = new System.Drawing.Point(243, 385);
            this.btnKhoiPhuc.Name = "btnKhoiPhuc";
            this.btnKhoiPhuc.Size = new System.Drawing.Size(103, 33);
            this.btnKhoiPhuc.TabIndex = 1;
            this.btnKhoiPhuc.Text = "Khôi phục";
            this.btnKhoiPhuc.UseVisualStyleBackColor = true;
            this.btnKhoiPhuc.Click += new System.EventHandler(this.btnKhoiPhuc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(493, 385);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 33);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fThungRac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnKhoiPhuc);
            this.Controls.Add(this.dgvThungRac);
            this.Name = "fThungRac";
            this.Text = "fThungRac";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fThungRac_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThungRac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThungRac;
        private System.Windows.Forms.Button btnKhoiPhuc;
        private System.Windows.Forms.Button btnXoa;
    }
}