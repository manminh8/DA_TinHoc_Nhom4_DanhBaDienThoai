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
    }
}
