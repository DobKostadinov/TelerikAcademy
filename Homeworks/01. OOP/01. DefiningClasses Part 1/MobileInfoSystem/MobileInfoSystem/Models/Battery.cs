namespace MobileInfoSystem
{
    using System.Text;
    using MobileInfoSystem.Enums;

    public class Battery
    {
        private string model;
        private int idleHours;
        private int hoursTalk;
        private BatteryType type;

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, BatteryType type, int idleHours = 0, int hoursTalk = 0)
            : this(model)
        {
            this.Type = type;
            this.IdleHours = idleHours;
            this.HoursTalk = hoursTalk;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int IdleHours
        {
            get { return this.idleHours; }
            set { this.idleHours = value; }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();

            stb.AppendLine($"-Battery-");
            stb.AppendLine($"Model: {this.Model}");

            if (this.IdleHours != 0)
            {
                stb.AppendLine($"Idle hours: {this.IdleHours}");
            }

            if (this.HoursTalk != 0)
            {
                stb.Append($"Hours of talk: {this.HoursTalk}");
            }

            return stb.ToString();
        }
    }
}