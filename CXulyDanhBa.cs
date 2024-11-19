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

namespace QLDanhBa
{
    public class CXulyDanhBa
    {
        private HashSet<CDanhBa> m_listPB;

        public CXulyDanhBa()
        {
            m_listPB = new HashSet<CDanhBa>();
        }
        public List<CDanhBa> laydanhsach()
        {
            return m_listPB.ToList();
        }
        public void them(CDanhBa thongtin)
        {
            m_listPB.Add(thongtin);
        }
        public bool saveFileJSON( string filePath)
        {
            try
            {
                // Chuyển đổi đối tượng thành chuỗi JSON
                string json = JsonConvert.SerializeObject(m_listPB, Formatting.Indented);
                // Bạn có thể lựa chọn ghi đè, thêm mới, hoặc hỏi ý kiến người dùng
                // Ở đây, mình chọn ghi đè
                //if (File.Exists(filePath))
                //{
                //    File.Delete(filePath);
                //}
                // Ghi dữ liệu vào file
                using (StreamWriter file = new StreamWriter(filePath))
                {
                    file.Write(json);
                }
                return true;//ghi file thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
                return false;
            }
        }
        public HashSet<CXulyDanhBa> LoadFileJSon(string filePath)
        {
            filePath = "danhba.json";
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File không tồn tại!");
                    return new HashSet<CXulyDanhBa>();// Trả về một danh sách rỗng nếu có lỗi
                }
                // Đọc dữ liệu từ file          
                string json = File.ReadAllText(filePath);
                // Chuyển đổi chuỗi JSON thành danh sách đối tượng
                HashSet<CXulyDanhBa> m_listPB = JsonConvert.DeserializeObject<HashSet<CXulyDanhBa>>(json);
                return m_listPB;
            }
            catch (JsonReaderException ex)
            {
                MessageBox.Show("Lỗi định dạng JSON: " + ex.Message);
                return new HashSet<CXulyDanhBa>();// Trả về một danh sách rỗng nếu có lỗi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message);
                return new HashSet<CXulyDanhBa>();// Trả về một danh sách rỗng nếu có lỗi
            }
        }
    }
}
