using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien dsnv = new DanhSachNhanVien();
            QuanLyNhanVien ql = new QuanLyNhanVien();
            dsnv.NhapTuFile();
            dsnv.Xuat();
            Console.WriteLine("===========================");
            Console.WriteLine(ql.DSNVBTG(dsnv));
            Console.WriteLine("Xin moi nhap thang x: ");
            int thang = int.Parse(Console.ReadLine());
            
            //Console.WriteLine(ql.DSNVBTGThang(dsnv, thang));
            Console.WriteLine("Nhan vien ban thoi gina luong thap nhat thang {0} la: ", thang);
            Console.WriteLine(ql.TimNVBTGLuongMinThang(dsnv, thang));
            Console.WriteLine("==============================");
            Console.WriteLine(ql.TimNhanVienCoLuongMax(dsnv));
            Console.ReadLine();
        }
    }
}
