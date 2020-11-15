using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class DanhSachHinhTron
    {
        List<HinhTron> DanhSachHinhT = new List<HinhTron>();
        public HinhTron this[int i]
        {
            get { return DanhSachHinhT[i]; }
        }
        public void Them(HinhTron ht)
        {
            DanhSachHinhT.Add(ht);
        }
        public override string ToString()
        {
            string line = "";
            foreach (var item in DanhSachHinhT)
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
            foreach (var item in DanhSachHinhT)
            {
                if (item.BK > max)
                    max = item.BK;
            }
            return max;
        }
        public DanhSachHinhTron TimBkMax()
        {
            DanhSachHinhTron kq = new DanhSachHinhTron();
            float max = TimMax();
            foreach (var  item in DanhSachHinhT)
            {
                if (item.BK == max)
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
        public void SapXepGiamCV()
        {
            for (int i = 0; i < DanhSachHinhT.Count; i++)
                for (int j = i + 1; j < DanhSachHinhT.Count; j++)
                    if (DanhSachHinhT[i].CV < DanhSachHinhT[j].CV)
                        HoanVi<HinhTron>(DanhSachHinhT, i, j);
        }
        public int dem
        {
            get { return DanhSachHinhT.Count; }
        }
        public void Xoa(HinhTron ht)
        {
            DanhSachHinhT.Remove(ht);
        }
       
    }
}
