using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> students = utilities.BuildList<string>("Osman", "Ahmet", "Mehmet");

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }

        class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }
        }

        interface IRepository<T> where T : class, IEntity, new()
        {
            List<T> GetAll();
            T Get();
            void Add();
            void Update();
            void Delete();
        }

        interface IEntity
        {

        }

        interface IProductDal : IRepository<Product>
        {

        }

        interface ICustomerDal : IRepository<Customer>
        {

        }

        class ProductDal : IProductDal
        {
            public void Add()
            {
                throw new NotImplementedException();
            }

            public void Delete()
            {
                throw new NotImplementedException();
            }

            public Product Get()
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update()
            {
                throw new NotImplementedException();
            }
        }

        class CustomerDal : ICustomerDal
        {
            public void Add()
            {
                throw new NotImplementedException();
            }

            public void Delete()
            {
                throw new NotImplementedException();
            }

            public Customer Get()
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update()
            {
                throw new NotImplementedException();
            }
        }

        class Product : IEntity
        {

        }

        class Customer : IEntity
        {

        }
    }
}
