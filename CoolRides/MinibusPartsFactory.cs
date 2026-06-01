using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRides
{
    class MinibusPartsFactory : AutomobilePartsFactory
    {
        public override IChassis GetChassis()
        {
            return new MinibusChassis();
        }
        public override ITrim GetTrim()
        {
            return new MinibusTrim();
        }
        public override IShell GetShell()
        {
            return new MinibusShell();
        }
        public override IWheels GetWheels()
        {
            return new MinibusWheels();
        }
    }
}
