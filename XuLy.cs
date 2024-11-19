//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace QLDanhBa
//{
//    public class XuLy
//    {
//        public static void suaChuoi(ref string chuoi)
//        {
//            string resultName = "";

//            //Loại bỏ khoảng trắng đầu và cuối
//            chuoi = chuoi.Trim();

//            //Loại bỏ khoảng trắng thừa ở giữa các từ, chuyển thành 1 khoảng trắng
//            while (chuoi.IndexOf("   ") != -1)
//            {
//                chuoi = chuoi.Replace("  ", "  ");
//            }

//            //Sao chép các ký tự của chuỗi vào 1 mảng
//            string[] arrayName = chuoi.Split(' ');

//            //Duyệt các phần tử trong mảng, Chuyển ký tự đầu tiên mỗi từ thành viết hoa, còn lại viết thường
//            for (int i = 0; i < arrayName.Length; i++)
//            {
//                arrayName[i] = arrayName[i].Substring(0, 1).ToUpper() + arrayName[i].Substring(0).ToLower();
//                resultName = arrayName[i].ToString() + " ";
//            }
//            chuoi = resultName;
//        }
//    }
//}
