namespace MobileInfoSystem
{
    using System;

    public class Call
    {
        private DateTime date;
        private string dialledNum;
        private ushort duration;

        public Call(DateTime date, string dialledNum, ushort duration)
        {
            this.Date = date;
            this.DialledNum = dialledNum;
            this.Duration = duration;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        public string DialledNum
        {
            get
            {
                return this.dialledNum;
            }

            set
            {
                this.dialledNum = value;
            }
        }

        public ushort Duration
        {
            get
            {
                return this.duration;
            }

            set
            {
                this.duration = value;
            }
        }

        public override string ToString()
        {
            return string.Format($"Date and time: {this.Date:G}; " + $"\nDuration: {this.Duration} seconds;" + $"\nDialed number: {this.DialledNum}");
        }
    }
}
