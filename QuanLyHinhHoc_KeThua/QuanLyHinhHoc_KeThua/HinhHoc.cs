using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc_KeThua
{
    abstract class HinhHoc
    {
        public abstract float TinhDienTich();
        public abstract float TinhChuVi();
        
    }
    class HinhTron : HinhHoc
    {
        private float banKinh;

        public float BanKinh
        {
            get { return banKinh; }
            set { banKinh = value; }
        }
        public HinhTron() { }
        public HinhTron(float banKinh)
        {
            this.banKinh = banKinh;
        }

        public override float TinhDienTich()
        {
            return (float)Math.PI * banKinh * banKinh;
        }

        public override float TinhChuVi()
        {
            return (float)Math.PI * 2 * banKinh;
        }

        public override string ToString()
        {
            return string.Format("Hinh Tron ban kinh: {0,-10}, Dien tich: {1,-10}, Chu vi: {2,-5}", banKinh, TinhDienTich(), TinhChuVi());
        }
    }
    class HinhVuong : HinhHoc
    {
        private float canh;

        public float Canh
        {
            get { return canh; }
            set { canh = value; }
        }
        public HinhVuong() { }

        public HinhVuong(float canh)
        {
            this.canh = canh;
        }
        public override float TinhDienTich()
        {
            return (float)Math.Pow(canh, 2);
        }
        public override float TinhChuVi()
        {
            return canh * 4;
        }
        public override string ToString()
        {
            return string.Format("Hinh Vuong Canh: {0,-13}, Dien tich: {1,-10}, Chu vi {2,-5}", canh, TinhDienTich(), TinhChuVi());
        }
    }
    class HinhCN : HinhHoc
    {
        private float dai;

        public float Dai
        {
            get { return dai; }
            set { dai = value; }
        }

        private float rong;

        public float Rong
        {
            get { return rong; }
            set { rong = value; }
        }

        public HinhCN() { }
        public HinhCN(float dai,float rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public override float TinhDienTich()
        {
            return dai * rong;
        }
        public override float TinhChuVi()
        {
            return (dai + rong) * 2;
        }
        public override string ToString()
        {
            return string.Format("Hinh CN: Dai: {0}, Rong: {1,-7}, Dien tich: {2,-10}, Chu vi: {3}", dai, rong, TinhDienTich(), TinhChuVi());
        }

    }
}
