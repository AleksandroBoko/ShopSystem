using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystem
{
    class DeviceTVLcd : DeviceTV
    {
        protected bool IsBuiltInCar;

        public DeviceTVLcd(string name, double price, int countChannel, int diagonal, bool isBuiltInCar) : base(name, price, countChannel, diagonal)
        {
            IsBuiltInCar = isBuiltInCar;
        }

    }
}
