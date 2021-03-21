using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] students = new string[3];
            students[0] = "Emin";
            students[1] = "Talha";
            students[2] = "Berat";

            string[] students2 = { "Şeyda", "Sema", "Hira" };


            foreach (var student in students)
            {
                Console.WriteLine("Sıradaki Öğrenci : " + student);
            }

            foreach (var student in students2)
            {
                Console.WriteLine("Yeni Öğrenci : " + student);
            }

            Console.WriteLine("--------------------");
            //Multi Dimensional Arrays

            string[,] regions = new string[5,3] {
                { "İstanbul","Kocaeli","Yalova"},
                { "Rize","Zonguldak","Trabzon"},
                { "Antalya","Muğla","Mersin"},
                { "İzmir","Manisa","Denizli"},
                { "Konya","Nevşehir","Yozgat"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
}
