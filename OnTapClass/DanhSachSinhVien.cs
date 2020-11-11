using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapClass
{
    class DanhSachSinhVien
    {
        List<SinhVien> ds =new List<SinhVien>();
        public void Them(SinhVien sv)
        {
            ds.Add(sv);
        }

        public void NhapThuFile()
        {
            var fileName = "data.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = "";
            while ((line=sr.ReadLine())!=null)
            {
                Them(new SinhVien(line));
            }
        }
        public void NhapTuFileDaGhi()
        {
            var fileName = "data1.txt";
            StreamReader sr = new StreamReader(fileName);
            var line = "";
            while ((line = sr.ReadLine()) != null)
            {
                Them(new SinhVien(line));
            }
        }

        //Xuat tieu de!
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("MSSV".PadRight(15) + "Ho Ten".PadRight(18) + "DTB".PadRight(5) + "GioiTinh".PadRight(10) + "Lop".PadRight(3) + "\n" + "===================================================="+"\n");
            foreach (var item in ds)
            {
                sb.Append(item + "\n");
            }
            return sb.ToString();
        }

        public float TimDTBCaoNhat()
        {
            return ds.Max(x => x.dTB);
        }

        public DanhSachSinhVien TimDSSVCoDTBCaoNhat()
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            float max = TimDTBCaoNhat();
            foreach (var item in ds)
            {
                if (item.dTB == max)
                    kq.Them(item);
            }
            return kq;
        }
        private int DemSoLuongSVTheoGioiTinhVaLop(bool GT,string lop)
        {
            return ds.Count(x => x.gioiTinh == GT && x.Lop == lop);
        }
        public int DemSoLuongSVNam(string lop)
        {
            return DemSoLuongSVTheoGioiTinhVaLop(true, lop);
        }
        public int DemSoLuongSVNu(string lop)
        {
            return DemSoLuongSVTheoGioiTinhVaLop(false, lop);
        }
        public void SapXepDSTheoLop(string lop)
        {
            if(ds.Count(x=>x.Lop==lop)!=0) 
                SapXep(KieuSapXep.GiamDTB);
            
        }
        public List<string> LayDanhSachLop()
        { 
            List<string> kq = new List<string>();
            foreach (var item in ds)
            {
                if (!kq.Contains(item.Lop))
                    kq.Add(item.Lop);
            }
            return kq;
        }
        public List<string> LayDanhSachLopDTB()
        {
            List<string> kq = new List<string>();
            foreach (var item in ds)
            {
                if (!kq.Contains(item.Lop))
                    kq.Add(item.maSV+" ".PadRight(3) + item.hoTen+" ".PadRight(10) + item.Lop+ " ".PadRight(3) + item.dTB);
            }
            return kq;
        }
        enum KieuSapXep
        {
            TangDTB,
            GiamDTB
        }
        private void SapXep(KieuSapXep kieu)
        {
            if (kieu == KieuSapXep.TangDTB)
                ds = ds.OrderBy(x => x.dTB).ToList();
            else if (kieu == KieuSapXep.GiamDTB)
                ds = ds.OrderByDescending(x => x.dTB).ToList();
        }
        public void SapXepTangTheoDTB()
        {
            SapXep(KieuSapXep.TangDTB);
        }
        public void SapXepGiamTheoDTB()
        {
            SapXep(KieuSapXep.GiamDTB);
        }

        //tìm lớp có sinh viên có điểm trung bình cao nhất.
        public List<string> TimLopCoDTBCaoNhat()
        {
            List<string> LopDiemCao = new List<string>();
            float max = TimDTBCaoNhat();
            foreach (var item in ds)
            {
                if (item.dTB == max && !LopDiemCao.Contains(item.Lop))
                    LopDiemCao.Add(item.Lop);
            }
            return LopDiemCao;
        }
        public List<string> TimLopKhongCoDTBCaoNhat()
        {
            List<string> LopDiemCao = TimLopCoDTBCaoNhat();
            List<string> LopKoDiemCao = new List<string>();
            foreach (var item in ds)
            {
                if (!LopDiemCao.Contains(item.Lop) && !LopKoDiemCao.Contains(item.Lop))
                    LopKoDiemCao.Add(item.Lop);
            }
            return LopKoDiemCao;
        }
       private DanhSachSinhVien LayDSSVTheoLop(string lop)
        {
            DanhSachSinhVien kq = new DanhSachSinhVien();
            foreach (var item in ds)
            {
                if (item.Lop.CompareTo(lop) == 0)
                    kq.Them(item);
            }
            return kq;
        }
        public void HienThiDSSVTheoLopGiamDTB()
       {
           List<string> dsLop = LayDanhSachLop();
           DanhSachSinhVien dsSVLop = new DanhSachSinhVien();
           foreach (var item in dsLop)
           {
               Console.WriteLine("=======================");
               Console.WriteLine("Danh sach sinh vien lop {0}:\n", item);
               dsSVLop = LayDSSVTheoLop(item);
               dsSVLop.SapXepGiamTheoDTB();
               Console.WriteLine(dsSVLop);
           }
       }
        private int ThuHangSV(SinhVien sv)
        {
            int vt = 1;
            foreach (var item in ds)
            {
                if (item.Lop.CompareTo(sv.Lop) == 0 && sv.dTB < item.dTB)
                    vt++;
            }
            return vt;
        }
        public void XepHangSinhVienLop(string lop)
        {
            int vt;
            foreach (var item in ds)
            {
                if(item.Lop.CompareTo(lop)==0)
                {
                    vt = ThuHangSV(item);
                    Console.WriteLine("{0}".PadRight(8) + "{1}", item, vt);

                }
            }
        }
        public void HienThiThuHangLop()
        {
            List<string> dsLop = LayDanhSachLop();
            foreach (var item in dsLop)
            {
                Console.WriteLine("=====================");
                Console.WriteLine("Lop {0}\n", item);
                Console.WriteLine("MSSV".PadRight(15) + "Ho Ten".PadRight(18) + "DTB".PadRight(5) + "GioiTinh".PadRight(10) + "Lop".PadRight(5) + " Hang\n");
                XepHangSinhVienLop(item);
            }
        }
       private float TimTongDTBCuaMotLop(string lop)
        {
            float tong = 0;
            foreach (var item in ds)
            {
                if (item.Lop.CompareTo(lop) == 0)
                    tong += item.dTB;
            }
            return tong;
        }
        public float TimTongDTBCaoNhat()
       {
           List<string> dsLop = LayDanhSachLop();
           float max = float.MinValue, tam;
           foreach (var item in dsLop)
           {
               tam = TimTongDTBCuaMotLop(item);
               if (max < tam)
                   max = tam;
           }
           return max;
       }
        public float TimTongDTBThapNhat()
        {
            List<string> dsLop = LayDanhSachLop();
            float min = float.MaxValue, tam;
            foreach (var item in dsLop)
            {
                tam = TimTongDTBCuaMotLop(item);
                if (min > tam)
                    min = tam;
            }
            return min;
        }
        public List<string> TimLopCoTongDTBCaoNhat()
        {
            float max = TimTongDTBCaoNhat();
            List<string> dsLop = LayDanhSachLop();
            List<string> kq = new List<string>();
            foreach (var item in dsLop)
            {
                if (TimTongDTBCuaMotLop(item) == max)
                    kq.Add(item);
            }
            return kq;
        }
        public void XuatRaFile()
        {
            string fileName = "data1.txt";
            StreamWriter sw = new StreamWriter(fileName);
            foreach (var item in ds)
            {
                sw.WriteLine("{0},{1},{2},{3},{4}", item.maSV, item.hoTen, item.gioiTinh, item.Lop, item.dTB);
            }
            sw.Close();
        }
       
    }
}
