using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class Program
    {
        enum Menu
        {
            Thoat,
            NhapTuBanPhim,
            NhapTuFile,
            Xuat,
            TimHinhVuongCoDTMax,
            TimHCNCosDTNhoNhat,
            TimHTCoBKMax,
            SapXepHVTangChuVi,
            SapXepHTTangCv,
            SapXepHCNTangCV,
            TimHinhCoDTMax,
            TimHinhCoCVMin,
            XoaHinhCoDTMax,
            XoaHinhCoCVMin
           
        }
        static void Main(string[] args)
        {
            QuanLyHinhHocc ql = new QuanLyHinhHocc();
            
            while(true)
            {
                Console.Clear();
                Console.WriteLine("===========================================");
                Console.WriteLine("Nhap {0} de Thoat", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de Nhap du lieu tu ban phim", (int)Menu.NhapTuBanPhim);
                Console.WriteLine("Nhap {0} de Nhap du lieu tu file", (int)Menu.NhapTuFile);
                Console.WriteLine("Nhap {0} de Xuat danh sach", (int)Menu.Xuat);
                Console.WriteLine("Nhap {0} de tim hinh vuong co dien tich lon nhat", (int)Menu.TimHinhVuongCoDTMax);
                Console.WriteLine("Nhap {0} de tim HCN co dien tich nho nhat", (int)Menu.TimHCNCosDTNhoNhat);
                Console.WriteLine("Nhap {0} de tim HT co ban kinh lon nhat",(int)Menu.TimHTCoBKMax);
                Console.WriteLine("Nhap {0} de Sap xep ds hinh vuong theo chieu tang giam cua chu vi", (int)Menu.SapXepHVTangChuVi);
                Console.WriteLine("Nhap {0} de Sap xep ds hinh tron theo chieu giam cua chu vi", (int)Menu.SapXepHTTangCv);
                Console.WriteLine("Nhap {0} de Sap xep ds dinh chu nhat tang theo chu vi", (int)Menu.SapXepHCNTangCV);
                Console.WriteLine("Nhap {0} de Tim hinh co dien tich lon nhat", (int)Menu.TimHinhCoDTMax);
                Console.WriteLine("Nhap {0} de tim hinh co chu vi nho nhat", (int)Menu.TimHinhCoCVMin);
                Console.WriteLine("Nhap {0} de Xoa hinh co dien tich lon nhat", (int)Menu.XoaHinhCoDTMax);
                Console.WriteLine("Nhap {0} de Xoa hinh co chu vi nho nhat", (int)Menu.XoaHinhCoCVMin);

                Menu nhap = (Menu)int.Parse(Console.ReadLine());
                switch(nhap)
                {
                    case Menu.Thoat:
                        return;
                    case Menu.NhapTuBanPhim:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("NHAP BAI TAY");
                            Console.WriteLine("=============================");
                            ql.NhapBangTay();
                            ql.Xuat();
                        }break;
                    case Menu.NhapTuFile:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("NHAP TU FILE");
                            Console.WriteLine("=============================");
                            ql.NhapTuFile();
                            Console.WriteLine("Da chuyen du lieu tu file vao danh sach!!!");
                            //ql.Xuat();
                        }break;
                    case Menu.Xuat:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("DANH SACH HIEN HANH");
                            Console.WriteLine("=============================");
                            ql.Xuat();
                        }break;
                    case Menu.TimHinhVuongCoDTMax:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("Tim hinh vuong co dien tich lon nhat");
                            Console.WriteLine("=============================");
                            //ql.NhapTuFile();
                            Console.WriteLine("Danh sach hinh vuong: ");
                            Console.WriteLine("Canh".PadRight(6) + "CV".PadRight(6) + "DT".PadRight(5));
                            Console.WriteLine("=====================");
                            ql.DanhSachHV.Xuat();
                            Console.WriteLine("Hinh vuong co dien tich lon nhat la: ");
                            Console.WriteLine("Canh".PadRight(6) + "CV".PadRight(6) + "DT".PadRight(5));
                            Console.WriteLine("====================================");
                            Console.WriteLine(ql.DanhSachHV.TimDTMax());
                        }break;
                    case Menu.TimHCNCosDTNhoNhat:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("Tim HCN co dien tich nho nhat");
                            Console.WriteLine("=============================");
                            //ql.NhapTuFile();
                            Console.WriteLine("DANH SACH HCN: ");
                            Console.WriteLine("Dai".PadRight(6) + "Rong".PadRight(6) + "CV".PadRight(6) + "DT".PadRight(5));
                            Console.WriteLine("===================================");
                            ql.DanhSachHCN.Xuat();
                            Console.WriteLine("Danh sach HCN co dien tich nho nhat la:");
                            Console.WriteLine("DANH SACH HCN: ");
                            Console.WriteLine("Dai".PadRight(6) + "Rong".PadRight(6) + "CV".PadRight(6) + "DT".PadRight(5));
                            Console.WriteLine("===================================");
                            Console.WriteLine(ql.DanhSachHCN.TimDTMin());
                        }break;
                    case Menu.TimHTCoBKMax:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("Tim Hinh tron co ban kinh lon nhat");
                            Console.WriteLine("=============================");
                            Console.WriteLine("SANH SACH HINH TRON: ");
                            Console.WriteLine("BK".PadRight(6) + "CV".PadRight(9) + "DT".PadRight(5));
                            Console.WriteLine("===================================");
                            ql.DanhSachHT.Xuat();
                            Console.WriteLine("Hinh tron co ban kinh lon nhat la:");
                            Console.WriteLine("SANH SACH HINH TRON: ");
                            Console.WriteLine("BK".PadRight(6) + "CV".PadRight(9) + "DT".PadRight(5));
                            Console.WriteLine("===================================");
                            Console.WriteLine(ql.DanhSachHT.TimBkMax());
                        }break;
                    case Menu.SapXepHVTangChuVi:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("Sap xep ds hinh vuong theo chieu tang giam cua chu vi");
                            Console.WriteLine("=============================");
                            ql.DanhSachHV.SapXepTangCV();
                            Console.WriteLine("Danh sach hinh vuong: ");
                            Console.WriteLine("Canh".PadRight(6) + "CV".PadRight(6) + "DT".PadRight(5));
                            Console.WriteLine("=====================");
                            Console.WriteLine(ql.DanhSachHV);
                        }break;
                    case Menu.SapXepHTTangCv:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("Sap xep ds hinh tron theo chieu tang giam cua chu vi");
                            Console.WriteLine("=============================");
                            ql.DanhSachHT.SapXepGiamCV();
                            Console.WriteLine("SANH SACH HINH TRON: ");
                            Console.WriteLine("BK".PadRight(6) + "CV".PadRight(9) + "DT".PadRight(5));
                            Console.WriteLine("===================================");
                            Console.WriteLine(ql.DanhSachHT);
                        }break;
                    case Menu.SapXepHCNTangCV:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("Sap xep ds hinh tron theo chieu tang giam cua chu vi");
                            Console.WriteLine("=============================");
                            ql.DanhSachHCN.SapXepTangCV();
                            Console.WriteLine("DANH SACH HCN: ");
                            Console.WriteLine("Dai".PadRight(6) + "Rong".PadRight(6) + "CV".PadRight(6) + "DT".PadRight(5));
                            Console.WriteLine("===================================");
                            Console.WriteLine(ql.DanhSachHCN);
                            
                        }break;
                    case Menu.TimHinhCoDTMax:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("Tim hinh co dien tich lon nhat");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Danh sach hien hanh:");
                            ql.Xuat();
                            Console.WriteLine("Hinh co dien tich lon nhat la: ");
                            ql.HienThiDSDTMax();
                        }break;
                    case Menu.TimHinhCoCVMin:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("Tim hinh co chu vi nho nhat");
                            Console.WriteLine("=============================");
                            Console.WriteLine("Danh sach hien hanh:");
                            ql.Xuat();
                            Console.WriteLine("Hinh co chu vi nho nhat la:");
                            ql.HienThiDSCVMin();
                        }break;
                    case Menu.XoaHinhCoDTMax:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("Xoa hinh co dien tich lon nhat");
                            Console.WriteLine("=============================");
                            ql.Xuat();
                            Console.WriteLine("Hinh co dien tich lon nhat la: ");
                            ql.HienThiDSDTMax();
                            Console.WriteLine("Nhan phim bat ky de xoa hinh co dien tich lon nhat!!!");
                            Console.ReadKey();
                            Console.Clear();
                            ql.XoaHinhDTMax();
                            ql.Xuat();
                        }break;
                    case Menu.XoaHinhCoCVMin:
                        {
                            Console.Clear();
                            Console.WriteLine("=============================");
                            Console.WriteLine("Xoa hinh co chu vi nho nhat");
                            Console.WriteLine("=============================");
                            ql.Xuat();
                            Console.WriteLine("Hinh co chu vi nho nhat la: ");
                            ql.HienThiDSCVMin();
                            Console.WriteLine("Nhan phim bat ky de xoa hinh co dchu vi nho nhat!!!");
                            Console.ReadKey();
                            Console.Clear();
                            ql.XoaHinhCVMin();
                            ql.Xuat(); 
                        }break;
                }
                Console.ReadLine();
            }
        }
    }
}
