using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
     class Book
    {
        public string Title;
        public string Author;
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
        }

        // Constructor with Title only
        public Book(string title)
        {
            Title = title;
            Author = "Unknown";
        }

        // Constructor with Title and Author
        public Book(string title, string au)
        {
            Title = title;
            Author = au;
        }
    }
}
