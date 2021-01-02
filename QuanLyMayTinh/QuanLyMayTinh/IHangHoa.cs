using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    interface IHangHoa
    {
        string MaHang { get; set; }
        string TenHang { get; set; }
        string MoTa { get; set; }
        int SoLuong { get; set; }
        int ThanhTien();
    }
    class MayTinh:IHangHoa
    {
        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        private string tenHang;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        private string moTa;

        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public int DonGia = 500;
        public int ThanhTien()
        {
            return soLuong * DonGia;
        }
        public MayTinh() { }
        public MayTinh(string ma,string ten,string mt,int sl)
        {
            maHang = ma;
            tenHang = ten;
            moTa = mt;
            soLuong = sl;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,-10} {3,-10} ${4,-10} ${5,-10}", maHang, tenHang, moTa, soLuong, DonGia, ThanhTien());
        }
    }
    class TaiNghe:IHangHoa
    {
        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        private string tenHang;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        private string moTa;

        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public int DonGia = 250;
        public int ThanhTien()
        {
            return soLuong * DonGia;
        }
        public TaiNghe() { }
        public TaiNghe(string ma,string ten,string mt,int sl)
        {
            maHang = ma;
            tenHang = ten;
            moTa = mt;
            soLuong = sl;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,-10} {3,-10} ${4,-10} ${5,-10}", maHang, tenHang, moTa, soLuong, DonGia, ThanhTien());
        }
    }
    class QuanAo:IHangHoa
    {
        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        private string tenHang;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        private string moTa;

        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public int DonGia =75;
        public int ThanhTien()
        {
            return soLuong * DonGia;
        }
        public QuanAo() { }
        public QuanAo(string ma,string ten,string mt,int sl)
        {
            maHang = ma;
            tenHang = ten;
            moTa = mt;
            soLuong = sl;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,-10} {3,-10} ${4,-10} ${5,-10}", maHang, tenHang, moTa, soLuong, DonGia, ThanhTien());
        }
    }
    class GiayDep:IHangHoa
    {
        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }
        private string tenHang;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }
        private string moTa;

        public string MoTa
        {
            get { return moTa; }
            set { moTa = value; }
        }
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public int DonGia = 100;
        public int ThanhTien()
        {
            return soLuong * DonGia;
        }
        public GiayDep() { }
        public GiayDep(string ma,string ten,string mt,int sl)
        {
            maHang = ma;
            tenHang = ten;
            moTa = mt;
            soLuong = sl;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,-10} {3,-10} ${4,-10} ${5,-10}", maHang, tenHang, moTa, soLuong, DonGia, ThanhTien());
        }
    }
}
