using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QLDanhBa
{
    public partial class fSua : Form
    {
       
        private CXulyDanhBa xuly;
        public fSua()
        {
            InitializeComponent();
            xuly = new CXulyDanhBa();
        }
        private bool check()
        {
            if (!Regex.IsMatch(txtSuaSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại không đúng");
                return false;
                // @: cho biết rằng đây là một chuỗi "verbatim" (chuỗi nguyên văn)
                // ^: Bắt đầu chuỗi.
                // Ký tự \d là một ký tự đặc biệt trong regex, đại diện cho bất kỳ chữ số nào từ 0 đến 9
                // Cặp dấu ngoặc nhọn {} được sử dụng để chỉ định số lần xuất hiện của ký tự hoặc nhóm trước đó
                // $: Kết thúc chuỗi.
            }
            else if (txtSuaTen.Text == string.Empty)
            {
                MessageBox.Show("Vui Lòng Nhập SĐT Cần Tìm Để Sửa Thông Tin");
                txtSuaTen.Focus();
                return false;
            }
            return true;
        }
        public void hienThiThongTin(CDanhBa danhBa)
        {
            txtSuaSDT.Text = danhBa.Sdt;
            txtSuaTen.Text = danhBa.Ten;
            txtSuaTenCoQuan.Text = danhBa.Tencoquan;
            txtSuaEmail.Text = danhBa.Email;
            txtSuaGhiChu.Text = danhBa.Ghichu;
        }
        private void FSua_Load(object sender, EventArgs e)
        {

        }
        private void btnSuaXacnhan_Click(object sender, EventArgs e)
        {
            //CDanhBa danhbaMoi = new CDanhBa(txtSuaSDT.Text, txtSuaTen.Text, txtSuaEmail.Text, txtSuaTenCoQuan.Text, txtSuaGhiChu.Text);
            CDanhBa danhBaMoi = xuly.tim(txtSuaSDT.Text);
            if (danhBaMoi!=null)
            {
                danhBaMoi.Ten = txtSuaTen.Text;
                danhBaMoi.Tencoquan = txtSuaTenCoQuan.Text;
                danhBaMoi.Email = txtSuaEmail.Text;
                danhBaMoi.Ghichu = txtSuaGhiChu.Text;               
                if (check())
                {
                    xuly.sua(danhBaMoi);
                    MessageBox.Show("Đã Sửa Thành Công!");
                }
                else
                {
                    MessageBox.Show("Không Thế Sửa!");
                }
            }
        }

        private void btnSuaHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
