using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int nhietDo,tong=0,trungBinh;
            for (int i=1;i<10;i++)
            {
                Console.WriteLine("Moi nguoi dung nhap vao Nhiet do hang ngay: ");
                int.TryParse(Console.ReadLine(), out nhietDo);
                tong = tong + nhietDo;
            }
            
        }
    }
}
