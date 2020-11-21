using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class DSBao
    {
        List<Bao> DanhSachBao = new List<Bao>();
        public Bao this[int i]
        {
            get { return DanhSachBao[i]; }
        }
        public void Them(Bao b)
        {
            DanhSachBao.Add(b);
        }
        public override string ToString()
        {
            string line = "";
            foreach (var item in DanhSachBao)
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
            get { return DanhSachBao.Count; }
        }
        public void Xoa(Bao b)
        {
            DanhSachBao.Remove(b);
        }
    }
}
