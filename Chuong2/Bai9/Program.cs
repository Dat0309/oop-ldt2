using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            int Move, Hour, Mile;
            string strgMove, strgHour, strgMile;
            double kq;
            Console.WriteLine("Nhap vo so lan di chuyen:");

            strgMove = Console.ReadLine();
            int.TryParse(strgMove, out Move);
            Console.WriteLine("Nhap so Gio di chuyen:");
            strgHour = Console.ReadLine();
            int.TryParse(strgHour, out Hour);
            Console.WriteLine("Nhap so Dam di chuyen:");
            strgMile = Console.ReadLine();
            int.TryParse(strgMile, out Mile);

            kq = (int)Move * 200 + Hour * 150 + Mile * 2;
            Console.WriteLine("Chi phi di chuyen la:{0}$", kq);
            Console.ReadKey();
            
        }
    }
}
