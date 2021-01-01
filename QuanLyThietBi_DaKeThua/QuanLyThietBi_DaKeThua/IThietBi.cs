using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi_DaKeThua
{
    interface IThietBi
    {
        float TinhGia();
        float GiaCPU { get; set; }
        float GiaRAM { get; set; }
        string TenCPU { get; set; }
        string TenRAM { get; set; }
    }
    class MayAnh:IThietBi
    {
        public List<ILinhKien> dslk = new List<ILinhKien>();
        public string tenMA;
        public float giaRAM, giaCPU;

        public float GiaCPU
        {
            get { return giaCPU; }
            set { giaCPU = value; }
        }

        public float GiaRAM
        {
            get { return giaRAM; }
            set { giaRAM = value; }
        }
        public string tenCPU, tenRAM;

        public string TenRAM
        {
            get { return tenRAM; }
            set { tenRAM = value; }
        }

        public string TenCPU
        {
            get { return tenCPU; }
            set { tenCPU = value; }
        }
        public void Them(ILinhKien x)
        {
            if (!dslk.Contains(x))
                dslk.Add(x);
        }
        public MayAnh() { }
        public MayAnh(string ten,RAM r,CPU c)
        {
            this.tenMA = ten;
            Them(r);
            TenRAM=r.Ten;
            GiaRAM=r.Gia;
            Them(c);
            TenCPU = c.Ten;
            GiaCPU = c.Gia;
        }
        public float TinhGia()
        {
            float tong = 0;
            foreach (var item in dslk)
                tong += item.Gia;
            return tong;
        }
        public override string ToString()
        {
            string str = tenMA;
            foreach (var item in dslk)
            {
                str += " " + item + ", ";
            }
            str += "Tong gia " + TinhGia() + "$";
            return str;
        }
    }
    class MayTinh:IThietBi
    {
        public List<ILinhKien> dslk = new List<ILinhKien>();
        public string tenMT;
        public float giaRAM, giaCPU;

        public float GiaCPU
        {
            get { return giaCPU; }
            set { giaCPU = value; }
        }

        public float GiaRAM
        {
            get { return giaRAM; }
            set { giaRAM = value; }
        }
        public string tenCPU, tenRAM;

        public string TenRAM
        {
            get { return tenRAM; }
            set { tenRAM = value; }
        }

        public string TenCPU
        {
            get { return tenCPU; }
            set { tenCPU = value; }
        }
        public void Them(ILinhKien x)
        {
            if (!dslk.Contains(x))
                dslk.Add(x);
        }
        public MayTinh() { }
        public MayTinh(string ten,RAM r,CPU c)
        {
            this.tenMT = ten;
            Them(r);
            TenRAM = r.Ten;
            GiaRAM = r.Gia;
            Them(c);
            TenCPU = c.Ten;
            GiaCPU = c.Gia;
        }
        public float TinhGia()
        {
            float tong = 0;
            foreach (var item in dslk)
                tong += item.Gia;
            return tong;
        }
        public override string ToString()
        {
            string str = tenMT;
            foreach (var item in dslk)
            {
                str += " " + item + ", ";
            }
            str += "Tong gia " + TinhGia() + "$";
            return str;
        }
    }
}
