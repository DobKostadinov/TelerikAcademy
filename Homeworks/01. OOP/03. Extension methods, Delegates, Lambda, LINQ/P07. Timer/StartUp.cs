namespace P07.Timer
{
    public class StartUp
    {
        static void Main()
        {
            Timer timer = new Timer(1);
            timer.InvokeDelegate();
        }
    }
}
