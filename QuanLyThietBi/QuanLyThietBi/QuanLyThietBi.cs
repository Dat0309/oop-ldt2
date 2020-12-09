using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
    class QuanLyThietBi
    {
        List<DanhSachLinhKien> dslk = new List<DanhSachLinhKien>();
        #region Phân loại các danh sách
        public DanhSachThietBi DS_MT(DanhSachThietBi a)
        {
            DanhSachThietBi kq = new DanhSachThietBi();
            foreach (var item in a.ds)
            {
                if (item is MayTinh)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachThietBi DS_MA(DanhSachThietBi a)
        {
            DanhSachThietBi kq=new DanhSachThietBi();
            foreach (var item in a.ds)
	        {
                if (item is MayAnh)
                    kq.Them(item);
	        }
            return kq;
        }
        #endregion
        #region Tim may tinh,may anh co gia cao-thap
        public DanhSachThietBi TimMTGiaMax(DanhSachThietBi a)
        {
            DanhSachThietBi ds = DS_MT(a);
            DanhSachThietBi kq = new DanhSachThietBi();
            float max = ds.TimMaxGia();
            foreach (var item in a.ds)
            {
                if (item.TinhGia() == max)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachThietBi TimMTGiaMin(DanhSachThietBi a)
        {
            DanhSachThietBi ds = DS_MT(a);
            DanhSachThietBi kq = new DanhSachThietBi();
            float min = ds.TimMinGia();
            foreach (var item in a.ds)
            {
                if (item.TinhGia() == min)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachThietBi TimMAGiaMax(DanhSachThietBi a)
        {
            DanhSachThietBi ds = DS_MA(a);
            DanhSachThietBi kq = new DanhSachThietBi();
            float max = ds.TimMaxGia();
            foreach (var item in a.ds)
            {
                if (item.TinhGia() == max)
                    kq.Them(item);
            }
            return kq;
        }
        public DanhSachThietBi TimMAGiaMin(DanhSachThietBi a)
        {
            DanhSachThietBi ds = DS_MA(a);
            DanhSachThietBi kq = new DanhSachThietBi();
            float min = ds.TimMinGia();
            foreach (var item in a.ds)
            {
                if (item.TinhGia() == min)
                    kq.Them(item);
            }
            return kq;
        }
        #endregion
        #region Dem thiet bi theo gia
        public DanhSachThietBi TimTheoGia(DanhSachThietBi a,float gia)
        {
            DanhSachThietBi kq=new DanhSachThietBi();
           
            
            foreach (var item in a.ds)
            {
                if (item.TinhGia() == gia)
                    kq.Them(item);
            }
            return kq;
        }
        #endregion
        #region Sap xep tang giam gia
        public DanhSachThietBi SapXepGiaTang(DanhSachThietBi a)
        {
            
            foreach (var item in a.ds)
            {
                a.ds.Sort((x, y) => x.TinhGia().CompareTo(y.TinhGia()));
            }
            return a;
        }
        public DanhSachThietBi SapXepGiaGiam(DanhSachThietBi a)
        {
            
            foreach (var item in a.ds)
            {
                a.ds.Sort((x, y) => y.TinhGia().CompareTo(x.TinhGia()));
            }
            return a;
        }
        public DanhSachThietBi SapXepMTTangGia(DanhSachThietBi a)
        {
            DanhSachThietBi ds = DS_MT(a);
            ds.ds.Sort((x, y) => x.TinhGia().CompareTo(y.TinhGia()));
            return ds;
        }
        public DanhSachThietBi SapXepMTGiamGia(DanhSachThietBi a)
        {
            DanhSachThietBi ds = DS_MT(a);
            ds.ds.Sort((x, y) => y.TinhGia().CompareTo(x.TinhGia()));
            return ds;
        }
        #endregion
        #region Tim Thiet Bi Co Gia CPU max,min
        public DanhSachThietBi TimThietBiCPUMax(DanhSachThietBi a)
        {
            DanhSachThietBi kq=new DanhSachThietBi();
            float max = a.TimMaxCPU();
            foreach (var item in a.ds)
            {
                if (item.GiaCPU == max)
                    kq.Them(item);
            }
            return kq;
        }
        
        public DanhSachThietBi TimThietBiCPUMin(DanhSachThietBi a)
        {
            DanhSachThietBi kq = new DanhSachThietBi();
            float min = a.TimMinCPU();
            foreach (var item in a.ds)
            {
                if (item.GiaCPU == min)
                    kq.Them(item);
            }
            return kq;
        }
        #endregion
        #region tìm thiết bị được sử dụng nhiều nhất, ít nhất RAM,CPU
        private float DemSuDungCPU(DanhSachThietBi a,DanhSachLinhKien b)
        {
            float max = float.MinValue;
            foreach (var item in b.ds)
            {
                float dem = 0;
                foreach (var i in a.ds)
                {
                    if(item is CPU)
                    {
                        CPU c = (CPU)item;
                        if (c.Ten.CompareTo(i.TenCPU) == 0)
                            dem++;
                    }
                    if (dem > max)
                        max = dem;
                }
            }
            return max;
        }
        
        private float DemSuDungCPUMin(DanhSachThietBi a,DanhSachLinhKien b)
        {
            float min = float.MaxValue;
            foreach (var item in b.ds)
            {
                float dem = 0;
                foreach (var i in a.ds)
                {
                    if (item is CPU)
                    {
                        CPU c = (CPU)item;
                        if (c.Ten.CompareTo(i.TenCPU) == 0)
                            dem++;
                    }
                    if (dem < min)
                        min = dem;
                }
            }
            return min;
        }
        private float DemSoLuongRAMMin(DanhSachThietBi a,DanhSachLinhKien b)
        {
            float min = float.MaxValue;
            foreach (var item in b.ds)
            {
                float dem = 0;
                foreach (var i in a.ds)
                {
                    if(item is RAM)
                    {
                        RAM r = (RAM)item;
                        if (r.Ten.CompareTo(i.TenRAM) == 0)
                            dem++;
                    }
                    if (dem < min)
                        min = dem;
                }
                
            }
            return min;
        }
        public void HienThiCPUSDMax(DanhSachThietBi a,DanhSachLinhKien b)
        {
            float max = DemSuDungCPU(a, b);
            foreach (var item in b.ds)
            {
                float dem = 0;
                foreach (var i in a.ds)
                {
                    if(item is CPU)
                    {
                        CPU c = (CPU)item;
                        if (c.Ten.CompareTo(i.TenCPU) == 0)
                            dem++;
                       
                    } 
                }
                if(item is CPU)
                {
                    CPU c = (CPU)item;
                    if (dem == max)
                        Console.WriteLine("TIM THAY CPU {0} duoc nhieu thiet bi su dung nhat voi so lan su dung la {1}", c.Ten, dem);
                }
            }
            
        }
        public void HienThiCPUSDMin(DanhSachThietBi a, DanhSachLinhKien b)
        {
            float min = DemSuDungCPUMin(a, b);
            foreach (var item in b.ds)
            {
                float dem = 0;
                foreach (var i in a.ds)
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
                    if (dem == min)
                        Console.WriteLine("TIM THAY CPU {0} duoc it thiet bi su dung nhat voi so lan su dung la {1}", c.Ten, dem);
                }
            }
        }
        public void HienThiRAMSDMin(DanhSachThietBi a,DanhSachLinhKien b)
        {
            float min = DemSoLuongRAMMin(a, b);
            foreach (var item in b.ds)
            {
                float dem = 0;
                foreach (var i in a.ds)
                {
                    if(item is RAM)
                    {
                        RAM r = (RAM)item;
                        if (r.Ten.CompareTo(i.TenRAM) == 0)
                            dem++;
                    }
                }
                if(item is RAM)
                {
                    RAM r = (RAM)item;
                    if (dem == min)
                        Console.WriteLine("Tim thay RAM {0} khong co thiet bi nao su dung!",r.Ten);
                }
            }
        }
        #endregion
        #region RAM
        public void HienThiRAMtheoRAM(DanhSachThietBi a,DanhSachLinhKien b)
        {
            foreach (var item in b.ds)
            {
                float dem = 0;
                foreach (var i in a.ds)
                {
                    if(item is RAM)
                    {
                        RAM r = (RAM)item;
                        if (r.Ten.CompareTo(i.TenRAM) == 0)
                            dem++;
                    }
                }
                if (item is RAM)
                {
                    RAM r = (RAM)item;    
                        Console.WriteLine("Tim thay RAM {0} co so thiet bi su dung la {1}", r.Ten,dem);
                }
            }
        }
        #endregion
        #region Tim linh kien duoc su dung nhieu nhat
        private float TimLinhKienSDMax(DanhSachThietBi a,DanhSachLinhKien b)
        {
            float max = float.MinValue;
            foreach (var item in b.ds)
            {
                float dem = 0;
                foreach (var i in a.ds)
                {
                    if ((item.Ten.CompareTo(i.TenRAM) == 0) || (item.Ten.CompareTo(i.TenCPU) == 0))
                        dem++;
                }
                if (dem > max)
                    max = dem;
            }
            return max;
        }
        public void HienThiLinhKienDSMax(DanhSachThietBi a,DanhSachLinhKien b)
        {
            float max = TimLinhKienSDMax(a, b);
            foreach (var item in b.ds)
            {
                float dem = 0;
                foreach (var i in a.ds)
                {
                    if ((item.Ten.CompareTo(i.TenRAM) == 0) || (item.Ten.CompareTo(i.TenCPU) == 0))
                        dem++;
                }
                if (dem == max)
                    Console.WriteLine("Tim duoc linh kien {0} duoc su dung nhieu nhat, coi so lan su dung la {1}", item, dem);
            }
        }
        #endregion

    }
}
