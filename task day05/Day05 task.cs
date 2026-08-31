using System;

namespace day05_task
{
     class Program
    {
        static void Main(string[] args)
        {

            #region part 01

            #region problem 1
            //try
            //{
            //    Console.Write("Enter first integer: ");
            //    int n1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter second integer: ");
            //    int n2 = int.Parse(Console.ReadLine());

            //    int result = n1 / n2;

            //    Console.WriteLine("Result = " + result);
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("can't divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //} 
            #endregion

            #region problem 2
            //int X, Y, Z;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Enter first Number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);

            //do
            //{
            //    Console.WriteLine("Enter Second Number : ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

            //Z = X / Y;

            //Console.WriteLine("Result = "+Z); 
            #endregion

            #region problem 3

            //int? num = null;

            //int result = num ?? 10;
            //Console.WriteLine("Result = "+result);

            //if(num.HasValue)
            //{
            //    Console.WriteLine("Number = " + num.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Number has no value");
            //} 
            #endregion

            #region problem 4
            //int[] nums = new int[5];
            //try
            //{
            //    Console.WriteLine(nums[5]);
            //}
            //catch(IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index is out of range");
            //} 
            #endregion

            #region problem 5

            //int[,] numbers = new int[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("Enter value: ");
            //        numbers[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        rowSum += numbers[i, j];
            //    }
            //    Console.WriteLine("Sum of row " + (i + 1) + " = " + rowSum);
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    int colSum = 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        colSum += numbers[i, j];
            //    }
            //    Console.WriteLine("Sum of column " + (i+1) + " = " + colSum);
            //} 
            #endregion

            #region problem 6

            //int[][] numbers = new int[3][];

            //numbers[0] = new int[2];
            //numbers[1] = new int[3];
            //numbers[2] = new int[4];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write("Enter value: ");
            //        numbers[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("Row " + (i + 1) + ": ");

            //    for (int j = 0; j < numbers[i].Length; j++)
            //    {
            //        Console.Write(numbers[i][j] + " ");
            //    }

            //    Console.WriteLine();
            //} 
            #endregion

            #region problem 7

            //string? name = null;

            //Console.Write("Do you want to enter your name:");
            //string answer = Console.ReadLine();
            //if (answer == "yes")
            //{
            //    Console.Write("Enter your name: ");
            //    name = Console.ReadLine();
            //}
            //else if (answer == "No")
            //{
            //    name = "No name entered";
            //}

            //Console.WriteLine("your name is: " + name!); 
            #endregion

            #region problem 8

            //// Boxing
            //int num = 10;
            //object obj = num;

            //Console.WriteLine("Boxing:");
            //Console.WriteLine(obj);

            //// Unboxing
            //try
            //{
            //    int result = (int)obj;
            //    Console.WriteLine("Unboxing:");
            //    Console.WriteLine(result);

            //    string tx = (string)obj;
            //}
            //catch(InvalidCastException)
            //{
            //    Console.WriteLine("Invalid cast exception occurred");
            //} 
            #endregion

            #region problem 9
            //static void SumandMultiply(int num1, int num2, out int Sum, out int product)
            //{
            //    Sum = num1 + num2;
            //    product = num1 * num2;
            //}
            //int Sum, product;
            //SumandMultiply(5,3,out Sum,out product);

            //Console.WriteLine("Sum = "+Sum);
            //Console.WriteLine("product = "+product); 
            #endregion

            #region problem 10
            //static void PrintText(string text , int times =5)
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        Console.WriteLine(text);
            //    }
            //}
            //PrintText("Hello");
            //PrintText("Welcome", 3);

            //PrintText(text: "C#", times: 2); 
            #endregion

            #region problem 11

            //int?[] nums = null;

            //Console.WriteLine("Array length: " + nums?.Length);

            //nums = new int?[] { 10, 20, null, 40 };
            //Console.WriteLine("Array length: "+nums?.Length); 
            #endregion

            #region problem 12
            //Console.Write("Enter a day of the week: ");
            //string day = Console.ReadLine();

            //int number = day switch
            //{
            //    "Monday" => 1,
            //    "Tuesday" => 2,
            //    "Wednesday" => 3,
            //    "Thursday" => 4,
            //    "Friday" => 5,
            //    "Saturday" => 6,
            //    "Sunday" => 7,
            //    _ => 0
            //};

            //Console.WriteLine("Day number = " + number); 
            #endregion

            #region problem 13
            //static int SumArray(params int[] numbers)
            //{
            //    int sum = 0;

            //    foreach (int num in numbers)
            //    {
            //        sum += num;
            //    }

            //    return sum;
            //}

            //Console.WriteLine("Sum = " + SumArray(1, 2, 3, 4));

            //int[] arr = { 5, 10, 15 };
            //Console.WriteLine("Sum = " + SumArray(arr)); 
            #endregion

            #endregion

            #region part 02

            #region problem 1
            //Console.Write("Enter a positive integer: ");
            //int num = int.Parse(Console.ReadLine());

            //if (num > 0)
            //{
            //    for (int i = 1; i <= num; i++)
            //    {
            //        Console.Write(i);

            //        if (i < num)
            //            Console.Write(", ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please enter a positive integer.");
            //} 
            #endregion

            #region problem 2
            //Console.Write("Enter an integer: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(num * i);

            //    if (i < 12)
            //        Console.Write(", ");
            //} 
            #endregion

            #region problem 3
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= num; i += 2)
            //{
            //    Console.Write(i);

            //    if (i < num - (num % 2))
            //        Console.Write(", ");
            //} 
            #endregion

            #region problem 4
            //Console.Write("Enter the first number: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.Write("Enter the power: ");
            //int power = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= power; i++)
            //{
            //    result *= num;
            //}

            //Console.WriteLine("Result: " + result); 
            #endregion

            #region problem 5
            //Console.Write("Enter a string: ");
            //string text = Console.ReadLine();

            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(text[i]);
            //} 
            #endregion

            #region problem 6

            //Console.Write("Enter an integer: ");
            //string num = Console.ReadLine();

            //for (int i = num.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(num[i]);
            //} 
            #endregion

            #region problem 7
            //Console.Write("Enter the size of the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Enter element " + i + ": ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int maxDistance = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1;

            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("Longest distance = " + maxDistance); 
            #endregion

            #region problem 8
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //string[] words = sentence.Split(' ');

            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words)); 
            #endregion 
            #endregion


        }
     }
}
