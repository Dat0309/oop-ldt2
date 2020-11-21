using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class TapChi
    {
        #region Khoi tao
        private string _TuaDe;
        public string tuaDe
        {
            get { return _TuaDe; }
            set { _TuaDe = value; }
        }
        private int _SoTrang;
        public int soTrang
        {
            get { return _SoTrang; }
            set { _SoTrang = value; }
        }
        private string _NXB;
        public string nxb
        {
            get { return _NXB; }
            set { _NXB = value; }
        }
        private int _SoBaiViet;
        public int soBaiViet
        {
            get { return _SoBaiViet; }
            set { _SoBaiViet = value; }
        }
        public TapChi(string tuaDe,int soTrang,string nxb,int soBaiViet)
        {
            this.tuaDe = tuaDe;
            this.soTrang = soTrang;
            this.nxb = nxb;
            this.soBaiViet = soBaiViet;
        }
        public void nhap()
        {
            do
            {
                Console.WriteLine("Nhap tua de tap chi: ");
                tuaDe = Console.ReadLine();
                Console.WriteLine("Nhap so trang tap chi: ");
                soTrang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap NXB tap chi: ");
                nxb=Console.ReadLine();
                Console.WriteLine("Nhap so bai viet cua tap chi: ");
                soBaiViet=int.Parse(Console.ReadLine());
            } while (tuaDe==null);
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-13} {2,-10} {3,-5}", _TuaDe, _SoTrang, _NXB, _SoBaiViet);
        }
        #endregion
       
    }
}
