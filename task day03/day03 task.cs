using System;
using System.Text;

namespace Day03_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 1
            //Console.WriteLine("Enter a number: ");
            //string S = Console.ReadLine();

            //try
            //{
            //    int X = int.Parse(S);
            //    Console.WriteLine(X);

            //    int Y = Convert.ToInt32(S);
            //    Console.WriteLine(Y);

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid Format");
            //} 
            #endregion

            #region problem 2
            //Console.WriteLine("Enter a number: ");
            //string S = Console.ReadLine();

            // bool flag = int.TryParse(S, out int X);

            //if(flag)
            //    Console.WriteLine(X);
            //else
            //    Console.WriteLine("Error"); 
            #endregion

            #region problem 3
            //object O;

            //O = 10;
            //Console.WriteLine(O.GetHashCode());

            //O = "Ali";
            //Console.WriteLine(O.GetHashCode());

            //O = 10.5;
            //Console.WriteLine(O.GetHashCode()); 
            #endregion

            #region problem 4
            //object obj = "Ali";

            //object obj2 = obj;
            //obj = "Ahmed";
            //Console.WriteLine(obj);
            //Console.WriteLine(obj2); 
            #endregion

            #region problem 5
            //string S = "Hello";
            //Console.WriteLine(S.GetHashCode());

            //S += " Hi Willy";
            //Console.WriteLine(S);
            //Console.WriteLine(S.GetHashCode()); 
            #endregion

            #region problem 6
            //StringBuilder sb = new StringBuilder("Hi Willy");

            //Console.WriteLine("HashCode before: " + sb.GetHashCode());

            //sb.Append(" Hello!");
            //Console.WriteLine("HashCode after: " + sb.GetHashCode());
            //Console.WriteLine("String: "+sb ); 
            #endregion

            #region problem 7
            //Console.Write("Enter first number: ");
            //int input1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //int input2 = int.Parse(Console.ReadLine());


            //Console.WriteLine("Sum is " + (input1 + input2));


            //Console.WriteLine(string.Format("Sum is {0}", input1 + input2));


            //Console.WriteLine($"Sum is {input1 + input2}"); 
            #endregion

            #region problem 8
            //StringBuilder sb = new StringBuilder("Hello World");

            //sb.Append("!");

            //sb.Replace("World", "Willy");

            //sb.Insert(6, "Dear ");

            //sb.Remove(6, 5);

            //Console.WriteLine(sb); 
            #endregion
        }
    }
}
