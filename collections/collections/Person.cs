using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
   
        public class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }


            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            // Tạo 1 constucter có tham số để tiện cho việc khởi tạo nhanh đối tượng Person với các giá trị cho sẵn
            public Person(string Name,int Age)
            {
                this.Name = Name;
                this.Age = Age;
            }
            public override string ToString()
            {
                return "Name : " + name + " | Age : " + age;
            }
        }
        
}
