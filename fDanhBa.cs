﻿using Newtonsoft.Json;
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
        private string searchType; //Lưu loại tìm kiếm 
        private CXulyDanhBa xulyDB;
        private CXulyRac xulyRac;
        private CXulyNhom xulyNhom;

        private void hienthi()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = xulyDB.getDanhBa();
            dgvDanhBa.DataSource = bs;
        }
        void taoColumn()
        {
            var ColSDT = new DataGridViewTextBoxColumn();

        }
        public fDanhBa()
        {
            InitializeComponent();
            xulyDB = new CXulyDanhBa();
            xulyRac = new CXulyRac();
            xulyNhom = new CXulyNhom();
            if (File.Exists("DanhBa.json"))
                xulyDB.autoLoad();
            if (File.Exists("TrashData.json"))
                xulyRac.autoLoadRac();
            if (File.Exists("JSON.json"))
                xulyNhom.autoLoadNhom();
            hienthi();
        }
        private void OpenFile(string filePath)
        {
            // Mở file bằng ứng dụng mặc định (người dùng tự chọn phương thức chia sẻ)
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }

        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            fAdd formAdd = new fAdd();
            formAdd.FormClosed += (s, arg) => this.Show();
            formAdd.ShowDialog();
            hienthi();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (xulyDB.saveFileJSON())
            {
                MessageBox.Show("Lưu Dữ Liệu Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
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
                MessageBox.Show("Tải Dữ Liệu Không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhBa.SelectedRows.Count > 0)
            {
                CDanhBa selectedDB = (CDanhBa)dgvDanhBa.SelectedRows[0].DataBoundItem;
                xulyRac.them(selectedDB);
                xulyRac.autoSaveRac();
                xulyDB.xoa(selectedDB.Sdt);
                xulyDB.autoSave();
                hienthi();
            }
            else
            {
                MessageBox.Show("Chọn Một Dòng Để Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            xulyNhom.GhiFileJson("JSON.json");
            Application.Exit();
        }

        private void btnThungRac_Click(object sender, EventArgs e)
        {
            fThungRac fRac = new fThungRac();
            this.Hide();
            fRac.FormClosed += (s, agrs) => this.Show(); // Khi Form2 đóng, mở lại Form1
            fRac.ShowDialog();
            hienthi();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            if (cb != null)
            {
                searchType = cb.Text;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            List<CDanhBa> listSearch = new List<CDanhBa>();
            foreach (var item in CDuLieu.khoiTao().getDanhBa())
            {
                if (searchType == "Số điện thoại")
                {
                    if (item.Sdt.Contains(search))
                    {
                        listSearch.Add(item);
                    }
                }
                else if (searchType == "Tên")
                {
                    if (item.Ten.Contains(search))
                    {
                        listSearch.Add(item);
                    }
                }
                else if (searchType == "Tên cơ quan")
                {
                    if (item.Tencoquan.Contains(search))
                    {
                        listSearch.Add(item);
                    }
                }
                else if (searchType == "Email")
                {
                    if (item.Email.Contains(search))
                    {
                        listSearch.Add(item);
                    }
                }
                else if (searchType == "Ghi chú")
                {
                    if (item.Ghichu.Contains(search))
                    {
                        listSearch.Add(item);
                    }
                }

                if (listSearch.Count == 0)
                {
                    dgvDanhBa.DataSource = null; // Làm rỗng dgv
                }
                else
                {
                    dgvDanhBa.DataSource = null;
                    dgvDanhBa.DataSource = listSearch;
                }
            }
        }

        private void btnTuyChon_Click(object sender, EventArgs e)
        {
            if (dgvDanhBa.SelectedRows.Count > 0)
            {
                CDanhBa selectedDB = (CDanhBa)dgvDanhBa.SelectedRows[0].DataBoundItem;
                fTuyChon frmchon = new fTuyChon();
                frmchon.FormClosed += (s, agrs) => this.Show(); // Khi Form2 đóng, mở lại Form1
                this.Hide();
                frmchon.hienThiThongTin(selectedDB);
                frmchon.ShowDialog();
                hienthi();
            }
            else
            {
                MessageBox.Show("Chọn Không Hợp Lệ!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNhom_Click(object sender, EventArgs e)
        {
            fNhom frmNhom = new fNhom();
            frmNhom.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            frmNhom.ShowDialog();
            xulyNhom.autoSaveNhom();
        }

        private void btnChiaSe_Click(object sender, EventArgs e)
        {
            if (dgvDanhBa.SelectedRows.Count > 0)
            {
                // Hiển thị hộp thoại lưu file
                SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "All files (*.*)|*.*|Plain text (*.txt)|*.txt|JSON files (*.json)|*.json|CSV files (*.csv)|*.csv",
                Title = "Lưu danh bạ"
            };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    {
                        //Tạo danh sách lưu trữ những danh sách đã chọn 
                        List<CDanhBa> ls = new List<CDanhBa>();
                        try
                        {
                            for (int i = 0; i < dgvDanhBa.SelectedRows.Count; i++)
                            {
                                ls.Add(xulyDB.tim(dgvDanhBa.SelectedRows[i].Cells[0].Value.ToString()));
                            }
                            // chuyển danh sách đã chọn qua chuỗi json 
                            string jsonContent = JsonConvert.SerializeObject(ls, Formatting.Indented);
                            // lưu trữ json 
                            File.WriteAllText(filePath, jsonContent);
                            MessageBox.Show("Liên hệ đã được chia sẻ tại: " + filePath, "Thông báo");
                            // Chia sẻ file
                            OpenFile(filePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Cần chọn một liên hệ để chia sẻ");
            }
        }

        private void dgvDanhBa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDanhBa.SelectedRows.Count > 0)
            {
                btnChiaSe.Enabled = true;
                btnTuyChon.Enabled = true;
            }
        }

        private void btnShowDBYT_Click(object sender, EventArgs e)
        {
            List<CDanhBa> dsDB = new List<CDanhBa>();
            foreach(CDanhBa db in xulyDB.getDanhBa())
            {
                if(db.Danhsach == QLDanhBa.DanhSach.YeuThich)
                {
                    dsDB.Add(db);
                }
            }
            dgvDanhBa.DataSource = null;
            if (dsDB.Count > 0)
            {
                dgvDanhBa.DataSource = dsDB.ToList();
            }

        }
    }
}
#endregion
