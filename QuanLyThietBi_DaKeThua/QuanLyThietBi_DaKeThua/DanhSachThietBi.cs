using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi_DaKeThua
{
    class DanhSachThietBi
    {
        public List<IThietBi> dstb = new List<IThietBi>();
        public void Them(IThietBi x)
        {
            dstb.Add(x);
        }
        public void XoaThietBiRAMGiaX(float gia)
        {
            dstb.RemoveAll(r => r.GiaRAM == gia);
        }
        public override string ToString()
        {
            string str = "";
            foreach (var item in dstb)
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
            string[] strR, strC;

            while ((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split(',');
                if (str[0] == "MT")
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
        public int Dem()
        {
            return dstb.Count();
        }
    }
}
