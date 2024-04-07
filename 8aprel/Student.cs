using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8aprel
{
    internal class Student
    {
        private static int count = 0;

        public static int Count { get => count; }
        public int Id { get;  set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public Student(string name, string surname)
        {
            Name = name.Capitalize();
            Surname = surname.Capitalize();
            Id = ++count;
        }

        public void GetInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Surname: {Surname}");
        }
    }
}
