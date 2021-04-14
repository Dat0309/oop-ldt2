using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhap1
{
    interface IAnPham
    {
        int SoTrang { get; set; }
        string NXB { get; set; }
        
    }
    class Sach:IAnPham
    {
        private int soTrang;

        public int SoTrang
        {
            get { return soTrang; }
            set { soTrang = value; }
        }
        private string nXB;

        public string NXB
        {
            get { return nXB; }
            set { nXB = value; }
        }
        private string tuaDe;

        public string TuaDe
        {
            get { return tuaDe; }
            set { tuaDe = value; }
        }
        public Sach() { }
        public Sach(string td,int st,string nxb)
        {
            tuaDe = td;
            soTrang = st;
            nXB = nxb;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2.-10}", tuaDe, nXB, soTrang);
        }
 
    }
    class Bao:IAnPham
    {
        private int soTrang;

        public int SoTrang
        {
            get { return soTrang; }
            set { soTrang = value; }
        }
        private string nXB;

        public string NXB
        {
            get { return nXB; }
            set { nXB = value; }
        }
        
        public Bao() { }
        public Bao(int st,string nxb)
        {
            soTrang = st;
            nXB = nxb;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10}",nXB,soTrang);
        }
    }
    class TapChi:IAnPham
    {
        private int soTrang;

        public int SoTrang
        {
            get { return soTrang; }
            set { soTrang = value; }
        }
        private string nXB;

        public string NXB
        {
            get { return nXB; }
            set { nXB = value; }
        }
        private string tuaDe;

        public string TuaDe
        {
            get { return tuaDe; }
            set { tuaDe = value; }
        }
        private int soBaiViet;

        public int SoBaiViet
        {
            get { return soBaiViet; }
            set { soBaiViet = value; }
        }
        public TapChi() { }
        public TapChi(string td,int sbv,int st,string nxb)
        {
            tuaDe = td;
            soBaiViet = sbv;
            soTrang = st;
            nXB = nxb;
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-10} {2,-10} {3,-10}",tuaDe,nXB,soTrang,soBaiViet);
        }
    }
}
