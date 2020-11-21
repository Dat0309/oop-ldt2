using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class DSTapChi
    {
        List<TapChi> DanhSachTapChi = new List<TapChi>();
        public TapChi this[int i]
        {
            get { return DanhSachTapChi[i]; }
        }
        public void Them(TapChi tc)
        {
            DanhSachTapChi.Add(tc);
        }
        public override string ToString()
        {
            string line = "";
            foreach (var item in DanhSachTapChi)
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
            get { return DanhSachTapChi.Count; }
        }
        public void Xoa(TapChi tc)
        {
            DanhSachTapChi.Remove(tc);
        }
        #region Chuc Nang
        private int TimMax()
        {
            int max = int.MinValue;
            foreach (var item in DanhSachTapChi)
            {
                if (item.soBaiViet > max)
                    max = item.soBaiViet;
            }
            return max;
        }
        private int TimMin()
        {
            int min = int.MaxValue;
            foreach (var item in DanhSachTapChi)
            {
                if (item.soBaiViet < min)
                    min = item.soBaiViet;
            }
            return min;
        }
        public DSTapChi TimSLBVMax()
        {
            DSTapChi kq = new DSTapChi();
            int max = TimMax();
            foreach (var item in DanhSachTapChi)
            {
                if (item.soBaiViet == max)
                    kq.Them(item);
            }
            return kq;
        }
        public DSTapChi TimSLBVMin()
        {
            DSTapChi kq = new DSTapChi();
            int min = TimMin();
            foreach (var item in DanhSachTapChi)
            {
                if (item.soBaiViet == min)
                    kq.Them(item);
            }
            return kq;
        }
        #endregion
    }
}
