using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{



    //class Animal
    //{
    //    public double Weight;
    //    public double Height;

    //    public void info()
    //    {
    //        /*
    //         * các phương thức bên trong lớp có thể gọi đến các thành phần khác ( bao gồm thuộc tính và phương thức ) trong lớp đó
    //         */
    //        Console.WriteLine(" Height: " + Height + " Weight: " + Weight);
    //    }
    //}

    class SinhVien
    {
        private string MASV;
        private string HoTen;
        private double DiemToan;
        private double DiemVan;
        private double diemLy;

        public double DiemLy
        {
            get { return diemLy; }
            set
            {
                if (value <= 10 || value >=0)
                {
                    diemLy = value;
                }
            }
        }

        //Phương thức truy vấn giá trị của thuộc tính MASV, vì thế phương thức sẽ trả về string ( trùng với kiểu dữ liệu của masv

        public string getMASV()
        {
            return MASV;
        }

        //Phương thức cập nhật giá trị cho thuộc tính DiemToan vì thế phương thức có 1 tham số truyền vào kiểu double trùng với kiểu của thuộc tính DiemToan
        public void setDiiemToan(int diemtoan)
        {
            DiemToan = diemtoan;
        }

        public void setDiemToan(int diemtoan)
        {
            DiemToan = diemtoan;
        }

        public void InThongTinDiemTB()
        {
            double DTB = (DiemToan + DiemVan) / 2;

            Console.WriteLine("SinhVien " + HoTen + "co diem TB la: " + DTB);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Animal Dog = new Animal();
            //Dog.Height = 2;
            //Dog.Weight = 50;

            //Animal Cat = new Animal();
            //Cat.Height = 1;
            //Cat.Weight = 30;

            //Dog.info();
            //Cat.info();


            //Bài 3. Các phạm vi truy cập
            SinhVien SV1 = new SinhVien();
            SV1.DiemLy = 8;
            Console.WriteLine("Diem ly: " + SV1.DiemLy);
            
            Console.ReadLine();
        }
    }
}
