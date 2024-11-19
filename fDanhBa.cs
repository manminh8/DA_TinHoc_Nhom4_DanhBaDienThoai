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
        CXulyDanhBa ListPB = new CXulyDanhBa();
        //bool isClose = true;

        public fDanhBa()
        {
            InitializeComponent();
        }

        private void hienthi(DataGridView dataGridView)
        {
            
            dataGridView.DataSource = ListPB.laydanhsach();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        
            hienthi(dgvDanhBa);
        }
        
        
        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            fAdd formAdd = new fAdd(dgvDanhBa);
            formAdd.Show();
            

        }


        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ListPB.saveFileJSON("danhba.json");        
        }
    }
}
