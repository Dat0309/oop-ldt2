using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham_KeThua
{
    class QuanLyAnPham
    {
        DanhSachAnPham DS = new DanhSachAnPham();
        List<string> DSNXB = new List<string>();
        #region Tach danh sach
        public DanhSachAnPham TimDSTapChi(DanhSachAnPham a)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach (var item in a.ds)
            {
                if (item is TapChi)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachAnPham TimDSSach(DanhSachAnPham a)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach (var item in a.ds)
            {
                if (item is Sach)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachAnPham TimDSBao(DanhSachAnPham a)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            foreach (var item in a.ds)
            {
                if (item is Bao)
                    kq.Them(item);
            }
            return kq;
        }
        #endregion
        public DanhSachAnPham TimTCBVMax(DanhSachAnPham a)
        {
            DanhSachAnPham ds = TimDSTapChi(a);
            DanhSachAnPham kq = new DanhSachAnPham();
            int max = ds.TimMaxBV();
            for(int i=0;i<ds.Dai();i++)
                if(ds[i] is TapChi)
                {
                    TapChi tc = (TapChi)ds[i];
                    if (tc.SoBaiViet == max)
                        kq.Them(ds[i]);
                }
            return kq;
        }
        public DanhSachAnPham TimTCBVMin(DanhSachAnPham a )
        {
            DanhSachAnPham ds = TimDSTapChi(a);
            DanhSachAnPham kq = new DanhSachAnPham();
            int min = ds.TimMinBV();
            for(int i=0;i<ds.Dai();i++)
                if(ds[i] is TapChi)
                {
                    TapChi tc = (TapChi)ds[i];
                    if (tc.SoBaiViet == min)
                        kq.Them(ds[i]);
                }
            return kq;
        }
        public DanhSachAnPham TimTuaDeDaiNhat(DanhSachAnPham a)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            int max = a.TimTuaDeMax();
            foreach (var item in a.ds)
            {
                if(item is Sach)
                {
                    Sach s = (Sach)item;
                    if (s.TuaDe.Length == max)
                        kq.Them(item);
                }
                else if(item is TapChi)
                {
                    TapChi tc = (TapChi)item;
                    if (tc.TuDe.Length == max)
                        kq.Them(item);
                }
            }
            return kq;
        }
        public DanhSachAnPham TimTuaDeNganNhat(DanhSachAnPham a)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            int min = a.TimTuaDeMin();
            foreach (var item in a.ds)
            {
                if(item is Sach)
                {
                    Sach s = (Sach)item;
                    if (s.TuaDe.Length == min)
                        kq.Them(item);
                }
                else if(item is TapChi)
                {
                    TapChi tc = (TapChi)item;
                    if (tc.TuDe.Length == min)
                        kq.Them(item);
                }
            }
            return kq;
        }
        public DanhSachAnPham TimSoTrangMax(DanhSachAnPham a)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            int max = a.TimTrangMax();
            foreach (var item in a.ds)
            {
                if (item.SoTrang == max)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachAnPham TimSoTrangMin(DanhSachAnPham a)
        {
            DanhSachAnPham kq = new DanhSachAnPham();
            int min = a.TimTrangMin();
            foreach (var item in a.ds)
            {
                if (item.SoTrang == min)
                    kq.Them(item);
            }
            return kq;
        }
        private List<string> LayDSNXB(DanhSachAnPham a)
        {
            foreach (var item in a.ds)
            {
                if (!DSNXB.Contains(item.NXB))
                    DSNXB.Add(item.NXB);
            }
            return DSNXB;
        }
        public void HienThiDSNXB(DanhSachAnPham a)
        {
            DSNXB = LayDSNXB(a);
            foreach (var item in DSNXB)
            {
                Console.WriteLine("Danh sach an pham cua nxb: {0} ", item);
                Console.WriteLine("==============================");
                for (int i = 0; i < a.Dai(); i++)
                    if (item.CompareTo(a[i].NXB) == 0)
                        Console.WriteLine(a[i]);
            }
        }
        private int TimNXBMax(DanhSachAnPham a)
        {
            int max = int.MinValue;
            DSNXB = LayDSNXB(a);
            foreach (var item in DSNXB)
            {
                int dem = 0;
                for (int i = 0; i < a.Dai(); i++)
                    if (item.CompareTo(a[i].NXB) == 0)
                        dem++;
                if (dem > max)
                    max = dem;
            }
            return max;
        }
        private int TimNXBMin(DanhSachAnPham a)
        {
            int min = int.MaxValue;
            DSNXB = LayDSNXB(a);
            foreach (var item in DSNXB)
            {
                int dem = 0;
                for (int i = 0; i < a.Dai(); i++)
                    if (item.CompareTo(a[i].NXB) == 0)
                        dem++;
                if (dem < min)
                    min = dem;
            }
            return min;
        }
        public void HienThiDanhSachNXBMax(DanhSachAnPham a)
        {
            int max = TimNXBMax(a);
            DSNXB = LayDSNXB(a);
            foreach (var item in DSNXB)
            {
                int dem = 0;
                for (int i = 0; i < a.Dai(); i++)
                    if (item.CompareTo(a[i].NXB) == 0)
                        dem++;
                if (dem == max)
                    Console.WriteLine("NXB Nhieu an pham nhat la: {0}, voi so an pham la: {1}", item, dem);
            }
        }
        public void HienThiDanhSachNXBMin(DanhSachAnPham a)
        {
            int min = TimNXBMin(a);
            DSNXB = LayDSNXB(a);
            foreach (var item in DSNXB)
            {
                int dem = 0;
                for (int i = 0; i < a.Dai(); i++)
                    if (item.CompareTo(a[i].NXB) == 0)
                        dem++;
                if (dem == min)
                    Console.WriteLine("NXB It an pham nhat la: {0}, voi so an pham la: {1}", item, dem);
            }
        }
        public void TimTheoNXB(DanhSachAnPham a)
        {
            string nhap;
            Console.WriteLine("Nhap ten NXB can tim an pham (NXBGD,NXBVN,NXBKD,etc...)");
            nhap = Console.ReadLine();
            Console.WriteLine("Danh sach an pham cua NXB: {0}", nhap);
            foreach (var item in a.ds)
            {
                if (nhap.CompareTo(item.NXB) == 0)
                    Console.WriteLine(item);
            }
        }
        public void XoaTheoNXB(DanhSachAnPham a)
        {
            string nhap;
            Console.WriteLine("Nhap ten NXB can xoa!!(NXBGD,NXBVN,NXBKD,etc...");
            nhap = Console.ReadLine();
            for (int j = 0; j < 2;j++)
                for (int i = 0; i < a.Dai(); i++)
                    if (nhap.CompareTo(a[i].NXB) == 0)
                        a.Xoa(a[i]);
        }
        public DanhSachAnPham SapXepTrangTang(DanhSachAnPham a)
        {
            foreach (var item in a.ds)
            {
                a.ds.Sort((x, y) => x.SoTrang.CompareTo(y.SoTrang));
            }
            return a;
        }
        public DanhSachAnPham SapXepTrangGiam(DanhSachAnPham a)
        {
            foreach (var item in a.ds)
            {
                a.ds.Sort((x, y) => y.SoTrang.CompareTo(x.SoTrang));
            }
            return a;
        }
    }
}
