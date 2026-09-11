using System;

namespace Day_08
{
    interface IWalkable
    {
        void walk();
    }

    interface IShapeSeries
    {
        int CurrentShapeArea {  get; set; }
        void GetNextArea();
        void ResetSeries();
    }

    internal class Program
    {
        static void PrintTenShapes(IShapeSeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine(series.CurrentShapeArea);
            }
        }

        public static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
            static void Main(string[] args)
        {
                #region problem 1
                //IVehicle car = new Car();
                //car.StartEngine();
                //car.StopEngine();
                //Console.WriteLine();
                //IVehicle bike = new Bike();
                //bike.StartEngine();
                //bike.StopEngine(); 
                #endregion

                #region problem 2
                //Shape Rec = new Rectangle(5,4);
                //Rec.Display();
                //Console.WriteLine("Rectangle Area: " + Rec.GetArea());

                //Shape C = new Circle(3);
                //C.Display();
                //Console.WriteLine("Circle Area: " + C.GetArea()); 
                #endregion

                #region problem 3

                //     Product[] products =
                //{
                //     new Product(1, "Laptop", 25000),
                //     new Product(2, "Mouse", 500),
                //     new Product(3, "Keyboard", 1200),
                //     new Product(4, "Monitor", 7000)
                // };

                //     Array.Sort(products);

                //     Console.WriteLine("Products sorted by price:");

                //     foreach (Product product in products)
                //     {
                //         Console.WriteLine(product);
                //     } 
                #endregion

                #region problem 4
                //Student s1 = new Student(1, "Salma", 90);

                //// Shallow copy
                //Student shallowCopy = s1;

                //// Deep copy using copy constructor
                //Student deepCopy = new Student(s1);


                //s1.Name = "Ahmed";
                //s1.Grade = 80;

                //Console.WriteLine("Original Student:");
                //Console.WriteLine(s1.Name + " - " + s1.Grade);

                //Console.WriteLine("\nShallow Copy:");
                //Console.WriteLine(shallowCopy.Name + " - " + shallowCopy.Grade);

                //Console.WriteLine("\nDeep Copy:");
                //Console.WriteLine(deepCopy.Name + " - " + deepCopy.Grade); 
                #endregion

                #region problem 5
                //Robot robot = new Robot();

                //robot.walk();

                //IWalkable walkable = robot;
                //walkable.walk(); 
                #endregion

                #region problem 6

                //Account acc = new Account();

                //acc.ACCIdProperty = 101;
                //acc.ACCHolderProperty = "Salma";
                //acc.BalanceProperty = 5000;

                //Console.WriteLine("Account ID: " + acc.ACCIdProperty);
                //Console.WriteLine("Account Holder: " + acc.ACCHolderProperty);
                //Console.WriteLine("Balance: " + acc.BalanceProperty); 
                #endregion

                #region last problem in part01
                //Book book1 = new Book();
                //Book book2 = new Book("C# Programming");
                //Book book3 = new Book("Clean Code", "Robert Martin");

                //Console.WriteLine("Book 1: " + book1.Title + " - " + book1.Author);
                //Console.WriteLine("Book 2: " + book2.Title + " - " + book2.Author);
                //Console.WriteLine("Book 3: " + book3.Title + " - " + book3.Author); 
                #endregion

                #region 1 part02
                //IShapeSeries square = new SquareSeries();

                //Console.WriteLine("Square Areas:");
                //PrintTenShapes(square);

                //square.ResetSeries();

                //IShapeSeries circle = new CircleSeries();

                //Console.WriteLine("\nCircle Areas:");
                //PrintTenShapes(circle); 
                #endregion

                #region 2 part02
                //    Shape1[] shapes =
                //{
                //    new Shape1("Square", 25),
                //    new Shape1("Circle", 12.56),
                //    new Shape1("Rectangle", 40),
                //    new Shape1("Circle", 28.26),
                //    new Shape1("Square", 9)
                //};

                //    Array.Sort(shapes);

                //    Console.WriteLine("Shapes sorted by area:");

                //    foreach (Shape1 shape in shapes)
                //    {
                //        Console.WriteLine(shape.Name + " - Area: " + shape.Area);
                //    } 
                #endregion

                #region 3 part02
                //Triangle tri = new Triangle();
                //tri.Dim1 = 10;
                //tri.Dim2 = 5;

                //Rectangle rec = new Rectangle();
                //rec.Dim1 = 8;
                //rec.Dim2 = 4;

                //Console.WriteLine("Triangle:");
                //Console.WriteLine("Area = " + tri.CalculateArea());
                //Console.WriteLine("Perimeter = " + tri.Perimeter);

                //Console.WriteLine();

                //Console.WriteLine("Rectangle:");
                //Console.WriteLine("Area = " + rec.CalculateArea());
                //Console.WriteLine("Perimeter = " + rec.Perimeter); 
                #endregion

                int[] shapeAreas = { 25, 12, 40, 28, 9 };

                Console.WriteLine("Before Sorting:");

                foreach (int area in shapeAreas)
                {
                    Console.WriteLine(area);
                }

                SelectionSort(shapeAreas);

                Console.WriteLine("\nAfter Sorting:");

                foreach (int area in shapeAreas)
                {
                    Console.WriteLine(area);
            }   }
        }
    }
}
