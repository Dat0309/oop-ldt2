using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5b
{
    class Program
    {
        static void Main(string[] args)
        {
            byte Thang, Ngay;
            string strgThang, strgNgay;
            Console.WriteLine("Nhap vao thang sinh: ");
            strgThang = Console.ReadLine();
            byte.TryParse(strgThang, out Thang);

            Console.WriteLine("Nhap vao ngay: ");
            strgNgay = Console.ReadLine();
            byte.TryParse(strgNgay, out Ngay);
            if (Thang == 1 || Thang ==3||Thang==5||Thang==7||Thang==8||Thang==10||Thang==12)
            {
                if (Ngay < 1 || Ngay > 31)
                    Console.WriteLine("Ngay thang khong hop le");
                else
                    Console.WriteLine("Ngay {0}/{1} hop le", Ngay, Thang);
            }
            else if (Thang ==4||Thang==6||Thang==9||Thang==11)
            {
                if (Ngay < 1 || Ngay > 30)
                    Console.WriteLine("Ngay thang khong hop le!");
                else
                    Console.WriteLine("Ngay {0} thang {1} hop le", Ngay, Thang);
            }
            else if(Thang==2)
            {
                if (Ngay < 1 || Ngay > 28)
                    Console.WriteLine("Khong hop le");
                else
                    Console.WriteLine("Ngay {0} Thang {1} hop le", Ngay, Thang);
            }
            Console.ReadKey();
        }
    }
}
