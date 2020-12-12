using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            int gaa, gab, gac, gad, tongTrung, chuc, qua;
            string strggaa, strggab, strggac, strggad;
            Console.WriteLine("Nhap vao so qua trung cua moi con ga:");
            strggaa = Console.ReadLine();
            int.TryParse(strggaa, out gaa);
            strggab = Console.ReadLine();
            int.TryParse(strggab, out gab);
            strggac = Console.ReadLine();
            int.TryParse(strggac, out gac);
            strggad = Console.ReadLine();
            int.TryParse(strggad, out gad);
            tongTrung = gaa + gab + gac + gad;
            Console.WriteLine("Tong so trung cua 4 con ga la:{0} qua trung", tongTrung);
            chuc = tongTrung / 12;
            qua = tongTrung % 12;
            Console.WriteLine("tong so {0} qua trung la {1} ta va {2} qua trung", tongTrung, chuc, qua);
            Console.ReadKey();
        }
    }
}
