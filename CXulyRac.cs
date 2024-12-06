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
    public class CXulyRac
    {
        private List<CDanhBa> m_dsRac;

        public CXulyRac()
        {
            m_dsRac = CDuLieu.khoiTao().getdsRac();
        }

        public List<CDanhBa> getDSRac()
        {
            return m_dsRac;
        }

        public CDanhBa tim(string sdt)
        {
            foreach(CDanhBa rac in m_dsRac)
            {
                if(rac.Sdt == sdt)
                {
                    return rac;
                }
            }
            return null;
        }

        public void them(CDanhBa tt)
        {
            m_dsRac.Add(tt);
        }
        public void xoa(string sdt)
        {
            CDanhBa rac = tim(sdt);
            if (rac != null)
            {
                m_dsRac.Remove(rac);
            }
        }
        public bool autoSaveRac()
        {
            try
            {
                string json = JsonConvert.SerializeObject(m_dsRac, Formatting.Indented);
                File.WriteAllText("TrashData.json", json);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool autoLoadRac()
        {
            try
            {
                string jsonString = File.ReadAllText("TrashData.json");
                List<CDanhBa> db = JsonConvert.DeserializeObject<List<CDanhBa>>(jsonString);
                foreach (CDanhBa dbItem in db)
                {
                    m_dsRac.Add(dbItem);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
