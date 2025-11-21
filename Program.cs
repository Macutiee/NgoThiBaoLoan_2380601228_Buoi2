using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NgoThiBaoLoan_2380601228_Buoi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> st = new List<Student>
            {
                new Student(1, "Dat", 14),
                new Student(2, "An", 16),
                new Student(3, "Nhan", 19),
                new Student(4, "Anh", 18),
                new Student(5, "Dai", 20),
            };

            //Cau a
            Console.WriteLine("--Danh sach hoc sinh--");
            foreach (var s in st)
            {
                Console.WriteLine($"ID: {s.Id} - Name: {s.Name} - Age: {s.Age}");
            }

            //Cau b
            Console.WriteLine("\n--Hoc sinh 15 den 18 tuoi--");
            var b = st.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var s in b)
            {
                Console.WriteLine($"ID: {s.Id} - Name: {s.Name} - Age: {s.Age}");
            }

            // Cau c
            Console.WriteLine("\n--Hoc sinh ten bat dau bang chu A--");
            var c = st.Where(s => s.Name.StartsWith("A"));
            foreach (var s in c)
            {
                Console.WriteLine($"{s.Name}");
            }

            //Cau d
            int totalAge = st.Sum(s => s.Age);
            Console.WriteLine("\nTong tuoi hoc sinh = " + totalAge);

            //Cau e
            Console.WriteLine("\n--Hoc sinh lon tuoi nhat--");
            int maxAge = st.Max(s => s.Age);
            var oldest = st.Where(s => s.Age == maxAge);
            foreach (var s in oldest)
            {
                Console.WriteLine($"{s.Name} - {s.Age}");
            }

            //Cau f
            Console.WriteLine("\n--Sap xep theo tuoi tang dan--");
            var sorted = st.OrderBy(s => s.Age);
            foreach (var s in sorted)
            {
                Console.WriteLine($"{s.Name} - {s.Age}");
            }
        }
    }
}
