using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
    abstract class ThietBi
    {
        public abstract float TinhGia();
        private float giaCPU;

        public float GiaCPU
        {
            get { return giaCPU; }
            set { giaCPU = value; }
        }

        private float giaRAM;

        public float GiaRAM
        {
            get { return giaRAM; }
            set { giaRAM = value; }
        }
        private string tenCPU;

        public string TenCPU
        {
            get { return tenCPU; }
            set { tenCPU = value; }
        }
        private string tenRAM;

        public string TenRAM
        {
            get { return tenRAM; }
            set { tenRAM = value; }
        }
    }
    class MayAnh:ThietBi
    {
        public List<LinhKien> dslk = new List<LinhKien>();
        private string tenMayAnh;

        public string TenMayAnh
        {
            get { return tenMayAnh; }
            set { tenMayAnh = value; }
        }
        public void Them(LinhKien x)
        {
            if (!dslk.Contains(x))
                dslk.Add(x);
        }
        public MayAnh() { }
        public MayAnh(string ten,RAM r,CPU c)
        {
            this.tenMayAnh = ten;
            Them(r);
            TenRAM = r.Ten;
            GiaRAM = r.Gia;
            Them(c);
            TenCPU = c.Ten;
            GiaCPU = c.Gia;
        }
        public override float TinhGia()
        {
            float tong = 0;
            foreach (var item in dslk)
                tong += item.Gia;
            return tong;
        }
        public override string ToString()
        {
            string str = tenMayAnh;
            foreach (var item in dslk)
            {
                str += " " + item + ", ";
            }
            str += "Tong gia " + TinhGia()+"$";
            return str;
        }
    }
    class MayTinh:ThietBi
    {
        public List<LinhKien> dslk = new List<LinhKien>();
        private string tenMayTinh;

        public string TenMayTinh
        {
            get { return tenMayTinh; }
            set { tenMayTinh = value; }
        }
        public void Them(LinhKien x)
        {
            if (!dslk.Contains(x))
                dslk.Add(x);
        }
        public MayTinh() { }
        public MayTinh(string ten,RAM r,CPU c)
        {
            this.tenMayTinh = ten;
            Them(r);
            TenRAM = r.Ten;
            GiaRAM = r.Gia;
            Them(c);
            TenCPU = c.Ten;
            GiaRAM = c.Gia;
        }
        public override float TinhGia()
        {
            float tong = 0;
            foreach (var item in dslk)
            {
                tong += item.Gia;
            }
            return tong;
        }
        public override string ToString()
        {
            string str = tenMayTinh;
            foreach (var item in dslk)
            {
                str += " " + item + ", ";
            }
            str += "Tong gia " + TinhGia()+"$";
            return str;
        }
       
    }
}
