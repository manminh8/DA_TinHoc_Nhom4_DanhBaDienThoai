using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Converters;

namespace QLDanhBa
{

    public class CXulyDanhBa
    {
        private List<CDanhBa> dbDienThoai;

        public CXulyDanhBa()
        {
            dbDienThoai = CDuLieu.khoiTao().getDanhBa();
        }
        public List<CDanhBa> getDanhBa()
        {
            return dbDienThoai.ToList();
        }
        public CDanhBa tim(string sdt)
        {
            foreach (CDanhBa lienhe in dbDienThoai)
            {
                if (lienhe.Sdt == sdt)
                {
                    return lienhe;
                }
            }
            return null;
        }
        public void them(CDanhBa thongtin)
        {
            dbDienThoai.Add(thongtin);
        }
        public void xoa(string sdt)
        {
            CDanhBa lienhe = tim(sdt);
            if (lienhe != null)
            {
                dbDienThoai.Remove(lienhe);
            }
        }

        public void sua(CDanhBa update)
        {
            CDanhBa lienhe = tim(update.Sdt);
            if (lienhe != null)
            {
                lienhe.Ten = update.Ten;
                lienhe.Tencoquan = update.Tencoquan;
                lienhe.Email = update.Email;
                lienhe.Ghichu = update.Ghichu;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Đối Tượng Để Sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        public bool autoSave()
        {
            try {
                string json = JsonConvert.SerializeObject(dbDienThoai, Formatting.Indented);
                File.WriteAllText("DanhBa.json", json);               
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool autoLoad()
        {
            try
            {
                string jsonString = File.ReadAllText("DanhBa.json");
                List<CDanhBa> db = JsonConvert.DeserializeObject<List<CDanhBa>>(jsonString);
                foreach (CDanhBa dbItem in db)
                {
                    dbDienThoai.Add(dbItem);
                }
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool saveFileJSON(object data)
        {
            try
            {
                // Chuyển đổi đối tượng thành chuỗi JSON
                string json = JsonConvert.SerializeObject(dbDienThoai, Formatting.Indented);

                // Hiển thị hộp thoại "Save File" để người dùng chọn vị trí lưu và đặt tên file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu file JSON vào vị trí đã chọn
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, json);

                    return true;
                }
                else
                {
                    // Người dùng không chọn vị trí lưu file
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool LoadFileJSon()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.Title = "Select a JSON file";
            try
            {
                // Hiển thị hộp thoại và kiểm tra xem người dùng có chọn tệp không
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string jsonString = File.ReadAllText(openFileDialog.FileName);

                    List<CDanhBa> db = JsonConvert.DeserializeObject<List<CDanhBa>>(jsonString);
                    foreach (CDanhBa dbItem in db)
                    {
                        dbDienThoai.Add(dbItem);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

    }
}
