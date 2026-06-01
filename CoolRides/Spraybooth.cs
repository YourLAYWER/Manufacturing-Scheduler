using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoolRides
{
    internal class Spraybooth
    {
        private static volatile Spraybooth _instance;
        private readonly static object thisLock = new object();

        public event Action<string> OnSprayStatusUpdate;


        private Spraybooth()
        {
        }

        public static Spraybooth GetInstance()
        {
            if (_instance == null)
            {
                lock (thisLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Spraybooth();
                    }
                }
            }
            return _instance;
        }

        public async void GetPainting(Automobile vehicle)
        {
            string color = vehicle.GetColor();
            OnSprayStatusUpdate?.Invoke($"Painting: {color} {vehicle.Model}...");

            if (vehicle is Minibus)
            {
                 await Task.Delay(7000);
            }
            else
            {
                 await Task.Delay(5000);
            }
            OnSprayStatusUpdate?.Invoke($"Idle");
            Thread.Sleep(1000);
            
        }
    }
}
