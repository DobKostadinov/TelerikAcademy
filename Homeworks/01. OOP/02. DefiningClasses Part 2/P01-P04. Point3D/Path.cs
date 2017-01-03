namespace P01_P04.Point3D
{
    using System.Collections.Generic;

    public class Path
    {
        private IList<Point3D> points;

        public Path()
        {
            this.Points = new List<Point3D>();
        }

        public IList<Point3D> Points
        {
            get { return this.points; }
            private set { this.points = value; }
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }
    }
}
