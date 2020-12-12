using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nhietDo,tong=0,i=1;
            float trungBinh;
            
                for (i =1;i<=10;i++)
                {
                    Console.WriteLine("Moi nguoi dung Nhap nhiet do hang ngay: ");
                    int.TryParse(Console.ReadLine(), out nhietDo);
                    if (nhietDo > 130 || nhietDo < 20)
                    {
                        Console.WriteLine("error!");
                    }
                    else
                    {
                        Console.WriteLine("Nhiet do cua ngay {0} la:{1}C ", i,nhietDo);
                        tong += nhietDo;
                    }
                    
                }
                trungBinh = tong / 10;
                Console.WriteLine("\n");
                Console.WriteLine("Nhiet do trung binh hang ngay la:{0}C",trungBinh);
                Console.ReadLine();

        }
    }
}
