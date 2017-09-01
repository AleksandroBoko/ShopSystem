using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystem
{
    class DevicePhone : Device
    {
        protected int BatteryCapacity;
        protected bool IsSensorDisplay;
        protected int Memory;

        public DevicePhone(string name, double price, int bcapacity, bool isSensor, int memory) : base(name, price)
        {
            BatteryCapacity = bcapacity;
            IsSensorDisplay = isSensor;
            Memory = memory;
        }
    }
}
