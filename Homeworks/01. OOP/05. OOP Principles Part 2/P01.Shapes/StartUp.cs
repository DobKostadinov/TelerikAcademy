using P01.Shapes.Models;
using System;
using System.Collections.Generic;

namespace P01.Shapes
{
    public class StartUp
    {
        static void Main()
        {
            List<Shape> figures = new List<Shape>();

            Rectangle rec = new Rectangle(5.5, 2);
            Triangle rigl = new Triangle(4, 8.2);
            Square sqr = new Square(4);

            figures.Add(rec);
            figures.Add(rigl);
            figures.Add(sqr);

            foreach (Shape figure in figures)
            {
                Console.WriteLine(figure.GetType().Name + " with area : " + figure.CalculateSurface());
            }
        }
    }
}
