using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, e, f,luongMax,tongLuong;
            int i = 0;
            string strgTenNv;
            

            while (i<1)
            {
                while (i <1)
                {
                    Console.WriteLine("Nhap ten va tong so tien ban duoc cua nhan vien: ");
                    strgTenNv = Console.ReadLine();
                    
                        if (strgTenNv[i] == 'd' || strgTenNv[i] == 'D')
                            int.TryParse(Console.ReadLine(), out d);
                        else if (strgTenNv[i] == 'e' || strgTenNv[i] == 'E')
                            int.TryParse(Console.ReadLine(), out e);
                        else if (strgTenNv[i] == 'f' || strgTenNv[i] == 'F')
                            int.TryParse(Console.ReadLine(), out f);
                        //else if (strgTenNv[i] == 'z' || strgTenNv[i] == 'Z')
                        //    Console.WriteLine("Tong so tien ban duoc cua nhan vien Daniele la: ${0}", d);
                        //    i++;
                        else
                        {
                            Console.WriteLine("error");
                        }
                    
                }
                
            }
            Console.ReadLine();
        }
    }
}
