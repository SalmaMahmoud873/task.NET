using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09_task
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }

        public override bool Equals(object obj)
        {
            Employee E = obj as Employee;

            if (E == null)
                return false;

            return Id == E.Id && Name == E.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
        public override string ToString()
        {
            return $"{Id} - {Name} - {Department.Name}";
        }
    }
}
