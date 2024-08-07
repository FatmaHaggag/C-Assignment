using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class Student : IComparable<Student>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public int CompareTo(Student s)
        {
            if (s == null)
                return 1;

            return this.ID.CompareTo(s.ID);

        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }
    }
}
