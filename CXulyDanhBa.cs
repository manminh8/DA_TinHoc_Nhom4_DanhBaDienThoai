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
            m_listPB = new HashSet<CDanhBa>();
        }
        public List<CDanhBa> laydanhsach
        {
             get => m_listPB.ToList();
        }
        public void them(CDanhBa thongtin)
        {
            m_listPB.Add(thongtin);
        }
        public void saveFileJSON()
        {
           string json = JsonConvert.SerializeObject(m_listPB, Formatting.Indented);
            File.WriteAllText("listPB.json", json);
            MessageBox.Show("Luu thanh cong");
        }
        public void LoadFileJSon()
        {
            string jsonString = File.ReadAllText("listPB.json");

            m_listPB = JsonConvert.DeserializeObject<HashSet<CDanhBa>>(jsonString);

        }
    }
}
