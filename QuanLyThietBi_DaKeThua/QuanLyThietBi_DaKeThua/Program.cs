using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi_DaKeThua
{
    class Program
    {
        enum Menu
        {
            Thoat,
            NhapTuFile,
            Xuat,
            TimThietBiCoGiaMax,
            TimMayTinhCoGiaMaxMin,
            TimMayAnhGiaMin,
            DemSoTBTheoGia,
            SapXepThietBiTheoGia,
            TimTBGiaCPUMax,
            TimCPUSDMax
        }
        static void Main(string[] args)
        {
            DanhSachLinhKien DSLK = new DanhSachLinhKien();
            DanhSachThietBi DSTB = new DanhSachThietBi();
            QuanLyThietBi ql = new QuanLyThietBi();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("================= DANH SACH CHUC NANG =================");
                Console.WriteLine("Nhap {0} de Thoat chuong trinh", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de doc du lieu tu file", (int)Menu.NhapTuFile);
                Console.WriteLine("Nhap {0} de Xuat danh sach du lieu", (int)Menu.Xuat);
                Console.WriteLine("Nhap {0} de Tim thiet bi co gia max", (int)Menu.TimThietBiCoGiaMax);
                Console.WriteLine("Nhap {0} de Tim may tinh co gia cao nhat - thap nhat", (int)Menu.TimMayTinhCoGiaMaxMin);
                Console.WriteLine("Nhap {0} de Tim may anh co gia thap nhat", (int)Menu.TimMayAnhGiaMin);
                Console.WriteLine("Nhap {0} de Dem so thiet bi theo gia", (int)Menu.DemSoTBTheoGia);
                Console.WriteLine("Nhap {0} de Sap xep thiet bi tang theo gia", (int)Menu.SapXepThietBiTheoGia);
                Console.WriteLine("Nhap {0} de Tim thiet bij gia CPU cao nhat", (int)Menu.TimTBGiaCPUMax);
                Console.WriteLine("Nhap {0} de Tim CPU duoc nhieu thiet bi su dung nhat", (int)Menu.TimCPUSDMax);

                Menu nhap = (Menu)int.Parse(Console.ReadLine());
                Console.Clear();
                switch (nhap)
                {
                    case Menu.Thoat:
                        return;
                    case Menu.NhapTuFile:
                        {
                            Console.Clear();
                            DSLK.NhapTuFile();
                            DSTB.NhapTuFile();
                            Console.WriteLine("============== DANH SACH THIET BI ==============");
                            DSTB.Xuat();
                            Console.WriteLine("============== DANH SACH LINH KIEN ==============");
                            DSLK.Xuat();
                        }
                        break;
                    case Menu.TimThietBiCoGiaMax:
                        {
                            Console.Clear();
                            Console.WriteLine(ql.TimThietBiCoGiaCaoNhat(DSTB));

                        }
                        break;
                    case Menu.TimMayTinhCoGiaMaxMin:
                        {
                            Console.Clear();
                            Console.WriteLine(ql.DS_MT(DSTB));
                            Console.WriteLine("=====================");
                            Console.WriteLine(ql.TimMayTinhGiaMax(DSTB));
                        }break;
                    case Menu.Xuat:
                        { 
                            Console.Clear();
                            DSTB.Xuat();
                            DSLK.Xuat();
                        }break;
                    case Menu.TimMayAnhGiaMin:
                        {
                            Console.Clear();
                            Console.WriteLine(ql.DS_MA(DSTB));
                            Console.WriteLine("======================");
                            Console.WriteLine(ql.TimMayAnhGiaMin(DSTB));
                        }break;
                    case Menu.DemSoTBTheoGia:
                        {
                            Console.Clear();
                            DSTB.Xuat();
                            Console.WriteLine("Xin moi nhap gia cua thiet bi may anh, may tinh can dem!!");
                            float gia = float.Parse(Console.ReadLine());
                            Console.WriteLine("Tim thay {0} thiet bi co gia {1}", ql.TimThietBiTheoGia(DSTB, gia).Dem(), gia);
                            Console.WriteLine(ql.TimThietBiTheoGia(DSTB, gia));
                        }break;
                    case Menu.SapXepThietBiTheoGia:
                        {
                            Console.Clear();
                            Console.WriteLine(ql.SapXepTBGiaTang(DSTB));
                        }break;
                    case Menu.TimTBGiaCPUMax:
                        {
                            Console.Clear();
                            DSTB.Xuat();
                            Console.WriteLine("==========================");
                            Console.WriteLine(ql.TimTBGiaCUPMax(DSTB));
                        }break;
                    case Menu.TimCPUSDMax:
                        {
                            Console.Clear();
                            //Console.WriteLine(ql.TimCPUSDMax(DSTB,DSLK));
                            ql.HienThiCPUSDMax(DSTB, DSLK);
                        }break;
                    default:
                        break;
                }
                Console.ReadLine();
            }

        }
    }
}
