using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.Write(" Please Enter Exercise Number");
            String num = Console.ReadLine();
            int val = Convert.ToInt16(num);
            if (val == 1)
            {
                ex1Point1 ex1p1 = new ex1Point1();
                ex1p1.exercise1Point1();
            }
            else if (val == 2)
            {
                ex1Point2 ex1p2 = new ex1Point2();
                ex1p2.exercise1Point2();
            }
            else
            {
                Console.Write(" Oops No exercise found @ this number");
                 Console.ReadLine();
            }

        }

        
    }

    class ex1Point1
    {
        // a program to request name and print a greeting message
        public void exercise1Point1()
        {
            Console.Write(" Please Enter your name");
            String s = Console.ReadLine();
            Console.Write("Good Morning" + "  Mr "+ s);
            Console.ReadLine();
        }
    }

    class ex1Point2
    {
        // try this
        public void exercise1Point2()
        {
           Console.Write(" Please Enter two numbers");
          string num1= Console.ReadLine();
          string num2 = Console.ReadLine();
          int val1 = Convert.ToInt16(num1);
          int val2 = Convert.ToInt16(num2);
            int t_val1=val1;
            int t_val2=val2;

          int x = 0;
          while (val1 != val2)
          {
              if (val1 > val2)
              {
                  x = val1 - val2;
                  val1 = x;
              }
              else
              {
                  x = val2 - val1;
                  val2 = x;
              }
          }
          Console.WriteLine("-- "+x+" --");
          Console.WriteLine("-- " + ((t_val1*t_val2) / x) + " --");
          Console.ReadLine();
          
        }
    }
}
