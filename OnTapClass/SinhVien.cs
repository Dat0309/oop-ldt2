using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapClass
{
    class SinhVien
    {
        public string maSV;
        public string hoTen;
        public float dTB;
        public Boolean gioiTinh;
        private string lop;

        public string Lop
        {
            get { return lop; }
            set {
                lop = value.Trim();
            }
        }

        public SinhVien (string ma,string ho,float dtb,bool gt,string lop)
        {
            maSV = ma;
            hoTen = ho;
            dTB = dtb;
            gioiTinh = gt;
            this.lop = lop;
        }

        //001,Nguyen Van A, 8.0, Nam, CTK43
        public SinhVien(string line)
        {
            string[] str = line.Split(',');
            maSV = str[0];
            hoTen = str[1];
            dTB = float.Parse(str[2]);
            gioiTinh = str[3] == "Nam" ? true : false;
            lop = str[4];
        }

        public void Nhap()
        {
            Console.Write("Nhap mssv ");
            maSV = Console.ReadLine();
            Console.Write("Nhap hoTen ");
            hoTen = Console.ReadLine();
        }
        public override string ToString()
        {
            return string.Format("{0,2} {1,21} {2,5} {3,6} {4,10}", maSV, hoTen, dTB, gioiTinh == true ? "Nam" : "Nu", lop);
        }
    }
}
