using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QLDanhBa
{
    public partial class fAdd : Form
    {
         private CXulyDanhBa xuly;       
        public fAdd()
        {
            InitializeComponent();
            xuly = new CXulyDanhBa();
        }
        private bool check()
        {
            if (!Regex.IsMatch(txtSdt.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại không đúng");
                return false;
                // @: cho biết rằng đây là một chuỗi "verbatim" (chuỗi nguyên văn)
                // ^: Bắt đầu chuỗi.
                // Ký tự \d là một ký tự đặc biệt trong regex, đại diện cho bất kỳ chữ số nào từ 0 đến 9
                // Cặp dấu ngoặc nhọn {} được sử dụng để chỉ định số lần xuất hiện của ký tự hoặc nhóm trước đó
                // $: Kết thúc chuỗi.
            }
            else if (txtTen.Text == string.Empty)
            {
                MessageBox.Show("Chưa nhập tên");
                txtTen.Focus();
                return false;
            }
            return true;
        }
        private void xoa()
        {
            txtSdt.Text = "";
            txtTen.Text= "";
            txtTenCoQuan.Text = "";
            txtEmail.Text = "";
            txtGhiChu.Text = "";       
        }
        private void btnXacnhan_Click(object sender, EventArgs e)
        {
          
            string Ten = txtTen.Text;
            string Tencoquan = txtTenCoQuan.Text;
            string Email = txtEmail.Text;
            string Sdt = txtSdt.Text;
            string Ghichu = txtGhiChu.Text;
            
            CDanhBa db1 = new CDanhBa(Sdt, Ten, Email, Tencoquan, Ghichu);
            if (xuly.tim(txtSdt.Text) == null)
            {
                if (check())
                {
                    xuly.them(db1);
                    MessageBox.Show("Đã thêm Thành công!", "Thông Báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xoa();
                }
            }
            else
            {
                MessageBox.Show("Số Điện Thoại Đã Tồn Tại!!");
            }
         
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void fAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
