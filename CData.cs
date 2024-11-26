using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLDanhBa
{
    [Serializable]
    internal class CData
    {
        private static CData m_instance=null;
        private HashSet<CDanhBa> m_dsdanhba;

        private CData()
        {
            m_dsdanhba = new HashSet<CDanhBa>();
        }

        public static CData khoiTao()
        {
            if(m_instance==null)
                m_instance = new CData();
            return m_instance;
        }
        public HashSet<CDanhBa> getDanhBa() { return m_dsdanhba; }
        
        //public static bool ghiFile(string filename)
        //{

        //}

    }
}
