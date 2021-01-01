using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi_DaKeThua
{
    class DanhSachLinhKien
    {
        public List<ILinhKien> dslk=new List<ILinhKien>();
        public void Them(ILinhKien x)
        {
            dslk.Add(x);
        }
        public void XoaRAM(float gia)
        {
            dslk.RemoveAll(r => r is RAM && r.Gia == gia);
        }
        public override string ToString()
        {
            string str = "";
            foreach (var item in dslk)
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
            string fileName = "LinhKien.txt";
            StreamReader sr = new StreamReader(fileName);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split(',');
                if (str[0] == "RAM")
                {
                    string[] x = str[1].Split(' ');
                    Them(new RAM(float.Parse(x[1]), x[0]));
                }
                else
                {
                    string[] x = str[1].Split(' ');
                    Them(new CPU(float.Parse(x[1]), x[0]));
                }
            }
        }
        public int Dem()
        {
            return dslk.Count();
        }
    }
}
