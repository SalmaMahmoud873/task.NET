using System;

namespace day04_task
{
    enum DayOfweek
    {
        Monday = 1,
        tuesday,wednesday, thursday, friday, saturday,sunday
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 1
            //    // 1. using new int[size]

            //    int[] arr1 = new int[3];
            //    arr1[0] = 20;
            //    arr1[1] = 40;
            //    arr1[2] = 60;
            //    Console.WriteLine("Array 1:");
            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        Console.WriteLine(arr1[i]);
            //    }

            //    // 2. using initialize list

            //    int[] arr2 = new int[] { 10, 30, 50 };
            //    Console.WriteLine("Array 2:");
            //    for (int i = 0; i < arr2.Length; i++)
            //    {
            //        Console.WriteLine(arr2[i]);
            //    }

            //    // syntax sugar

            //    int[] arr3 = { 70, 80, 90 };
            //    Console.WriteLine("Array 3:");
            //    for (int i = 0; i < arr3.Length; i++)
            //    {
            //        Console.WriteLine(arr3[i]);
            //    }

            //    try
            //    {
            //        Console.WriteLine(arr1[5]);
            //    }
            //    catch(IndexOutOfRangeException)
            //    {
            //        Console.WriteLine("IndexOutOfRangeException occured");
            //    } 
            #endregion

            #region problem 2
            //int[] arr1 = { 10, 20, 30 };

            //int[] arr2 = arr1;

            //Console.WriteLine("before : ");
            //Console.WriteLine("arr1[0] = " + arr1[0]);
            //Console.WriteLine("arr2[0] = " + arr2[0]);

            //arr2[0] = 100;

            //Console.WriteLine("After modifying: ");
            //Console.WriteLine("arr1[0] = " + arr1[0]);
            //Console.WriteLine("arr2[0] = " + arr2[0]);

            //int[] arr3 = (int[])arr1.Clone();
            //arr3[1] = 200;

            //Console.WriteLine("arr1[1] = " + arr1[1]);
            //Console.WriteLine("arr3[1] = " + arr3[1]); 
            #endregion

            #region problem 3
            //int[,] grades = new int[3, 3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Enter grades for student " + (i + 1) + ":");

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("subject" + (j + 1) + ":");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Student Grades:");

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Student " + (i + 1) + ":");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(grades[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region problem 4
            //int[] arr = { 50, 30, 10, 20, 40 };

            //// 1. sort
            //Console.WriteLine("Before sort:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Array.Sort(arr);
            //Console.WriteLine("\nAfter sort:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine("\nSort arranges element in ascending order.\n");

            //// 2.Reverse
            //Console.WriteLine("Before Reverse:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Array.Reverse(arr);
            //Console.WriteLine("\nAfter Reverse:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine("\nchanges the order of the elements.\n");

            //// 3.Indexof
            //Console.WriteLine("Array:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //int index = Array.IndexOf(arr, 30);
            //Console.WriteLine("\nIndex of 30 = " + index);
            //Console.WriteLine("finds the position of an elements.\n");

            ////4. copy
            //int[] arr2 = new int[5];
            //Console.WriteLine("Before copy:");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i] + " ");
            //}
            //Array.Copy(arr, arr2, arr.Length);

            //Console.WriteLine("\nAfter copy:");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i] + " ");
            //}
            //Console.WriteLine("\ncopies element from one array to another.\n");

            ////5.clear
            //Console.WriteLine("Before clear:");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i] + " ");
            //}
            //Array.Clear(arr2, 0, arr2.Length);
            //Console.WriteLine("\nAfter Clear:");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.Write(arr2[i] + " ");
            //}
            //Console.WriteLine("\nset all elements to their default value.");
            #endregion

            #region problem 5
            //int[] arr = { 10, 20, 30, 40, 50 };
            ////1. for loop
            //Console.WriteLine("using for loop:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine("\n");

            ////2. foreach loop
            //Console.WriteLine("using foreach loop:");
            //foreach (int x in arr)
            //{
            //    Console.Write(x + " ");
            //}
            //Console.WriteLine("\n");

            ////3. while loop in reverse
            //Console.WriteLine("reverse:");
            //int j = arr.Length - 1;
            //while (j >= 0)
            //{
            //    Console.Write(arr[j] + " ");
            //    j--;
            //}
            #endregion

            #region problem 6
            //int num;
            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    if (!int.TryParse(Console.ReadLine(), out num))
            //    {
            //        Console.WriteLine("Invalid input, please enter a number");
            //        num = 0;
            //    }
            //    else if (num <= 0 || num % 2 == 0)
            //    {
            //        Console.WriteLine("please enter a positive odd number.");
            //    }
            //}
            //while (num <= 0 || num % 2 == 0);
            //Console.WriteLine("valid number: " + num);
            #endregion

            #region problem 7
            //int[,] arr =
            //{
            //    {1,2,3} , {4,5,6} , {7,8,9}
            //};

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write(arr[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region problem 8
            //Console.Write("Enter month number: ");
            //int month = int.Parse(Console.ReadLine());

            //// using if_else
            //if (month == 1)
            //    Console.WriteLine("January");
            //else if (month == 2)
            //    Console.WriteLine("February");
            //else if (month == 3)
            //    Console.WriteLine("March");
            //else if ( month == 4)
            //    Console.WriteLine("April");
            //else if ( month ==5)
            //    Console.WriteLine("May");
            //else if ( month ==6)
            //    Console.WriteLine("June");
            //else if (month ==7)
            //    Console.WriteLine("July");
            //else if (month ==8)
            //    Console.WriteLine("August");
            //else if (month==9)
            //    Console.WriteLine("September");
            //else if (month == 10)
            //    Console.WriteLine("October");
            //else if (month == 11)
            //    Console.WriteLine("November");
            //else if (month == 12)
            //    Console.WriteLine("December");
            //else
            //    Console.WriteLine("Invalid month");

            //// using switch
            //switch(month)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("June");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("September");
            //        break;
            //    case 10:
            //        Console.WriteLine("October");
            //        break;
            //    case 11:
            //        Console.WriteLine("November");
            //        break;
            //    case 12:
            //        Console.WriteLine("December");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month");
            //        break;
            //} 
            #endregion

            #region problem 9

            //int[] arr = { 40, 10, 30, 20, 30, 50 };

            //Console.WriteLine("Before sort:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Array.Sort(arr);

            //Console.WriteLine("\nAfter sort:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //int value = 30;

            //int firstIndex = Array.IndexOf(arr, value);
            //int lastIndex = Array.LastIndexOf(arr, value);

            //Console.WriteLine("\n\nFirst index of " + value + " = " + firstIndex);
            //Console.WriteLine("Last index of " + value + " = " + lastIndex); 
            #endregion

            #region problem 10

            //int[] arr = { 10, 20, 30, 40, 50 };

            //// using for loop
            //int sum1 = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum1 += arr[i];
            //}

            //Console.WriteLine("Sum using for = " + sum1);


            //// Using foreach loop
            //int sum2 = 0;

            //foreach (int x in arr)
            //{
            //    sum2 += x;
            //}

            //Console.WriteLine("Sum using foreach = " + sum2); 
            #endregion

            #region part02 q2
            //Console.WriteLine("Enter a number from 1 to 7: ");
            //int input = int.Parse(Console.ReadLine());

            //DayOfWeek day = (DayOfWeek)Enum.Parse(
            //    typeof(DayOfWeek), input.ToString());

            //Console.WriteLine(day); 
            #endregion

        }
    }
}
