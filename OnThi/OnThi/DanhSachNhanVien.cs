using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OnThi
{
    class DanhSachNhanVien
    {
        public List<INhanVien> dsnv = new List<INhanVien>();
        public void Them(INhanVien x)
        {
            dsnv.Add(x);
        }
      
        public override string ToString()
        {
            string str = "";
            foreach (var item in dsnv)
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
                if (str[0] == "NVHD")
                {

                    Them(new NhanVienHopDong(str[1], str[2], int.Parse(str[3]), int.Parse(str[4])));
                }
                else
                {
                    Them(new NhanVienBanThoiGian(str[1], str[2], int.Parse(str[3]), int.Parse(str[4])));
                }
            }
        }
    }
}
