using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day02
{
     class Car : IMovable
    {
        public int Id;
        public string Brand;
        public double price;

        //Default cons
        public Car()
        {
            Id = 0;
            Brand = " ";
            price = 0;
        }

        // constructor with Id
        public Car(int id)
        {
            Id = id;
            Brand = " ";
            price = 0;
        }

        // with Id and Brand
        public Car(int id,string B)
        {
            Id =id;
            Brand = B;
            price = 0;
        }

        // Id,Brand and price
        public Car(int id , string B , double P)
        {
            Id =id;
            Brand = B;
            price = P;
        }
        public void Display()
        {
            Console.WriteLine($"Id: {Id}, Brand: {Brand}, Price: {price}");
        }

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}
