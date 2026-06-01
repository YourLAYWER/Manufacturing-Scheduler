using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoolRides
{
    internal class Automobile
    {
        public ITrim Trim { get; set; }
        public IChassis Chassis { get; set; }

        public IWheels Wheels { get; set; }
        public IShell Shell { get; set; }
        public string Model { get; set; }
        private string Color;

        public event Action<string> OnStatusUpdate;
        public AutomobilePartsFactory PartFactory { get; set; }

        public Automobile(AutomobilePartsFactory PartFactory)
        {
            this.PartFactory = PartFactory;
        }
        public void SetColor(string color)
        {
            color = color.ToLower();
            if (color == "white" || color == "black")
            {
                this.Color = color;

            }
            else
            {
                Console.Error.WriteLine("Color must only be white or black and cannot be null");
            }
        }
        public string GetColor()
        {
            return this.Color;
        }
        protected void ReportStatus(string status)
        {
            OnStatusUpdate?.Invoke(status);
        }
        public async Task AssembleCar()
        {
            ReportStatus(AddChassis());
            //await Task.Delay(2000);
            Thread.Sleep(2000);

            //await Task.Delay(4000);
            ReportStatus(AddShell());
            Thread.Sleep(2000);
            //await Task.Delay(2000);

            //await Task.Delay(6000);
            ReportStatus(AddWheels());
            Thread.Sleep(2000);
            //await Task.Delay(2000);

            ReportStatus(AddTrim());
            //await Task.Delay(1000);
            Thread.Sleep(1000);
        }
        public async Task AssembleMiniBus()
        {
            ReportStatus(AddChassis());
            //await Task.Delay(2000);
            Thread.Sleep(2000);

            //await Task.Delay(4000);
            ReportStatus(AddShell());
            Thread.Sleep(3000);
            //await Task.Delay(3000);

            //await Task.Delay(6000);
            ReportStatus(AddWheels());
            Thread.Sleep(2000);
            //await Task.Delay(2000);

            ReportStatus(AddTrim());
            //await Task.Delay(2000);
            Thread.Sleep(2000);
        }

        public virtual string AddChassis()
        {
            return $"Adding {Color} {Model} {Chassis.GetType().Name}";
        }
        public virtual string AddTrim()
        {
            return $"Adding interior {Color} {Model} {Trim.GetType().Name}";
        }
        public virtual string AddShell()
        {
            return $"Adding {Color} {Model} {Shell.GetType().Name}";
        }
        public virtual string AddWheels()
        {
            return $"Adding {Color} {Model} {Wheels.GetType().Name}";
        }
    }
}
