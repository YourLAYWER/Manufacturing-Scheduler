using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRides
{
    class MinibusCommand : ICommand
    {
        AutomobileFactory factory;
        public string color;

        public MinibusCommand(AutomobileFactory factory, string color)
        {
            this.factory = factory;
            this.color = color;
        }

        public void Execute()
        {
            factory.OrderAutomobile(color);
        }
    }
}
