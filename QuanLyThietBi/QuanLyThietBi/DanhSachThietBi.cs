using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
    class DanhSachThietBi
    {
        public List<ThietBi> ds = new List<ThietBi>();
        public void Them(ThietBi x)
        {
            ds.Add(x);
        }
        public void XoaThietBiRAMGiaX(float gia)
        {
            ds.RemoveAll(r => r.GiaRAM == gia);
        }
        public override string ToString()
        {
            string str = "";
            foreach (var item in ds)
            {
                str += item + "\n";
            }
            return str;
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }
        public void NhapTuFile()
        {
            string fileName = "ThietBi.txt";
            StreamReader sr = new StreamReader(fileName);
            string line;
            string[] strR,strC;
            
            while((line=sr.ReadLine())!=null)
            {
                string[] str = line.Split(',');
                if(str[0]=="MT")
                {
                    strR = str[2].Split(' ');
                    strC = str[3].Split(' ');
                    Them(new MayTinh(str[1], new RAM(float.Parse(strR[1]), strR[0]), new CPU(float.Parse(strC[1]), strC[0])));
                }
                else
                {
                    strR = str[2].Split(' ');
                    strC = str[3].Split(' ');
                    Them(new MayAnh(str[1], new RAM(float.Parse(strR[1]), strR[0]), new CPU(float.Parse(strC[1]), strC[0])));
                }
            }
        }
        public void NhapBangTay()
        {
            string[] strR, strC;
            string line = "";
            do
            {
                
                Console.WriteLine("Nhap theo dinh dang vd: MT,Dell,Corsair_4GB 81,CoreI9-7940X 1366");
            a:
                 line = Console.ReadLine();
                string[] str = line.Split(',');
                if (str[0] == "MT")
                {
                    strR = str[2].Split(' ');
                    strC = str[3].Split(' ');
                    Them(new MayTinh(str[1], new RAM(float.Parse(strR[1]), strR[0]), new CPU(float.Parse(strC[1]), strC[0])));
                }
                else if (str[0] == "MA")
                {
                    strR = str[2].Split(' ');
                    strC = str[3].Split(' ');
                    Them(new MayAnh(str[1], new RAM(float.Parse(strR[1]), strR[0]), new CPU(float.Parse(strC[1]), strC[0])));
                }
                else
                    return;
                Console.WriteLine("Xin moi nhap tiep thong tin hoac Nhan phim bat ky de xuat danh sach!!!");
                goto a;
            } while (line==null);
            
        }
        public int Dem()
        {
            return ds.Count();
        }
        public float TimMaxGia()
        {
            float max = float.MinValue;
            foreach (var item in ds)
            {
                if (item.TinhGia() > max)
                    max = item.TinhGia();
            }
            return max;
        }
        public float TimMinGia()
        {
            float min = float.MaxValue;
            foreach (var item in ds)
            {
                if (item.TinhGia() < min)
                    min = item.TinhGia();
            }
            return min;
        }
        public float TimMaxCPU()
        {
            float max = float.MinValue;
            foreach (var item in ds)
            {
                if (item.GiaCPU > max)
                    max = item.GiaCPU;
            }
            return max;
        }
        public float TimMinCPU()
        {
            float min = float.MaxValue;
            foreach (var item in ds)
            {
                if (item.GiaCPU < min)
                    min = item.GiaCPU;
            }
            return min;
        }
    }
}
