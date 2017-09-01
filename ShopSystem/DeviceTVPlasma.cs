using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSystem
{
    class DeviceTVPlasma : DeviceTV
    {
        public enum GasType
        {
            GasNeon,
            GasXenon
        }

        protected GasType Gas;

        public DeviceTVPlasma(string name, double price, int countChannel, int diagonal, GasType gas) : base(name, price, countChannel, diagonal)
        {
            Gas = gas;
        }

    }
}
