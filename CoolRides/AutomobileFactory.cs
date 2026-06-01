using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRides
{
    abstract class AutomobileFactory
    {
        public abstract Automobile AssembleAutomobile(string color);

        public AutomobilePartsFactory partFacory;

        public AutomobileFactory(AutomobilePartsFactory partFactory)
        {
            this.partFacory = partFactory;
        }

        public Automobile OrderAutomobile(string type)
        {
            Automobile vehicle = null;

            vehicle = AssembleAutomobile(type);
            type = type.ToLower();
            if (vehicle != null)
            {

                if (vehicle.GetType().Name == "MiniBus")
                {
                    vehicle.AssembleMiniBus();
                }
                else
                {
                    vehicle.AssembleCar();
                }
            }

            return vehicle;
        }
    }
}
