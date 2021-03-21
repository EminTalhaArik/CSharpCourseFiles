using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeAndVariables
{
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday,
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            int number1 = 10293;
            long number2 = 983289;
            short number3 = 32000;
            byte number4 = 255;
            double number5 = 27.4;
            decimal number6 = 10.9m;
            char character = 'A';

            var number7 = 1;
            number7 = 'A';


            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Number 5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);

            Console.WriteLine("Today is {0}", Days.Friday);
            Console.WriteLine("Number7 is {0}", number7);

            //Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
