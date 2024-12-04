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

        public List<CDanhBa> getDanhBa()
        {
            return dbDienThoai;
        }
        public List<CDanhBa> getdsRac()
        {
            return dsRac;
        }
        private CDuLieu()
        {
            dbDienThoai = new List<CDanhBa>();
            dsRac = new List<CDanhBa>();
        }

        public static CDuLieu khoiTao()
        {
            if (m_instance == null)
                m_instance = new CDuLieu();
            return m_instance;
        }

    }
}
