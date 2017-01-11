namespace MobileInfoSystem
{
    using System.Collections.Generic;
    using System.Text;
    using MobileInfoSystem.Enums;

    public class GSM
    {
        private string model;
        private string manufacture;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;

        public GSM(string model, string manufacture)
        {
            this.Model = model;
            this.Manufacture = manufacture;
            this.callHistory = new List<Call>();
        }

        public GSM(string model, string manufacture, double price = 0) 
            : this (model, manufacture)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacture, double price, string owner = null, Battery baterry = null, Display display = null) 
            : this(model, manufacture, price)
        {
            this.Owner = owner;
            this.Battery = baterry;
            this.Display = display;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacture
        {
            get { return this.manufacture; }
            set { this.manufacture = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        public static GSM IPhone4S
        {
            get
            {
                return new GSM("IPhone4S", "Apple", 2000, "Iv", new Battery("GGG000", BatteryType.LiIon), new Display("GGE", 24.2));
            }
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();

            stb.AppendLine($"--GSM--");
            stb.AppendLine($"Model: {this.Model}");
            stb.AppendLine($"Manufacture: {this.Manufacture}");
            
            if (this.Price != 0)
            {
                stb.AppendLine($"Price: {this.Price}");
            }

            if (this.Owner != null)
            {
                stb.AppendLine($"Owner: {this.Owner}");
            }

            if (this.Battery != null)
            {
                stb.AppendLine(this.Battery.ToString());
            }

            if (this.Display != null)
            {
                stb.AppendLine(this.Display.ToString());
            }

            return stb.ToString();
        }

        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public static double CalculateTotalAmountForCalls(List<Call> calls, double pricePerMinute)
        {
            var overallCallDuration = 0;

            foreach (var call in calls)
            {
                overallCallDuration += call.Duration;
            }

            var callsInMinutes = overallCallDuration / 60;
            var finalPrice = callsInMinutes * pricePerMinute;

            return finalPrice;
        }
    }
}
