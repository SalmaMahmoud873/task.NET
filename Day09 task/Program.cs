using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace day09_task
{
    enum Weekdays
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    enum Grades : short
    {
        A,B,C,D,E, F = -1
    }
    class person
    {
        public string name {  get; set; }
        public int age { get; set; }
        public string Department {  get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Department: {Department}");
        }
    }
    class Utility
    {
        public static double CalcPerimeter(double length , double width)
        {
            return 2*(length+width);
        }
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }
    enum Gender
    {
        Male,
        Female
    }

    enum GenderByte : byte
    {
        Male,
        Female
    }
    class Helper
    {
        public static T Max<T>(T X, T Y) where T : IComparable<T>
        {
            return X.CompareTo(Y) > 0 ? X : Y;
        }
        public static void Swap(ref Rectangle R1, ref Rectangle R2)
        {
            Rectangle temp = R1;
            R1 = R2;
            R2 = temp;
        }
    }
    class Helper2<T>
    {
        public static int SearchArray(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                    return i;
            }

            return -1;
        }

        public static void ReplaceArray(T[] array, T oldValue, T newValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(oldValue))
                {
                    array[i] = newValue;
                }
            }
        }
    }

    class CircleClass
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleClass(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }
    }

    class MyStack<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public T Peek()
        {
            return items[items.Count - 1];
        }
    }
    internal class Program
    {
        static T[] ReverseArray<T>(T[] array)
        {
            T[] reversed = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversed[i] = array[array.Length - 1 - i];
            }

            return reversed;
        }

        static void Swap<T>(T[] array, int index1, int index2)
        {
            T temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
        static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            T max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }

            return max;
        }
        static void Main(string[] args)
        {
            #region problem1
            //foreach(Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"{day} = {(int)day}");
            //} 
            #endregion

            #region problem2
            //foreach ( Grades grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"{grade} = {(short)grade}");
            //} 
            #endregion

            #region problem3
            //person p1 = new person();
            //p1.name = "Salma";
            //p1.age = 20;
            //p1.Department = "Computer Science";

            //person p2 = new person();
            //p2.name = "Yara";
            //p2.age = 20;
            //p2.Department = "Ai";

            //p1.PrintDetails();
            //Console.WriteLine();
            //p2.PrintDetails(); 
            #endregion

            #region problem4

            //Child C = new Child(10,20,30);
            //C.Salary = 15000;
            //C.DisplaySalary(); 
            #endregion

            #region problem5
            //double result = Utility.CalcPerimeter(10, 5);
            //Console.WriteLine($"Perimeter = {result}"); 
            #endregion

            #region problem6
            //ComplexNumber C1 = new ComplexNumber(2, 3);
            //ComplexNumber C2 = new ComplexNumber(4,5);

            //ComplexNumber result = C1 * C2;
            //Console.WriteLine(result); 
            #endregion

            #region problem7

            //Console.WriteLine($"Default int size = {sizeof(int)} byte");
            //Console.WriteLine($"GenderByte size = {sizeof(GenderByte)} byte"); 
            #endregion

            #region problem8

            //double result = Utility.CelsiusToFahrenheit(25);
            //Console.WriteLine($"Fahrenheit = {result}"); 
            #endregion

            #region problem11
            //int intResult = Helper.Max(10, 20);
            //double doubleResult = Helper.Max(5.5, 3.2);
            //string stringResult = Helper.Max("Ahmed", "Salma");

            //Console.WriteLine(intResult);
            //Console.WriteLine(doubleResult);
            //Console.WriteLine(stringResult); 
            #endregion

            #region problem12
            //int[] nums = { 1, 2, 2, 3, 2 };

            //Helper2<int>.ReplaceArray(nums, 2, 5);

            //Console.WriteLine(string.Join(", ", nums));


            //string[] names = { "Ahmed", "Salma", "Ahmed", "Mona" };

            //Helper2<string>.ReplaceArray(names, "Ahmed", "Ali");

            //Console.WriteLine(string.Join(", ", names)); 
            #endregion

            #region problem13
            //Rectangle R1 = new Rectangle(10, 5);
            //Rectangle R2 = new Rectangle(20, 8);

            //Console.WriteLine("Before Swap:");
            //Console.WriteLine(R1);
            //Console.WriteLine(R2);

            //Helper.Swap(ref R1, ref R2);

            //Console.WriteLine("After Swap:");
            //Console.WriteLine(R1);
            //Console.WriteLine(R2); 
            #endregion

            #region problem14

            //            Department IT = new Department(Id = 1 , Name = "IT");
            //            Department HR = new Department(Id = 2, Name = "HR");
            //            Employee[] employees =
            //{
            //    new Employee { Id = 1, Name = "Ahmed", Department = IT },
            //    new Employee { Id = 2, Name = "Salma", Department = HR },
            //    new Employee { Id = 3, Name = "Mona", Department = IT }
            //};

            //            int index = Helper2<Department>.SearchArray(
            //                new Department[] { employees[0].Department, employees[1].Department },
            //                HR
            //            );

            //            Console.WriteLine($"Department found at index: {index}"); 
            #endregion

            #region problem15

            //Circle C1 = new Circle(5, "Red");
            //Circle C2 = new Circle(5, "Red");

            //Console.WriteLine(C1 == C2);
            //Console.WriteLine(C1.Equals(C2));


            //CircleClass C3 = new CircleClass(5, "Red");
            //CircleClass C4 = new CircleClass(5, "Red");

            //Console.WriteLine(C3 == C4);
            //Console.WriteLine(C3.Equals(C4)); 
            #endregion

            #region problem1 part02
            //int[] numbers = { 1, 2, 3, 4, 5 };

            //int[] result = ReverseArray(numbers);

            //foreach (int num in result)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region problem2
            //MyStack<int> stack = new MyStack<int>();

            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop()); 
            #endregion

            #region problem3
            //int[] numbers = { 10, 20, 30, 40 };

            //Swap(numbers, 1, 3);

            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            int[] numbers = { 10, 50, 20, 80, 30 };

            int max = FindMax(numbers);

            Console.WriteLine("Maximum = " + max);
        }
    
    }
}
