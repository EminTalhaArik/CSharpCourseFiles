using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //İF Tutorial
            Console.WriteLine("----İf Block Used----");
            var number = 65;
            var character = 'A';
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else if (number == character)
            {
                Console.WriteLine("Acayip şeyler oluyor");
            }
            else
            {
                Console.WriteLine("number is not 10 or 20");
            }

            //Single Line Tutorial
            Console.WriteLine("----Single Lİne İF Used----");
            var number2 = 30;
            Console.WriteLine(number2 <= 30 ? "Number is low than 30" : "Number is big than 30");


            //Switch Block Tutorial
            Console.WriteLine("-----Switch Block Used----");
            var number3 = 11;
            switch (number3)
            {
                case 10:
                    Console.WriteLine("Number3 is 10");
                    break;
                case 15:
                    Console.WriteLine("Number3 is 15");
                    break;
                default:
                    Console.WriteLine("Number3 is not 10 or 15");
                    break;
            }

            //Demo 01
            Console.WriteLine("----Demo_01----");
            var number4 = 199;
            if (number4 >= 0 && number4 <= 100)
            {
                Console.WriteLine("Number 4 is between 0-100");
            }
            else if (number4 > 100 && number4 <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if(number4 <0 || number4 > 200)
            {
                Console.WriteLine("Number4 is less than 0 or grater than 200");
            }

            //Other İF Using technic
            Console.WriteLine("----Other if technics----");
            if(number < 100)
            {
                if(number >= 90 && number < 95)
                {
                    Console.WriteLine("it is Succes");
                }
                else
                {
                    Console.WriteLine("it is not succes");
                }
            }
            else
            {
                Console.WriteLine("it is not succes");
            }

            Console.ReadLine();
        }
    }
}
