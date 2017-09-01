using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystem
{
    class DeviceComputerNotebook : DeviceComputer
    {
        protected double Weight;

        public DeviceComputerNotebook(string name, double price, double speed, int countCore, double weight) : base(name, price, speed, countCore)
        {
            Weight = weight;
        }
    }
}
