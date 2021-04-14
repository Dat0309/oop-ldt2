using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhap1
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachAnPham DSAP = new DanhSachAnPham();
            QuanLyAnPham ql=new QuanLyAnPham();
            DSAP.NhapTuFile();
            DSAP.Xuat();
            //Console.WriteLine("An pham co tua de dai nhat la: "+"\n");
            //Console.WriteLine(ql.HienThiAPTuaDeMax(DSAP));
            //Console.WriteLine("An pham co so trang dai nhat la: " + "\n");
            //Console.WriteLine(ql.APTrangMax(DSAP));
            //Console.WriteLine("Hien thi an pham theo chieu tang cua so trang:" + "\n");
            //Console.WriteLine(ql.TangGiamTrang(DSAP));
            //Console.WriteLine("Tim tap chi co so bai viet nhieu nhat" + "\n");
            //Console.WriteLine(ql.TCSLBVMax(DSAP));
            //ql.HienThiDSNXB(DSAP);
            Console.ReadLine();
        }
    }
}
