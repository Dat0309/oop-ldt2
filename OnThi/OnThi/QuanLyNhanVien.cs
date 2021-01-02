using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
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
        private DanhSachNhanVien DSNVBTGThang(DanhSachNhanVien a,int thang)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds = DSNVBTG(a);
            DanhSachNhanVien kq = new DanhSachNhanVien();
            foreach (var item in ds.dsnv)
            {
                if (item.Thang.CompareTo(thang) == 0)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachNhanVien TimNVBTGLuongMinThang(DanhSachNhanVien a,int thang)
        {
            DanhSachNhanVien ds = new DanhSachNhanVien();
            ds = DSNVBTGThang(a, thang);
            DanhSachNhanVien kq = new DanhSachNhanVien();
            int min = ds.dsnv.Min(x => x.Luong());
            foreach (var item in ds.dsnv)
            {
                if (item.Luong() == min)
                    kq.Them(item); 
            }
            return kq;
        }
        public DanhSachNhanVien TimNhanVienCoLuongMax(DanhSachNhanVien a)
        {
            int max = a.dsnv.Max(x => x.Luong());
            DanhSachNhanVien kq = new DanhSachNhanVien();
            kq.dsnv = a.dsnv.Where(x => x.Luong() == max).ToList();
            return kq;
        }
      
    }
}
