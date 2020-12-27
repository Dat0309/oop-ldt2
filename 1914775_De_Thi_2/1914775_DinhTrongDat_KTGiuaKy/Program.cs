using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1914775_DinhTrongDat_KTGiuaKy
{
   

    class Program
    {
        static void Main(string[] args)
        {
            DanhSachNhanVien DSNV = new DanhSachNhanVien();
            QuanLyNhanVien QL = new QuanLyNhanVien();
            Console.WriteLine("======================DANH SACH HIEN HANH==========================");
            DSNV.NhapTuFile();
            DSNV.Xuat();
            Console.WriteLine("=====TIM NHAN VIEN BAN THOI GIAN CO LUONG THAP NHAT THANG X DO=====");
            Console.WriteLine("DANH SACH NHAN VIEN BAN THOI GIAN" + "\n");
            Console.WriteLine(QL.DSNVBTG(DSNV));
            Console.WriteLine("=======================================");
            Console.WriteLine("Xin moi nhap thang: ");
            int thang = int.Parse(Console.ReadLine());
            Console.WriteLine("NHAN VIEN BAN THOI GIAN CO LUONG THAP NHAT THANG {0} LA: ",thang);
            Console.WriteLine(QL.TimNVBTGLuongMin(DSNV, thang));
            Console.WriteLine("NHAN PHIM BAT KY DE QUA CHUC NANG KHAC!!"+"\n");
            Console.ReadKey();
            Console.WriteLine("=======TIM THANG TRA LUONG CHO NHAN VIEN THAP NHAT============"+"\n");
            QL.TimThangTraLuongChoNVMin(DSNV);
            Console.WriteLine("NHAN PHIM BAT KY DE QUA CHUC NANG KHAC!!"+"\n");
            Console.ReadKey();
            Console.WriteLine("========TIM NHAN VIEN CO LUONG CAO NHAT===================="+"\n");
            Console.WriteLine(QL.TimNVLuongMax(DSNV));
            Console.WriteLine("==================KET THUC CHUONG TRINH====================");
            Console.ReadLine();
        }
    }
}
