using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int SoTK, SoTkb,SoTkc;
            string strga, strgb,strgc;
            Console.WriteLine("Nhap So tai khoan cua ban: ");
            strga = Console.ReadLine();
            strgb = strga.Substring(0,3);
            strgc = strga.Substring(3);
            if (strga.Length > 4)
            {
                Console.WriteLine("Qua 4 chu so, Xin moi nhap lai!");
            }
            else
            {
                int.TryParse(strga, out SoTK);

                int.TryParse(strgb, out SoTkb);
                int.TryParse(strgc, out SoTkc);
                if (SoTkb % 7 == SoTkc)
                {
                    Console.WriteLine("Tai khoan hop le!");
                }
                else
                    Console.WriteLine("Tai khoan khong hop le!");
            }
          
                Console.ReadKey();
            
        }
    }
}
