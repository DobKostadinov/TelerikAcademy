namespace P01_P04.Point3D
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D o;

        private double x;
        private double y;
        private double z;

        static Point3D()
        {
            o = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D O
        {
            get { return o; }
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public double Z { get; private set; }

        public override string ToString()
        {
            return string.Format($"X = {this.X}, Y = {this.Y}, Z = {this.Z}");
        }

        public static Point3D Parse(string pointToParse)
        {
            string[] splittedPoint = pointToParse.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Point3D resultPoint = new Point3D(double.Parse(splittedPoint[2]),
                                              double.Parse(splittedPoint[5]),
                                              double.Parse(splittedPoint[8]));
            return resultPoint;
        }
    }
}
