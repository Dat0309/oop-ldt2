using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_KeThua
{
    class DanhSachHinhHoc
    {
        public List<HinhHoc> DSHinhHoc = new List<HinhHoc>();

        public HinhHoc this[int i]
        {
            get { return DSHinhHoc[i]; }
        }
        public void Them(HinhHoc a)
        {
            DSHinhHoc.Add(a);
        }
        public void Xoa(HinhHoc a)
        {
            DSHinhHoc.Remove(a);
        }
        public int Dai
        {
            get { return DSHinhHoc.Count; }
        }
        public override string ToString()
        {
            string line = "";
            foreach (var item in DSHinhHoc)
            {
                line += item + "\n";
            }
            return line;
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }
       
        public float TimMax_DT()
        {
            float max = float.MinValue;
            foreach (var item in DSHinhHoc)
                if (max < item.TinhDienTich())
                    max = item.TinhDienTich();
            return max;
        }

        public float TimMin_DT()
        {
            float min = float.MaxValue;
            foreach (var item in DSHinhHoc)
                if (min > item.TinhDienTich())
                    min = item.TinhDienTich();
            return min;
        }

        public float TimMax_CV()
        {
            float max = float.MinValue;
            foreach (var item in DSHinhHoc)
                if (max < item.TinhChuVi())
                    max = item.TinhChuVi();
            return max;
        }

        public float TimMin_CV()
        {
            float min = float.MaxValue;
            foreach (var item in DSHinhHoc)
                if (min > item.TinhChuVi())
                    min = item.TinhChuVi();
            return min;
        }

        public float TimMax_BK()
        {
            float max = float.MinValue;
            foreach (var item in DSHinhHoc)
                if (item is HinhTron)
                {
                    HinhTron t = (HinhTron)item;
                    if (max < t.BanKinh)
                        max = t.BanKinh;
                }
            return max;
        }
        public void NhapTuFile()
        {
            string fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split(' ');
                if (str[0] == "HT")
                    Them(new HinhTron(float.Parse(str[1])));
                else if (str[0] == "HV")
                    Them(new HinhVuong(float.Parse(str[1])));
                else
                    Them(new HinhCN(float.Parse(str[1]), float.Parse(str[2])));
            }
        }
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
                    Them(new HinhVuong(float.Parse(str[1])));
                else if (str[0] == "HT")
                    Them(new HinhTron(float.Parse(str[1])));
                else if (str[0] == "HCN")
                    Them(new HinhCN(float.Parse(str[1]), float.Parse(str[2])));
                else
                    return;
                Console.WriteLine("Xin moi nhap tiep thong tin hoac Nhan phim bat ky de xuat danh sach hinh hoc!...");
                goto a;
            } while (line == null);
        }
        public void Xuath()
        {
            Console.WriteLine("===========================================================================");
            Console.WriteLine("DANH SACH HINH HOC");
            Console.WriteLine("===========================================================================");
            Console.WriteLine(DSHinhHoc);
        }
    }
}
