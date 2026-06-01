using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRides
{
    class CarPartsFactory : AutomobilePartsFactory
    {
        public override ITrim GetTrim()
        {
            return new CarTrim();
        }

        public override IChassis GetChassis()
        {
            return new CarChassis();
        }

        public override IShell GetShell()
        {
            return new CarShell();
        }
        public override IWheels GetWheels()
        {
            return new CarWheels();
        }
    }
}
