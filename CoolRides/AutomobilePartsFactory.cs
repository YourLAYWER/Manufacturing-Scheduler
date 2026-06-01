using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRides
{
    abstract class AutomobilePartsFactory
    {
        public abstract ITrim GetTrim();
        public abstract IChassis GetChassis();
        public abstract IWheels GetWheels();
        public abstract IShell GetShell();
    }
}
