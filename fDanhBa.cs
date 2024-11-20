using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLDanhBa
{
    public partial class fDanhBa : Form
    {
        CXulyDanhBa listPB = new CXulyDanhBa();
        public fDanhBa()
        { 
            InitializeComponent();
        }

        private void hienthi(DataGridView dgv, List<CDanhBa> ds)
        { 
            dgv.DataSource = ds.ToList();
        }
        
        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            fAdd formAdd = new fAdd(dgvDanhBa);
            formAdd.ShowDialog();
        }


        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnLuu_Click(object sender, EventArgs e)
        {
            listPB.saveFileJSON();        
        }

    }
}
