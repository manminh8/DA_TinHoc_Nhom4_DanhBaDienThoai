using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDanhBa
{
    [Serializable]
    public class CData
    {
        private static CData m_instance = null;
        private HashSet<CDanhBa> dbDienThoai;

        public CData()
        {
            dbDienThoai = new HashSet<CDanhBa>();
        }

        public static CData khoiTao()
        {
            if (m_instance == null)
                m_instance = new CData();
            return m_instance;
        }
        public HashSet<CDanhBa> getDanhBa()
        {
            return dbDienThoai;
        }
        public static bool LoadFileJSon(string filename)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.Title = "Select a JSON file";

            // Hiển thị hộp thoại và kiểm tra xem người dùng có chọn tệp không
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText(filename);
                m_instance.dbDienThoai = JsonConvert.DeserializeObject<HashSet<CDanhBa>>(jsonString);
                return true;
            }
            return false;

        }
        public static bool saveDataToFile(string filePath)
        {
            if (m_instance == null) return false;
            string jsonData = JsonConvert.SerializeObject(m_instance.dbDienThoai);
            File.WriteAllText(filePath, jsonData);
            return true;
        }
    }
}
