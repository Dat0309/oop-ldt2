using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_16
{
    class Program
    {
        enum thang : byte
        {
            JANUARY =1,
            FEBRUARY=2,
            MARCH=3,
            APRIL=4,
            MAY=5,
            JUNE=6,
            JULY=7,
            AUGUST=8,
            SEPTEMBER=9,
            OCTOBER=10,
            NOVEMBER=11,
            DECEMBER=12
        }
        static void Main(string[] args)
        {
            byte Thang;
            Console.WriteLine("Nhap mot so tu 1 den 12");
            Thang = byte.Parse(Console.ReadLine());
            switch(Thang)
            {
                case (byte)thang.JANUARY:
                    {
                        Console.WriteLine("JANUARY");
                        break;
                    };
                case (byte)thang.FEBRUARY:
                    {
                        Console.WriteLine("FEBRUARY");
                        break;
                    };
                case (byte)thang.MARCH:
                    {
                        Console.WriteLine("MARCH");
                        break;
                    };
                case (byte)thang.MAY:
                    {
                        Console.WriteLine("MAY");
                        break;
                    };
                case (byte)thang.JUNE:
                    {
                        Console.WriteLine("JUNE");
                        break;
                    };
                case(byte)thang.JULY:
                    {
                        Console.WriteLine("JULY");
                        break;
                    };
                case(byte)thang.AUGUST:
                    {
                        Console.WriteLine("AUGUST");
                        break;
                    };
                case (byte)thang.SEPTEMBER:
                    {
                        Console.WriteLine("SEPTEMBER");
                        break;
                    }
                case (byte)thang.OCTOBER:
                    {
                        Console.WriteLine("OCTOBER");
                        break;
                    };
                case (byte)thang.NOVEMBER:
                    {
                        Console.WriteLine("NOVEMBER");
                        break;
                    };
                case(byte)thang.DECEMBER:
                    {
                        Console.WriteLine("DECEMBER");
                        break;
                    }
                default:
                    Console.WriteLine("So khong hop le!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
