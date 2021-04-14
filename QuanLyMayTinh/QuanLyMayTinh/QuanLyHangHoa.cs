using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class QuanLyHangHoa
    {

        DanhSachHangHoa dshh = new DanhSachHangHoa();
        List<string> dsten = new List<string>();
        public DanhSachHangHoa InDSHHSLMuoi(DanhSachHangHoa a)
        {
            DanhSachHangHoa kq = new DanhSachHangHoa();
            kq.dshh = a.dshh.Where(x => x.SoLuong >= 10).ToList();
            return kq;
        }
        public DanhSachHangHoa TimDSTaiNghe(DanhSachHangHoa a)
        {
            DanhSachHangHoa kq = new DanhSachHangHoa();
            kq.dshh = a.dshh.Where(x => x.TenHang == "TAI NGHE").ToList();
            return kq;
        }
        private int TongTien(DanhSachHangHoa a)
        {
            int max = int.MinValue;
            foreach (var item in a.dshh)
                if (!dsten.Contains(item.TenHang))
                    dsten.Add(item.TenHang);
            foreach (var item in dsten)
            {
                int Tong = 0;
                foreach (var i in a.dshh)
                {
                    if (item.CompareTo(i.TenHang) == 0)
                        Tong += i.ThanhTien();
                }
                if (Tong > max)
                    max = Tong;
            }
            return max;
        }
        public void TimMHTongTienMax(DanhSachHangHoa a)
        {
            int max = TongTien(a);
            DanhSachHangHoa kq = new DanhSachHangHoa();
            foreach (var item in dsten)
            {
                int Tong = 0;
                foreach (var i in a.dshh)
                {
                    if (item.CompareTo(i.TenHang) == 0)
                        Tong += i.ThanhTien();
                }
                if (Tong == max)
                    Console.WriteLine("Mat hang co tong so tien nhieu nhat la : " + item+" voi tong so tien la: $"+Tong);
            }
        }
        public DanhSachHangHoa TimMatHangThanhTienMax(DanhSachHangHoa a)
        {
            DanhSachHangHoa kq = new DanhSachHangHoa();
            int max = a.dshh.Max(x => x.ThanhTien());
            kq.dshh = a.dshh.Where(x => x.ThanhTien() == max).ToList();
            return kq;
        }
        public DanhSachHangHoa TimDSMatHangX(DanhSachHangHoa a,string ten)
        {
            DanhSachHangHoa kq = new DanhSachHangHoa();
                kq.dshh = a.dshh.FindAll(x => x.TenHang == ten).ToList();
            return kq;
        }
        public DanhSachHangHoa TimSoTienMaxMHX(DanhSachHangHoa a,string ten)
        {
            DanhSachHangHoa ds = new DanhSachHangHoa();
            ds = TimDSMatHangX(a, ten);
            int max = ds.dshh.Max(x => x.ThanhTien());
            DanhSachHangHoa kq = new DanhSachHangHoa();
            kq.dshh = a.dshh.Where(x => x.ThanhTien() == max).ToList();
            return kq;
        }
        #region
        public DanhSachHangHoa SapXep(DanhSachHangHoa a)
        {
            a.dshh.Sort((x, y) => x.ThanhTien().CompareTo(y.ThanhTien()));
            return a;
        }
        public DanhSachHangHoa SapXepGiam(DanhSachHangHoa a)
        {
            a.dshh.Sort((x, y) => y.ThanhTien().CompareTo(x.ThanhTien()));
            return a;
        }
        public DanhSachHangHoa SapXepTangSL(DanhSachHangHoa a)
        {
            a.dshh.Sort((x, y) => x.SoLuong.CompareTo(y.SoLuong));
            return a;
        }
        public DanhSachHangHoa SapXepTheoTen(DanhSachHangHoa a)
        {
            a.dshh.Sort((x, y) => x.MoTa.CompareTo(y.MoTa));
            return a;
        }
        public DanhSachHangHoa SapXepTangChieuDaiTen(DanhSachHangHoa a)
        {
            a.dshh.Sort((x, y) => x.MoTa.Length.CompareTo(y.MoTa.Length));
            return a;
        }
        #endregion
        public void XoaHangHoaX(DanhSachHangHoa a,string ten)
        {
            DanhSachHangHoa ds=new DanhSachHangHoa();
                ds.dshh = a.dshh.FindAll(x => x.MoTa == ten).ToList();
            foreach (var item in ds.dshh)
            {
                a.Xoa(item);
            }
        }

    }
}
