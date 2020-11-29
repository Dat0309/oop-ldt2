using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham_KeThua
{
    abstract class AnPham
    {
        int sotrang;
        string nxb;
        public int SoTrang { get { return sotrang; } set {sotrang=value ;} }
        public string NXB { get { return nxb; } set {nxb=value ;} }
    }
    class Sach : AnPham
    {
        private string tuaDe;
       
        public string TuaDe
        {
            get { return tuaDe; }
            set { tuaDe = value; }
        }

        public Sach() { }

        public Sach(string tuaDe,int st,string n)
        {
            this.tuaDe = tuaDe;
            SoTrang = st;
            NXB = n;
        }
        
        public override string ToString()
        {
            return string.Format("Sach: Tua De: {0,-13}, So Trang: {1,-5}, NXB: {2,-10}", tuaDe,SoTrang,NXB);
        }
    }
    class Bao:AnPham
    {
        
        public Bao() { }
        public Bao(int st,string n)
        {
            SoTrang = st;
            NXB = n;
        }
        public override string ToString()
        {

            return string.Format("Bao:".PadRight(29) + "So Trang: {0,-5}, NXB: {1,-10}", SoTrang, NXB);
        }
    }
    class TapChi:AnPham
    {
        
        private string tuDe;

        public string TuDe
        {
            get { return tuDe; }
            set { tuDe = value; }
        }
        private int soBaiViet;

        public int SoBaiViet
        {
            get { return soBaiViet; }
            set { soBaiViet = value; }
        }
        public TapChi() { }
        public TapChi(string td,int st,string n,int sbv)
        {
            TuDe = td;
            SoTrang = st;
            NXB = n;
            SoBaiViet = sbv;
        }
        public override string ToString()
        {
            return string.Format("Tap Chi: Tua De: {0,-10}, So Trang: {1,-5}, NXB: {2,-10}, So Bai Viet: {3,-5}", TuDe, SoTrang, NXB, SoBaiViet);
        }

    }
}
