using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolRides
{
    internal class CorporateHQ
    {
        public Queue<ICommand> carQue;
        public Queue<ICommand> miniBusQue;
        public Queue<Automobile> spraybooth;
        public Spraybooth Spraybooth;
        private bool isBoothBusy = false;
        private readonly object _queueLock = new object();
        public event Action<string> OnHQStatusUpdate;
        // This lazy instantiation of the Queue
        public CorporateHQ()
        {
            carQue = new Queue<ICommand>();
            miniBusQue = new Queue<ICommand>();
            spraybooth = new Queue<Automobile>();
            Spraybooth = Spraybooth.GetInstance();

        }
        public void DisplayBooth()
        {
            foreach (var item in spraybooth)
            {
                Console.WriteLine(item);
            }
        }
        public void SetOrder(ICommand command, string type)
        {
            type = type.ToLower();
            if (type == "car")
            {
                AddCar(command);
            }
            else
                AddMiniBus(command);
        }

        public void AddCar(ICommand command)
        {
            carQue.Enqueue(command);
        }
        public void AddMiniBus(ICommand command)
        {
            miniBusQue.Enqueue(command);
        }
        public async Task RouteToSpraybooth(Automobile vehicle)
        {
            lock (_queueLock)
            {
                spraybooth.Enqueue(vehicle);
            }

            await ProcessSprayboothQueue();
        }

        private async Task ProcessSprayboothQueue()
        {
            lock (_queueLock)
            {
                if (isBoothBusy)
                {
                    OnHQStatusUpdate?.Invoke($"Busy. Queued: {spraybooth.Count} in line...");
                    return;
                }

                if (spraybooth.Count == 0)
                {
                    OnHQStatusUpdate?.Invoke("Empty");
                    return;
                }

                isBoothBusy = true;
            }


            while (spraybooth.Count > 0)
            {
                Automobile vehicleToPaint;
                int remainingInQueue;

                lock (_queueLock)
                {
                    vehicleToPaint = spraybooth.Dequeue();
                    remainingInQueue = spraybooth.Count;
                }
                Spraybooth.GetPainting(vehicleToPaint);
            }

            lock (_queueLock)
            {
                isBoothBusy = false;
                OnHQStatusUpdate?.Invoke("Empty");
            }
        }
    }
}
