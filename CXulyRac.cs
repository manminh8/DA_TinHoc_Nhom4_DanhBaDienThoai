using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
