using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
     class Product : IComparable<Product>
    {
        public int ID;
        public string Name;
        public double Price;

        public Product(int id , string n , double P )
        {
            ID = id;
            Name = n;
            Price = P;
        }
        public int CompareTo(Product other)
        {
            return Price.CompareTo( other.Price );

        }
        public override string ToString()
        {
            return ID + " - " + Name + " - " + Price;
        }
    }
}
