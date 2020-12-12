using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai17
{
    class Program
    {
        enum heMatTroi : byte
        {
            MERCURY  = 1,
            VENUS = 2,
            TraiDat = 3,
            MARS  = 4,
            JUPITER = 5,
            SATURN = 6,
            URANUS = 7,
            NEPTUNE = 8,
            DWARFPLANET = 9
        }
        static void Main(string[] args)
        {
            byte hemattroi;
            Console.WriteLine("Nhap mot so tu 1 den 9");
            hemattroi = byte.Parse(Console.ReadLine());
            switch (hemattroi)
            {
                case (byte)heMatTroi.MERCURY:
                    {
                        Console.WriteLine("MERCURY - SAO THUY");
                        break;
                    };
                case (byte)heMatTroi.VENUS:
                    {
                        Console.WriteLine("VENUS - SAO KIM");
                        break;
                    };
                case (byte)heMatTroi.TraiDat:
                    {
                        Console.WriteLine("TRAI DAT");
                        break;
                    };
                case (byte)heMatTroi.MARS:
                    {
                        Console.WriteLine("SAO HOA");
                        break;
                    };
                case (byte)heMatTroi.JUPITER:
                    {
                        Console.WriteLine("JUPITER - SAO MOC");
                        break;
                    };
                case (byte)heMatTroi.SATURN:
                    {
                        Console.WriteLine("SATURN - SAO THO");
                        break;
                    };
                case (byte)heMatTroi.URANUS:
                    {
                        Console.WriteLine("URANUS - SAO THIEN VUONG");
                        break;
                    };
                case (byte)heMatTroi.NEPTUNE:
                    {
                        Console.WriteLine("NEPTUNE - SAO HAI VUONG");
                        break;
                    }
                case (byte)heMatTroi.DWARFPLANET:
                    {
                        Console.WriteLine("DWARF PLANET - HANH TINH LUN - SAO DIEM VUONG");
                        break;
                    };
                
                default:
                    Console.WriteLine("Khong co hanh tinh hop le!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
