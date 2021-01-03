using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhap1
{
    class QuanLyAnPham
    {
        DanhSachAnPham dsap = new DanhSachAnPham();
        List<string> DSNXB = new List<string>();
        private DanhSachAnPham DSTC(DanhSachAnPham a)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach (var item in a.dsap)
            {
                if (item is TapChi)
                    kq.Them(item);
            }
            return kq;
        }

        private int TimAPTuaDeMax(DanhSachAnPham a)
        {
            int max = int.MinValue;
            foreach (var item in a.dsap)
            {
                if(item is Sach)
                {
                    Sach s = (Sach)item;
                    if (s.TuaDe.Length > max)
                        max = s.TuaDe.Length;
                }
                if(item is TapChi)
                {
                    TapChi tc = (TapChi)item;
                    if (tc.TuaDe.Length > max)
                        max = tc.TuaDe.Length;
                }
            }
            return max;
        }
        public DanhSachAnPham HienThiAPTuaDeMax(DanhSachAnPham a)
        {
            DanhSachAnPham kq=new DanhSachAnPham();
            int max = TimAPTuaDeMax(a);
            foreach (var item in a.dsap)
            {
                if (item is Sach)
                {
                    Sach s = (Sach)item;
                    if (s.TuaDe.Length == max)
                        kq.Them(item);
                }
                if (item is TapChi)
                {
                    TapChi tc = (TapChi)item;
                    if (tc.TuaDe.Length == max)
                        kq.Them(item);
                }
            }
            return kq;
        }
        public DanhSachAnPham APTrangMax(DanhSachAnPham a)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            int max = a.dsap.Max(x => x.SoTrang);
            kq.dsap = a.dsap.Where(x => x.SoTrang == max).ToList();
            return kq;
        }
        public DanhSachAnPham TangGiamTrang(DanhSachAnPham a)
        {
            a.dsap.Sort((x, y) => x.SoTrang.CompareTo(y.SoTrang));
            return a;
        }
        public DanhSachAnPham TCSLBVMax(DanhSachAnPham a)
        {
            DanhSachAnPham ds = new DanhSachAnPham();
            ds = DSTC(a);
            int max = ds.TimSLBVMax();
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach (var item in ds.dsap)
            {
                if(item is TapChi)
                {
                    TapChi tc=(TapChi)item;
                    if(tc.SoBaiViet==max)
                        kq.Them(item);
                }
            }
            return kq;
        }
        private List<string> LayDSNXB(DanhSachAnPham a)
        {
            foreach (var item in a.dsap)
            {
                if(!DSNXB.Contains(item.NXB))
                    DSNXB.Add(item.NXB);
            }
            return DSNXB;
        }
        public void HienThiDSNXB(DanhSachAnPham a)
        {
            DSNXB = LayDSNXB(a);
            foreach (var item in DSNXB)
            {
                Console.WriteLine("NXB" + item);
                Console.WriteLine("=============");
                foreach (var i in a.dsap)
                {
                    if (item.CompareTo(i.NXB) == 0)
                        Console.WriteLine(i);
                }
            }
        }

    }
}
