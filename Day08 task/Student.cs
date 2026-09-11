using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
     class Student
    {
        public int Id;
        public string Name;
        public double Grade;

        public Student(int id, string n, double grade)
        {
            Id = id;
            Name = n;
            Grade = grade;
        }

        public Student(Student other)
        {
            Id = other.Id;
            Name = other.Name;
            Grade = other.Grade;
        }
    }
}
