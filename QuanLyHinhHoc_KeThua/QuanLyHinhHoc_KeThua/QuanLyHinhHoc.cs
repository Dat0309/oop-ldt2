using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_KeThua
{
    class QuanLyHinhHoc
    {
        DanhSachHinhHoc DS = new DanhSachHinhHoc();

        public void NhapTuFile()
        {
            string fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] str = line.Split(' ');
                if (str[0] == "HT")
                    DS.Them(new HinhTron(float.Parse(str[1])));
                else if (str[0] == "HV")
                    DS.Them(new HinhVuong(float.Parse(str[1])));
                else
                    DS.Them(new HinhCN(float.Parse(str[1]), float.Parse(str[2])));
            }
        }
        public void NhapBangTay()
        {
            string line = "";
            do
            {
                Console.WriteLine("Xin moi nhap thong tin: Hinh vuong(vd: HV Canh), Hinh tron(vd: HT banKinh), Hinh CN(vd: HCN Dai Rong) :");

            a:
                line = Console.ReadLine();
                string[] str = line.Split(' ');
                if (str[0] == "HV")
                    DS.Them(new HinhVuong(float.Parse(str[1])));
                else if (str[0] == "HT")
                    DS.Them(new HinhTron(float.Parse(str[1])));
                else if (str[0] == "HCN")
                    DS.Them(new HinhCN(float.Parse(str[1]), float.Parse(str[2])));
                else
                    return;
                Console.WriteLine("Xin moi nhap tiep thong tin hoac Nhan phim bat ky de xuat danh sach hinh hoc!...");
                goto a;
            } while (line == null);
        }
        public void Xuat()
        {
            Console.WriteLine("===========================================================================");
            Console.WriteLine("DANH SACH HINH HOC");
            Console.WriteLine("===========================================================================");
            Console.WriteLine(DS);
        }

        public DanhSachHinhHoc Tim_DS_HT(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in a.DSHinhHoc)
                if (item is HinhTron)
                    kq.Them(item);
            return kq;
        }
        public DanhSachHinhHoc Tim_DS_HV(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in a.DSHinhHoc)
            {
                if (item is HinhVuong)
                    kq.Them(item); 
            }
            return kq;
        }
        public DanhSachHinhHoc Tim_DS_HCN(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            foreach (var item in a.DSHinhHoc)
            {
                if (item is HinhCN)
                    kq.Them(item);
            }
            return kq;
        }

        //Sap xep hinh tron tang giam chu vi
        public DanhSachHinhHoc SapXepHTGiamCV(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = Tim_DS_HT(a);
            ds.DSHinhHoc.Sort((x, y) => y.TinhChuVi().CompareTo(x.TinhChuVi()));
            return ds;
        }
        public DanhSachHinhHoc SapXepHTTangCV(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = Tim_DS_HT(a);
            ds.DSHinhHoc.Sort((x, y) => x.TinhChuVi().CompareTo(y.TinhChuVi()));
            return ds;
        }
        //Sap xep hinh vuong tang giam chu vi
        public DanhSachHinhHoc SapXepHVGiamCV(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = Tim_DS_HV(a);
            ds.DSHinhHoc.Sort((x, y) => y.TinhChuVi().CompareTo(x.TinhChuVi()));
            return ds;
        }
        public DanhSachHinhHoc SapXepHVTangCV(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = Tim_DS_HV(a);
            ds.DSHinhHoc.Sort((x, y) => x.TinhChuVi().CompareTo(y.TinhChuVi()));
            return ds;
        }
        //Sap xep hcn tang giam chu vi
        public DanhSachHinhHoc SapXepHCNGiamCV(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = Tim_DS_HCN(a);
            ds.DSHinhHoc.Sort((x, y) => y.TinhChuVi().CompareTo(x.TinhChuVi()));
            return ds;
        }
        public DanhSachHinhHoc SapXepHCNTangCV(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = Tim_DS_HCN(a);
            ds.DSHinhHoc.Sort((x, y) => x.TinhChuVi().CompareTo(y.TinhChuVi()));
            return ds;
        }
        //Sap xep theo dien tich giam dan
        public DanhSachHinhHoc SapXepDTGiam(DanhSachHinhHoc a)
        {
            foreach (var item in a.DSHinhHoc)
            {
                a.DSHinhHoc.Sort((x, y) => y.TinhDienTich().CompareTo(x.TinhDienTich()));
            }
            return a;
        }
        public DanhSachHinhHoc SapXepCVTang(DanhSachHinhHoc a)
        {
            foreach (var item in a.DSHinhHoc)
            {
                a.DSHinhHoc.Sort((x, y) => x.TinhChuVi().CompareTo(y.TinhChuVi()));
            }
            return a;
        }
        //Tim hinh vuong dien tich max min
        public DanhSachHinhHoc TimHVDTMax(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = Tim_DS_HV(a);
            DanhSachHinhHoc kq= new DanhSachHinhHoc();
            float max = ds.TimMax_DT();
            for (int i = 0; i < ds.Dai; i++)
                if (ds[i].TinhDienTich() == max)
                    kq.Them(ds[i]);
                return kq;
        }
        public DanhSachHinhHoc TimHVDTMin(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = Tim_DS_HV(a);
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float min = ds.TimMin_DT();
            for (int i = 0; i < ds.Dai; i++)
                if (ds[i].TinhDienTich() == min)
                    kq.Them(ds[i]);
            return kq;
        }
        //Tim hcn dien tich nho nhat
        public DanhSachHinhHoc TimHCNDTMin(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = Tim_DS_HCN(a);
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float min = ds.TimMin_DT();
            for (int i = 0; i < ds.Dai; i++)
                if (ds[i].TinhDienTich() == min)
                    kq.Them(ds[i]);
            return kq;
        }
        //Tim hinh tron co ban kinh max
        public DanhSachHinhHoc TimHTBKMax(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = Tim_DS_HT(a);
            DanhSachHinhHoc kq = new DanhSachHinhHoc();
            float max = ds.TimMax_BK();
            for(int i=0;i<ds.Dai;i++)
                if(ds[i] is HinhTron)
                {
                    HinhTron ht = (HinhTron)ds[i];
                    if (ht.BanKinh == max)
                        kq.Them(ds[i]);
                }
            return kq;
        }
        //Tim hinh co dt max - min
        public DanhSachHinhHoc TimHinhCoDTMax(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = new DanhSachHinhHoc();
            float max = a.TimMax_DT();
            foreach (var item in a.DSHinhHoc)
            {
                if (item.TinhDienTich() == max) 
                ds.Them(item);
            }
            return ds;
        }
        public DanhSachHinhHoc TimHinhCoDTMin(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = new DanhSachHinhHoc();
            float min = a.TimMin_DT();
            foreach (var item in a.DSHinhHoc)
            {
                if (item.TinhDienTich() == min)
                    ds.Them(item);
            }
            return ds;
        }
        //Tim hinh co cv max-min
        public DanhSachHinhHoc TimHinhCoCVMin(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = new DanhSachHinhHoc();
            float min = a.TimMin_CV();
            foreach (var item in a.DSHinhHoc)
            {
                if (item.TinhChuVi() == min)
                    ds.Them(item);
            }
            return ds;
        }
        public DanhSachHinhHoc TimHinhCoCVMax(DanhSachHinhHoc a)
        {
            DanhSachHinhHoc ds = new DanhSachHinhHoc();
            float max = a.TimMax_CV();
            foreach (var item in a.DSHinhHoc)
            {
                if (item.TinhChuVi() == max)
                    ds.Them(item);
            }
            return ds;
        }
        //Xoa hinh co cv lon nhat
        public void XoaHinhCoCVMax(DanhSachHinhHoc a)
        {
            float max = a.TimMax_CV();
            DanhSachHinhHoc ds = new DanhSachHinhHoc();
            foreach (var item in a.DSHinhHoc)
            {
                if (item.TinhChuVi() == max)
                    ds.Them(item);
            }
            foreach (var item in ds.DSHinhHoc)
            {
                a.Xoa(item);
            }
        }
        public void XoaHinhCoDTMin(DanhSachHinhHoc a)
        {
            float min = a.TimMin_DT();
            DanhSachHinhHoc ds = new DanhSachHinhHoc();
            foreach (var item in a.DSHinhHoc)
            {
                if (item.TinhDienTich() == min)
                    ds.Them(item);
            }
            foreach (var item in ds.DSHinhHoc)
            {
                a.Xoa(item);
            }
        }
        
    }
}
