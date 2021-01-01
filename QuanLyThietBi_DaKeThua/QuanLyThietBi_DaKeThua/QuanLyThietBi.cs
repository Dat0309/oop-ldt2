using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi_DaKeThua
{
    class QuanLyThietBi
    {
        public DanhSachThietBi dstb = new DanhSachThietBi();
        public DanhSachThietBi DS_MT(DanhSachThietBi a)
        {
            DanhSachThietBi kq = new DanhSachThietBi();
            foreach (var item in a.dstb)
            {
                if (item is MayTinh)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachThietBi DS_MA(DanhSachThietBi a)
        {
            DanhSachThietBi kq = new DanhSachThietBi();
            foreach (var item in a.dstb)
            {
                if (item is MayAnh)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachThietBi TimThietBiCoGiaCaoNhat(DanhSachThietBi a)
        {
            DanhSachThietBi kq = new DanhSachThietBi();
            float max = a.dstb.Max(thietbi => thietbi.TinhGia());
            kq.dstb = a.dstb.Where(thietbi => thietbi.TinhGia() == max).ToList();
            return kq;
        }
        public DanhSachThietBi TimMayTinhGiaMax(DanhSachThietBi a)
        {
            DanhSachThietBi ds = new DanhSachThietBi();
            ds = DS_MT(a);
            DanhSachThietBi kq = new DanhSachThietBi();
            float max = ds.dstb.Max(x => x.TinhGia());
            kq.dstb = ds.dstb.Where(x => x.TinhGia() == max).ToList();
            return kq;
        }
        public DanhSachThietBi TimMayAnhGiaMin(DanhSachThietBi a)
        {
            DanhSachThietBi ds = new DanhSachThietBi();
            ds = DS_MA(a);
            DanhSachThietBi kq = new DanhSachThietBi();
            float min = ds.dstb.Min(x => x.TinhGia());
            kq.dstb = ds.dstb.Where(x => x.TinhGia() == min).ToList();
            return kq;
        }
        public DanhSachThietBi TimThietBiTheoGia(DanhSachThietBi a,float gia)
        {
            DanhSachThietBi kq = new DanhSachThietBi();
            kq.dstb = a.dstb.Where(x => x.TinhGia() == gia).ToList();
            return kq;
        }
        public DanhSachThietBi SapXepTBGiaTang(DanhSachThietBi a)
        {
            a.dstb.Sort((x, y) => x.TinhGia().CompareTo(y.TinhGia()));
            return a;
        }
        public DanhSachThietBi TimTBGiaCUPMax(DanhSachThietBi a)
        {
            DanhSachThietBi kq = new DanhSachThietBi();
            float max = a.dstb.Max(x => x.GiaCPU);
            kq.dstb = a.dstb.Where(x => x.GiaCPU == max).ToList();
            return kq;
        }
        private float TimCPUSDMax(DanhSachThietBi a,DanhSachLinhKien b)
        {
            DanhSachThietBi kq = new DanhSachThietBi();
            float max = float.MinValue;
            foreach (var item in b.dslk)
            {
                float dem = 0;
                foreach (var i in a.dstb)
                {
                    if (item is CPU)
                    {
                        CPU c = (CPU)item;
                        if (c.Ten.CompareTo(i.TenCPU) == 0)
                            dem++;
                    }
                }
                if (dem > max)
                    max = dem;
            }
            return max;
        }
        public void HienThiCPUSDMax(DanhSachThietBi a, DanhSachLinhKien b)
        {
            float max = TimCPUSDMax(a, b);
            foreach (var item in b.dslk)
            {
                float dem = 0;
                foreach (var i in a.dstb)
                {
                    if (item is CPU)
                    {
                        CPU c = (CPU)item;
                        if (c.Ten.CompareTo(i.TenCPU) == 0)
                            dem++;

                    }
                }
                if (item is CPU)
                {
                    CPU c = (CPU)item;
                    if (dem == max)
                        Console.WriteLine("TIM THAY CPU {0} duoc nhieu thiet bi su dung nhat voi so lan su dung la {1}", c.Ten, dem);
                }
            }

        }
    }
}
