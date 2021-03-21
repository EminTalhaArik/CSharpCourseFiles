using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void StockControl();
    public class Product
    {
        int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock { get; set; }

        public void Sell(int amount)
        {
            Stock -= amount;
            Console.WriteLine("Stock Amount : {0}", Stock);
        }

    }
}
