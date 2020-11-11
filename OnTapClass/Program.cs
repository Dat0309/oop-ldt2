using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapClass
{
    class Program
    {
        enum Menu
        {
            XuatDanhSach,
            SapTangTheoDTB,
            DemSoSVNamNu,
            TimDSSVCoDTBCaoNhat,
            TimLopCoDTBCaoNhat,
            TimLopKoCoDTBCaoNhat,
            HienThiDSSVTheoLopDTBGiam,
            XepHangSinhVien,
            TimLopCoTongDTBCaoNhatThapNhat,
            GhiXuongFileDSSV,
            XemDSSVTongFileVuaGhi,
            Thoat = 12
        }

        static void Main(string[] args)
        {
            DanhSachSinhVien ctk43 = new DanhSachSinhVien();

            ctk43.NhapThuFile();
           
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===============================================");
                Console.WriteLine("Nhap {0} De Xuat Danh Sach: ", (int)Menu.XuatDanhSach);
                Console.WriteLine("Nhap {0} De Sap Xep Danh Sach Tang Theo DTB: ", (int)Menu.SapTangTheoDTB);
                Console.WriteLine("Nhap {0} De Dem so sinh vien Nam Nu trong lop:", (int)Menu.DemSoSVNamNu);
                Console.WriteLine("Nhap {0} De tim DSSV co DTB cao nhat:", (int)Menu.TimDSSVCoDTBCaoNhat);
                Console.WriteLine("Nhap {0} De tim lop co DTB cao nhat:", (int)Menu.TimLopCoDTBCaoNhat);
                Console.WriteLine("Nhap {0} De tim lop ko co DTB cao nhat:", (int)Menu.TimLopKoCoDTBCaoNhat);
                Console.WriteLine("Nhap {0} De sap xep sinh vien theo danh sach lop voi DTB giam dan:", (int)Menu.HienThiDSSVTheoLopDTBGiam);
                Console.WriteLine("Nhap {0} De xep hang sinh vien theo lop:", (int)Menu.XepHangSinhVien);
                Console.WriteLine("Nhap {0} De tim lop co tong DTB cao nhat va Thap nhat:", (int)Menu.TimLopCoTongDTBCaoNhatThapNhat);
                Console.WriteLine("Nhap {0} De ghi xuong file danh sach lop:", (int)Menu.GhiXuongFileDSSV);
                Console.WriteLine("Nhap {0} De xem DSSV trong file vua ghi:",(int)Menu.XemDSSVTongFileVuaGhi);
                Console.WriteLine("Nhap {0} De Thoat Chuong Trinh", (int)Menu.Thoat);

                Menu nhap = (Menu)int.Parse(Console.ReadLine());
                switch (nhap)
                {
                    case Menu.XuatDanhSach:
                        {
                            Console.Clear();
                            Console.WriteLine("====================================================");
                            Console.WriteLine("Danh Sach Sinh Vien: ");
                            Console.WriteLine("====================================================");
                            Console.WriteLine(ctk43);
                            Console.WriteLine("====================================================");
                        }
                        break;
                    case Menu.SapTangTheoDTB:
                        {
                            Console.Clear();
                            //ctk43.NhapThuFile();
                            Console.WriteLine(ctk43);
                            Console.WriteLine("==============================");
                            ctk43.SapXepTangTheoDTB();
                            Console.WriteLine(ctk43);
                        }
                        break;
                    case Menu.DemSoSVNamNu:
                        {
                            Console.Clear();
                            List<string> dslop = ctk43.LayDanhSachLop();
                            foreach (var item in dslop)
                            {
                                Console.WriteLine(item + " Nam: " + ctk43.DemSoLuongSVNam(item) + " Nu: " + ctk43.DemSoLuongSVNu(item));
                            }
                        }
                        break;
                    case Menu.TimDSSVCoDTBCaoNhat:
                        {
                            Console.Clear();
                            Console.WriteLine("DSSV Co DTB MAX :" + "\n" + "==================");
                            Console.WriteLine(ctk43.TimDSSVCoDTBCaoNhat());
                        }
                        break;
                    case Menu.TimLopCoDTBCaoNhat:
                        {
                            Console.Clear();
                            List<string> lopDC = ctk43.TimLopCoDTBCaoNhat();
                            Console.WriteLine("Lop co DTB cao nhat la" + "\n" + "===================");
                            foreach (var item in lopDC)
                            {
                                Console.WriteLine(item + " Co DTB cao nhat!");
                                Console.WriteLine("Sinh vien: ");
                                Console.WriteLine(ctk43.TimDSSVCoDTBCaoNhat());
                            }
                        }
                        break;
                    case Menu.TimLopKoCoDTBCaoNhat:
                        {
                            Console.Clear();
                            List<string> LopKDC = ctk43.TimLopKhongCoDTBCaoNhat();
                            Console.WriteLine("Lop khong co DTB cao nhat la:" + "\n" + "================");
                            foreach (var item in LopKDC)
                            {
                                Console.WriteLine("Lop "+ item + " Khong co DTB cao nhat!");
                            }
                        }
                        break;
                    case Menu.HienThiDSSVTheoLopDTBGiam:
                        {
                            Console.Clear();
                            Console.WriteLine("Danh sach hien hanh:\n");
                            Console.WriteLine(ctk43);
                            Console.WriteLine("Nhan phim bat ky de tiep tuc!");
                            Console.ReadKey();
                            Console.Clear();
                            ctk43.HienThiDSSVTheoLopGiamDTB();
                        }
                        break;
                    case Menu.XepHangSinhVien:
                        {
                            Console.Clear();
                            ctk43.HienThiThuHangLop();
                        }
                        break;
                    case Menu.TimLopCoTongDTBCaoNhatThapNhat:
                        {
                            Console.Clear();
                            Console.WriteLine("=======================================");
                            Console.WriteLine("Danh sach hien hanh:");
                            Console.WriteLine(ctk43);
                            List<string> kq = ctk43.TimLopCoTongDTBCaoNhat();
                            float tongDTB = ctk43.TimTongDTBCaoNhat();
                            Console.WriteLine("Lop co tong DTB cao nhat la:");
                            foreach (var item in kq)
                            {
                                Console.WriteLine(item);
                            }
                            Console.WriteLine("Voi tong DTB la {0} ", tongDTB);
                            
                        }
                        break;
                    case Menu.GhiXuongFileDSSV:
                        {
                            Console.Clear();
                            ctk43.XuatRaFile();
                            Console.WriteLine("Da xuat file data1.txt");
                        }
                        break;
                   
                    case Menu.Thoat:
                        return;
                
                }
                Console.ReadLine();
            }
        }
    }
}
