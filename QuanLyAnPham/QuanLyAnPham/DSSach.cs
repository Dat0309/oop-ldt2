using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class DSSach
    {
        List<Sach> DanhSachSach = new List<Sach>();
        public Sach this[int i]
        {
            get { return DanhSachSach[i]; }
        }
        public void Them(Sach s)
        {
            DanhSachSach.Add(s);
        }
        public override string ToString()
        {
            string line = "";
            foreach (var item in DanhSachSach)
            {
                line += item + "\n";
            }
            return line;
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }
        public int Dai
        {
            get {return DanhSachSach.Count;}
        }
        public void Xoa(Sach s)
        {
            DanhSachSach.Remove(s);
        }
    }
}
