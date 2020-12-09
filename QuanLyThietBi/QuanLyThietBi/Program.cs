using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
    class Program
    {
        enum Menu
        {
            Thoat,
            NhapBangTay,
            NhapTuFile,
            Xuat,
            TimMayTinhCoGiaCaoThap,
            TimMayAnhCoGiaCaoThap,
            DemSoLuongMayTinhMayAnhCoGia,
            SapXepTangGiamGia,
            SapXepMayTinhTangGiamGia,
            TimThietBiCPUMaxMin,
            DemSoLuongRamKhongDuocSD,
            DemSoLuongCPUKhongDuocSD,
            DemSoLuongRAMTheoLoaiRAM,
            XoaRAMTheoGia,
            XoaTatCaThietBiRAM,
            TimLKSDMax
            
        }
        static void Main(string[] args)
        {
            DanhSachThietBi DSTB = new DanhSachThietBi();
            DanhSachLinhKien DSLK = new DanhSachLinhKien();
            QuanLyThietBi QL = new QuanLyThietBi();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Danh sach chuc nang:");
                Console.WriteLine("Nhap {0} de Thoat chuong trinh", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de Nhap du lieu bang tay", (int)Menu.NhapBangTay);
                Console.WriteLine("Nhap {0} de Nhap du lieu tu file", (int)Menu.NhapTuFile);
                Console.WriteLine("Nhap {0} de xuat danh sach   ", (int)Menu.Xuat);
                Console.WriteLine("Nhap {0} de tim may tinh co gia cao nhat, thap nhat", (int)Menu.TimMayTinhCoGiaCaoThap);
                Console.WriteLine("Nhap {0} de tim may anh co gia cao nhat, thap nhat", (int)Menu.TimMayAnhCoGiaCaoThap);
                Console.WriteLine("Nhap {0} de dem so luong may anh, may tinh co gia la x", (int)Menu.DemSoLuongMayTinhMayAnhCoGia);
                Console.WriteLine("Nhap {0} de sap xep 2 thiet bi theo chieu tang, giam gia",(int)Menu.SapXepTangGiamGia);
                Console.WriteLine("Nhap {0} de sap xep may tinh tang, giam gia", (int)Menu.SapXepMayTinhTangGiamGia);
                Console.WriteLine("Nhap {0} de tim thiet bi co gia CPU cao, thap nhat", (int)Menu.TimThietBiCPUMaxMin);
                Console.WriteLine("Nhap {0} de dem so luong CPU duoc nhieu thiet bi su dung nhat", (int)Menu.DemSoLuongRamKhongDuocSD);
                Console.WriteLine("Nhap {0} de dem so luong RAM khong duoc su dung", (int)Menu.DemSoLuongCPUKhongDuocSD);
                Console.WriteLine("Nhap {0} de dem so luong RAM theo loai RAM", (int)Menu.DemSoLuongRAMTheoLoaiRAM);
                Console.WriteLine("Nhap {0} de xoa mot loai RAM theo gia", (int)Menu.XoaRAMTheoGia);
                Console.WriteLine("Nhap {0} de xoa tat ca cac thiet bi su dung RAM gia x", (int)Menu.XoaTatCaThietBiRAM);
                Console.WriteLine("Nhap {0} de tim linh kien duoc su dung nhieu nhat", (int)Menu.TimLKSDMax);


                Menu nhap = (Menu)int.Parse(Console.ReadLine());
                Console.Clear();
                switch (nhap)
                {
                    case Menu.Thoat:
                        return;
                    case Menu.NhapBangTay:
                        {
                            Console.Clear();
                            DSTB.NhapBangTay();
                            DSTB.Xuat();
                        }
                        break;
                    case Menu.NhapTuFile:
                        {
                            Console.Clear();
                            DSTB.NhapTuFile();
                            DSLK.NhapTuFile();
                            Console.WriteLine("Da chuyen du lieu vao danh sach!!" + "\n");
                            //DSLK.Xuat();
                            DSTB.Xuat(); 
                        }
                        break;
                    case Menu.Xuat:
                        {
                            Console.Clear();
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("Danh sach Thiet bi:" + "\n" + "============================================================================" + "\n");
                            DSTB.Xuat();
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("Danh sach Linh kien:" + "\n" + "============================================================================" + "\n");
                            DSLK.Xuat();
                        }
                        break;
                    case Menu.TimMayTinhCoGiaCaoThap:
                        {
                            Console.Clear();
                            Console.WriteLine("May tinh co gia cao nhat la:" + "\n");
                            QL.TimMTGiaMax(DSTB).Xuat();
                            Console.WriteLine("May tinh co gia thap nhat la:" + "\n");
                            QL.TimMTGiaMin(DSTB).Xuat();
                        }break;
                    case Menu.TimMayAnhCoGiaCaoThap:
                        {
                            Console.Clear();
                            Console.WriteLine("May anh co gia cao nhat la:" + "\n");
                            QL.TimMAGiaMax(DSTB).Xuat();
                            Console.WriteLine("May anh co gia thap nhat la:" + "\n");
                            QL.TimMAGiaMin(DSTB).Xuat();
                        }break;
                    case Menu.DemSoLuongMayTinhMayAnhCoGia:
                        {
                            Console.Clear();
                            float gia;
                            Console.WriteLine("Xin moi nhap gia x:");
                            gia = float.Parse(Console.ReadLine());
                            Console.WriteLine("Tim thay {0} thiet bi co gia la {1}$!", QL.TimTheoGia(DSTB, gia).Dem(), gia);
                            
                        }break;
                    case Menu.SapXepTangGiamGia:
                        {
                            Console.Clear();
                            Console.WriteLine("Hien thi danh sch theo chieu tang: " + "\n");
                            QL.SapXepGiaTang(DSTB).Xuat();
                            Console.WriteLine("Hien thi danh sach theo chieu giam: " + "\n");
                            QL.SapXepGiaGiam(DSTB).Xuat();
                        }break;
                    case Menu.SapXepMayTinhTangGiamGia:
                        {
                            Console.Clear();
                            Console.WriteLine("Hien thi danh sach may tinh theo chieu tang: " + "\n");
                            QL.SapXepMTTangGia(DSTB).Xuat();
                            Console.WriteLine("Hien thi danh sach may tinh theo chieu giam: " + "\n");
                            QL.SapXepMTGiamGia(DSTB).Xuat();
                        }break;
                    case Menu.TimThietBiCPUMaxMin:
                        {
                            Console.Clear();
                            Console.WriteLine("Thiet bi co gia CPU cao nhat la: ");
                            QL.TimThietBiCPUMax(DSTB).Xuat();
                        }break;
                    case Menu.DemSoLuongRamKhongDuocSD:
                        {
                            Console.Clear();
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("Danh sach Thiet bi:" + "\n" + "============================================================================" + "\n");
                            DSTB.Xuat();
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("Danh sach Linh kien:" + "\n" + "============================================================================" + "\n");
                            DSLK.Xuat();
                            Console.WriteLine("============================================================================");
                            QL.HienThiCPUSDMax(DSTB, DSLK);
                            Console.WriteLine("=====");
                            QL.HienThiCPUSDMin(DSTB, DSLK);

                        }break;
                    case Menu.DemSoLuongCPUKhongDuocSD:
                        {
                            Console.Clear();
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("Danh sach Thiet bi:" + "\n" + "============================================================================" + "\n");
                            DSTB.Xuat();
                            Console.WriteLine("============================================================================");
                            Console.WriteLine("Danh sach Linh kien:" + "\n" + "============================================================================" + "\n");
                            DSLK.Xuat();
                            Console.WriteLine("============================================================================");
                            QL.HienThiRAMSDMin(DSTB, DSLK);
                        }break;
                    case Menu.DemSoLuongRAMTheoLoaiRAM:
                        {
                            Console.Clear();
                            QL.HienThiRAMtheoRAM(DSTB, DSLK);
                        }break;
                    case Menu.XoaRAMTheoGia:
                        {
                            Console.Clear();
                            DSLK.Xuat();
                            float gia;
                            Console.WriteLine("Xin moi nhap gia :");
                            gia=float.Parse(Console.ReadLine());
                            DSLK.XoaRAM(gia);
                            DSLK.Xuat();
                        }break;
                    case Menu.XoaTatCaThietBiRAM:
                        {
                            Console.Clear();
                            DSTB.Xuat();
                            float gia;
                            Console.WriteLine("Xin moi nhap gia :");
                            gia = float.Parse(Console.ReadLine());
                            DSTB.XoaThietBiRAMGiaX(gia);
                            DSTB.Xuat();
                        }break;
                    case Menu.TimLKSDMax:
                        {
                            Console.Clear();
                            QL.HienThiLinhKienDSMax(DSTB, DSLK);
                        }break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
