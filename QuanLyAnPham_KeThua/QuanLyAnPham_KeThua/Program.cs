using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham_KeThua
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
            XoaAnPhamThuocNXB,
            HienThiAnPhamTheoChieuTangGiamTrang

        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Nhan phim bat ky de xuat danh sach menu!!..........");
            //Console.ReadKey();
            
            DanhSachAnPham ds = new DanhSachAnPham();
            QuanLyAnPham ql = new QuanLyAnPham();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================================================");
                Console.WriteLine("=============DINH TRONG DAT CTK43================================");
                Console.WriteLine("=================================================================");
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
                Console.WriteLine("Nhap {0} de Hien thi danh sach theo chieu tang giam so trang", (int)Menu.HienThiAnPhamTheoChieuTangGiamTrang);

                Menu nhap = (Menu)int.Parse(Console.ReadLine());
                switch (nhap)
                {
                    case Menu.Thoat:
                        return;
                    case Menu.NhapTuBanPhim:
                        {
                            Console.Clear();
                            ds.NhapBangTay();
                            ds.Xuat();
                        }
                        break;
                    case Menu.NhapTuFile:
                        {
                            Console.Clear();
                            ds.NhapTuFile();
                            Console.WriteLine("Du lieu tap tin da duoc chuyen vao danh sach!!");
                        }
                        break;
                    case Menu.Xuat:
                        {
                            Console.Clear();
                            Console.WriteLine("Danh sach hien hanh!!");
                            Console.WriteLine("===============================================================================");
                            ds.Xuat();
                            Console.WriteLine("===============================================================================");
                        }
                        break;
                    case Menu.TimTapChiCoSLBVMaxMin:
                        {
                            Console.Clear();
                            
                            Console.WriteLine("Tap chi co so luong bai viet nhieu nhat la: "+"\n");
                            Console.WriteLine(ql.TimTCBVMax(ds));
                            Console.WriteLine("Tap chi co so luong bai viet it nhat la:" + "\n");
                            Console.WriteLine(ql.TimTCBVMin(ds));
                        }
                        break;
                    case Menu.TimTuaDeNganDai:
                        {
                            Console.Clear();
                            Console.WriteLine("Danh sach co tua de dai nhat la:" + "\n");
                            Console.WriteLine(ql.TimTuaDeDaiNhat(ds));
                            Console.WriteLine("Danh sach co tua de ngan nhat la:" + "\n");
                            Console.WriteLine(ql.TimTuaDeNganNhat(ds));
                        }
                        break;
                    case Menu.TimTrangNganDai:
                        {
                            Console.Clear();
                            Console.WriteLine("An pham co so trang dai nhat la: " + "\n");
                            Console.WriteLine(ql.TimSoTrangMax(ds));
                            Console.WriteLine("An pham co so trang ngan nhat la: " + "\n");
                            Console.WriteLine(ql.TimSoTrangMin(ds));
                        }
                        break;
                    case Menu.HienThiDSTheoNXB:
                        {
                            Console.Clear();
                            ql.HienThiDSNXB(ds);
                        }
                        break;
                    case Menu.TimNXBNhieuAnPhamNhat:
                        {
                            Console.Clear();
                            Console.WriteLine("Danh sach nha xuat ban: " + "\n");
                            ql.HienThiDSNXB(ds);
                            Console.WriteLine();
                            ql.HienThiDanhSachNXBMax(ds);
                            ql.HienThiDanhSachNXBMin(ds);
                        }
                        break;
                    case Menu.TimTatCaAnPhamTheoNXBDo:
                        {
                            Console.Clear();
                            ql.TimTheoNXB(ds);
                        }
                        break;
                    case Menu.XoaAnPhamThuocNXB:
                        {
                            Console.Clear();
                            Console.WriteLine("Danh sach hien hanh");
                            ds.Xuat();
                            ql.XoaTheoNXB(ds);
                            Console.WriteLine("Nhan phim bat ky de xoa!!");
                            Console.ReadKey();
                            Console.Clear();
                            ds.Xuat();
                        }
                        break;
                    case Menu.HienThiAnPhamTheoChieuTangGiamTrang:
                        {
                            Console.Clear();
                            Console.WriteLine("Danh sach trang tang dan: " + "\n");
                            Console.WriteLine(ql.SapXepTrangTang(ds));
                            Console.WriteLine("Danh sach trang giam dan: " + "\n");
                            Console.WriteLine(ql.SapXepTrangGiam(ds));
                        }
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
            }
            
            
        }
    }
}
