using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marshallrevenues
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tranh1, Tranh2,DoanhThu1,DoanhThu2,TongDoanhThu;
            string strgT1, strgT2;
            Console.WriteLine("Nhap vao so luong buc tranh noi that: ");
            strgT1 = Console.ReadLine();
            int.TryParse(strgT1, out Tranh1);
            Console.WriteLine("Nhap vao so luong buc tranh ben ngoai: ");
            strgT2 = Console.ReadLine();
            int.TryParse(strgT2, out Tranh2);
            DoanhThu1 = Tranh1 * 500;
            DoanhThu2 = Tranh2 * 750;
            TongDoanhThu = DoanhThu1 + DoanhThu2;
            Console.WriteLine("                     ===========BAO CAO===========                          ");
            Console.WriteLine("So luong tranh noi that du kien duoc ve trong thang toi la {0} buc", Tranh1);
            Console.WriteLine("So luong tranh tuong ben ngoai du kien duoc ve trong thang toi la {0} buc", Tranh2);
            Console.WriteLine("Doanh thu tranh noi that la ${0} ", DoanhThu1);
            Console.WriteLine("Doanh thu tranh tuong ngoai la ${0} ", DoanhThu2);
            Console.WriteLine("Tong doanh thu la : ${0}", TongDoanhThu);
            if (Tranh1 > Tranh2)
                Console.WriteLine("Nhung buc tranh noi that duoc len lich nhieu hon nung buc tranh ben ngoai!");
            else
                Console.WriteLine("Nhung buc tranh noi that duoc len lich it hon nhung buc tranh ben ngoai!");
            Console.ReadKey();
        }
    }
}
