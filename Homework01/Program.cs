using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                FirstName = "Emin Talha",
                LastName = "Arık",
                Class = 10,
                Number = 193,
                TCNumber = "102411111",
                Address = "Arapçeşme Mah..."
            };

            Planet planet = new Planet
            {
                Gravity = 9.8f,
                Radius = 6.371f
            };
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Class { get; set; }
        public int Number { get; set; }
        public string TCNumber { get; set; }
        public string Address { get; set; }
    }

    class Planet
    {
        public float Gravity { get; set; }
        public float Radius { get; set; }
    }
}
