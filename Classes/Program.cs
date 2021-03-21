using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Emin";
            customer.LastName = "Arık";
            customer.Id = 1;
            customer.City = "Kocaeli";

            Customer customer2 = new Customer
            {
                FirstName = "Talha",LastName="Arık",City="Kocaeli",Id=2,
            };

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer2.FirstName);

            Console.ReadLine();
        }
    }
}
