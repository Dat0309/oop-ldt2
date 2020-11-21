using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class QuanLyAnPhamm
    {
        public DSBao DSBao = new DSBao();
        public DSSach DSSach = new DSSach();
        public DSTapChi DSTapChi = new DSTapChi();
        public List<string> DSTD = new List<string>();
        public List<int> DSTrang = new List<int>();
        public List<string> DSNXB = new List<string>();

        //Nhap bang tay
        public void NhapBangTay()
        {
            string line = "";
            do
            {
                Console.WriteLine("Xin moi nhap thong tin theo dinh dang: Sach(vd: SACH,TuaDe,SoTrang,NXB), Bao(vd: BAO,SoTrang,NXB), Tap Chi(vd:TAPCHI,TuaDe,SoTrang,NXB,SoBaiViet) :");
            a:
                line = Console.ReadLine();
                string[] str = line.Split(',');
                if (str[0] == "SACH")
                    DSSach.Them(new Sach(str[1], int.Parse(str[2]), str[3]));
                else if (str[0] == "BAO")
                    DSBao.Them(new Bao(int.Parse(str[1]), str[2]));
                else if (str[0] == "TAPCHI")
                    DSTapChi.Them(new TapChi(str[1], int.Parse(str[2]), str[3], int.Parse(str[4])));
                else
                    return;
                Console.WriteLine("Xin moi nhap tiep thong tin hoa nhan phim bat ky de xuat danh sach an pham!...");
                goto a;
            } while (line==null);
        }
        public void Xuat()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("DANH SACH SACH: ");
            Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(10) + "NXB".PadRight(10));
            Console.WriteLine("================================================");
            Console.WriteLine(DSSach);
            Console.WriteLine("================================================");
            Console.WriteLine("DANH SACH BAO: ");
            Console.WriteLine("So trang".PadRight(11) + "NXB".PadRight(10));
            Console.WriteLine("================================================");
            Console.WriteLine(DSBao);
            Console.WriteLine("================================================");
            Console.WriteLine("DANH SACH TAP CHI: ");
            Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(15) + "NXB".PadRight(10) +"So bai viet".PadRight(5));
            Console.WriteLine("================================================");
            Console.WriteLine(DSTapChi);
        }
        //nhap tu file
        public void NhapTuFile()
        {
            string fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            string line = "";
            while ((line=sr.ReadLine())!=null)
            {
                string[] str = line.Split(',');
                if(str[0] =="SACH")
                    DSSach.Them(new Sach(str[1], int.Parse(str[2]), str[3]));
                else if(str[0]=="BAO")
                    DSBao.Them(new Bao(int.Parse(str[1]), str[2]));
                else if(str[0]=="TAPCHI")
                    DSTapChi.Them(new TapChi(str[1], int.Parse(str[2]), str[3], int.Parse(str[4])));
            }
        }

        #region Tim tua de min max
        private List<string> LayDSTuaDe()
        {
            for (int i = 0; i < DSSach.Dai; i++)
                DSTD.Add(DSSach[i].TuaDe);
            for (int i = 0; i < DSTapChi.Dai; i++)
                DSTD.Add(DSTapChi[i].tuaDe);
            return DSTD;
        }
        private int TimTuaDeMax()
        {
            DSTD = LayDSTuaDe();
            int max = int.MinValue;
            foreach (var item in DSTD)
            {
                if (item.Length > max)
                    max = item.Length;
            }
            return max;
        }
        private int TimTuaDeMin()
        {
            DSTD = LayDSTuaDe();
            int min = int.MaxValue;
            foreach (var item in DSTD)
            {
                if (item.Length < min)
                    min = item.Length;
            }
            return min;
        }
        public void HienThiDSTuaDeMax()
        {
            int max = TimTuaDeMax();
            for(int i=0;i<DSSach.Dai;i++)
                if(DSSach[i].TuaDe.Length==max)
                {
                    Console.WriteLine("DANH SACH SACH: ");
                    Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(10) + "NXB".PadRight(10));
                    Console.WriteLine("================================================");
                    Console.WriteLine(DSSach[i]);
                    Console.WriteLine();
                }
            for (int i=0;i<DSTapChi.Dai;i++)
                if(DSTapChi[i].tuaDe.Length==max)
                {
                    Console.WriteLine("DANH SACH TAP CHI: ");
                    Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(15) + "NXB".PadRight(10) + "So bai viet".PadRight(5));
                    Console.WriteLine("================================================");
                    Console.WriteLine(DSTapChi[i]);
                    Console.WriteLine();
                }
        }

        public void HienThiDSTuaDeMin()
        {
            int min = TimTuaDeMin();
            for (int i = 0; i < DSSach.Dai; i++)
                if (DSSach[i].TuaDe.Length == min)
                {
                    Console.WriteLine("DANH SACH SACH: ");
                    Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(10) + "NXB".PadRight(10));
                    Console.WriteLine("================================================");
                    Console.WriteLine(DSSach[i]);
                    Console.WriteLine();
                }
            for (int i = 0; i < DSTapChi.Dai; i++)
                if (DSTapChi[i].tuaDe.Length == min)
                {
                    Console.WriteLine("DANH SACH TAP CHI: ");
                    Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(15) + "NXB".PadRight(10) + "So bai viet".PadRight(5));
                    Console.WriteLine("================================================");
                    Console.WriteLine(DSTapChi[i]);
                    Console.WriteLine();
                }
        }
        #endregion
        #region Tim so trang ngan nhat, dai nhat
        private List<int> LayDSTrang()
        {
            for (int i = 0; i < DSSach.Dai; i++)
                DSTrang.Add(DSSach[i].soTrang);
            for (int i = 0; i < DSBao.Dai; i++)
                DSTrang.Add(DSBao[i].soTrang);
            for (int i = 0; i < DSTapChi.Dai; i++)
                DSTrang.Add(DSTapChi[i].soTrang);
            return DSTrang;
        }
        private int TimSoTrangMax()
        {
            DSTrang = LayDSTrang();
            int max = int.MinValue;
            foreach (var item in DSTrang)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
        private int TimSoTrangMin()
        {
            DSTrang = LayDSTrang();
            int min = int.MaxValue;
            foreach (var item in DSTrang)
            {
                if (item < min)
                    min = item;
            }
            return min;
        }
        public void HienThiDSTrangMax()
        {
            float max = TimSoTrangMax();
            for(int i=0;i<DSSach.Dai;i++)
                if(DSSach[i].soTrang==max)
                {
                    Console.WriteLine("DANH SACH SACH: ");
                    Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(10) + "NXB".PadRight(10));
                    Console.WriteLine("================================================");
                    Console.WriteLine(DSSach[i]);
                    Console.WriteLine();
                }
            for(int i=0;i<DSBao.Dai;i++)
                if(DSBao[i].soTrang==max)
                {
                    Console.WriteLine("DANH SACH BAO: ");
                    Console.WriteLine("So trang".PadRight(11) + "NXB".PadRight(10));
                    Console.WriteLine("================================================");
                    Console.WriteLine(DSBao[i]);
                    Console.WriteLine();
                }
            for(int i=0;i<DSTapChi.Dai;i++)
                if(DSTapChi[i].soTrang==max)
                {
                    Console.WriteLine("DANH SACH TAP CHI: ");
                    Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(15) + "NXB".PadRight(10) + "So bai viet".PadRight(5));
                    Console.WriteLine("================================================");
                    Console.WriteLine(DSTapChi[i]);
                    Console.WriteLine();
                }
        }
        public void HienThiDSTrangMin()
        {
            float min = TimSoTrangMin();
            for (int i = 0; i < DSSach.Dai; i++)
                if (DSSach[i].soTrang == min)
                {
                    Console.WriteLine("DANH SACH SACH: ");
                    Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(10) + "NXB".PadRight(10));
                    Console.WriteLine("================================================");
                    Console.WriteLine(DSSach[i]);
                    Console.WriteLine();
                }
            for (int i = 0; i < DSBao.Dai; i++)
                if (DSBao[i].soTrang == min)
                {
                    Console.WriteLine("DANH SACH BAO: ");
                    Console.WriteLine("So trang".PadRight(11) + "NXB".PadRight(10));
                    Console.WriteLine("================================================");
                    Console.WriteLine(DSBao[i]);
                    Console.WriteLine();
                }
            for (int i = 0; i < DSTapChi.Dai; i++)
                if (DSTapChi[i].soTrang == min)
                {
                    Console.WriteLine("DANH SACH TAP CHI: ");
                    Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(15) + "NXB".PadRight(10) + "So bai viet".PadRight(5));
                    Console.WriteLine("================================================");
                    Console.WriteLine(DSTapChi[i]);
                    Console.WriteLine();
                }
        }
        #endregion
        #region NXB
        private List<string> LayDSNXB()
        {
            for (int i = 0; i < DSSach.Dai; i++)
                if(!DSNXB.Contains(DSSach[i].nxb))
                DSNXB.Add(DSSach[i].nxb);
            for (int i = 0; i < DSBao.Dai; i++)
                if(!DSNXB.Contains(DSBao[i].nxb))
                DSNXB.Add(DSBao[i].nxb);
            for (int i = 0; i < DSTapChi.Dai; i++)
                if(!DSNXB.Contains(DSTapChi[i].nxb))
                DSNXB.Add(DSTapChi[i].nxb);
            return DSNXB;
        }
       
      public void HienThidsTheoNXB()
        {
            
            DSNXB = LayDSNXB();
            foreach (var item in DSNXB)
            {
                
                Console.WriteLine("======================");
                Console.WriteLine("Danh sach an pham cua nxb: {0}", item);
                Console.WriteLine("======================");
                Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(10) + "NXB".PadRight(10));
                Console.WriteLine("======================");
                for (int i = 0; i < DSSach.Dai; i++)
                    if (item.CompareTo(DSSach[i].nxb) == 0)
                    {
                        Console.WriteLine(DSSach[i]);
                    }
                Console.WriteLine("So trang".PadRight(11) + "NXB".PadRight(10));
                Console.WriteLine("======================");
                for (int i = 0; i < DSBao.Dai; i++)
                    if (item.CompareTo(DSBao[i].nxb) == 0)
                    {
                        Console.WriteLine(DSBao[i]);
                    }
                Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(15) + "NXB".PadRight(10) + "So bai viet".PadRight(5));
                Console.WriteLine("====================== ");
                for(int i=0;i<DSTapChi.Dai;i++)
                    if(item.CompareTo(DSTapChi[i].nxb)==0)
                    {
                        Console.WriteLine(DSTapChi[i]);
                    }
                Console.WriteLine("========================================================================");
            }
        }
      private int TimNXBMax()
      {
          int max = int.MinValue;
          DSNXB = LayDSNXB();
          foreach (var item in DSNXB)
          {
              int dem = 0;
              for (int i = 0; i < DSSach.Dai; i++)
                  if (item.CompareTo(DSSach[i].nxb) == 0)
                      dem++;
              for (int i = 0; i < DSBao.Dai; i++)
                  if (item.CompareTo(DSBao[i].nxb) == 0)
                      dem++;
              for (int i = 0; i < DSTapChi.Dai; i++)
                  if (item.CompareTo(DSTapChi[i].nxb) == 0)
                      dem++;
              
              if (dem > max)
                  max = dem;
          }
          return max;
      }
      private int TimNXBMin()
      {
          int min = int.MaxValue;
          DSNXB = LayDSNXB();
          foreach (var item in DSNXB)
          {
              int dem = 0;
              for (int i = 0; i < DSSach.Dai; i++)
                  if (item.CompareTo(DSSach[i].nxb) == 0)
                      dem++;
              for (int i = 0; i < DSBao.Dai; i++)
                  if (item.CompareTo(DSBao[i].nxb) == 0)
                      dem++;
              for (int i = 0; i < DSTapChi.Dai; i++)
                  if (item.CompareTo(DSTapChi[i].nxb) == 0)
                      dem++;
              
              if (dem < min)
                  min = dem;
          }
          return min;
      }
        public void HienThiDSNXBMax()
      {
          int max = TimNXBMax();
            DSNXB = LayDSNXB();
            foreach (var item in DSNXB)
            {
                int dem = 0;
                for (int i = 0; i < DSSach.Dai; i++)
                    if (item.CompareTo(DSSach[i].nxb) == 0)
                        dem++;
                for (int i = 0; i < DSBao.Dai; i++)
                    if (item.CompareTo(DSBao[i].nxb) == 0)
                        dem++;
                for (int i = 0; i < DSTapChi.Dai; i++)
                    if (item.CompareTo(DSTapChi[i].nxb) == 0)
                        dem++;
                if (dem == max)
                    Console.WriteLine("NXB nhieu an pham nhat la : {0} voi so an pham la: {1}", item,dem);
            }
      }
        public void HienThiDSNXBMin()
        {
            int min = TimNXBMin();
            DSNXB = LayDSNXB();
            foreach (var item in DSNXB)
            {
                int dem = 0;
                for (int i = 0; i < DSSach.Dai; i++)
                    if (item.CompareTo(DSSach[i].nxb) == 0)
                        dem++;
                for (int i = 0; i < DSBao.Dai; i++)
                    if (item.CompareTo(DSBao[i].nxb) == 0)
                        dem++;
                for (int i = 0; i < DSTapChi.Dai; i++)
                    if (item.CompareTo(DSTapChi[i].nxb) == 0)
                        dem++;
                if (dem == min)
                    Console.WriteLine("NXB it an pham nhat la : {0} voi so an pham la: {1}", item,dem);
            }
        }
        public void TimTheoNXB()
        {
            string Nhap;
            Console.WriteLine("Nhap ten NXB can tim an pham (NXBGD,NXBVN,NXBKD): ");
            Nhap=Console.ReadLine();
            Console.WriteLine("======================");
            Console.WriteLine("Danh sach an pham cua nxb: {0}", Nhap);
            Console.WriteLine("======================");
            Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(10) + "NXB".PadRight(10));
            Console.WriteLine("======================");
            for (int i = 0; i < DSSach.Dai; i++)
                if (Nhap.CompareTo(DSSach[i].nxb) == 0)
                    Console.WriteLine(DSSach[i]);
            Console.WriteLine("So trang".PadRight(11) + "NXB".PadRight(10));
            Console.WriteLine("======================");
            for (int i = 0; i < DSBao.Dai; i++)
                if (Nhap.CompareTo(DSBao[i].nxb) == 0)
                    Console.WriteLine(DSBao[i]);
            Console.WriteLine("Tua De".PadRight(10) + "So trang".PadRight(15) + "NXB".PadRight(10) + "So bai viet".PadRight(5));
            Console.WriteLine("======================");
            for (int i = 0; i < DSTapChi.Dai; i++)
                if (Nhap.CompareTo(DSTapChi[i].nxb) == 0)
                    Console.WriteLine(DSTapChi[i]);
        }
        public void XoaDSTheoNXB()
        {
            string Nhap;
            Console.WriteLine("Nhap ten NXB Can xoa an pham (NXBGD,NXBVN,NXBKD): ");
            Nhap = Console.ReadLine();
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < DSSach.Dai; i++)
                    if (Nhap.CompareTo(DSSach[i].nxb) == 0)
                        DSSach.Xoa(DSSach[i]);
                for (int i = 0; i < DSBao.Dai; i++)
                    if (Nhap.CompareTo(DSBao[i].nxb) == 0)
                        DSBao.Xoa(DSBao[i]);
                for (int i = 0; i < DSTapChi.Dai; i++)
                    if (Nhap.CompareTo(DSTapChi[i].nxb) == 0)
                        DSTapChi.Xoa(DSTapChi[i]);
            }
        }

        #endregion
    }
}
