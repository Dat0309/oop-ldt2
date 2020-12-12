using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            double DiemTb, DiemXt;
            string strgTb, strgXt;
            Console.WriteLine("Nhap vao diem Trung Binh: ");
            strgTb = Console.ReadLine();
            double.TryParse(strgTb, out DiemTb);
            Console.WriteLine("Nhap vao diem Xet tuyen: ");
            strgXt = Console.ReadLine();
            double.TryParse(strgXt, out DiemXt);
            if((DiemTb>3.0 && DiemXt>60)||(DiemTb<3.0 && DiemXt>80))
            {
               Console.WriteLine("Du dieu kien xet tuyen!");
            }
            else
                Console.WriteLine("Khong du dieu kien xet tuyen!");
            Console.ReadKey();
        }
    }
}
