using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoops_01();
            //For();
            //While();
            //DoWhile();
            //ForEach();

            Console.WriteLine(IsPrimeNumber(5));
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        private static void ForEach()
        {
            string[] students = new string[] { "Engin", "Salih", "Derin" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        private static void ForLoops_01()
        {
            //For Loops
            for (int i = 0; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Birinci Döngü Örneği Bitti");
        }
        private static void For()
        {
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("İkinci Döngü Örneği Bitti");
        }
        private static void While()
        {
            //While Loops

            int number = 100;

            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine("Üçüncü Döngü Örneği Bitti");
        }
        private static void DoWhile()
        {
            //Do While Loops

            int number2 = 11;

            do
            {
                Console.WriteLine(number2);
            } while (number2 < 10);

            Console.WriteLine("Dördüncü Döngü Örneği Bitti");
        }
    }
}
