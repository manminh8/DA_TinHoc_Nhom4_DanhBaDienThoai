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
            //load();
            //hienthi();
        }

        private void hienthi()
        { 
            dgvDanhBa.DataSource = listPB.laydanhsach;
        }

        //private void load()
        //{
        //    CDanhBa a = new CDanhBa("0707809288", "Man", "hominhman", "STU", "Sinh vien");
        //    CDanhBa b = new CDanhBa("0707809222", "Minh", "hominhman", "STU", "Sinh vien");
        //    CDanhBa c = new CDanhBa("0707809233", "Manh", "hominhman", "STU", "Sinh vien");
        //    listPB.them(a); listPB.them(b); listPB.them(c);
        //}

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

        private void IFile_Click(object sender, EventArgs e)
        {
            listPB.LoadFileJSon();
            dgvDanhBa.DataSource = listPB.laydanhsach;
            hienthi();
        }
    }
}
