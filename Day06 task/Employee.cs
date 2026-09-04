using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_day01_task
{
    internal struct Employee
    {
        private int EmpId;
        private string Name;
        private double Salary;

        public string GetName()
        {
            return Name;
        }
        public void SetName(string n)
        {
            Name = n;
        }
        public void setEmpId(int id)
        {
            EmpId = id;
        }
        public int GetEmpId()
        {
            return EmpId;
        }
        public double GetSalary()
        {
            return Salary;
        }
        public void setSalary(double s)
        {
            Salary = s;
        }

      
    }
}
