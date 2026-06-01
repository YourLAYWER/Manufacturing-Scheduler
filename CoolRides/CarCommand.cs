using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRides
{
    internal class CarCommand : ICommand
    {
        AutomobileFactory factory;
        public string color;
        public CarCommand(AutomobileFactory factory, string color)
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
