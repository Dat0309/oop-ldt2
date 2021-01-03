using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nhap1
{
    class DanhSachAnPham
    {
        public List<IAnPham> dsap = new List<IAnPham>();
        public void Them(IAnPham x)
        {
            dsap.Add(x);
        }
        public override string ToString()
        {
            string str = "";
            foreach (var item in dsap)
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
            string fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split(',');
                if (str[0] == "SACH")
                    Them(new Sach(str[1], int.Parse(str[2]), str[3]));
                if (str[0] == "BAO")
                    Them(new Bao(int.Parse(str[1]), str[2]));
                if (str[0] == "TAPCHI")
                    Them(new TapChi(str[1], int.Parse(str[2]), int.Parse(str[3]), str[4]));
            }
        }
        public int TimSLBVMax()
        {
            int max = int.MinValue;
            foreach (var item in dsap)
            {
                if(item is TapChi)
                {
                    TapChi tc = (TapChi)item;
                    if (tc.SoBaiViet > max)
                        max = tc.SoBaiViet;
                }
            }
            return max;
        }
    }
}
