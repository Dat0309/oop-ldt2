using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThietBi
{
    abstract class LinhKien
    {
        private float gia;

        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
    }
    class CPU:LinhKien
    {
        public CPU() { }
        public CPU(float g,string t)
        {
            Gia = g;
            Ten = t;
        }
        public override string ToString()
        {
            return string.Format("CPU: {0},".PadRight(10)+ "gia: {1}$".PadLeft(10), Ten, Gia);
        }
    }
    class RAM:LinhKien
    {
        public RAM() { }
        public RAM(float g,string t)
        {
            Gia = g;
            Ten = t;
        }
        public override string ToString()
        {
            return string.Format("RAM: {0},".PadRight(10)+" gia: {1}$", Ten, Gia);
        }
    }
}
