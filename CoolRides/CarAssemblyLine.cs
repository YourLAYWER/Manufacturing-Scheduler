using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRides
{
    class CarAssemblyLine : AutomobileFactory
    {
        public CarAssemblyLine() : base(new CarPartsFactory())
        {

        }
        public override Automobile AssembleAutomobile(string color)
        {
            return new Car(partFacory, color);
        }
    }
}
