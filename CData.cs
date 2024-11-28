using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLDanhBa
{
    [Serializable]
    public class CData
    {
        private static CData m_instance=null;
        private HashSet<CDanhBa> dbDienThoai;

        public CData()
        {
            dbDienThoai = new HashSet<CDanhBa>();
        }

        public static CData khoiTao()
        {
            if(m_instance==null)
                m_instance = new CData();
            return m_instance;
        }
        public HashSet<CDanhBa> getDanhBa()
        { 
            return dbDienThoai; 
       }
    }
}
