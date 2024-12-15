using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace QLDanhBa
{
    [Serializable]
    public class CXulyNhom
    {
        private List<CNhom> m_lstNhom;

        public CXulyNhom()
        {
            m_lstNhom = CDuLieu.khoiTao().getdsNhom();
        }

        public List<CNhom> getDSNhom()
        {
            return m_lstNhom;
        }
        public List<CDanhBa> layDanhSachDanhBaTrongNhom(string tennhom)
        {
            CNhom nhom = tim(tennhom);
            return nhom?.getDSDBNhom();
        }
        public bool taoNhom(string tennhom)
        {
            if (tim(tennhom) == null)
            {
                m_lstNhom.Add(new CNhom(tennhom));
                return true;
            }
            return false;
        }
        public CNhom tim(string tennhom)
        {
            foreach (CNhom nhom in m_lstNhom)
            {
                if (nhom.Tennhom == tennhom)
                {
                    return nhom;
                }
            }
            return null;
        }
        public bool XoaNhom(string tenNhom)
        {
            CNhom nhom = tim(tenNhom);
            if (nhom != null)
            {
                m_lstNhom.Remove(nhom);
                return true;
            }
            return false;
        }
        public bool ThemDanhBaVaoNhom(string tenNhom, CDanhBa danhBa)
        {
            CNhom nhom = tim(tenNhom);
            if (nhom != null)
            {
                nhom.ThemDanhBa(danhBa);
                return true;
            }
            return false;
        }
        public bool XoaDanhBaKhoiNhom(string tenNhom, string sdt)
        {
            CNhom nhom = tim(tenNhom);
            if (nhom != null)
            {
                return nhom.xoaDanhBa(sdt);
            }
            return false;
        }
        public void LuuDanhSachVaoFile()
        {
            string json = JsonConvert.SerializeObject(m_lstNhom);
            File.WriteAllText("danhba.json", json);
        }
        public void autoLoad()
        {
            try
            {
                string json = File.ReadAllText("ListNhom.json");
                List<CNhom> nhom = JsonConvert.DeserializeObject<List<CNhom>>(json);
                foreach (var item in nhom)
                {
                    m_lstNhom.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool autoSave()
        {
            try
            {
                string json = JsonConvert.SerializeObject(this, Formatting.Indented);
                File.WriteAllText("ListNhom.json", json);
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
