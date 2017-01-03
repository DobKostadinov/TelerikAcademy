namespace P01_P04.Point3D
{
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(Path path, string fileName)
        {
            string pathWithFileName = "..//..//" + fileName + ".txt";

            using (StreamWriter sWriter = new StreamWriter((pathWithFileName)))
            {
                foreach (var point in path.Points)
                {
                    sWriter.WriteLine(point);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sReader = new StreamReader(filePath))
            {
                while (sReader.EndOfStream == false)
                {
                    string nextPointTxt = sReader.ReadLine();
                    Point3D nextPoint = Point3D.Parse(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }

            return path;
        }
    }
}
