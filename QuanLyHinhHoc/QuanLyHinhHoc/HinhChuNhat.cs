using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    class HinhChuNhat
    {
        #region Khoi tao
        private float chieuDai;
        public float dai
        {
            get { return chieuDai; }
            set { chieuDai = value; }
        }
        private float chieuRong;
        public float rong
        {
            get { return chieuRong; }
            set { chieuRong = value; }
        }
        private float DienTich;
        public float DT
        {
            get { return DienTich; }
            set { DienTich = value; }
        }
        private float ChuVi;
        public float CV
        {
            get { return ChuVi; }
            set { ChuVi = value; }
        }
        public HinhChuNhat(float dai,float rong)
        {
            this.dai = dai;
            this.rong = rong;
            TinhChuVi();
            TinhDienTich();
        }
        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap vao chieu dai cua hcn: ");
                dai = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhap vao chieu rong cua hcn: ");
                rong = float.Parse(Console.ReadLine());
            } while (dai<0||rong<0);
            TinhDienTich();
            TinhChuVi();
        }
        public override string ToString()
        {
            return string.Format("{0,-5} {1,-5} {2,-5} {3,-5} ", chieuRong, chieuDai, ChuVi, DienTich);
        }
        #endregion 
        #region Tinh chu vi dien tich
        public void TinhChuVi()
        {
            CV = (dai + rong) * 2;
        }
        public void TinhDienTich()
        {
            DT = dai * rong;
        }
       
        #endregion

    }
}
