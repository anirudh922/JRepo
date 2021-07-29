using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }

        internal Student(int Rollno, string Name, string City, String Gender)
        {
            this.Rollno = Rollno;
            this.Name = Name;
            this.City = City;
            this.Gender = Gender;

        }
        class Program
        {
            static void Main(string[] args)
            {
                string[] book = { "English", "Tamil", "Maths", "Science" };
                //LINQ : QUERY SYNTAX
                //DISPLAY ALL BOOKS
                var result = from b in book
                             select b;
                foreach (var bname in result)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine("Displaythe book name that contains 'a'");
                    //display the book name that contains 'a'
                    //Query syntax

                    var r = from bookname in book
                            where bookname.Contains('a')
                            select bookname;


                    
                    foreach (var ename in r)
                    {
                        Console.WriteLine(ename);
                    }

                    int[] Marks = { 90, 78, 67, 99, 100 };
                    Console.WriteLine("Minimum Marks:{0}", Marks.Min());
                    Console.WriteLine("Maximum Marks:{0}", Marks.Max());

                    //marks btw 70 to 100

                    var r1 = from m in Marks
                             where m > 70 && m <= 100
                             select m;

                    foreach(var marks in r1)
                    {
                        Console.WriteLine(marks);
                    }

                    //method syntax

                    var m2 = Marks.Where(mark => mark <=100 && mark >70);
                    var r2 = (from m in Marks
                              where m > 70 && m <= 100
                              select m).Count();

                    Console.WriteLine("No of marks btw 70 and 100 :{0}", r2);

                    List<Student> stu = new List<Student>()
                    {
                        new Student(1001,"Janaka","Trichy","Female"),
                        new Student(1002,"Ravi","Chennai","male"),
                        new Student(1003,"balu","Madurai","male"),
                        new Student(1004,"ABI","Salem","Female")
                    };

                    var stucity = from s in stu
                                  where s.City.Equals("Chennai")
                    select new { s.Name, s.City };

                    Console.WriteLine("----------------");

                    Console.WriteLine("Display name and city where city is chennai");
                    foreach (var st in stucity)
                    {
                        Console.WriteLine(st.Name + " " + st.City);

                    }

                    Console.WriteLine("-------------");

                    Console.WriteLine("/Order the student info based on gender");

                    //order by
                    //order the student info based on gender
                    var stugender = from s in stu
                                    orderby s.Gender, s.Name
                                    select s;
                    foreach (var st in stugender)
                    {
                        Console.WriteLine(st.Name + " " + st.City + " " + st.Gender);
                    }
                    Console.WriteLine("--------------------");

                    Console.WriteLine("//No of Males and Females");
                    //Group by
                    //NO of males and females

                    var stumf = from s in stu
                                group s by s.Gender;
                    foreach (var s in stumf)
                    {
                        Console.WriteLine(s.Key + " " + s.Count());
                    }
                }

            }
        }
    }
}
