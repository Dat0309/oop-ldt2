using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1914775_DinhTrongDat_KTGiuaKy
{
    class QuanLyNhanVien
    {
        DanhSachNhanVien dsnv = new DanhSachNhanVien();
        public DanhSachNhanVien DSNVBTG(DanhSachNhanVien a)
        {
            DanhSachNhanVien kq = new DanhSachNhanVien();
            foreach (var item in a.dsnv)
            {
                if (item is NhanVienBanThoiGian)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachNhanVien DSNVBTHThang(DanhSachNhanVien a,int thang)
        {
            DanhSachNhanVien kq = new DanhSachNhanVien();
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds = DSNVBTG(a);
            foreach (var item in ds.dsnv)
            {
                if (item.Thang.CompareTo(thang) == 0)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachNhanVien TimNVBTGLuongMin(DanhSachNhanVien a,int thang)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds = DSNVBTHThang(a,thang);
            int min = ds.dsnv.Min(x => x.Luong());
            DanhSachNhanVien kq = new DanhSachNhanVien();
            foreach (var item in ds.dsnv)
            {
               if(item.Thang==thang)
                {
                    if (item.Luong() == min)
                        kq.Them(item);
                }
            }
            return kq;
        }
        public void TimThangTraLuongChoNVMin(DanhSachNhanVien a)
        {
            
            int min = a.dsnv.Min(x => x.Luong());
            foreach (var item in a.dsnv)
            {
                if (item.Luong() == min)
                    Console.WriteLine("Tim thay thang {0} tra luong cho nhan vien thap nhat!!", item.Thang);
            }
            
        }
        public DanhSachNhanVien TimNVLuongMax(DanhSachNhanVien a)
        {
            DanhSachNhanVien kq = new DanhSachNhanVien();
            int max = a.dsnv.Max(x => x.Luong());
            foreach (var item in a.dsnv)
            {
                if (item.Luong() == max)
                    kq.Them(item);
            }
            return kq;
        }

    }
}
