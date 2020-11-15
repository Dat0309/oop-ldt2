using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class DanhSachHinhVuong
    {
        List<HinhVuong> DanhSachHinhV = new List<HinhVuong>();

        public HinhVuong this[int i]
        {
            get { return DanhSachHinhV[i]; }
        }
        public void Them(HinhVuong hv)
        {
            DanhSachHinhV.Add(hv);
        }
        public override string ToString()
        {
            string line = "";
            foreach (var item in DanhSachHinhV)
            {
                line += item + "\n";
            }
            return line;
        }
        public void Xuat()
        {
            Console.WriteLine(this);
        }
        private float TimMax()
        {
            float max = float.MinValue;
            foreach (var item in DanhSachHinhV)
            {
                if (item.DT > max)
                    max = item.DT;
            }
            return max;
        }
        public DanhSachHinhVuong TimDTMax()
        {
            DanhSachHinhVuong kq=new DanhSachHinhVuong();
            float max = TimMax();
            foreach (var item in DanhSachHinhV)
            {
                if (item.DT == max)
                    kq.Them(item);
            }
            return kq;
        }
        private void HoanVi<L>(IList<L> list,int i, int j)
        {
            L tam = list[i];
            list[i] = list[j];
            list[j] = tam;
        }
        public void SapXepTangCV()
        {
            for (int i = 0; i < DanhSachHinhV.Count; i++)
                for (int j = i + 1; j < DanhSachHinhV.Count; j++)
                    if (DanhSachHinhV[i].CV > DanhSachHinhV[j].CV)
                        HoanVi<HinhVuong>(DanhSachHinhV, i, j);
        }
        public int Dai
        {
            get {return DanhSachHinhV.Count;}
        }
        public void Xoa(HinhVuong hv)
        {
            DanhSachHinhV.Remove(hv);
        }
    }
}
