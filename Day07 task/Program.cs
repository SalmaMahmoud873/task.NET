using System;

namespace oop_day02
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            #region problem1
            //Car C1 = new Car();

            //Car C2 = new Car(1001);

            //Car C3 = new Car(1002,"BMW");

            //Car C4 = new Car(1003, "Mercedes", 1500000);
            //C1.Display();
            //C2.Display();
            //C3.Display();
            //C4.Display(); 
            #endregion

            #region problem2
            //Calculator calc = new Calculator();
            //Console.WriteLine(calc.Sum(10,20));

            //Console.WriteLine(calc.Sum(10,20,30));

            //Console.WriteLine(calc.Sum(10.5,20.5)); 
            #endregion

            #region problem3
            //Child ch = new Child(10, 20, 30);

            //Console.WriteLine($"X = {ch.X}");
            //Console.WriteLine($"Y = {ch.Y}");
            //Console.WriteLine($"Z = {ch.Z}"); 
            #endregion

            #region problem4
            //ChildNew C1 = new ChildNew(10,20,2);

            //Console.WriteLine("using New:");
            //Console.WriteLine(C1.Product());

            //Parent p1 = C1;
            //Console.WriteLine(p1.Product());

            //Child C2 = new Child(10, 20, 2);
            //Console.WriteLine("using override:");
            //Console.WriteLine(C2.Product());

            //Parent P2 = C2;
            //Console.WriteLine(P2.Product()); 
            #endregion

            #region problem5
            //Parent P = new Parent(10, 20);
            //Child ch = new Child(10, 20, 30);

            //Console.WriteLine(P);
            //Console.WriteLine(ch); 
            #endregion

            #region problem6
            //Rectangle r1 = new Rectangle();
            //r1.Width = 10;
            //r1.Height = 5;
            //Console.WriteLine($"Area = {r1.Area}");
            //r1.Draw(); 
            #endregion

            #region problem7
            //Circle c1 = new Circle();
            //c1.Radius = 5;
            //c1.Draw();
            //IShape sh = c1;
            //sh.PrintDetails(); 
            #endregion

            #region problem8
            //IMovable M = new Car();
            //M.Move(); 
            #endregion

            #region problem9
            //File F = new File();
            //F.Read();
            //F.Write(); 
            #endregion

            Rectangle R = new Rectangle();
            R.Width = 10;
            R.Height = 5;
            R.Draw();
            Console.WriteLine($"Area = {R.calcArea()}");

        }
    }
}
