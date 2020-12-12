using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpKieu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Chuyển đổi ngầm định
             * Chuyển đổi tường minh
             * Sử dụng phương thức, lớp hỗ trợ sẵn
             * Người dùng tự định nghĩa
             */

            //#region Chuyển kiểu ngầm định

            //int k = 10;
            //long l = k; //Chuyển kiểu ngầm định vì kiểu long có miền giá trị lớn hơn kiểu int nên có thể chuyển
            //float f = 10.9f;
            //double d = f; //Tương tự
            //#endregion

            //#region Chuyển kiểu tường minh là chuyển kiểu dùng từ khóa rõ ràng, chỉ định, chứ không dùng phương thức, thường sử dụng chuyển đổi các kiểu dữ liệu tương tự nhau như số với số, ký tự với ký tự
            //cú pháp: kiểu dữ liệu = (kiểu dữ kiệu cần chuyển)a/c
            //int i = 300; //300 có mã nhị phân là 100101100
            //byte b = (byte)i;//do kiểu byte có giới hạn giá trị là 255 thôi nên không thể nhập i vô được, nên nó sẽ chuyển i thành mã nhị phân và lấy đúng giá trị 1byte = 8bit, nên xuất ra b = 44

            //int a = 5;
            //int c = 2;
            ////để chia a/c ra kết quả là 2.5 thì ta phải ép kiểu của nó thành kiểu float
            //float tt = (float)a / c;
            //#endregion

            
            //#region Chuyển kiểu lớp hỗ trợ sẵn
            ////Parse(): kiểu dữ kiệu cần chuyển.Parse(biến cần chuyển dữ liệu)
            //string s = "10";
            //int k = int.Parse(s);//Chuyển chuỗi s sang kiểu int và lưu giá trị vào biến k - kết quả = 10

            ////TryParse(): Kiểu dữ liệu cần chuyển.TryParse(biến cần chuyển, out Result)
            //int Result; //Biến chứa giá trị kết quả khi ép kiểu thành công
            //bool isSuccess;//Biến kiểm tra việc ép kiểu có thành công hay không
            //string Data1 = "10", Data2 = "Kteam";//Dữ liệu cần ép kiểu

            //isSuccess = int.TryParse(Data1, out Result);//thử ép kiểu Data1 thành int, nếu thành công thì  result sẽ trả về giá trị 
            //Console.Write(isSuccess == true ? "Success !" : "Failed !");//sử dụng toán tử 3 ngôi để in ra màn hình
            //Console.WriteLine("Result =" + Result);//in result ra màn hình
            //Console.ReadKey();
            //#endregion




        }
    }
}
