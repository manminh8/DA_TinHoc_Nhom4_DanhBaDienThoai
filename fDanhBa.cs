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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLDanhBa
{
    public partial class fDanhBa : Form
    {
        private CXulyDanhBa xuly;

        private void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xuly.getDanhBa();
            dgvDanhBa.DataSource = bs;
        }
        public fDanhBa()
        {
            InitializeComponent();
            xuly = new CXulyDanhBa();
            //load();

            hienthi();
        }
        void load()
        {
            CDanhBa a = new CDanhBa("0707809288", "Man", "hominhman2004tn@gmail.com", "STU", "SinhVien");
            CDanhBa b = new CDanhBa("0707809288", "Man", "hominhman2004tn@gmail.com", "STU", "SinhVien");
            CDanhBa c = new CDanhBa("0707809288", "Man", "hominhman2004tn@gmail.com", "STU", "SinhVien");
            xuly.them(a); xuly.them(b); xuly.them(c);
        }
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
            if (xuly.saveFileJSON())
            { 
                MessageBox.Show("Luu thanh cong");
            } else { MessageBox.Show("Luu khong thanh cong"); }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            if (xuly.LoadFileJSon())
            {
                MessageBox.Show("Load file thanh cong");
                hienthi();
            }
            else
            {
                MessageBox.Show("Load file khong thanh cong");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDanhBa.SelectedRows.Count > 0)
            {
                CDanhBa selectedDB = (CDanhBa)dgvDanhBa.SelectedRows[0].DataBoundItem;
                xuly.xoa(selectedDB.Sdt);
                hienthi();
            }
            else
            {
                MessageBox.Show("Chọn một dòng để xóa");
            }
        }

        private void btnReFresh_Click(object sender, EventArgs e)
        {
            hienthi();
        }
    }
}
