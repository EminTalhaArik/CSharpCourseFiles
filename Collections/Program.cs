using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            //Dictionary();

            Console.ReadLine();

        }

        private static void Dictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("Book", "Kitap");
            dictionary.Add("Computer", "Bilgisayar");
            dictionary.Add("Table", "Masa");

            foreach (var item in dictionary)
            {
                Console.WriteLine("Item : {0} ||| Value : {1}", item.Key, item.Value);
            }
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Kocaeli");
            cities.Add("Zonguldak");

            //cities.Add(1);  #Type Safe (cities is not take a integer value)

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Emin" });
            customers.Add(new Customer { Id = 2, FirstName = "Berat" });
            customers.Add(new Customer { Id = 3, FirstName = "Hira" });

            var count = customers.Count;
            var customer1 = new Customer
            {
                Id = 4,
                FirstName = "Salih",
            };

            customers.Remove(customer1);
            //customers.Clear();
            customers.Append<Customer>(new Customer { Id = 5, FirstName = "Osman" });

            customers.Add(customer1);

            var index = customers.IndexOf(customer1);
            var lastIndex = customers.LastIndexOf(customer1);

            var contains = customers.Contains(customer1);

            Console.WriteLine("Index : {0} Last Index : {1} Contains : {2}", index, lastIndex, contains);
            Console.WriteLine("Customer Count : {0}", count);
            customers.Add(customer1);

            foreach (var customer in customers)
            {
                Console.WriteLine("Customer Name : {0}", customer.FirstName);
            }
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");

            cities.Add(3);
            cities.Add(true);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

    }
}
