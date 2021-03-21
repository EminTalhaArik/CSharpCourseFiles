using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICustomerDal
    {

        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("SQL Updated");
        }

        public void Update()
        {
            Console.WriteLine("SQL Deleted");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Updated");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }

    class MySQLCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySQL Added");
        }

        public void Delete()
        {
            Console.WriteLine("MySQL Updated");
        }

        public void Update()
        {
            Console.WriteLine("MySQL Deleted");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
