using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham_KeThua
{
    class DanhSachAnPham
    {
        public List<AnPham> ds = new List<AnPham>();
        public AnPham this[int i]
        {
            get { return ds[i]; }
        }
        public void Them(AnPham x)
        {
            ds.Add(x);
        }
        public override string ToString()
        {
            string line = "";
            foreach (var item in ds)
            {
                line += item + "\n";
            }
            return line;
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }
        public void NhapTuFile()
        {
            string fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            string line;
            while ((line=sr.ReadLine())!=null)
            {
                string[] str = line.Split(',');
                if (str[0] == "SACH")
                    Them(new Sach(str[1], int.Parse(str[2]), str[3]));
                if (str[0] == "BAO")
                    Them(new Bao(int.Parse(str[1]), str[2]));
                if (str[0] == "TAPCHI")
                    Them(new TapChi(str[1], int.Parse(str[2]), str[3], int.Parse(str[4])));
            }
        }
        public void NhapBangTay()
        {
            string line = "";
            do
            {
                Console.WriteLine("Xin moi nhap thong tin, moi lan nhap mot loai: Sach(SACH,Tua de,so trang, NXB),Bao(BAO,so trang,NXB),Tap chi(TAPCHI,Tua de,so trang,NXB,So an pham)");
            a:
                line = Console.ReadLine();
                string[] str = line.Split(',');
                if (str[0] == "SACH")
                    Them(new Sach(str[1], int.Parse(str[2]), str[3]));
                else if (str[0] == "BAO")
                    Them(new Bao(int.Parse(str[1]), str[2]));
                else if (str[0] == "TAPCHI")
                    Them(new TapChi(str[1], int.Parse(str[2]), str[3], int.Parse(str[4])));
                else 
                    return;
                Console.WriteLine("Xin moi nhap tiep thong tin hoac Nhan phim bat ky de xuat danh sach hinh hoc!...");
                goto a;
            } while (line==null);
        }
        public int TimMaxBV()
        {
            int max = int.MinValue;
            foreach (var item in ds)
            {
                if(item is TapChi)
                {
                    TapChi t = (TapChi)item;
                    if (max < t.SoBaiViet)
                        max = t.SoBaiViet;
                }
            }
            return max;
        }
        public int TimMinBV()
        {
            int min = int.MaxValue;
            foreach (var item in ds)
            {
                if(item is TapChi)
                {
                    TapChi t = (TapChi)item;
                    if (min > t.SoBaiViet)
                        min = t.SoBaiViet;
                }
            }
            return min;
        }
        public int TimTuaDeMax()
        {
            int max = int.MinValue;
            foreach (var item in ds)
            {
                if (item is Sach)
                {
                    Sach s = (Sach)item;
                    if (max < s.TuaDe.Length)
                        max = s.TuaDe.Length;
                }
                else if (item is TapChi)
                {
                    TapChi tc = (TapChi)item;
                    if (max < tc.TuDe.Length)
                        max = tc.TuDe.Length;
                }
            }
            return max;
        }
        public int TimTuaDeMin()
        {
            int min = int.MaxValue;
            foreach (var item in ds)
            {
                if (item is Sach )
                {
                    Sach s = (Sach)item;
                    if (min > s.TuaDe.Length)
                        min = s.TuaDe.Length;
                }
                else if(item is TapChi)
                {
                    TapChi tc = (TapChi)item;
                    if (min > tc.TuDe.Length)
                        min = tc.TuDe.Length;
                }
            }
                return min;
        }
        public int TimTrangMax()
        {
            int max = int.MinValue;
            foreach (var item in ds)
            {
                if (max < item.SoTrang)
                    max = item.SoTrang;
            }
            return max;
        }
        public int TimTrangMin()
        {
            int min = int.MaxValue;
            foreach (var item in ds)
            {
                if (min > item.SoTrang)
                    min = item.SoTrang;
            }
            return min;
        }
        public int Dai()
        { return ds.Count(); }
        public void Xoa(AnPham x)
        {
             ds.Remove(x);
        }
    }
}
