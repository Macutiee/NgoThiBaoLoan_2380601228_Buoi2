using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgoThiBaoLoan_2380601228_Buoi2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
    }
}
