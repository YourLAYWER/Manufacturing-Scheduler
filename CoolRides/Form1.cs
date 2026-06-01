using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolRides
{
    public partial class Form1 : Form
    {
        private CorporateHQ Hq;
        private CarAssemblyLine carLine;
        private MinibusAssemblyLine minibusLine;
        private Spraybooth spraybooth;
        string black ;
        string white ;
        private bool isCarProcessing = false;
        private bool isMinibusProcessing = false;
        public Form1()
        {
            InitializeComponent();
            Hq = new CorporateHQ();
            carLine = new CarAssemblyLine();
            minibusLine = new MinibusAssemblyLine();
            spraybooth = Spraybooth.GetInstance();


            spraybooth.OnSprayStatusUpdate += (statusText) =>
            {
                UpdateUI(lblSprayboothStatus, statusText);
            };
            Spraybooth.GetInstance().OnSprayStatusUpdate += (statusText) =>
            {
                UpdateUI(lblSprayboothStatus, statusText);
            };


            black = "black";
            white = "white";


            lblCarStatus.Text = "Idle";
            lblMinibusStatus.Text = "Idle";
            lblSprayboothStatus.Text = "Idle";

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(rbnBlackLux.Checked || rbnWhiteLux.Checked)
            {
                string color = rbnBlackLux.Checked ? black : white;
                ICommand command = new CarCommand(carLine, color);

                Hq.SetOrder(command, "car");
                UpdateQueueLabels();
                
                if (!isCarProcessing)
                {
                    isCarProcessing = true;
                    Task.Run(() => ProcessCarQueue());
                }
            }

            if (rbnBlackMv.Checked || rbnWhiteMv.Checked)
            {
                string color = rbnBlackMv.Checked ? black : white;
                ICommand command = new MinibusCommand(minibusLine, color);

                Hq.SetOrder(command, "minibus");
                UpdateQueueLabels();

                if (!isMinibusProcessing)
                {
                    isMinibusProcessing = true;
                    Task.Run(() => ProcessMinibusQueue());
                }
            }
        }
        private void UpdateUI(Label lbl, string message)
        {
            if (lbl.InvokeRequired)
            {
                lbl.Invoke(new Action(() => lbl.Text = message));
            }
            else
            {
                lbl.Text = message;
            }
        }
        private async Task ProcessCarQueue()
        {
            while(Hq.carQue.Count  > 0)
            {
                ICommand cmd = Hq.carQue.Dequeue();
                UpdateQueueLabels();

                Car car = (Car)carLine.AssembleAutomobile(((CarCommand)cmd).color);
                car.OnStatusUpdate += (status) => UpdateUI(lblCarStatus, status);

                await car.AssembleCar();
                
                UpdateUI(lblCarStatus, "Idle");

                await Hq.RouteToSpraybooth(car);
                

            }
            isCarProcessing = false;
        }
        private async Task ProcessMinibusQueue()
        {
            while (Hq.miniBusQue.Count > 0)
            {
                ICommand cmd = Hq.miniBusQue.Dequeue();
                UpdateQueueLabels();

                Minibus bus = (Minibus)minibusLine.AssembleAutomobile(((MinibusCommand)cmd).color);
                bus.OnStatusUpdate += (status) => UpdateUI(lblMinibusStatus, status);

                await bus.AssembleMiniBus();
               
                UpdateUI(lblMinibusStatus, "Idle");

                await Hq.RouteToSpraybooth(bus);
            }
            isMinibusProcessing = false;
        }
        private async Task ProcessSprayBooth(Automobile vehicle, int duration)
        {
            UpdateUI(lblSprayboothStatus, $"Painting {vehicle.Model} {vehicle.GetColor()}....");

            Thread.Sleep(duration);

            UpdateUI(lblSprayboothStatus, "Idle");
        }
        private void UpdateQueueLabels()
        {
            UpdateUI(lblCar, $"Orders: {Hq.carQue.Count}");
            UpdateUI(lblMinibus, $"Orders: {Hq.miniBusQue.Count}");
        }
       
    }
}
