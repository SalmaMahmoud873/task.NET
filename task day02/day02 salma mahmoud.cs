using System;
using System.Runtime.InteropServices;

namespace ConsoleApp4
{
    class person
    {
        public string Name;
        public int Age;
         public person(string name, int age)
        {
            Name = name;
            Age = age;
        }
            
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 1
            // declare two integr variables
            // int x = 10;
            // int y = 20;
            /*
             calculate the sum of x amd y,
            then store the result in variable sum
            */
            // int sum = x + y; // 20 + 10 = 30
            //display the sum of x and y on console
            // Console.WriteLine(sum); 
            #endregion
            #region problem 2 
            // int x = "10";
            // x is integar use it without " "
            //int x = 10;
            // y not declared 
            // int y = 10;
            // Console.WriteLine(x + y);
            #endregion
            #region problem 3
            //string fullName = "Salma Mahmoud";
            //int age = 20;
            //double monthlysalary = 15000;
            //bool isStudent = true; 
            #endregion
            #region problem 4
            //person p1 = new person("salma", 20);
            //person p2 = p1;
            //p2.Name = "Ahmed";
            //p2.Age = 22;
            //Console.WriteLine(p1.Name);
            //Console.WriteLine(p1.Age);

            //Console.WriteLine(p2.Name);
            //Console.WriteLine(p2.Age); 
            #endregion
            #region problem 5
            //int x = 15;
            //int y = 4;

            //int sum = x + y;
            //int difference = x - y;
            //int product = x * y;
            //double division = x / y;
            //int remainder = x % y;

            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Difference: " + difference);
            //Console.WriteLine("Product: " + product);
            //Console.WriteLine("Division: " + division);
            //Console.WriteLine("Remainder: " + remainder); 
            #endregion
            #region problem 6
            //int num = 20;
            //if (num > 10 && num % 2 == 0)
            //{
            //    Console.WriteLine("the number is greater than 10 and even");
            //}
            //else
            //{
            //    Console.WriteLine("the conditions not met");
            //}  
            #endregion
            #region problem 7
            //double input = double.Parse(Console.ReadLine());
            //int num = 10;
            //double implicitResult = num;

            //Console.WriteLine("implicit casting: " + implicitResult);

            //int explicitResult = (int)input;
            //Console.WriteLine("Explicit casting: " + explicitResult); 
            #endregion
            #region problem 8
            //Console.Write("enter your age: ");
            //string agein = Console.ReadLine();

            //int age = int.Parse(agein);

            //if (age > 0)
            //{
            //    Console.WriteLine("valid age");
            //}
            //else
            //{
            //    Console.WriteLine("invalid age");
            //} 
            #endregion
            #region Problem 9

            //int x = 5;
            //int postfix = x++;

            //Console.WriteLine("Postfix result: " + postfix);
            //Console.WriteLine("x after postfix: " + x);

            //x = 5;
            //int prefix = ++x;

            //Console.WriteLine("Prefix result: " + prefix);
            //Console.WriteLine("x after prefix: " + x);

            #endregion
        }
    }
}
