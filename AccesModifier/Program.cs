using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesModifier
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        protected int Id { get; set; }

        void Save()
        {
            Console.WriteLine(Id);
        }
    }

    class Teacher
    {
        Person person = new Person();
        public void Add()
        {
            //person.Id;  //Person.Id is not found
        }
    }

    class Student:Person
    {
        void Delete()
        {
            Console.WriteLine(Id);
        }
    }
}
