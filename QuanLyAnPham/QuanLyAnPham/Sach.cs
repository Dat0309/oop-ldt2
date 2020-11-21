using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class Sach
    {
        #region Khoi Tao
        private string _TuaDe;
        public string TuaDe
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
        public Sach(string TuaDe,int soTrang,string nxb)
        {
            this.TuaDe = TuaDe;
            this.soTrang = soTrang;
            this.nxb = nxb;
        }
        public void nhap()
        {
            do
            {
                Console.WriteLine("Nhap tua de sach: ");
                TuaDe = Console.ReadLine();
                Console.WriteLine("Nhap so trang sach: ");
                soTrang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ten NXB: ");
                nxb = Console.ReadLine();
            } while (TuaDe == null);
        }
        public override string ToString()
        {
            return string.Format("{0,-9} {1,-8} {2,-5}", _TuaDe, _SoTrang, _NXB);
        }
        #endregion
    }
}
