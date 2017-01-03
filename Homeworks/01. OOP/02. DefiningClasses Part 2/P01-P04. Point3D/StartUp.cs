namespace P01_P04.Point3D
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Taks 1 to 4:");
            Path test = new Path();

            Point3D point1 = new Point3D(2.1, 1.5, 2.2);
            Point3D point2 = new Point3D(-5, 2, 4);
            Point3D point3 = new Point3D(3, 2, 4);

            test.AddPoint(point1);
            test.AddPoint(point3);

            test.RemovePoint(point3);

            test.AddPoint(point2);

            PathStorage.SavePath(test, "Testing");

            Console.WriteLine("Check your folder in order to see the generated file");
        }
    }
}
