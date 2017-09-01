using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystem
{
    class DevicePhoneSmart : DevicePhone
    {
        protected string OperatingSystem;

        public DevicePhoneSmart(string name, double price, int bcapacity, bool isSensor, int memory, string os) : base(name, price, bcapacity, isSensor, memory)
        {
            OperatingSystem = os;
        }
    }
}
