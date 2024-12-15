using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace QLDanhBa
{
    public partial class fNhom : Form
    {
        CXulyNhom xulyNhom;
        public fNhom()
        {
            InitializeComponent();
            xulyNhom = new CXulyNhom();

            hienthiNhom();
        }
        public void hienthiNhom()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xulyNhom.getDSNhom();
            dgvNhom.DataSource = bs;
        }
        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            fThemNhom fTN = new fThemNhom();
            fTN.FormClosed += (s, args) =>
            {
                hienthiNhom();
                this.Show();
            };
            this.Hide();
            fTN.ShowDialog();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhom.SelectedRows.Count > 0)
            {
                CNhom nhom = (CNhom)dgvNhom.SelectedRows[0].DataBoundItem;
                string tennhom = nhom.Tennhom;
                if (xulyNhom.XoaNhom(tennhom))
                {
                    hienthiNhom();
                }
            }
            else
            {
                MessageBox.Show("Chọn một nhóm để xóa");
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvNhom.SelectedRows.Count > 0)
            {

                CNhom nhom = (CNhom)dgvNhom.SelectedRows[0].DataBoundItem;
                string tennhom = nhom.Tennhom;

                fChiTietNhom fCTN = new fChiTietNhom();
                fCTN.loadChiTietNhom(tennhom);
                fCTN.FormClosed += (s, args) =>
                {
                    hienthiNhom();
                    this.Show();
                };
                this.Hide();
                fCTN.ShowDialog();
            }
        }
        public void xoaDong()
        {
          BindingSource bs=(BindingSource)dgvNhom.DataSource;
            bs.RemoveCurrent();
        }
        private void dgvNhom_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {          
            foreach (DataGridViewRow row in dgvNhom.Rows)
            {
                if (string.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Không Thể Để Trống Tên Nhóm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);                
                }
                xoaDong();
            }
        }
    }
    #endregion
}
