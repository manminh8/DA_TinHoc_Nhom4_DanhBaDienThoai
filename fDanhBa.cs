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
       CXulyDanhBa xuly = new CXulyDanhBa();
        
        private void hienthi()
        {
            dgvDanhBa.DataSource = xuly.getDanhBa().ToList();
        }
        public fDanhBa()
        { 
            InitializeComponent();
            //load();
            hienthi();
        }
        //void load()
        //{
        //    CDanhBa a = new CDanhBa("0707809288", "Man", "hominhman2004tn@gmail.com", "STU", "SinhVien");
        //    CDanhBa b = new CDanhBa("0707809288", "Man", "hominhman2004tn@gmail.com", "STU", "SinhVien");
        //    CDanhBa c = new CDanhBa("0707809288", "Man", "hominhman2004tn@gmail.com", "STU", "SinhVien");
        //    xuly.them(a);xuly.them(b);xuly.them(c);
        //}          
        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {         
            fAdd formAdd = new fAdd();                   
            formAdd.ShowDialog(); 
            hienthi();
        }


        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btnLuu_Click(object sender, EventArgs e)
        {
            xuly.saveFileJSON();        
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            xuly.LoadFileJSon();
            dgvDanhBa.DataSource=xuly.getDanhBa();
            hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          
                           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
