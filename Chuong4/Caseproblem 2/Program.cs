using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caseproblem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tuongTrong,tuongNgoai,tongChiPhi;
            byte thang;
            Console.WriteLine("Nhap vao so buc tranh tuong Noi That can son : ");
            int.TryParse(Console.ReadLine(), out tuongTrong);
            Console.WriteLine("Nhap vao so buc tranh tuong Ngoai can son : ");
            int.TryParse(Console.ReadLine(), out tuongNgoai);
            Console.WriteLine("Nhap thang ");
            byte.TryParse(Console.ReadLine(), out thang);
            
            if (thang==12||thang==1||thang==2)
            {
                tuongNgoai = 0;
                tongChiPhi = 750 * tuongNgoai + 500 * tuongTrong;
                Console.WriteLine("Tong chi phi la: ${0}", tongChiPhi);
            }
            else if(thang ==4||thang==5||thang==9||thang==10)
            {
                tongChiPhi = 699 * tuongNgoai + 500 * tuongTrong;
                Console.WriteLine("Tong chi phi la: ${0}", tongChiPhi);
            }
            else if (thang==7||thang==8)
            {
                tongChiPhi = 750 * tuongNgoai + 450 * tuongTrong;
                Console.WriteLine("Tong chi phi la: ${0}", tongChiPhi);
            }
            else
            {
                tongChiPhi = 500 * tuongNgoai + 750 * tuongTrong; 
            }
            Console.ReadKey();
        }
    }
}
