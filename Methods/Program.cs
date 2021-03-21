using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Save();
            Add(5,1);

            int number1 = 20;
            int number2 = 10;
            int result = Add2(number1, number2);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Add2(int number1, int number2)
        {
            return number1 + number2;
        }

        static void Add(int number1, int number2)
        {
            
            Console.WriteLine(number1 + number2);
        }

        static void Save()
        {
            Console.WriteLine("Kullanıcı Kaydedildi");
        }
    }
}
