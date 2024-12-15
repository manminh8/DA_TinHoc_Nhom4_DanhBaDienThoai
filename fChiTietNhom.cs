using Newtonsoft.Json;
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
        private string tenNhomcu;
        CXulyNhom xulyNhom;
        List<CDanhBa> dsDB = new List<CDanhBa>();

        public fChiTietNhom()
        {
            InitializeComponent();
            xulyNhom = new CXulyNhom();

        }

        public void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsDB.ToList();
            dgvChiTietNhom.DataSource = bs;
        }

        public void addDanhBa(CDanhBa danhBa)
        {
            dsDB.Add(danhBa);
        }

        public void loadChiTietNhom(string tennhom)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xulyNhom.layDanhSachDanhBaTrongNhom(tennhom);
            dgvChiTietNhom.DataSource = bs;
            dsDB = xulyNhom.layDanhSachDanhBaTrongNhom(tennhom);
            tenNhomcu = tennhom;
            txtTennhom.Text = tennhom;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            CNhom c = xulyNhom.tim(tenNhomcu);
            if (c.Tennhom == txtTennhom.Text)
            {
                foreach(CDanhBa db in dsDB) 
                    xulyNhom.ThemDanhBaVaoNhom(c.Tennhom, db);
            }
            if (xulyNhom.tim(txtTennhom.Text) == null)
            {
                xulyNhom.taoNhom(txtTennhom.Text);
                foreach (CDanhBa db in dsDB)
                {
                    xulyNhom.ThemDanhBaVaoNhom(txtTennhom.Text, db);
                }
                xulyNhom.XoaNhom(tenNhomcu);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên nhóm bị trùng");
                txtTennhom.Focus();
            }
        }

        private void btnThemThanhVien_Click(object sender, EventArgs e)
        {
            fThemThanhVienNhom frm = new fThemThanhVienNhom();
            frm.Owner = this;
            frm.FormClosed += (s, args) =>
            {
                hienthi();
                this.Show();
            }; this.Hide();
            frm.ShowDialog();
        }
    }
}
