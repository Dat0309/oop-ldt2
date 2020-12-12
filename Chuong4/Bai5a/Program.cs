using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5a
{
    class Program
    {
        static void Main(string[] args)
        {
            int Thang;
            string strgThang;
            Console.WriteLine("Nhap thang sinh ");
            strgThang = Console.ReadLine();
            int.TryParse(strgThang, out Thang);
            if (Thang < 1 || Thang > 12)
                Console.WriteLine("Error");
            else
                Console.WriteLine("{0} la thang hop le!", Thang);
            Console.ReadKey();
        }
    }
}
