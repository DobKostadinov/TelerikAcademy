namespace _01.Cooking
{
    using System;

    public class CookingMain
    {
        public static void Main()
        {
            var chef = new Chef();
            var bowl = chef.Cook();

            Console.WriteLine(bowl);
        }
    }
}
