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
            int[] nhietDo = new int[5];
            float kq,trungBinh = 0;
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Nhap nhiet do cua ngay thu {0}", i + 1);
            nhapLai:
                int.TryParse(Console.ReadLine(), out nhietDo[i]);
                if (nhietDo[i] < -30 || nhietDo[i] > 130)
                {
                    Console.WriteLine("Nhiet do nhap vao khong hop le! xin mowi nhap lai!");
                    goto nhapLai;
                }
                trungBinh = trungBinh + nhietDo[i];
            }

            if (nhietDo[0] > nhietDo[1] && nhietDo[1] > nhietDo[2] && nhietDo[2] > nhietDo[3] && nhietDo[3] > nhietDo[4] )
                Console.WriteLine("Nhiet do dang lanh dan!");
            else if (nhietDo[0] < nhietDo[1] && nhietDo[1] < nhietDo[2] && nhietDo[2] < nhietDo[3] && nhietDo[3] < nhietDo[4])
                Console.WriteLine("Nhiet do dang nong dan!");
            else
                Console.WriteLine("Nhiet do dang hon loan!");

            Console.WriteLine("Nhiet do trong tat ca ca ngay la: ");
            foreach (var j in nhietDo)
            {
                Console.WriteLine(j);
            }
            kq = trungBinh / 5;
            Console.WriteLine("Nhiet do trung binh la: {0}", kq);
            
                Console.ReadLine();
        }
    }
}
