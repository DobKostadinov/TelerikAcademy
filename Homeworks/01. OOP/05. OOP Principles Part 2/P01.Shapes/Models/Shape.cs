using P01.Shapes.Common;

namespace P01.Shapes.Models
{
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            set
            {
                Validator.NonNegativeNumbersValidation(value, "Width");

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                Validator.NonNegativeNumbersValidation(value, "Height");

                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
