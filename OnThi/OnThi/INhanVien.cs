using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThi
{
    interface INhanVien
    {
        string HoTen { get; set; }
        string NTNS { get; set; }
        int Thang { get; set; }
        
        int Luong();
    }
    class NhanVienHopDong:INhanVien
    {
        private int soNgay { get; set; }
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
        public int DonGia = 25;
        public int Luong()
        {
            return DonGia * soNgay;
        }
        public NhanVienHopDong() { }
        public NhanVienHopDong(string ht,string nt,int th,int ngay)
        {
            hoTen = ht;
            nTNS = nt;
            thang = th;
            soNgay = ngay;
        }
        public override string ToString()
        {
            return string.Format("Nhan vien hop dong: Ho Ten: {0},Ngay sinh: {1}, Luong Thang: {2}, So Ngay lam: {3}, Luong: {4}", hoTen, nTNS, thang, soNgay, Luong());
        }

    }
    class NhanVienBanThoiGian:INhanVien
    {
        private int soGio { get; set; }
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
        public int DonGia = 20;
        public int Luong()
        {
            return DonGia * soGio;
        }
        public NhanVienBanThoiGian() { }
        public NhanVienBanThoiGian(string ht, string nt, int th, int gio)
        {
            hoTen = ht;
            nTNS = nt;
            thang = th;
            soGio = gio;
        }
        public override string ToString()
        {
            return string.Format("Nhan vien ban thoi gian: Ho Ten: {0},Ngay sinh: {1}, Luong Thang: {2}, So Ngay lam: {3}, Luong: {4}", hoTen, nTNS, thang, soGio, Luong());
        }
    }
}
