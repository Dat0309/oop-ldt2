using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class Program
    {
        enum Menu
        {
            Thoat,
            NhapTuBanPhim,
            NhapTuFile,
            Xuat,
            TimTapChiCoSLBVMaxMin,
            TimTuaDeNganDai,
            TimTrangNganDai,
            HienThiDSTheoNXB,
            TimNXBNhieuAnPhamNhat,
            TimTatCaAnPhamTheoNXBDo,
            XoaAnPhamThuocNXB
        }
        static void Main(string[] args)
        {
            QuanLyAnPhamm ql = new QuanLyAnPhamm();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=============================================");
                Console.WriteLine("Nhap {0} de thoat chuong trinh", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de Nhap tu ban phim", (int)Menu.NhapTuBanPhim);
                Console.WriteLine("Nhap {0} de Nhap tu file", (int)Menu.NhapTuFile);
                Console.WriteLine("Nhap {0} de Xuat Danh sach du lieu", (int)Menu.Xuat);
                Console.WriteLine("Nhap {0} de Tim tap chi co so luong bai viet lon nhat, nho nhat", (int)Menu.TimTapChiCoSLBVMaxMin);
                Console.WriteLine("Nhap {0} de Tim tua de ngan nhat - dai nhat", (int)Menu.TimTuaDeNganDai);
                Console.WriteLine("Nhap {0} de Tim trang ngan - dai nhat", (int)Menu.TimTrangNganDai);
                Console.WriteLine("Nhap {0} de Hien thi danh sach theo nxb", (int)Menu.HienThiDSTheoNXB);
                Console.WriteLine("Nhap {0} de tim NXB nhieu - it an pham nhat", (int)Menu.TimNXBNhieuAnPhamNhat);
                Console.WriteLine("Nhap {0} de Tim tat ca an pham theo NXB", (int)Menu.TimTatCaAnPhamTheoNXBDo);
                Console.WriteLine("Nhap {0} de Xoa tat ca an pham thuoc NXB nao do", (int)Menu.XoaAnPhamThuocNXB);


                Menu nhap = (Menu)int.Parse(Console.ReadLine());
                switch (nhap)
                {
                    case Menu.Thoat:
                        return;
                    case Menu.NhapTuBanPhim:
                        {
                            Console.Clear();
                            Console.WriteLine("================================");
                            Console.WriteLine("NHAP BANG TAY!");
                            Console.WriteLine("================================");
                            ql.NhapBangTay();
                            ql.Xuat();
                        }
                        break;
                    case Menu.NhapTuFile:
                        {
                            Console.Clear();
                            Console.WriteLine("================================");
                            Console.WriteLine("NHAP TU FILE!");
                            Console.WriteLine("================================");
                            ql.NhapTuFile();
                            Console.WriteLine("Du lieu tu file da duoc chuyen vao danh sach!");
                        }
                        break;
                    case Menu.Xuat:
                        {
                            Console.Clear();
                            Console.WriteLine("================================");
                            Console.WriteLine("DANH SACH HIEN HANH: ");
                            Console.WriteLine("================================");
                            ql.Xuat();
                        }
                        break;
                    case Menu.TimTapChiCoSLBVMaxMin:
                        {
                            Console.Clear();
                            Console.WriteLine("================================");
                            Console.WriteLine("TIM TAP CHI CO SLBV MAX-MIN: ");
                            Console.WriteLine("================================");
                            Console.WriteLine("DANH SACH TAP CHI MAX: ");
                            Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(15) + "NXB".PadRight(10) + "So bai viet".PadRight(5));
                            Console.WriteLine("================================================");
                            Console.WriteLine(ql.DSTapChi.TimSLBVMax());
                            Console.WriteLine("DANH SACH TAP CHI MIN: ");
                            Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(15) + "NXB".PadRight(10) + "So bai viet".PadRight(5));
                            Console.WriteLine("================================================");
                            Console.WriteLine(ql.DSTapChi.TimSLBVMin());
                        }break;
                    case Menu.TimTuaDeNganDai:
                        {
                            Console.Clear();
                            Console.WriteLine("================================");
                            Console.WriteLine("TIM TUA DE NGAN NHAT - DAI NHAT: ");
                            Console.WriteLine("================================");
                            Console.WriteLine("Danh sach hien hanh:");
                            ql.Xuat();
                            Console.WriteLine("NHAN PHIM BAT KY DE TIEP TUC!!!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("An pham co tua de dai nhat la: " + "\n");
                            ql.HienThiDSTuaDeMax();
                            Console.WriteLine("An pham co tua de ngan nhat la: " + "\n");
                            ql.HienThiDSTuaDeMin();
                        }break;
                    case Menu.TimTrangNganDai:
                        {
                            Console.Clear();
                            Console.WriteLine("================================");
                            Console.WriteLine("TIM TUA DE NGAN NHAT - DAI NHAT: ");
                            Console.WriteLine("================================");
                            Console.WriteLine("Danh sach hien hanh:");
                            ql.Xuat();
                            Console.WriteLine("NHAN PHIM BAT KY DE TIEP TUC!!!");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("An pham co trang dai nhat :" + "\n");
                            ql.HienThiDSTrangMax();
                            Console.WriteLine("An pham co trang ngan nhat :" + "\n");
                            ql.HienThiDSTrangMin();
                        }break;
                    case Menu.HienThiDSTheoNXB:
                        {
                            Console.Clear();
                            Console.WriteLine("================================");
                            Console.WriteLine("HIEN THI DANH SACH THEO NHA XUAT BAN: ");
                            Console.WriteLine("================================");
                            ql.HienThidsTheoNXB();
                        }break;
                    case Menu.TimNXBNhieuAnPhamNhat:
                        {
                            Console.Clear();
                            Console.WriteLine("================================");
                            Console.WriteLine("TIM NXB CO NHIEU - IT AN PHAM NHAT: ");
                            Console.WriteLine("================================");
                            Console.WriteLine("Danh sach hien hanh:");
                            ql.Xuat();
                            Console.WriteLine("NHAN PHIM BAT KY DE TIEP TUC!!!");
                            Console.ReadKey();
                            Console.Clear();
                            ql.HienThiDSNXBMax();
                            ql.HienThiDSNXBMin();
                        }break;
                    case Menu.TimTatCaAnPhamTheoNXBDo:
                        {
                            Console.Clear();
                            Console.WriteLine("================================");
                            Console.WriteLine("TIM NXB CO NHIEU - IT AN PHAM NHAT: ");
                            Console.WriteLine("================================");
                            ql.TimTheoNXB();
                        }break;
                    case Menu.XoaAnPhamThuocNXB:
                        {
                            Console.Clear();
                            Console.WriteLine("================================");
                            Console.WriteLine("XOA TAT CA AN PHAM CUA NXB : ");
                            Console.WriteLine("================================");
                            ql.Xuat();
                            Console.WriteLine("NHAN PHIM BAT KY DE TIEP TUC!!!");
                            Console.ReadKey();
                            Console.Clear();
                            ql.XoaDSTheoNXB();
                            ql.Xuat();
                        }break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
