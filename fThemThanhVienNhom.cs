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
    public partial class fThemThanhVienNhom : Form
    {
        CXulyDanhBa xulyDB;
        CXulyNhom xulyNhom;

        private fChiTietNhom parentForm1 = new fChiTietNhom();
        private fThemNhom parentForm2 = new fThemNhom();
        public void SetDataGridViewData(DataTable dataTable) {
            dgvDanhBaTV.DataSource = dataTable;
        }
        public fThemThanhVienNhom()
        {
            InitializeComponent();
            xulyDB = new CXulyDanhBa();
            xulyNhom = new CXulyNhom();

            hienthi();
        }

        void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xulyDB.getDanhBa();
            dgvDanhBaTV.DataSource = bs;
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dgvDanhBaTV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvDanhBaTV.SelectedRows)
                {
                    CDanhBa selectedDB = (CDanhBa)row.DataBoundItem;
                    if (this.Owner.GetType() == typeof(fChiTietNhom))
                    {
                        ((fChiTietNhom)this.Owner).addDanhBa(selectedDB);
                    }
                    else if (this.Owner.GetType() == typeof(fThemNhom))
                    {
                        ((fThemNhom)this.Owner).addDanhBa(selectedDB);
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Chọn liên hệ để thêm");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
