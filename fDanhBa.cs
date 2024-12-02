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
            hienthi();
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
                MessageBox.Show("Lưu Dữ Liệu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Không Thể Luu Được Dữ Liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            if (xuly.LoadFileJSon())
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
                fSua frmSua = new fSua();
                frmSua.hienThiThongTin(selectedDB);
                if(frmSua.ShowDialog() == DialogResult.OK)
                {
                    xuly.sua(selectedDB);
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
                xuly.xoa(selectedDB.Sdt);
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

        private void cmsDanhBaDong_Click(object sender, EventArgs e)
        {
            string text = "Bạn Có Muốn Dừng Chương Trình?";
            string caption = "Thông Báo";
            DialogResult rs=MessageBox.Show(text, caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
