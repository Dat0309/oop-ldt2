﻿using System;
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
            foreach (var item in a.dshh)
            {
                if (item.TenHang.CompareTo(ten) == 0)
                    kq.Them(item);
            }
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
        public DanhSachHangHoa SapXep(DanhSachHangHoa a)
        {
            a.dshh.Sort((x, y) => x.ThanhTien().CompareTo(y.ThanhTien()));
            return a;
        }
    }
}