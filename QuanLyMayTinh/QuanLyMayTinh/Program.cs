using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class Program
    {
        enum Menu
        {
            Thoat,
            NhapTuFile,
            Xuat,
            InDSMHSLTren10,
            XuatDSTaiNghe,
            TimMatHangCoTongTienCaoNhat,
            MatHangThanhTienMax,
            TimMaxMatHangX,
            SapXep,
            XoaHangHoaMoTaX
        }
        enum sort
        {
            TangTheoTien,
            GianTheoTien,
            TangSL,
            SapXepTangTen,
            SapXepTangTheoChieuDaiTen
        }
        static void Main(string[] args)
        {
            DanhSachHangHoa DSHH = new DanhSachHangHoa();
            QuanLyHangHoa ql = new QuanLyHangHoa();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("====================== DANH SACH CHUC NANG ======================");
                Console.WriteLine("Nhap {0} de Thoat", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de Nhap du lieu tu file", (int)Menu.NhapTuFile);
                Console.WriteLine("Nhap {0} de Xuat file du lieu", (int)Menu.Xuat);
                Console.WriteLine("Nhap {0} de In danh sach mat hang co so luong tren 10", (int)Menu.InDSMHSLTren10);
                Console.WriteLine("Nhap {0} de In danh sach mat hang co ten la TAI NGHE", (int)Menu.XuatDSTaiNghe);
                Console.WriteLine("Nhap {0} de Tim mat hang co tong so tien cao nhat", (int)Menu.TimMatHangCoTongTienCaoNhat);
                Console.WriteLine("Nhap {0} de Mat Hang co Thanh Tien cao nhat", (int)Menu.MatHangThanhTienMax);
                Console.WriteLine("Nhap {0} de Tim gia lon nhat cua mat hang X", (int)Menu.TimMaxMatHangX);
                Console.WriteLine("Nhap {0} de Sap xep", (int)Menu.SapXep);
                Console.WriteLine("Nhap {0} de xoa hang hoa co mo ta X", (int)Menu.XoaHangHoaMoTaX);

                Menu nhap = (Menu)int.Parse(Console.ReadLine());
                switch (nhap)
                {
                    case Menu.Thoat:
                        return;
                    case Menu.NhapTuFile:
                        {
                            Console.Clear();
                            DSHH.NhapThuFile();
                            DSHH.Xuat();
                        }
                        break;
                    case Menu.Xuat:
                        {
                            Console.Clear();
                            DSHH.Xuat(); }
                        break;
                    case Menu.InDSMHSLTren10:
                        {
                            Console.Clear();
                            ql.InDSHHSLMuoi(DSHH).Xuat();
                        }
                        break;
                    case Menu.XuatDSTaiNghe:
                        {
                            Console.Clear();
                            ql.TimDSTaiNghe(DSHH).Xuat();
                        }
                        break;
                    case Menu.TimMatHangCoTongTienCaoNhat:
                        {
                            Console.Clear();
                            ql.TimMHTongTienMax(DSHH);
                        }break;
                    case Menu.MatHangThanhTienMax:
                        {
                            Console.Clear();
                            ql.TimMatHangThanhTienMax(DSHH).Xuat();
                        }break;
                    case Menu.TimMaxMatHangX:
                        {
                            Console.Clear();
                            while(true)
                            {
                            Console.WriteLine("Xin moi nhap ten hang hoa gom (MAY TINH, QUAN AO, GIAY, TAI NGHE)");
                            string ten = Console.ReadLine();
                            try
                            {
                                ql.TimDSMatHangX(DSHH, ten).Xuat();
                                Console.WriteLine("Hang hoa Thanh tien cao nhat mat hang {0} la: ", ten+"\n");
                                ql.TimSoTienMaxMHX(DSHH, ten).Xuat();
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Mat hang vua nhap khong ton tai, xin moi nhap lai!!");
                            }
                            }
                        }break;
                    case Menu.SapXep:
                        {
                            Console.Clear();
                            Console.WriteLine("Nhap {0} de Sap xep tang theo thanh tien!", (int)sort.TangTheoTien);
                            Console.WriteLine("Nhap {0} de Sap xep giam theo thanh tien!", (int)sort.GianTheoTien);
                            Console.WriteLine("Nhap {0} de Sap xep tang theo so luong", (int)sort.TangSL);
                            Console.WriteLine("Nhap {0} de sap xep tang theo ten", (int)sort.SapXepTangTen);
                            Console.WriteLine("Nhap {0} de Sap xep tang theo chieu dai ten", (int)sort.SapXepTangTheoChieuDaiTen);

                            sort n = (sort)int.Parse(Console.ReadLine());
                            switch (n)
                            {
                                case sort.TangTheoTien:
                                    {
                                        Console.Clear();
                                        ql.SapXep(DSHH).Xuat();
                                    }
                                    break;
                                case sort.GianTheoTien:
                                    {
                                        Console.Clear();
                                        ql.SapXepGiam(DSHH).Xuat();
                                    }
                                    break;
                                case sort.TangSL:
                                    {
                                        Console.Clear();
                                        ql.SapXepTangSL(DSHH).Xuat();
                                    }break;
                                case sort.SapXepTangTen:
                                    {
                                        Console.Clear();
                                        ql.SapXepTheoTen(DSHH).Xuat();
                                    }break;
                                case sort.SapXepTangTheoChieuDaiTen:
                                    {
                                        Console.Clear();
                                        ql.SapXepTangChieuDaiTen(DSHH).Xuat();
                                    }break;
                                default:
                                    break;
                            }
                        }break;
                    case Menu.XoaHangHoaMoTaX:
                        {
                            Console.Clear();
                            DSHH.Xuat();
                            string ten;
                            Console.WriteLine("Xin moi nhap ten hang hoa: ");
                            ten=Console.ReadLine();
                            ql.XoaHangHoaX(DSHH, ten);
                            DSHH.Xuat();
                        }break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
           
            Console.ReadLine();
        }
    }
}
