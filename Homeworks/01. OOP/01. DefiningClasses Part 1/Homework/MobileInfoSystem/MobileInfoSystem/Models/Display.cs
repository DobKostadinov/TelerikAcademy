namespace MobileInfoSystem
{
    using System.Text;

    public class Display
    {
        private string model;
        private double size;
        private double numberOfColors;

        public Display(string model)
        {
            this.Model = model;
        }

        public Display(string model, double size = 0, double numberOfColors = 0)
            : this (model)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public double NumberOfColors
        {
            get { return this.numberOfColors; }
            set { this.numberOfColors = value; }
        }

        public override string ToString()
        {
            StringBuilder stb = new StringBuilder();

            stb.AppendLine($"-Display-");
            stb.AppendLine($"Model: {this.Model}");

            if (this.Size != 0)
            {
                stb.AppendLine($"Size: {this.Size}");
            }

            if (this.NumberOfColors != 0)
            {
                stb.AppendLine($"Number of colors: {this.NumberOfColors}");
            }

            return stb.ToString();
        }
    }
}