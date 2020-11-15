using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class HinhTron
    {
        #region Phuong thuc khoi tao
        private float banKinh;
        public float BK
        {
            get { return banKinh; }
            set { banKinh = value; }
        }
        private float chuVi;
        public float CV
        {
            get { return chuVi; }
            set { chuVi = value; }
        }
        private float dienTich;
        public float DT
        {
            get { return dienTich; }
            set { dienTich = value; }
        }

        public HinhTron(float banKinh)
        {
            BK = banKinh;
            TinhChuVi();
            TinhDienTich();
        }
        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap ban kinh cua hinh tron: ");
                BK = float.Parse(Console.ReadLine());
            } while (BK <0);
            TinhChuVi();
            TinhDienTich();
        }

        public override string ToString()
        {
            return string.Format("{0,-5} {1,-5} {2,-5} ", banKinh, chuVi, dienTich);
        }
        #endregion
        #region Tinh chu vi dien tich hinh tron
        public void TinhChuVi()
        {
            CV = banKinh * 2 * (float)Math.PI;
        }
        public void TinhDienTich()
        {
            DT = banKinh * banKinh * (float)Math.PI;
        }
        #endregion


    }
}
