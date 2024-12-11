using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDanhBa
{
    public class CXulyNhom
    {
        private List<CNhom> m_lstNhom;

        public CXulyNhom()
        {
            m_lstNhom = CDuLieu.khoiTao().getdsNhom();
        }

        public List<CNhom> lstNhom()
        {
            return m_lstNhom;
        }
        public void them(CNhom nhom)
        {
            m_lstNhom.Add(nhom);
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
        public void xoa(string tennhom)
        {
            CNhom nhom = tim(tennhom);
            if (nhom != null)
            {
                m_lstNhom.Remove(nhom);
            }
        }
        public void sua(CNhom nhomUpdate)
        {
            CNhom nhom = tim(nhomUpdate.Tennhom);
            if(nhom != null)
            {
                nhom.Sdt = nhomUpdate.Sdt;
                nhom.Ten = nhomUpdate.Ten;
                nhom.Email = nhomUpdate.Email;
                nhom.Tencoquan = nhomUpdate.Tencoquan;
                nhom.Danhsach = nhomUpdate.Danhsach;
            }
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
