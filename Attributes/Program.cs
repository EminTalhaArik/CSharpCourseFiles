using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                LastName = "Arık",
                Age = 16,
            };

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            customerDal.AddNew(customer);

            Console.ReadLine();
        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }

    class CustomerDal
    {
        [Obsolete("Dont use Add, Instead use AddNew Method")] //Hazır Attribute - Eklendiği method'a eski kod anlamı sunar. 
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;

        public ToTableAttribute(string tableName)
        {
            this._tableName = tableName;
        }
    }

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {

    }
}
