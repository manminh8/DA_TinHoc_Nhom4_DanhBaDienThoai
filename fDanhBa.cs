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
        private CXulyDanhBa xulyDB;
        private CXulyRac xulyRac;

        private void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xulyDB.getDanhBa();
            dgvDanhBa.DataSource = bs;
        }
        public fDanhBa()
        {
            InitializeComponent();
            xulyDB = new CXulyDanhBa();
            xulyRac = new CXulyRac();
            xulyDB.autoLoad();
            hienthi();
        }
      
        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            fAdd formAdd = new fAdd();
            formAdd.ShowDialog();
            xulyDB.autoSave();
            hienthi();
        }



       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xulyDB.saveFileJSON(xulyDB.getDanhBa()))
            {
                MessageBox.Show("Lưu Dữ Liệu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Không Thể Luu Được Dữ Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            if (xulyDB.LoadFileJSon())
            {
                MessageBox.Show("Đã Tải Dữ Liệu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienthi();
            }
            else
            {
                MessageBox.Show("Đã Tải Dữ Liệu Không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhBa.SelectedRows.Count > 0)
            {
                CDanhBa selectedDB=(CDanhBa)dgvDanhBa.SelectedRows[0].DataBoundItem;
                this.Hide();
                fSua frmSua = new fSua();
                frmSua.hienThiThongTin(selectedDB);
                if(frmSua.ShowDialog() == DialogResult.OK)
                {
                    xulyDB.sua(selectedDB);
                    hienthi();
                }               
            }
            else
            {
                MessageBox.Show("Chọn Một Dòng Để Sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvDanhBa.SelectedRows.Count > 0)
            {
                CDanhBa selectedDB = (CDanhBa)dgvDanhBa.SelectedRows[0].DataBoundItem;
                xulyRac.them(selectedDB);
                xulyDB.xoa(selectedDB.Sdt);
                hienthi();
            }
            else
            {
                MessageBox.Show("Chọn Một Dòng Để Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReFresh_Click(object sender, EventArgs e)
        {
            hienthi();
        }


        #endregion

        private void fDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThungRac_Click(object sender, EventArgs e)
        {
            fThungRac fRac = new fThungRac();
            this.Hide();
            fRac.FormClosed += (s, agrs) => this.Show(); // Khi Form2 đóng, mở lại Form1
            fRac.ShowDialog();
            hienthi();
        }
    }
}
