using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_KeThua
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
            HienThiTheoChieuTangDT,
            HienThiTheoChieuGiamCV,
            XoaCacHinhCoDTMin,
                XoaCacHinhCoCVMax
           
        }
        static void Main(string[] args)
        {
            QuanLyHinhHoc ql = new QuanLyHinhHoc();
            DanhSachHinhHoc ds = new DanhSachHinhHoc();
            while (true)
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
                Console.WriteLine("Nhap {0} de hien thi tat ca cac hinh theo chieu giam cua dien tich", (int)Menu.HienThiTheoChieuTangDT);
                Console.WriteLine("Nhap {0} de hien thi tat ca cac hinh theo chieu tang cua chu vi", (int)Menu.HienThiTheoChieuGiamCV);
                Console.WriteLine("Nhap {0} de xoa cac hinh co dien tich nho nhat", (int)Menu.XoaCacHinhCoDTMin);
                Console.WriteLine("Nhap {0} de xoa cac hinh co chu vi lon nhat", (int)Menu.XoaCacHinhCoCVMax);

                Menu nhap = (Menu)int.Parse(Console.ReadLine());
                switch (nhap)
                {
                    case Menu.Thoat:
                        return;
                    case Menu.NhapTuBanPhim:
                        {
                            Console.Clear();
                            ds.NhapBangTay();
                            ds.Xuath();
                        }
                        break;
                    case Menu.NhapTuFile:
                        {
                            Console.Clear();
                            ds.NhapTuFile();
                            
                            Console.WriteLine("Du lieu da duoc chuyen vao!");
                        }
                        break;
                    case Menu.Xuat:
                        {
                            Console.Clear();
                            ds.Xuat();
                        }
                        break;
                    case Menu.TimHinhVuongCoDTMax:
                        {
                            Console.Clear();
                            DanhSachHinhHoc kq1 = ql.TimHVDTMax(ds);
                            DanhSachHinhHoc kq2 = ql.TimHVDTMin(ds);
                            Console.WriteLine("Hinh vuong co dien tich lon nhat la: " + "\n");
                            Console.WriteLine(kq1);
                            Console.WriteLine("Hinh vuong co dien tich nho nhat la: " + "\n");
                            Console.WriteLine(kq2);
                        }
                        break;
                    case Menu.TimHCNCosDTNhoNhat:
                        {
                            Console.Clear();
                            DanhSachHinhHoc kq = ql.TimHCNDTMin(ds);
                            Console.WriteLine("HCN Co dien tich nho nhat la: "+"\n");
                            Console.WriteLine(kq);
                        }
                        break;
                    case Menu.TimHTCoBKMax:
                        {
                            Console.Clear();
                            DanhSachHinhHoc kq = ql.TimHTBKMax(ds);
                            Console.WriteLine("Hinh tron co ban kinh lon nhat la:" + "\n");
                            Console.WriteLine(kq);
                        }
                        break;
                    case Menu.SapXepHVTangChuVi:
                        {
                            Console.Clear();
                            DanhSachHinhHoc kq1 = ql.SapXepHVTangCV(ds);
                            DanhSachHinhHoc kq2 = ql.SapXepHVGiamCV(ds);
                            Console.WriteLine("Sap DSHV Tang theo chu vi:" + "\n" + "=========================================");
                            Console.WriteLine(kq1+"\n");
                            Console.WriteLine("Sap DSHV Giam theo chu vi:" + "\n" + "=========================================");
                            Console.WriteLine(kq2);
                        }
                        break;
                    case Menu.SapXepHTTangCv:
                        {
                            Console.Clear();
                            DanhSachHinhHoc kq1 = ql.SapXepHTTangCV(ds);
                            DanhSachHinhHoc kq2 = ql.SapXepHTGiamCV(ds);
                            Console.WriteLine("Sap DSHT Tang theo chu vi:" + "\n" + "=========================================");
                            Console.WriteLine(kq1 + "\n");
                            Console.WriteLine("Sap DSHT Giam theo chu vi:" + "\n" + "=========================================");
                            Console.WriteLine(kq2);
                        }
                        break;
                    case Menu.SapXepHCNTangCV:
                        {
                            Console.Clear();
                            DanhSachHinhHoc kq1 = ql.SapXepHCNTangCV(ds);
                            DanhSachHinhHoc kq2 = ql.SapXepHCNGiamCV(ds);
                            Console.WriteLine("Sap DSHCN Tang theo chu vi:" + "\n" + "=========================================");
                            Console.WriteLine(kq1 + "\n");
                            Console.WriteLine("Sap DSHCN Giam theo chu vi:" + "\n" + "=========================================");
                            Console.WriteLine(kq2);
                        }
                        break;
                    case Menu.TimHinhCoDTMax:
                        {
                            Console.Clear();
                            DanhSachHinhHoc kq1 = ql.TimHinhCoDTMax(ds);
                            DanhSachHinhHoc kq2 = ql.TimHinhCoDTMin(ds);
                            Console.WriteLine("Hinh co dien tich lon nhat la: " + "\n");
                            Console.WriteLine(kq1+"\n");
                            Console.WriteLine("Hinh co dien tich nho nhat la: " + "\n");
                            Console.WriteLine(kq2);
                        }
                        break;
                    case Menu.TimHinhCoCVMin:
                        {
                            Console.Clear();
                            DanhSachHinhHoc kq1 = ql.TimHinhCoCVMax(ds);
                            DanhSachHinhHoc kq2 = ql.TimHinhCoCVMin(ds);
                            Console.WriteLine("Hinh co chu vi lon nhat la: " + "\n");
                            Console.WriteLine(kq1 + "\n");
                            Console.WriteLine("Hinh co chu vi nho nhat la: " + "\n");
                            Console.WriteLine(kq2);
                        }
                        break;
                    case Menu.HienThiTheoChieuTangDT:
                        {
                            Console.Clear();
                            Console.WriteLine(ql.SapXepDTGiam(ds));
                        }break;
                    case Menu.HienThiTheoChieuGiamCV:
                        {
                            Console.Clear();
                            Console.WriteLine(ql.SapXepCVTang(ds));
                        }break;
                    case Menu.XoaCacHinhCoCVMax:
                        {
                            Console.Clear();
                            Console.WriteLine("Hinh co chu vi lon nhat la: " + ql.TimHinhCoCVMax(ds));
                            Console.WriteLine("Nhan phim bat ky de xoa hinh co chu vi max!!");
                            Console.ReadKey();
                            ql.XoaHinhCoCVMax(ds);
                            ds.Xuat();
                        }break;
                    case Menu.XoaCacHinhCoDTMin:
                        {
                            Console.Clear();
                            Console.WriteLine("Hinh co dien tich nho nhat la: " + ql.TimHinhCoDTMin(ds));
                            Console.WriteLine("Nhan phim bat ky de xoa hinh co dien tich min!!");
                            Console.ReadKey();
                            ql.XoaHinhCoDTMin(ds);
                            ds.Xuat();
                        }break;
                        
                    default:
                        break;
                }
                Console.ReadLine();
            }
            //ds.NhapTuFile();
            //ql.NhapTuFile();
            //ql.Xuat();
            //Console.WriteLine("=================");
            //DanhSachHinhHoc kq = ql.SapXepHTGiamCV(ds);
            //Console.WriteLine(kq);
            //DanhSachHinhHoc kq = ql.SapXepDTGiam();
            //Console.WriteLine(kq);
            //DanhSachHinhHoc kq = ql.TimHVDTMax(ds);
            //Console.WriteLine(kq);

           
        }
    }
}
