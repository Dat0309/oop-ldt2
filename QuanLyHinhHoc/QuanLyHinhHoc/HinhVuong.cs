using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class HinhVuong
    {
        #region Khoi tao
        private float Canh;
        public float canh
        {
            get { return Canh; }
            set { Canh = value; }
        }
        private float chuVi;
        public float CV
        {
            get { return chuVi; }
            set { chuVi = value; }
        }
        private float DienTich;
        public float DT
        {
            get { return DienTich; }
            set { DienTich = value; }
        }
        public HinhVuong(float Canh)
        {
            canh = Canh;
            TinhChuVi();
            TinhDienTich();
        }
        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap chieu dai canh cua hinh vuong: ");
                canh = float.Parse(Console.ReadLine());
            } while (canh<0);
            TinhDienTich();
            TinhChuVi();
        }
        public override string ToString()
        {
            return string.Format("{0,-5} {1,-5} {2,-5}", Canh, chuVi, DienTich);
        }
        #endregion
        #region Tinh Dien tich
        public void TinhChuVi()
        {
            CV = canh * 4;
        }
        public void TinhDienTich()
        {
            DT = canh * canh;
        }
        #endregion

    }
}
