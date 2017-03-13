namespace Events
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title;
        private string location;

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public string Location { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public int CompareTo(object obj)
        {
            Event objectToCompareAsEvent = obj as Event;

            int byDate = this.Date.CompareTo(objectToCompareAsEvent.date);
            int byTitle = this.Title.CompareTo(objectToCompareAsEvent.title);
            int byLocation = this.Location.CompareTo(objectToCompareAsEvent.location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }

                else
                {
                    return byTitle;
                }
            }

            return byDate;
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();

            stb.Append(this.Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            stb.Append(" | " + this.Title);

            if (string.IsNullOrEmpty(this.Location))
            {
                stb.Append(" | " + this.Location);
            }

            return stb.ToString();
        }
    }
}
