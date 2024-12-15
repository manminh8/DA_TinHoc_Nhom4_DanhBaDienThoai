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
    public partial class fNhom : Form
    {
        CXulyNhom xulyNhom;
        public fNhom()
        {
            InitializeComponent();
            xulyNhom = new CXulyNhom();

            hienthiNhom();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            fChiTietNhom frm = new fChiTietNhom();
            frm.FormClosed += (s, args) => this.Show();
            this.Hide();
            frm.ShowDialog();
        }

        void hienthiNhom()
        {
            dgvNhom.DataSource = xulyNhom.getDSNhom();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
