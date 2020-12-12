using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_truc_lenh_co_ban
{
    class Program
    {
        static void Main(string[] args)
        {
           // Các hàm nhập xuất
            //Console.Write("Dinh Trong Dat"); // in ra màn hình dòng chữ Dinh Trong Dat
            //Console.Write(10);//In ra màn hình số 10
            //Console.Write(10.9f);//In ra màn hình số 10.9, f là biểu thựi cho dữ liệu kiểu float
            //Console.Write(true);//in ra màn hình chữ true của kiểu dữ liệu bool

            //Console.WriteLine("Dat");// có xuống dòng
            //Console.Write("Trong Dat \n");// dùng \n như c++ để xuống dòng
            //Console.Write(Environment.NewLine); //Sử dụng lệnh xuống dòng
            //Console.ReadLine();// Dừng màn hình lại để mình đọc, ẩn dòng chữ Press anykey to continues

            //int a = 5; //Khai báo biến a kiểu nguyên có giá trị là 5
            //Console.Write(" a = " + a);
            //Console.ReadKey();

            // Console.WriteLine(Console.Read());//Đọc một ký tự từ bàn phím và trả về ký tự vừa đọc, rồi chuyển sang dạng mã ASCII, nhưng chỉ nhận 1 ký tự đầu tiên
            // Console.WriteLine(Console.ReadLine());// Đọc cho đến khi nhấn enter rồi dừng

            Console.WriteLine("Trong Dat");

            Console.ReadKey(); //Không truyền tham số vào thì mặc định là false
            Console.ReadKey(false); //Hiển thị phím ấn lên màn hình
            Console.ReadKey(true);//Không hiển thị phím ấn lên màn hình
        }

       
    }
}
