using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1914775_DinhTrongDat_KTGiuaKy
{
    interface INhanVien
    {
        string HoTen{get;set;}
        string NTNS { get; set; }
        int Thang { get; set; }
        int Luong();
    }
    class NhanVienHopDong :INhanVien
    {
        private int donGia;

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        private int soNgayLamViec;

        public int SoNgayLamViec
        {
            get { return soNgayLamViec; }
            set { soNgayLamViec = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string nTNS;

        public string NTNS
        {
            get { return nTNS; }
            set { nTNS = value; }
        }
        private int thang;

        public int Thang
        {
            get { return thang; }
            set { thang = value; }
        }
        public int Luong()
        {
            return this.soNgayLamViec * this.donGia;
        }
        public NhanVienHopDong() { }
        public NhanVienHopDong(string t,string ns,int th,int don,int so)
        {
            this.hoTen = t;
            nTNS = ns;
            thang = th;
            donGia = don;
            soNgayLamViec = so;
        }
        public override string ToString()
        {
            return string.Format("Nhan vien hop dong ten: {0}, ntns: {1}, thang: {2}, don gia: {3}, luong: {4}$,so ngay lam viec: {5}", hoTen, nTNS, thang, donGia, Luong(),soNgayLamViec);
        }
    }
    class NhanVienBanThoiGian:INhanVien
    {
        private int donGia;

        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        private int soGioLamViec;

        public int SoGioLamViec
        {
            get { return soGioLamViec; }
            set { soGioLamViec = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string nTNS;

        public string NTNS
        {
            get { return nTNS; }
            set { nTNS = value; }
        }
        private int thang;

        public int Thang
        {
            get { return thang; }
            set { thang = value; }
        }
        public int Luong()
        {
            return this.soGioLamViec * this.donGia;
        }
        public NhanVienBanThoiGian() { }
        public NhanVienBanThoiGian(string t,string ns,int th,int don,int so)
        {
            this.hoTen = t;
            nTNS = ns;
            thang = th;
            donGia = don;
            soGioLamViec = so;
        }
        public override string ToString()
        {
            return string.Format("Nhan vien ban thoi gian ten: {0}, ntns: {1}, thang: {2}, don gia: {3}, luong: {4}$, so gio lam viec: {5}", hoTen, nTNS, thang, donGia, Luong(),soGioLamViec);
        }
    }
}
