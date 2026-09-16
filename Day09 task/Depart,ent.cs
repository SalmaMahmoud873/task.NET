using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day09_task
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            Department D = obj as Department;

            if (D == null)
                return false;

            return Id == D.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
