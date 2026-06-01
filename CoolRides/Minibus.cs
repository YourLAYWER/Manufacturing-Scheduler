using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRides
{
    class Minibus : Automobile
    {
        public Minibus(AutomobilePartsFactory PartFactory, string color) : base(PartFactory)
        {
            this.Trim = PartFactory.GetTrim();
            this.Chassis = PartFactory.GetChassis();
            this.Wheels = PartFactory.GetWheels();
            this.Shell = PartFactory.GetShell();
            this.SetColor(color);
            this.Model = "MV5000";
        }
    }
}
