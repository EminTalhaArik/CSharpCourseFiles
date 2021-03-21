using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(13);
            customerManager.List();

            Product product0 = new Product(1, "Hamza");
            Product product1 = new Product();

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Console.ReadLine();
        }
    }

    class BaseClass
    {
        string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} item collected",_entity);
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {
            
        }

        public void Add()
        {
            Message();
        }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database!");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logget to File!");
        }
    }

    class EmployeeManager
    {
        ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class CustomerManager
    {
        int _count;

        public CustomerManager(int count)
        {
            _count = count;
        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
    }

    class Product
    {

        public Product()
        {

        }
        int _id;
        string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

    }
}
