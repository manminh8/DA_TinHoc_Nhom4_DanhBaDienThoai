using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Converters;

namespace QLDanhBa
{

    public class CXulyDanhBa
    {
        private HashSet<CDanhBa> dbDienThoai;

        public CXulyDanhBa()
        {
            dbDienThoai = CData.khoiTao().getDanhBa();
        }
        public HashSet<CDanhBa> getDanhBa()
        {
            return dbDienThoai;
        }
        public CDanhBa tim(string sdt)
        {
            foreach (CDanhBa lienhe in dbDienThoai)
            {
                if (lienhe.Sdt == sdt)
                {
                    return lienhe;
                }
            }
            return null;
        }
        public void them(CDanhBa thongtin)
        {
            dbDienThoai.Add(thongtin);
        }
        public void xoa(string sdt)
        {
            CDanhBa lienhe = tim(sdt);
            if (lienhe != null)
            {
                dbDienThoai.Remove(lienhe);
            }
        }

        public void sua(CDanhBa update)
        {
            CDanhBa lienhe = tim(update.Sdt);
            if (lienhe != null)
            {
                lienhe.Ten = update.Ten;
                lienhe.Tencoquan = update.Tencoquan;
                lienhe.Email = update.Email;
                lienhe.Ghichu = update.Ghichu;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Đối Tượng Để Sửa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    
    }
}
