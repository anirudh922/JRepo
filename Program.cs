using System;
using System.Collections.Generic;

namespace Day_3
{
    class GenericsEg 
    {

        static void ListEg()
        {
            List<string> fruits = new List<string>();

            fruits.Add("Mango");
            fruits.Add("Apple");
            fruits.Add("Orange");

            fruits.Insert(1, "Pineapple");
            fruits.RemoveAt(3);

            //fruits.Add(10); type safe

            List<string> Vegetables = new List<string>();

            Vegetables.Add("Carrot");
            Vegetables.Add("Beetroot");
            Vegetables.AddRange(fruits);

            foreach (var list in fruits)
            {
                Console.WriteLine("Fruits:{0}", list);
            }

            Console.WriteLine("Vegetables");

            foreach (var list in Vegetables)
            {
                Console.WriteLine("Vegetables:{0}", list);
            }
        }

        //key value pair

        static void DictionaryEg()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Java");
            dt.Add(2, "Networks");
            dt.Add(3, "AI");

            foreach (KeyValuePair<int,string> kp in dt)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
        }
        static void StackEg()
        {
            Stack<int> st = new Stack<int>();
            st.Push(40);
            st.Push(30);
            st.Push(10);
            st.Push(50);

            foreach(var stack in st)
            {
                Console.WriteLine(stack);

            }
            st.Pop();

            Console.WriteLine("After 1 pop");

            foreach (var  stack in st)
            {
                Console.WriteLine(stack);
            }

            Console.WriteLine("Peek:{0}", st.Peek());
        }

        //SORTED LIST, QUEUE

        static void Main()
        {
            ListEg();
            Console.WriteLine("Personal details");
            Console.WriteLine("--------");


            // look from ss

        }



    }
}
