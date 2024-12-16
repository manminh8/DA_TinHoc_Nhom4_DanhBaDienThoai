using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDanhBa
{
    public class CNhom
    {
        private string m_tenNhom;
        private List<CDanhBa> m_dsDanhBa; //Danh sach danh ba
        public string Tennhom { get => m_tenNhom; set => m_tenNhom = value; }
        public List<CDanhBa> DsDanhBa {
            get => m_dsDanhBa;
            set => m_dsDanhBa = value;
        }

        public CNhom(string tennhom)
        {
            Tennhom = tennhom;
            DsDanhBa = new List<CDanhBa>();
        }
        public List<CDanhBa> getDSDBNhom() { return m_dsDanhBa; }

        public CDanhBa tim(string sdt)
        {
            foreach (CDanhBa db in m_dsDanhBa)
            {
                if (db.Sdt == sdt)
                    return db;
            }
            return null;
        }
        public void ThemDanhBa(CDanhBa danhBa)
        {
            if (danhBa != null && !m_dsDanhBa.Contains(danhBa))
            {
                m_dsDanhBa.Add(danhBa);
            }
        }
        public bool xoaDanhBa(string sdt)
        {
            CDanhBa db = tim(sdt);
            if (db.Sdt == sdt)
            {
                if (db != null)
                {
                    m_dsDanhBa.Remove(db);
                    return true;
                }
            }
            return false;
        }
    }

}
