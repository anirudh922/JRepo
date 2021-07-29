using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
        //Generic class
        class Sample<T>
        {
            T Name;
            T City;

            internal Sample (T name, T City)
            {
                this.Name = name;
                this.City = City;
            }

            internal void Add(int x,int y)
            {
                Console.WriteLine("Addition is :{0}", (x + y));
            }


            /// code remaining
            ///Generic  Method
            ///<T>
            
            internal void SWap<T>(T x, T y)
            {
                T temp;
                temp = x;
                x = y;
                y = temp;
                Console.WriteLine("X is {0} || Y is {1}", x, y);

            }

            /* Generic Constraint
             * where T: Struct //value type
             * where t: class //refrence type
             * where t:new  //default constraint
             * where t: <interface name>
             */
            }
            class Student<T> where T : struct
            {

            }

            class GenericMethods
            {
                static void Main()
                {
                    Sample<string> sample = new Sample<string>("Anu", "Chennai");
                    sample.SWap<int>(6, 8);
                    sample.SWap<string>("Good", "Morning");

                    //struc constraint
                    //error because student class will accept only struct value(Value type)
                    //Student <string> student = new Student <string>();

                    Student<int> student1 = new Student<int>();

                }
            }
}
