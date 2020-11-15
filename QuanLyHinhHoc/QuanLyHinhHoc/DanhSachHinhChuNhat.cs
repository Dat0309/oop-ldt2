using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class DanhSachHinhChuNhat
    {
        List<HinhChuNhat> DanhSachHCN = new List<HinhChuNhat>();
        public HinhChuNhat this[int i]
        {
            get { return DanhSachHCN[i]; }
        }
        public void Them(HinhChuNhat hcn)
        {
            DanhSachHCN.Add(hcn);
        }
        public override string ToString()
        {
            string line = "";
            foreach (var item in DanhSachHCN)
            {
                line += item + "\n";
            }
            return line;
        }
       public void Xuat()
        {
            Console.WriteLine(this);
        }
        private float TimMin()
       {
           float min = float.MaxValue;
           foreach (var item in DanhSachHCN)
           {
               if (item.DT < min)
                   min = item.DT;
           }
           return min;
       }
        public DanhSachHinhChuNhat TimDTMin()
        {
            DanhSachHinhChuNhat kq=new DanhSachHinhChuNhat();
            float min=TimMin();
            foreach (var item in DanhSachHCN)
	{
        if (item.DT == min)
            kq.Them(item);
	}
            return kq;
        }
        private void HoanVi<L>(IList<L> list,int i,int j)
        {
            L tam = list[i];
            list[i] = list[j];
            list[j] = tam;
        }
        public void SapXepTangCV()
        {
            for (int i = 0; i < DanhSachHCN.Count; i++)
                for (int j = i + 1; j < DanhSachHCN.Count; j++)
                    if (DanhSachHCN[i].CV > DanhSachHCN[j].CV)
                        HoanVi<HinhChuNhat>(DanhSachHCN, i, j);
        }
       public int dem
        {
            get { return DanhSachHCN.Count; }
        }
        public void Xoa(HinhChuNhat hcn)
       {
           DanhSachHCN.Remove(hcn);
       }
    }
}
