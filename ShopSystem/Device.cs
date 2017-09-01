using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystem
{
    class Device
    {
        protected string Name;
        protected double Price;

        public Device(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name is {0}; Price is {1}", Name, Price);
        }
    }
}
