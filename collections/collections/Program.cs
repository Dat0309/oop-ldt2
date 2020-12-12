using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collections
{
    

    class Program
    {

        static void Main(string[] args)
        {
           
            //#region khởi tạo arraylist
            //arraylist myarr = new arraylist(); //khởi tạo 1 array list rỗng
            //arraylist myarr2 = new arraylist(5);// khởi tạo 1 array list và chỉ định capacity ban đầu là 5
            ///*
            // * khởi tạo 1 arrlist có khích thước bằng với myarr2
            // * sao chép toàn bộ phần tư trong myarr2 vào myarr 3
            // */
            //arraylist myarr3 = new arraylist(myarr2);
            //#endregion

            #region Sắp xếp một danh sách các object trong array list

            ArrayList arrPerson = new ArrayList();

            //Thêm 3 person vào danh sách
            arrPerson.Add(new Person("Dinh Trong Dat",18));
            arrPerson.Add(new Person("Mai Ngoc Tri", 19));
            arrPerson.Add(new Person("Dao Xuan Hai", 20));
            //in thử danh sách Person ban đầu ra
            Console.WriteLine("Danh sach ban dau la: ");
            foreach (Person item in arrPerson)
            {
                Console.WriteLine(item.ToString());
            }   

            //Thực hiện sắp xếp danh sách Person theo tiêu chí đã định nghĩa
            //trong phương thức Compare của lớp SortPerson (tuổi tăng dần)

            Console.ReadLine();
            #endregion
        }
    }
   

}
