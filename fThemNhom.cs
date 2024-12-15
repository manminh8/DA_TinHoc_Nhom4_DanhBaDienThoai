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
    public partial class fThemNhom : Form
    {
        private List<CDanhBa> dsDB = new List<CDanhBa>();
        CXulyNhom xulyNhom;
        public fThemNhom()
        {
            InitializeComponent();
            xulyNhom = new CXulyNhom();
        }
        public void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dsDB.ToList();
            dgvThemNhom.DataSource = bs;
        }
        public void addDanhBa(CDanhBa db)
        {
            dsDB.Add(db);
        }
        private void btnThemThanhVien_Click(object sender, EventArgs e)
        {
            try
            {
                fThemThanhVienNhom frm = new fThemThanhVienNhom();
                frm.Owner = this;
                frm.FormClosed += (s, args) =>
                {
                    hienthi();
                    this.Show();
                };
                this.Hide();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xulyNhom.tim(txtTenNhom.Text) == null)
            {
                if (txtTenNhom.Text == string.Empty)
                {
                    MessageBox.Show("Không được để trống tên nhóm");
                    txtTenNhom.Focus();
                }
                else
                {
                    xulyNhom.taoNhom(txtTenNhom.Text);
                    foreach (CDanhBa db in dsDB)
                    {
                        xulyNhom.ThemDanhBaVaoNhom(txtTenNhom.Text, db);
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Tên nhóm bị trùng");
                txtTenNhom.Focus();
            }
        }
    }
}
