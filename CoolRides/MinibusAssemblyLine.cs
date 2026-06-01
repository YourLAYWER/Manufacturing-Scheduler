using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRides
{
    class MinibusAssemblyLine : AutomobileFactory
    {
        public MinibusAssemblyLine() : base(new MinibusPartsFactory())
        {
        }

        public override Automobile AssembleAutomobile(string color)
        {
            return new Minibus(partFacory, color);
        }
    }
}
