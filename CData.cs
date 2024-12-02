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
        private List<CDanhBa> dbDienThoai;

        private CData()
        {
            dbDienThoai = new List<CDanhBa>();
        }

        public static CData khoiTao()
        {
            if (m_instance == null)
                m_instance = new CData();
            return m_instance;
        }
        public List<CDanhBa> getDanhBa()
        {
            return dbDienThoai;
        }
    }
}
