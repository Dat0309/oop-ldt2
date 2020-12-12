using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ts1, Ts2,DoanhThu1,DoanhThu2;
            string strgTs1, strgTs2;
            Console.WriteLine("Nhap vao so thi sinh thi nam ngoai: ");
            strgTs1 = Console.ReadLine();
            int.TryParse(strgTs1, out Ts1);
            Console.WriteLine("Nhap vao so thi sinh nam nay: ");
            strgTs2 = Console.ReadLine();
            int.TryParse(strgTs2, out Ts2);
            DoanhThu1 = Ts1 * 25;
            DoanhThu2 = Ts2 * 25;
            Console.WriteLine("So luong thi sinh tham du cuoc thi greenville vao nam ngoai va nam nay la {0} nguoi va {1} nguoi", Ts1, Ts2);
            Console.WriteLine("Doanh thu nam ngoai la ${0} ", DoanhThu1);
            Console.WriteLine("Doanh thu du tinh cua nam nay la ${0}", DoanhThu2);
            if (Ts1 < Ts2)
            {
                Console.WriteLine("So luong thi sinh nam nay nhieu hon so luong thi sinh nam ngoai");
            }
            else
                Console.WriteLine("So luong thi sinh nam nay it hon so luong thi sinh nam ngoai");
            Console.ReadKey();

        }
    }
}
