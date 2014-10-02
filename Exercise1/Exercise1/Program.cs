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
            string yesOrNo;

            do
            {

                Console.Write("Please Enter Exercise Number");
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
                // continued on 1/10/2014
                else if(val==11){
                    ex1Point11 ex1p11 = new ex1Point11();
                    ex1p11.exercise1Point11();
                }
                else if (val == 12)
                {
                    ex1Point12 ex1p12 = new ex1Point12();
                    ex1p12.exercise1Point12();
                }
                else if (val == 13)
                {
                    ex1Point13 ex1p13 = new ex1Point13();
                    ex1p13.exercise1Point13();
                }
                else if (val == 14)
                {
                    ex1Point14 ex1p14 = new ex1Point14();
                    ex1p14.exercise1Point14();
                }
                else if (val == 15)
                {
                    ex1Point15 ex1p15 = new ex1Point15();
                    ex1p15.exercise1Point15();
                }
                else if (val == 16)
                {
                    ex1Point16 ex1p16 = new ex1Point16();
                    ex1p16.exercise1Point16();
                }
                else if (val == 17)
                {
                    ex1Point17 ex1p17 = new ex1Point17();
                    ex1p17.exercise1Point17();
                }

                else if (val == 18)
                {
                    ex1Point18 ex1p18 = new ex1Point18();
                    ex1p18.exercise1Point18();
                }
                else if (val == 19)
                {
                    ex1Point19 ex1p19 = new ex1Point19();
                    ex1p19.exercise1Point19();
                }

                else if (val == 20)
                {
                    ex1Point20 ex1p20 = new ex1Point20();
                    ex1p20.exercise1Point20();
                }
                else if (val == 27)
                {
                    ex1Point27 ex1p27 = new ex1Point27();
                    ex1p27.exercise1Point27();
                }
                else if (val == 35)
                {
                    ex1Point35 ex1p35 = new ex1Point35();
                    ex1p35.exercise1Point35();
                }
                else if (val == 36)
                {
                    ex1Point36 ex1p36 = new ex1Point36();
                    ex1p36.exercise1Point36();
                }
                else if (val == 37)
                {
                    ex1Point37 ex1p37 = new ex1Point37();
                    ex1p37.exercise1Point37();
                }

                else
                {
                    Console.Write(" Oops No exercise found @ this number");
                    Console.ReadLine();
                }
                
                
                
                
                // to continue the looping..
                Console.Write("Do you want to continue .y/n");
                yesOrNo=Console.ReadLine().ToString();
            }
            while (yesOrNo.Equals("y"));
            

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

    class ex1Point11
    {
        /*
        */
        public void exercise1Point11()
        {
          
            double Number = ISS.RV.LIB.ISSConsole.ReadDouble("Enter the distance travelled in kms");
            const double FixedCharge = 2.40;
            double TotalFare = FixedCharge+(Number*0.4);
            double RoundedTotalFare = Math.Round(TotalFare, 2);
            Console.WriteLine("Total Fare is {0:.#0} -- {0}", TotalFare);
        }
    }
    class ex1Point12
    {
        /*
        */
        public void exercise1Point12()
        {

            double Number = ISS.RV.LIB.ISSConsole.ReadDouble("Enter the distance travelled in kms");
            const double FixedCharge = 2.40;
            double TotalFare = FixedCharge + (Number * 0.4);
            double RoundedTotalFare = Math.Round(TotalFare, 2);
            double RoundedTotalFareCeil = Math.Ceiling(TotalFare*100)/10;
            double RoundedTotalFareFloor = Math.Floor(TotalFare*100)/10;
            Console.WriteLine("Total Fare is {0} - {1:.#0} ceil {2:.#0} floor{3:.#0}-", TotalFare, RoundedTotalFare, RoundedTotalFareCeil, RoundedTotalFareFloor);
        }
    }
    class ex1Point13
    {
        /*
        */
        public void exercise1Point13()
        {
            // done in prevoius exercise 1.12 itself..please do refer/.
            ex1Point12 obj = new ex1Point12();
            obj.exercise1Point12();
        }
    }

    class ex1Point14
    {
        /*
        */
        public void exercise1Point14()
        {
            double a = ISS.RV.LIB.ISSConsole.ReadDouble("Enter A value");
            double b = ISS.RV.LIB.ISSConsole.ReadDouble("Enter b value");
            double c = ISS.RV.LIB.ISSConsole.ReadDouble("Enter c value");
            double s= (a+b+c)/2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("Area of the triagle whose sides {0},{1},{2} is {3}", a, b, c, area);
        }
    }

    class ex1Point15
    {
        /*
        */
        public void exercise1Point15()
        {
        int a=ISS.RV.LIB.ISSConsole.ReadInt("Enter a three digit number");
        int numberEntered=a;
        if ((a>=100) && (a<=999))
        {
            int modulo = 0;
            int division = 0;
            int sumOfCubes = 0;
            const int size=4;
            int i=0;
            do
            {
                 modulo = a % 10;
                 division = a / 10;
                 sumOfCubes = sumOfCubes + (modulo * modulo*modulo);
                 i++;
                 a = division;
            } while (i<size);
            if (sumOfCubes == numberEntered)
            {
                Console.WriteLine(sumOfCubes.ToString() +"Is an Armstrong Number");
            }
            else
            {
                Console.WriteLine(numberEntered + "Is not Armstrong Number");
            }
        }

        }
    }


    class ex1Point16
    {
        /*
        */
        public void exercise1Point16()
        {
            String name = ISS.RV.LIB.ISSConsole.ReadString("Enter the name");
            char gender = ISS.RV.LIB.ISSConsole.ReadChar("Gender : M/F [M- Male, F-Female]");
            String[] salutationStrings = new String[2]{"Mr.","Mrs."};
            if (gender.Equals('M') || (gender.Equals('m')))
            {
                Console.WriteLine("Hello, Good Morning {0} {1}",salutationStrings[0],name);
            }
            else if (gender.Equals('F') || (gender.Equals('f')))
            {
                Console.WriteLine("Hello, Good Morning {0} {1}", salutationStrings[1],name);
            }
            else
            {
                Console.WriteLine("Oops invalid gender");
                return;
            }
        }
    }

    class ex1Point17
    {
        /*
        */
        public void exercise1Point17()
        {
            String name = ISS.RV.LIB.ISSConsole.ReadString("Enter the name");
            char gender = ISS.RV.LIB.ISSConsole.ReadChar("Gender : M/F [M- Male, F-Female]");
            int age = ISS.RV.LIB.ISSConsole.ReadInt("Enter the Age");
            String[] salutationStrings = new String[2] { "Mr.", "Mrs." };
            String[] uncleOrAunty = new string[2] { "Uncle","Aunty"};
            if (age >= 40)
            {
                if (gender.Equals('M') || (gender.Equals('m')))
                {
                    Console.WriteLine("Hello, Good Morning {0} {1}", uncleOrAunty[0] ,name);
                }
                else if (gender.Equals('F') || (gender.Equals('f')))
                {
                    Console.WriteLine("Hello, Good Morning {0} {1}", uncleOrAunty[1], name);
                }
            }
            else
            {
                if (gender.Equals('M') || (gender.Equals('m')))
                {
                    Console.WriteLine("Hello, Good Morning {0} {1}", salutationStrings[0], name);
                }
                else if (gender.Equals('F') || (gender.Equals('f')))
                {
                    Console.WriteLine("Hello, Good Morning {0} {1}", salutationStrings[1], name);
                }
            }
        }
    }

    class ex1Point18
    {
        /*
        */
        public void exercise1Point18()
        {

            int mark = ISS.RV.LIB.ISSConsole.ReadInt("Enter the Marks");

            if (mark >= 80 && mark <= 100)
            {
                Console.WriteLine("Your Grade is{0}","A");
            }
            else if(mark >=60 && mark <=79){
                Console.WriteLine("Your Grade is{0}", "B");
            }
            else if (mark > 40 && mark <= 59)
            {
                Console.WriteLine("Your Grade is{0}", "C");
            }
            else if (mark >= 0 && mark <= 40)
            {
                Console.WriteLine("Your Grade is{0}", "D");
            }
            else if (mark < 0 || mark > 100)
            {
                Console.WriteLine("**Error**");
            }
        }
    }

    class ex1Point19
    {
        /*
        */
        public void exercise1Point19()
        {

            double DistanceTravelled = ISS.RV.LIB.ISSConsole.ReadDouble("Enter the Distance travelled");
            double roundedValue = Math.Ceiling(DistanceTravelled*10) / 10;
           const double minimumFare=2.40;
           const double MinimumFareFreeDist = 0.5;
           const double NextMinimumFareDist = 8.5;

           const double next8_5KmsFarePer100Meters = 0.04;
           const double above8_5KmsFarePer100Meters = 0.05;


            if(roundedValue <= MinimumFareFreeDist){
                double fare = minimumFare;
             Console.WriteLine("The fare is {0:.#0}",fare);
            }
           else if (roundedValue > MinimumFareFreeDist && roundedValue <= NextMinimumFareDist)
           {
               double fare = minimumFare +
                   (((roundedValue - MinimumFareFreeDist) * 10) * next8_5KmsFarePer100Meters);
          Console.WriteLine("The fare is {0:.#0}",fare);
           }
            else if (roundedValue > NextMinimumFareDist)
            {
                double fare = minimumFare + 
                    (((NextMinimumFareDist) * 10) * next8_5KmsFarePer100Meters) +
                    (above8_5KmsFarePer100Meters * ((roundedValue-(MinimumFareFreeDist + NextMinimumFareDist))*10));
                Console.WriteLine("The fare is {0:.#0}", fare);
            }

               //double fare = minimumFare + (next8_5KmsFarePer100Meters * (8.5 * 10)) +
               //   (above8_5KmsFarePer100Meters * ((roundedValue * 10) - ((MinimumFareFreeDist + NextMinimumFareDist) * 10)));
           
         
          
        }
    }


    class ex1Point20
    {
        /*
        */
        public void exercise1Point20()
        {
           
        }
    }


    class sorting
    {
        void SelectionSort()
        {
            //int i = ISS.RV.LIB.ISSConsole.ReadInt("Hai please enter a number");
            //int j = Convert.ToInt16(Console.ReadLine());
            //int[] gValues = new int[4] {2,3,4,6};

            // selection sorting algorithm
            int[] a = new int[10] { 10, 5, 8, 3, 7, 5, 4, 3, 67, 1 };
            int[] sortedArray = new int[10];

            for (int f = 0; f < a.Length; f++)
            {

                for (int ii = f;// assigning f to ii, in order to move the pointer one step from left to right
                    ii < a.Length; ii++)
                {
                    // checking a[f] which the least most [item[0]] in our array. for the iteration. and the posititon is being moved as the loop goes on
                    if (a[f] > a[ii])
                    {
                        int temp = a[f];
                        a[f] = a[ii];
                        a[ii] = temp;
                    }

                }
                Console.Write(a[f].ToString() + " ");
            }
              
        }
    }


    class ex1Point35
    {
        /* Program to read a phrase and to count the number of vowels in it
         */
        static int global = 0;
        static int aVowel = 0;
        static int eVowel = 0;
        static int iVowel = 0;
        static int oVowel = 0;
        static int uVowel = 0;
           
        public void exercise1Point35()
        {
           
           Console.WriteLine("Enter a phrase");
           String s =Console.ReadLine();
           s = s.Trim();
           Console.WriteLine(s);
           String[] subString = s.Split(' ');
         
               for (int i = 0; i < subString.Length; i++)
               {
                 Console.WriteLine("##-"+subString[i]);
                 char[] charValues =subString[i].ToCharArray();
                 checkForVowels(charValues);
               }
               printAllVowelCounts();

           Console.Read();
        }

        void printAllVowelCounts()
        {
            Console.WriteLine("##-aVowel-##" + aVowel);
            Console.WriteLine("##-eVowel-##" + eVowel);
            Console.WriteLine("##-iVowel-##" + iVowel);
            Console.WriteLine("##-oVowel-##" + oVowel);
            Console.WriteLine("##-uVowel-##" + uVowel);
        }

        public static void checkForVowels(char[] charValues)
        {
            for (int j = 0; j < charValues.Length; j++)
            {

                if (charValues[j] == 'a')
                {
                    aVowel++;
                }
                else if (charValues[j] == 'e')
                {
                    eVowel++;
                }
                else if (charValues[j] == 'i')
                {
                    iVowel++;
                }
                else if (charValues[j] == 'o')
                {
                    oVowel++;
                }
                else if (charValues[j] == 'u')
                {
                    uVowel++;
                }
                else
                {

                }

            }
        }
    }


     class ex1Point36
    {
        /* Program for palindrome
         */
        public void exercise1Point36()
        {
            Console.WriteLine("Enter a phrase");
            String s = Console.ReadLine();

            int length = s.Length;
            int sublenght= length / 2;
            int Count=0; 
           //Console.Write("" + s.Length + "sub" + sublenght);
           for (int i = 0; i < sublenght; i++)
            {
                if(s[i]==s[(s.Length-1)-i])
                {
                    Count++;
                }
            } 
             
           if  (sublenght == Count)
           { 
                Console.WriteLine("palindrome");
           } 
           else
           { 
               Console.WriteLine(" not palindrome");
           }

          
            
                Console.ReadLine();
        }
    }

     class ex1Point37
     {
         /* Program to read a phrase and change it to Title case
          */
         StringBuilder builder = new StringBuilder();
         public void exercise1Point37()
         {
             Console.WriteLine("Enter a phrase");
             String s = Console.ReadLine();
            
             int result = s.CompareTo("hai");
             Console.WriteLine(result);

             s = s.Trim();
            // Console.WriteLine(s);

             String[] subString = s.Split(' ');

             for (int i = 0; i < subString.Length; i++)
             {
                 
                 char[] charValues = subString[i].ToCharArray();
                 changeFirstLetter(charValues);
             }
             Console.WriteLine(builder);

             Console.Read();
         }
         void changeFirstLetter(char[] charValues)
         {
               string s = new string(charValues);
            // Console.WriteLine("f"+s);

             charValues[0] = Char.ToUpper(charValues[0]);
             string newS = new string(charValues);
             //Console.WriteLine(newS);

             builder.Append(newS).Append(" ");
           
            

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
     


