using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDanhBa
{
    public partial class fThungRac : Form
    {
        private CXulyRac xulyRac;
        private CXulyDanhBa xulyDB;
        public fThungRac()
        {
            InitializeComponent();
            xulyRac = new CXulyRac();
            xulyDB = new CXulyDanhBa();
            hienthi();
        }

        private void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xulyRac.getDSRac();
            dgvThungRac.DataSource= bs;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvThungRac.SelectedRows.Count > 0)
            {
                CDanhBa selectedItem = (CDanhBa)dgvThungRac.SelectedRows[0].DataBoundItem;
                xulyRac.xoa(selectedItem.Sdt);
                MessageBox.Show("Liên hệ đã được xóa");
                hienthi();
            }
            else
            {
                MessageBox.Show("Chọn một liên hệ để xóa");
            }
        }

        private void fThungRac_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if(dgvThungRac.SelectedRows.Count> 0)
            {
                CDanhBa selectedItem = (CDanhBa)dgvThungRac.SelectedRows[0].DataBoundItem;
                xulyDB.them(selectedItem);
                xulyRac.xoa(selectedItem.Sdt);
                MessageBox.Show("Đã khôi phục liên hệ");
                hienthi();
            }
            else
            {
                MessageBox.Show("Chọn một liên hệ để khôi phục");
            }
        }
    }
}
