using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDanhBa
{
    public enum DanhSach{ YeuThich,HanChe,None}
    public class CDanhBa
    {
        private string m_sdt;
        private string m_ten;
        private string m_email;
        private string m_tencoquan;
        private string m_ghichu;
        private DanhSach m_danhsach;
        //private string m_danhmuc;
        

        public CDanhBa(string sdt, string ten,string mail, string tencoquan, string ghichu)//,string danhmuc)
        {
            Sdt = sdt;
            Ten = ten;
            Email = mail;
            Tencoquan = tencoquan;
            Ghichu = ghichu;
        }
        public CDanhBa() : this("", "", "", "","") { }

        public CDanhBa(CDanhBa orther)
        {
            Sdt = orther.Sdt;
            Ten = orther.Ten;
            Email = orther.Email;
            Tencoquan = orther.Tencoquan;
            Ghichu = orther.Ghichu;
        }
        public string Sdt { get => m_sdt; set => m_sdt = value; }
        public string Ten { get => m_ten; set => m_ten = value; }      
        public string Email { get => m_email; set => m_email = value; }
        public string Tencoquan { get => m_tencoquan; set => m_tencoquan = value; }
        public string Ghichu { get => m_ghichu; set => m_ghichu = value; }
        public DanhSach Danhsach { get => m_danhsach; set => m_danhsach = value; }

    }
}
