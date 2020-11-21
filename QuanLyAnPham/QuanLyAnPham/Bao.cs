using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAnPham
{
    class Bao
    {
        #region Khoi Tao
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
        public Bao(int soTrang,string nxb)
        {
            this.soTrang = soTrang;
            this.nxb = nxb;
        }
        public void nhap()
        {
            do
            {
                Console.WriteLine("Nhap so trang bao: ");
                soTrang = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap NXB: ");
                nxb = Console.ReadLine();
            } while (soTrang<0);
        }
        public override string ToString()
        {
            return string.Format("{0,-10} {1,-5}",_SoTrang,_NXB);
        }
        #endregion
    }
}
