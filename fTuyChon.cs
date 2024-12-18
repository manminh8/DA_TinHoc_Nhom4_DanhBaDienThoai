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

namespace QLDanhBa
{
    public partial class fTuyChon : Form
    {
        private CXulyDanhBa xuly;
        private CXulyRac xulyRac;
        private CXulyNhom xulyNhom;
        public fTuyChon()
        {
            InitializeComponent();
            xuly = new CXulyDanhBa();
            xulyRac = new CXulyRac();
            xulyNhom = new CXulyNhom();
        }
        public void hienThiThongTin(CDanhBa danhBa)
        {
            txtSuaSDT.Text = danhBa.Sdt;
            txtSuaTen.Text = danhBa.Ten;
            txtSuaTenCoQuan.Text = danhBa.Tencoquan;
            txtSuaEmail.Text = danhBa.Email;
            txtSuaGhiChu.Text = danhBa.Ghichu;
            if (danhBa.Danhsach == DanhSach.YeuThich)
            {
                rdbYeuThich.Checked = true;
            }
        }
        public bool timDanhBa(List<CNhom> dsnhom)
        {
            foreach (CNhom c in dsnhom)
            {
                List<CDanhBa> dsDB = xulyNhom.layDanhSachDanhBaTrongNhom(c.Tennhom);
                if(dsDB.Any(danhba => danhba.Sdt == txtSuaSDT.Text))
                {
                    return false;
                }
            }
            return true;
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSuaSDT.Tag == null)
                txtSuaSDT.Tag = txtSuaSDT.Text;
            CDanhBa danhBaCu = xuly.tim(txtSuaSDT.Tag.ToString());
            danhBaCu.Sdt = txtSuaSDT.Text;
            danhBaCu.Ten = txtSuaTen.Text;
            danhBaCu.Tencoquan = txtSuaTenCoQuan.Text;
            danhBaCu.Email = txtSuaEmail.Text;
            danhBaCu.Ghichu = txtSuaGhiChu.Text;
            if (rdbYeuThich.Checked)
            {
                danhBaCu.Danhsach = DanhSach.YeuThich;
                rdbHanChe.Checked = false;
            }
            else if (rdbHanChe.Checked)
            {
                danhBaCu.Danhsach = DanhSach.HanChe;
                rdbYeuThich.Checked = false;
            }
            if (check())
            {
                xuly.sua(danhBaCu);
                xuly.autoSave();
                MessageBox.Show("Đã Sửa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            CDanhBa danhBaMoi = xuly.tim(txtSuaSDT.Text);
            if (danhBaMoi != null && timDanhBa(xulyNhom.getDSNhom()) == true) 
            {
                xuly.xoa(danhBaMoi.Sdt);
                xuly.autoSave();
                xulyRac.them(danhBaMoi);
                xulyRac.autoSaveRac();
                MessageBox.Show("Đã Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();

            }
            else
            {
                MessageBox.Show("Không Thể Xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void txtSuaSDT_Enter(object sender, EventArgs e)
        {
            txtSuaSDT.Tag = txtSuaSDT.Text; // Lưu lại số điện thoại cũ
        }
    }


}

