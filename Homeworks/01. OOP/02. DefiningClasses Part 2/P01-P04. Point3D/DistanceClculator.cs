namespace P01_P04.Point3D
{
    using System;

    static class DistanceClculator
    {
        public static double CalulateDistance(Point3D pointA, Point3D pointB)
        {
            double distance = Math.Sqrt((pointA.X - pointB.X) * (pointA.X - pointB.X) +
                                (pointA.Y - pointB.Y) * (pointA.Y - pointB.Y) +
                                (pointA.Z - pointB.Z) * (pointA.Z - pointB.Z));

            return distance;
        }
    }
}
