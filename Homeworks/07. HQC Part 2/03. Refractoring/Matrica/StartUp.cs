using GameFifteen.Models;
using System;

namespace Task3
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = 6;
            MatrixWalk.StartMatrixWalk(n, new ConsoleLogger());
        }
    }
}
