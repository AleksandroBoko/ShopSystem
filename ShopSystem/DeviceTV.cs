using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystem
{
    class DeviceTV : Device
    {
        protected int CountChannel;
        protected int Diagonal;

        public DeviceTV(string name, double price, int countChannel, int diagonal) : base(name, price)
        {
            CountChannel = countChannel;
            Diagonal = diagonal;
        }

    }
}
