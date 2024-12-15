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
    public partial class fChiTietNhom : Form
    {
        CXulyDanhBa xulyDanhBa;
        CXulyNhom xulyNhom;
        public fChiTietNhom()
        {
            InitializeComponent();
            xulyNhom = new CXulyNhom();
            xulyDanhBa = new CXulyDanhBa();

            hienthiChiTiet();
        }

        void hienthiChiTiet()
        {
            BindingSource bs = new BindingSource();
            dgvChiTietNhom.DataSource = bs;
        }

        private void btnThemThanhVien_Click(object sender, EventArgs e)
        {
            fThemThanhVienNhom frm = new fThemThanhVienNhom();
            frm.FormClosed += (s, args) => this.Show();
            this.Hide();
            frm.Show();
        }
    }
}
