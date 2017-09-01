using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystem
{
    class DeviceComputerPC : DeviceComputer
    {
        protected bool IsMonoblock;

        public DeviceComputerPC(string name, double price, double speed, int countCore, bool isMonoblock) : base(name, price, speed, countCore)
        {
            IsMonoblock = isMonoblock;
        }
    }
}
