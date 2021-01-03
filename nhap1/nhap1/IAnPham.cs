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
            return string.Format("Sach: Tua de: {0}, NXB: {1}, So trang: {2}", tuaDe, nXB, soTrang);
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
            return string.Format("Bao: NXB: {0}, So trang: {1}",nXB,soTrang);
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
            return string.Format("Tap Chi: Tua de: {0}, NXB: {1}, So trang: {2}, So bai viet: {3} ",tuaDe,nXB,soTrang,soBaiViet);
        }
    }
}
