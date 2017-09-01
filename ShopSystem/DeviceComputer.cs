using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystem
{
    class DeviceComputer : Device
    {
        protected double SpeedProcessor;
        protected int CountCore;

        public DeviceComputer(string name, double price, double speed, int countCore) : base(name, price)
        {
            SpeedProcessor = speed;
            CountCore = countCore;
        }

    }
}
