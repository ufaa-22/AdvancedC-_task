using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC__task
{
    internal class Student : IComparable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CompareTo(Student other)
        {
            return this.ID.CompareTo(other.ID);
        }

    }
}
