namespace Abstraction
{
    using System;

    using Contracts;

    class FiguresExample
    {
        public static void Main()
        {
            IFigure circle = new Circle(5.0);
            Console.WriteLine(circle);

            IFigure rectangle = new Rectangle(10.2, 5.2);
            Console.WriteLine(rectangle);
        }
    }
}
