using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace QuanLyMayTinh
{
    class DanhSachHangHoa
    {
        public List<IHangHoa> dshh = new List<IHangHoa>();
        public void Them(IHangHoa x)
        {
            dshh.Add(x);
        }
        public override string ToString()
        {
            Console.WriteLine("Ma hang".PadRight(10) + "Ten hang".PadRight(12) + "Mo ta".PadRight(11) + "So luong".PadRight(11) + "Don gia".PadRight(11) + "Thanh tien".PadRight(10));
            Console.WriteLine("===========================================================");
            string str = "";
            foreach (var item in dshh)
            {
                str += item + "\n";
            }
            return str;
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }
        public void NhapThuFile()
        {
            string fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            string line;
            while((line=sr.ReadLine())!=null)
            {
                string[] str = line.Split(',');
                if(str[0]=="MT")
                {
                    Them(new MayTinh(str[1],str[2],str[3],int.Parse(str[4])));
                }
                else if(str[0]=="TN")
                {
                    Them(new TaiNghe(str[1],str[2],str[3],int.Parse(str[4])));
                }
                else if(str[0]=="QA")
                {
                    Them(new QuanAo(str[1],str[2],str[3],int.Parse(str[4])));
                }
                else
                {
                    Them(new GiayDep(str[1],str[2],str[3],int.Parse(str[4])));
                }
            }
        }
        public int Dem()
        {
           return dshh.Count();
        }
        public void Xoa(IHangHoa x)
        {
            dshh.Remove(x);
        }
    }
}
