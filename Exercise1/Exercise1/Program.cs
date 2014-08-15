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
           
                   Console.Write("Please Enter Exercise Number   ");
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
                        else if (val == 3)
                        {
                            ex1Point3 ex1p3 = new ex1Point3();
                            ex1p3.exercise1Point3();
                        }
                        else if (val == 4)
                        {
                            ex1Point4 ex1p4 = new ex1Point4();
                            ex1p4.exercise1Point4();
                        }
                        else if (val == 5)
                        {
                            ex1Point5 ex1p5 = new ex1Point5();
                            ex1p5.exercise1Point5();
                        }
                        else if (val == 6)
                        {
                            ex1Point6 ex1p6 = new ex1Point6();
                            ex1p6.exercise1Point6();
                        }
                        else if (val == 7)
                        {
                            ex1Point7 ex1p7 = new ex1Point7();
                            ex1p7.exercise1Point7();
                        }
                        else if (val == 8)
                        {
                            ex1Point8 ex1p8 = new ex1Point8();
                            ex1p8.exercise1Point8();
                        }
                        else if (val == 9)
                        {
                            ex1Point9 ex1p9 = new ex1Point9();
                            ex1p9.exercise1Point9();
                        }
                        else if (val == 10)
                        {
                            ex1Point10 ex1p10 = new ex1Point10();
                            ex1p10.exercise1Point10();
                        }
                        else if (val == 27)
                        {
                            ex1Point27 ex1p27 = new ex1Point27();
                            ex1p27.exercise1Point27();
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

    class ex1Point3
    {
        // a program to find square of integer number
        public void exercise1Point3()
        {
            Console.Write(" Please Enter an Integer Number");
            String s = Console.ReadLine();
            int number = Convert.ToInt32(s);
            int squaredNumber = number * number;
            
            Console.Write("Square of the number *{0}* is = {1}",number,squaredNumber);
            Console.ReadLine();
        }
    }


    class ex1Point4
    {
        // a program to find square of double precision number
        public void exercise1Point4()
        {
            Console.Write(" Please Enter a Double Precision Number");
            String s = Console.ReadLine();
            double number = Convert.ToDouble(s);
            double squaredNumber = number * number;

            Console.Write("Square of the double precision number *{0}* is = {1}", number, squaredNumber);
            Console.ReadLine();
        }
    }

    class ex1Point5
    {
        // a program to find SquareRoot
        public void exercise1Point5()
        {
            Console.Write(" Please Enter a Double Precision Number");
            String s = Console.ReadLine();
            double number = Convert.ToDouble(s);
            double sqrtOfTheNumber = Math.Sqrt(number);

            Console.Write("Square Root of the double precision number *{0}* is = {1}", number, sqrtOfTheNumber);
            Console.ReadLine();
        }
    }


    class ex1Point6
    {
        // A program to find SquareRoot of a double Precision Number and rounded to 3 decimal places
        public void exercise1Point6()
        {
            Console.Write(" Please Enter a Double Precision Number");
            String s = Console.ReadLine();
            double number = Convert.ToDouble(s);
            double sqrtOfTheNumber = Math.Sqrt(number);
            double sqrtOfTheNumberRounded = Math.Round(sqrtOfTheNumber,3);
            Console.Write("Square Root of the double precision number rounded to 3 decimal places *{0}* is = {1}", number, sqrtOfTheNumberRounded);
           //Console.Write("Square Root of the double precision number rounded to 3 decimal places *{0}* is = {1:.###}", number, sqrtOfTheNumber);
            Console.ReadLine();
        }
    }

    class ex1Point7
    {
        /* ABC company pays its employee salary plus benifits.
        Benefits are calculated as a percentage of salary,
         
         */
        public void exercise1Point7()
        {
            Console.Write(" Please Enter your salary $  ");
            String s = Console.ReadLine();
            double empSalary = Convert.ToDouble(s);
            double housingAllowance = ((10.0 * empSalary) / 100);
            double transaportAllowance = ((3.0 * empSalary) / 100);
            Console.WriteLine("Employe salary Details ####   $"+empSalary);
            //Console.WriteLine("Employe housingAllowance Details ####    "+housingAllowance);
            Console.WriteLine("Employe housingAllowance Details ####    $" + Math.Round(housingAllowance,2));
            //Console.WriteLine("Employe transaportAllowance Details ####     " + transaportAllowance);
            Console.WriteLine("Employe transaportAllowance Details ####     $" + Math.Round(transaportAllowance,2));
           
            Console.ReadLine();
        }
    }

    class ex1Point8
    {
        /* Program to convert temperature in centigrade to fahrenheit
         */
        public void exercise1Point8()
        {
            Console.Write(" Please Enter Temperature in centigrade");
            String s = Console.ReadLine();
            double c = Convert.ToDouble(s);
            double f = (1.8 * c) + 32;
            Console.Write("Temperature in fahrenheit is "+f);
            Console.ReadLine();
        }
    }

    class ex1Point9
    {
        /* Program to calculate  5x2 - 4x + 3 from x
         */
        public void exercise1Point9()
        {
            Console.Write(" Please Enter the value of X");
            String s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double y = 5*(x * x) - (4 * x) + 3;
            Console.Write("The output of 5x2 - 4x + 3    " + y);
            Console.ReadLine();
        }
        
        
       
    }


    class ex1Point10
    {
        /* Program to read x,y coordinates of two points  , and to compute the distance between the two points
         */
        public void exercise1Point10()
        {
         Console.Write(" Please Enter first co-ordinates of (x1,y1)");
         String x = Console.ReadLine();
         String y = Console.ReadLine();
         double x1 = Convert.ToDouble(x);
         double y1 = Convert.ToDouble(y);
         
         Console.Write(" Please Enter second co-ordinates of (x2,y2)");
          x = Console.ReadLine();
          y = Console.ReadLine();
         double x2 = Convert.ToDouble(x);
         double y2 = Convert.ToDouble(y);

         double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
         Console.Write(distance);
         Console.ReadLine();
        }
    }


     class ex1Point27
    {
        /* Program to read x,y coordinates of two points  , and to compute the distance between the two points
         */
       public void exercise1Point27()
         {
             getYvalues();
           Console.Read();
         }
            static void getYvalues()
                {
                    double[] yValue = new double[20];
                    int j = 0;
                    for (int i = -10; i < 10; i++)
                    {
               
                        yValue[j] = (20*(5 * (i * i) - (4 * i) + 3))/444;
                       // Console.WriteLine(yValue[j]);
                        j++;
                    }

                    for (int i = 0; i < yValue.Length; i++)
                    {
                        generatespace(yValue[i]);
               
                    }
            
                }

                public static void generatespace(double p)
                {
                    for (int j = 0; j < p; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                    Console.WriteLine("");
                }
         }
    }
     


