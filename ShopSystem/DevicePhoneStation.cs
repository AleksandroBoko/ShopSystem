using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystem
{
    class DevicePhoneStation : DevicePhone
    {
        protected bool HasBaseStation;

        public DevicePhoneStation(string name, double price, int bcapacity, bool isSensor, int memory, bool hasStation) : base(name, price, bcapacity, isSensor, memory)
        {
            HasBaseStation = hasStation;
        }
    }
}
