using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
   
    class QuanLyHinhHocc
    {
        
        public DanhSachHinhChuNhat DanhSachHCN = new DanhSachHinhChuNhat();
        public DanhSachHinhTron DanhSachHT = new DanhSachHinhTron();
        public DanhSachHinhVuong DanhSachHV = new DanhSachHinhVuong();
        public List<float> DS_DT = new List<float>();
        public List<float> DS_CV = new List<float>();

        //Nhap tu ban phim
        public void NhapBangTay()
        {
            string line = "";
            do
            {
                    Console.WriteLine("Xin moi nhap thong tin: Hinh vuong(vd: HV Canh), Hinh tron(vd: HT banKinh), Hinh CN(vd: HCN Dai Rong) :");
                    
            a:
                    line = Console.ReadLine();
                    string[] str = line.Split(' ');
                    if (str[0] == "HV")
                        DanhSachHV.Them(new HinhVuong(float.Parse(str[1])));
                    else if (str[0] == "HT")
                        DanhSachHT.Them(new HinhTron(float.Parse(str[1])));
                    else if (str[0] == "HCN")
                        DanhSachHCN.Them(new HinhChuNhat(float.Parse(str[1]), float.Parse(str[2])));
                    else
                        return;
                    Console.WriteLine("Xin moi nhap tiep thong tin hoac Nhan phim bat ky de xuat danh sach hinh hoc!...");
                    goto a;
            } while (line==null);
        }
        public void Xuat()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("DANH SACH HINH VUONG: ");
            Console.WriteLine("Canh".PadRight(6) + "CV".PadRight(6)+"DT".PadRight(5));
            Console.WriteLine("===================================");
            Console.WriteLine(DanhSachHV);
            Console.WriteLine("===================================");
            Console.WriteLine("SANH SACH HINH TRON: ");
            Console.WriteLine("BK".PadRight(6) + "CV".PadRight(9) + "DT".PadRight(5));
            Console.WriteLine("===================================");
            Console.WriteLine(DanhSachHT);
            Console.WriteLine("===================================");
            Console.WriteLine("DANH SACH HCN: ");
            Console.WriteLine("Dai".PadRight(6) + "Rong".PadRight(6) + "CV".PadRight(6) + "DT".PadRight(5));
            Console.WriteLine("===================================");
            Console.WriteLine(DanhSachHCN);
        }
        //Nhap tu file
        public void NhapTuFile()
        {
            string fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            string line = "";
            while ((line=sr.ReadLine())!=null)
            {
                string[] str = line.Split(' ');
                if (str[0] == "HV")
                    DanhSachHV.Them(new HinhVuong(float.Parse(str[1])));
                else if (str[0] == "HT")
                    DanhSachHT.Them(new HinhTron(float.Parse(str[1])));
                else
                    DanhSachHCN.Them(new HinhChuNhat(float.Parse(str[1]), float.Parse(str[2])));
            }
        }
       public List<float> LayDSDT()
        {
            for (int i=0; i < DanhSachHV.Dai; i++)
                DS_DT.Add(DanhSachHV[i].DT);
            for (int i=0; i < DanhSachHT.dem; i++)
                DS_DT.Add(DanhSachHT[i].DT);
            for (int i = 0; i < DanhSachHCN.dem; i++)
                DS_DT.Add(DanhSachHCN[i].DT);
            return DS_DT;
        }
        public List<float> LayDSCV()
       {
           for (int i = 0; i < DanhSachHV.Dai; i++)
               DS_CV.Add(DanhSachHV[i].DT);
           for (int i = 0; i < DanhSachHT.dem; i++)
               DS_CV.Add(DanhSachHT[i].DT);
           for (int i = 0; i < DanhSachHCN.dem; i++)
               DS_CV.Add(DanhSachHCN[i].DT);
           return DS_CV;
       }
       public float TimDTMax()
       {
           DS_DT = LayDSDT();
           float max = float.MinValue;
           foreach (var item in DS_DT)
           {
               if (item > max)
                   max = item;
           }
           return max;
       }
        public float TimCVMin()
       {
           DS_CV = LayDSCV();
           float min = float.MaxValue;
           foreach (var item in DS_CV)
           {
               if (item < min)
                   min = item;
           }
           return min;
       }
        public void HienThiDSDTMax()
       {
           float max = TimDTMax();
           for (int i = 0; i < DanhSachHV.Dai; i++)
               if (DanhSachHV[i].DT == max)
               {
                   Console.WriteLine("Hinh vuong:");
                   Console.WriteLine("Canh".PadRight(6) + "CV".PadRight(6) + "DT".PadRight(5));
                   Console.WriteLine("===================================");
                   Console.WriteLine(DanhSachHV[i]);
               }
           for (int i = 0; i < DanhSachHT.dem; i++)
               if (DanhSachHT[i].DT == max)
               {
                   Console.WriteLine("Hinh tron:");
                   Console.WriteLine("BK".PadRight(6) + "CV".PadRight(9) + "DT".PadRight(5));
                   Console.WriteLine("===================================");
                   Console.WriteLine(DanhSachHT[i]);
               }
           for (int i = 0; i < DanhSachHCN.dem; i++)
               if (DanhSachHCN[i].DT == max)
               {
                   Console.WriteLine("Hinh chu nhat:");
                   Console.WriteLine("Dai".PadRight(6) + "Rong".PadRight(6) + "CV".PadRight(6) + "DT".PadRight(5));
                   Console.WriteLine("===================================");
                   Console.WriteLine(DanhSachHCN[i]);
               }
       }
        public void HienThiDSCVMin()
        {
            float min = TimCVMin();
            for (int i = 0; i < DanhSachHV.Dai; i++)
                if (DanhSachHV[i].DT == min)
                {
                    Console.WriteLine("Hinh vuong:");
                    Console.WriteLine("Canh".PadRight(6) + "CV".PadRight(6) + "DT".PadRight(5));
                    Console.WriteLine("===================================");
                    Console.WriteLine(DanhSachHV[i]);
                }
            for (int i = 0; i < DanhSachHT.dem; i++)
                if (DanhSachHT[i].DT == min)
                {
                    Console.WriteLine("Hinh tron:");
                    Console.WriteLine("BK".PadRight(6) + "CV".PadRight(9) + "DT".PadRight(5));
                    Console.WriteLine("===================================");
                    Console.WriteLine(DanhSachHT[i]);
                }
            for (int i = 0; i < DanhSachHCN.dem; i++)
                if (DanhSachHCN[i].DT == min)
                {
                    Console.WriteLine("Hinh chu nhat:");
                    Console.WriteLine("Dai".PadRight(6) + "Rong".PadRight(6) + "CV".PadRight(6) + "DT".PadRight(5));
                    Console.WriteLine("===================================");
                    Console.WriteLine(DanhSachHCN[i]);
                }
        }
        public void XoaHinhDTMax()
        {
            float max = TimDTMax(); 
            for (int i = 0; i < DanhSachHV.Dai; i++)
                if (DanhSachHV[i].DT == max)
                    DanhSachHV.Xoa(DanhSachHV[i]);
            for (int i = 0; i < DanhSachHT.dem; i++)
                if (DanhSachHT[i].DT == max)
                    DanhSachHT.Xoa(DanhSachHT[i]);
            for (int i = 0; i < DanhSachHCN.dem; i++)
                if (DanhSachHCN[i].DT == max)
                    DanhSachHCN.Xoa(DanhSachHCN[i]);
        }
        public void XoaHinhCVMin()
        {
            float min = TimCVMin();
            for (int i = 0; i < DanhSachHV.Dai; i++)
                if (DanhSachHV[i].DT == min)
                    DanhSachHV.Xoa(DanhSachHV[i]);
            for (int i = 0; i < DanhSachHT.dem; i++)
                if (DanhSachHT[i].DT == min)
                    DanhSachHT.Xoa(DanhSachHT[i]);
            for (int i = 0; i < DanhSachHCN.dem; i++)
                if (DanhSachHCN[i].DT == min)
                    DanhSachHCN.Xoa(DanhSachHCN[i]);
        }
      
    }
}
