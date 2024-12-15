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
    public class CDuLieu
    {
        private static CDuLieu m_instance = null;

        private List<CDanhBa> dbDienThoai;
        private List<CDanhBa> dsRac;
        private List<CNhom> dsNhom;
        private CDuLieu()
        {
            dbDienThoai = new List<CDanhBa>();
            dsRac = new List<CDanhBa>();
            dsNhom = new List<CNhom>();
        }

        public List<CDanhBa> getDanhBa()
        {
            return dbDienThoai;
        }
        public List<CDanhBa> getdsRac()
        {
            return dsRac;
        }
        public List<CNhom> getdsNhom()
        {
            return dsNhom;
        }
        public static CDuLieu khoiTao()
        {
            if (m_instance == null)
                m_instance = new CDuLieu();
            return m_instance;
        }

    }
}
