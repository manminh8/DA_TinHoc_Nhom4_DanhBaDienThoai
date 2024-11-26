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
    [Serializable]
    public class CXulyDanhBa
    {
        private HashSet<CDanhBa> m_listPB;

        public CXulyDanhBa()
        {
            m_listPB = CData.khoiTao().getDanhBa();
        }
        public List<CDanhBa> laydanhsach()
        {
            return m_listPB.ToList();
        }
        public void them(CDanhBa thongtin)
        {
            m_listPB.Add(thongtin);
        }
        public CDanhBa tim(string sdt)
        {
            foreach (CDanhBa lienhe in m_listPB)
            {
                if (lienhe.Sdt == sdt)
                {
                    return lienhe;
                }
            }
            return null;
        }

        public void xoa(string sdt)
        {
            CDanhBa lienhe = tim(sdt);
            if (lienhe != null)
            {
                m_listPB.Remove(lienhe);
            }
        }

        public void sua(CDanhBa update_m)
        {
            CDanhBa lienhe = tim(update_m.Sdt);
            if(lienhe != null)
            {
                lienhe.Email = update_m.Email;
                lienhe.Ten = update_m.Ten;
                lienhe.Tencoquan=update_m.Tencoquan;
                lienhe.Ghichu = update_m.Ghichu;
            }
        }
        public void saveFileJSON()
        {
            string json = JsonConvert.SerializeObject(m_listPB, Formatting.Indented);
            File.WriteAllText("listPB.json", json);
            MessageBox.Show("Luu thanh cong");
        }
        public void LoadFileJSon()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog.Title = "Select a JSON file";

            // Hiển thị hộp thoại và kiểm tra xem người dùng có chọn tệp không
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonString = File.ReadAllText("listPB.json");

                m_listPB = JsonConvert.DeserializeObject<HashSet<CDanhBa>>(jsonString);
            }
        }
    }
}
