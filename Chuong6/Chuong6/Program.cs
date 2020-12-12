using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] soNguyen = new int[] { 5, 6, 1, 4, 9, 8, 3, 7, 12, 58 };
            
            int chon;
            do
            {
                Console.WriteLine("================MENU=================");
                Console.WriteLine("XIN MOI NGUOI DUNG NHAP LUA CHON: ");
                Console.WriteLine("1.Xem danh sach tu dau toi cuoi. ");
                Console.WriteLine("2.Xem danh sach tu cuoi den dau.");
                Console.WriteLine("3.Chon mot vi tri cu the de xem.");
                Console.WriteLine("4.Thoat chuong trinh.");
                int.TryParse(Console.ReadLine(),out chon);
                switch (chon)
	            {
                    case 1: 
                        Console.WriteLine("Xem danh sach tu dau toi cuoi. ");
                        for (int i = 0; i < 10;i++ )
                        {
                            Console.WriteLine("Phan tu thu {0} la {1}", i + 1, soNguyen[i]);
                        }
                        Console.WriteLine("====================================================");
                        Console.ReadLine();
                            break;
                    case 2:
                        Console.WriteLine("Xem danh sach tu cuoi den dau. ");
                        Array.Reverse(soNguyen);
                        for (int i = 0; i < soNguyen.Length; i++)
                            Console.WriteLine(soNguyen[i]);
                        
                        Console.WriteLine("====================================================");
                            Console.ReadLine();
                            break;
                    case 3:
                        Console.WriteLine("Chon mot vi tri cu the de xem. ");
                        int nhap;
                        Console.WriteLine("Nhap vi tri bat ki de xem: ");
                        int.TryParse(Console.ReadLine(), out nhap);
                        Console.WriteLine("Vi tri thu {0} co gia tri la {1}", nhap, soNguyen[nhap]);
                        Console.WriteLine("====================================================");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Vui long nhap lai!");
                     break;
	             }

            }while(chon!=4);
            Console.ReadLine();
        }
    }
}
