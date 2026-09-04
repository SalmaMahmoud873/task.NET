using System;
using System.Drawing;

namespace oop_day01_task
{
    
    internal class Program
    {
        static void ChangePoint(Point p)
        {
            p.X = 100;
            p.Y = 200;
        }
        class Employee
        {
            public string name;
           
        }
        static void ChangeEmployee(Employee e)
        {
            e.name = "Ahmed";
        }
        static void Main(string[] args)
        {
            #region problem 1
            //Point p1 = new Point();
            //Point p2 = new Point(10,20);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2); 
            #endregion

            #region problem 2
            //TypeA obj = new TypeA();
            ////Console.WriteLine(obj.F); //error(private)
            //Console.WriteLine(obj.G);
            //Console.WriteLine(obj.H);
            //obj.ShowinClass(); 
            #endregion

            #region problem 3
            //Employee emp = new Employee();

            //emp.setEmpId(100);
            //emp.setSalary(25000);
            //emp.SetName("Salma");
            //Console.WriteLine("Employee ID: " + emp.GetEmpId());
            //Console.WriteLine("Employee Name: " + emp.GetName());
            //Console.WriteLine("Employee salary: " + emp.GetSalary()); 
            #endregion

            #region problem 4
            //point2 p1 = new point2(10);
            //point2 p2 = new point2(10,30);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2); 
            #endregion

            #region problem 5

            //point2 p1 = new point2(10);
            //point2 p2 = new point2(10, 30);
            //point2 p3 = new point2(5, 15);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3); 
            #endregion

            Point p = new Point(10, 20);
            Employee emp = new Employee();

            emp.name = "Ali";

            Console.WriteLine("Before:");
            Console.WriteLine(p);
            Console.WriteLine(emp.name);

            ChangePoint(p);
            ChangeEmployee(emp);

            Console.WriteLine("After:");
            Console.WriteLine(p);
            Console.WriteLine(emp.name);
        }
    }
}
