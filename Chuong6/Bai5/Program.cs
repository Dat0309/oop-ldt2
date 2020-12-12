using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zipCode = new int[] { 800000, 880000, 780000, 680000, 980000, 500000, 450000, 600000, 700000, 600000 };
            int[] DlverCharge = new int[] { 10, 15, 20, 11, 13, 14, 16, 18, 17, 12 };
            int x, nhap;
            Console.WriteLine("Nhap vao ma zip bat ki!");
            Array.Sort(zipCode);
            //for (int i = 0; i < zipCode.Length;i++ )
            //{
            //    Console.WriteLine(zipCode[i]);
            //}
            int.TryParse(Console.ReadLine(), out nhap);
            x = Array.BinarySearch(zipCode, nhap);
            if (x < 0)
                Console.WriteLine("zipCode {0} khong thuoc khu vuc giao hang cua cong ty!", nhap);
            else
                Console.WriteLine("zipCode {0} thuoc khu vuc giao hang cua cong ty!", nhap);

            Console.ReadLine();
        }
    }
}
