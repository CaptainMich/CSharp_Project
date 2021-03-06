﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class GSM
    {
        private string model = null;
        private string manufacturer = null;
        private decimal price = 0;
        private string owner = null;
        public Battery battery;                             // set to public just for unit test purpose
        public Display display;                             // set to public just for unit test purpose
        public List<Call> callHistory = new List<Call>();   // set to public just for unit test purpose
        static GSM samsungGalaxyS7;

        public string Model
        {
            get { return model; }
            private set { model = value; }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            private set { manufacturer = value; }
        }
        public decimal Price
        {
            get { return price; }
            private set
            {
                if (value >= 0)
                    price = value;
                else
                    throw new ArgumentOutOfRangeException("Invalid Argument: Price must be a positive number");
            }
        }
        public string Owner
        {
            get { return owner; }
            private set { owner = value; }
        }
        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }

        public GSM(string model, string manufacturer, decimal price, string owner, string batteryModel,
            double batteryIdleTime, double batteryHoursTalk, BatteryType batteryType, double displaySize,
            uint displayColors)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            battery = new Battery(batteryModel, batteryIdleTime, batteryHoursTalk, batteryType);
            display = new Display(displaySize, displayColors);
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner, battery.Model, battery.IdleTime, battery.HoursTalk, battery.Type, display.Size, display.Colors) { }

        public GSM(string model, string manufacturer, decimal price, string owner, string batteryModel, double batteryIdleTime, double batteryHoursTalk)
            : this(model, manufacturer, price, owner, batteryModel, batteryIdleTime, batteryHoursTalk, 0, 0, 0) { }

        public GSM(string model, string manufacturer, decimal price, string owner, double displaySize, uint displayColors)
            : this(model, manufacturer, price, owner, null, 0, 0, 0, displaySize, displayColors) { }

        public GSM(string model, string manufacturer, decimal price, string owner, double batteryHoursTalk, BatteryType batteryType)
            : this(model, manufacturer, price, owner, null, 0, batteryHoursTalk, batteryType, 0, 0) { }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer, price, owner, null, 0, 0, 0, 0, 0) { }

        public GSM(string model, string manufacturer, decimal price)
          : this(model, manufacturer, price, null, null, 0, 0, 0, 0, 0) { }

        static GSM()
        {
            samsungGalaxyS7 = new GSM("GalaxyS7", "Samsung", 519.90m, "Mr.Robot", new Battery(null, 217.40, 22, BatteryType.LiPo), new Display(5.1, 167000000));
        }

        public override string ToString()
        {
            const string fullInfo = "Model: {0}\nManufacturer: {1}\nPrice: {3:c}\nOwner: {4}\n";
            return string.Format(fullInfo, model, manufacturer, price, owner) +
                                    "\t" + battery.ToString() +
                                    "\t\t" + display.ToString();
        }


        // add several method to manage Call
        public void AddCall(int duration)
        {
            Call incomingCall = new Call(duration);
            callHistory.Add(incomingCall);
        }

        // ----------------------------------------------------------
        public void RemoveCallByDay(DateTime day)
        {
            callHistory.RemoveAll(call => call.Date == day);
        }

        // ----------------------------------------------------------
        public void RemoveCallByDuration(int duration)
        {
            callHistory.RemoveAll(call => call.CallDuration == duration);
        }

        // ----------------------------------------------------------
        public void DeleteAllCall()
        {
            callHistory.Clear();
        }

        // ----------------------------------------------------------
        public decimal GetCallPrice(decimal ppm) // where ppm = price per minute
        {
            decimal totalAmount = 0;
            foreach (Call call in callHistory)
            {
                totalAmount += (decimal)(call.CallDuration) * ppm;
            }

            return totalAmount;
        }
    }
}
