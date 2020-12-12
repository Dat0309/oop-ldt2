using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            int gaa=100, gab=100, gac=100, gad=27, tongTrung,chuc,qua;
            
            Console.WriteLine("Nhap vao so qua trung cua moi con ga:");
           
            tongTrung = gaa + gab + gac + gad;
            Console.WriteLine("Tong so trung cua 4 con ga la:{0} qua trung", tongTrung);
            chuc = tongTrung / 12;
            qua = tongTrung % 12;
            Console.WriteLine("tong so {0} qua trung la {1} ta va {2} qua trung", tongTrung, chuc, qua);
            Console.ReadKey();
        }
    }
}
