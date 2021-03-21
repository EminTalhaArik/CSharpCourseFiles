using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 15;

            Console.WriteLine(number1);

            //Reference Types

            string[] cities1 = new string[] { "İstanbul", "Ankara", "Bursa" };
            string[] cities2 = new string[] { "Kocaeli", "Zonguldak", "Konya" };

            cities1 = cities2;
            cities2[0] = "Balıkesir";

            Console.WriteLine(cities1[0]);

            Console.ReadLine();

        }
    }
}
