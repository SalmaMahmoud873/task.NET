using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Day01_LINQ
{
    static class StringExtensions
    {
        public static bool IsPalindrome(this string text)
        {
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }
    }

    public static class  InExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number < 2)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part1 problem1
            //var num = 10;
            //var name = "Salma";
            //var price = 15.5;
            //var isStudent = true;
            //var numbers = new int[] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(num.GetType());
            //Console.WriteLine(name.GetType());
            //Console.WriteLine(price.GetType());
            //Console.WriteLine(isStudent.GetType());
            //Console.WriteLine(numbers.GetType()); 
            #endregion

            #region part1 problem2
            //// Explicit types
            //int num1 = 10;
            //string name1 = "Salma";
            //double price1 = 15.5;
            //bool isStudent1 = true;

            //// using var
            //var num2 = 10;
            //var name2 = "Salma";
            //var price2 = 15.5;
            //var isStudent2 = true;

            ///*var is determined by the compiler at compile time
            // therefore, num2 is int , name2 is string , price2 is double
            //and isStudent2 is bool exactly like the explict declarations
            // */
            //Console.WriteLine(num1.GetType());
            //Console.WriteLine(num2.GetType());
            //Console.WriteLine(name1.GetType());
            //Console.WriteLine(name2.GetType()); 
            #endregion

            #region part2 problem3
            //var product = new
            //{
            //    Name = "Laptop",
            //    price = 25000.0,
            //    Quantity = 3
            //};

            //Console.WriteLine("Name: " + product.Name);
            //Console.WriteLine("Price: " + product.price);
            //Console.WriteLine("Quantity: " + product.Quantity); 
            #endregion

            #region part2 problem4
            //var students = new[]
            //{
            //    new {Name = "Salma",Grade =90},
            //    new {Name = "Abdelrahman",Grade =85},
            //    new {Name = "Ahmed" , Grade = 95}
            //};
            //foreach (var student in students)
            //{
            //    Console.WriteLine("Name: "+student.Name);
            //    Console.WriteLine("Grades: "+student.Grade);
            //    Console.WriteLine();
            //} 
            #endregion

            #region part2 problem5
            //var order = new
            //{
            //    OrderId = 101,
            //    Product = "Laptop",
            //    Price = 25000,
            //    Customer = new
            //    {
            //        Name = "Salma",
            //        City = "Cairo"
            //    }
            //};

            //Console.WriteLine("Order ID: " + order.OrderId);
            //Console.WriteLine("Product: " + order.Product);
            //Console.WriteLine("Price: " + order.Price);
            //Console.WriteLine("Customer Name: " + order.Customer.Name);
            //Console.WriteLine("Customer City: " + order.Customer.City); 
            #endregion

            #region part3 problem6
            //string word1 = "level";
            //string word2 = "hello";
            //string word3 = "madam";

            //Console.WriteLine(word1.IsPalindrome());
            //Console.WriteLine(word2.IsPalindrome());
            //Console.WriteLine(word3.IsPalindrome()); 
            #endregion

            #region part3 problem7

            //int number1 = 7;
            //int number2 = 10;
            //int number3 = 13;

            //Console.WriteLine(number1.IsPrime());
            //Console.WriteLine(number2.IsPrime());
            //Console.WriteLine(number3.IsPrime()); 
            #endregion

            #region part4 problem9

            //List<string> employees = new List<string>();

            //employees.Add("Ahmed");
            //employees.Add("Salma");
            //employees.Add("Mariem");
            //employees.Add("Omar");

            //employees.Remove("Omar");

            //string searchName = "Salma";
            //bool found = false;

            //for (int i = 0; i < employees.Count; i++)
            //{
            //    if (employees[i] == searchName)
            //    {
            //        found = true;
            //        break;
            //    }
            //}
            //Console.WriteLine("Search Result: "+found);
            //Console.WriteLine("Final List:");
            //foreach (string employee in employees)
            //{
            //    Console.WriteLine(employee);
            //} 
            #endregion

            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { Name = "Ahmed", Salary = 5000 });
            employees.Add(new Employee { Name = "Salma", Salary = 8000 });
            employees.Add(new Employee { Name = "Mariam", Salary = 6000 });
            employees.Add(new Employee { Name = "Omar", Salary = 10000 });

            double value = 7000;

            foreach (Employee employee in employees)
            {
                if (employee.Salary > value)
                {
                    Console.WriteLine("Name: " + employee.Name);
                    Console.WriteLine("Salary: " + employee.Salary);
                    Console.WriteLine();
                }
            }
        }
    }
}
