using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    public class AgeNotValid : ApplicationException
    {
        public AgeNotValid(string Message) : base(Message)
        {

        }
    }
    class Exception_handling
    {
        static void Main()
        {
            try
            {
                int num = 10, div = 5;
                if (div==0)
                {
                    throw new DivideByZeroException();
                }
                else 
                {
                    num=num/div;
                }

                Console.WriteLine(num);

                int[] arr = new int[] { 20, 30, 40 };
                Console.WriteLine(arr[6]);
                Console.WriteLine("Enter the age");
                int Age = Convert.ToInt32(Console.ReadLine());
                if (Age<18)
                {
                    throw new AgeNotValid("TO VOTE AGE SHOULD BE GREATER THAN 18");
                }
                else
                {
                    Console.WriteLine("Eligile to vote");
                }
            }

            //error child than parent
            /*catch (Exception e)
            {
                Console.WriteLine(e);
            }*/

            catch (DivideByZeroException e)
            {
                //Console .writeline(e)
                //console.writeline(e.message)
                Console.WriteLine("Please enter valid number");

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("How are you feeling !");
            }
        }
    }
}
