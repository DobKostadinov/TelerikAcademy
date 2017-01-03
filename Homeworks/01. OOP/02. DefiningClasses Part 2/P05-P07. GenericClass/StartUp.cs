namespace P05_P07.GenericClass
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Tasks 5 to 7:");
            var genericList = new GenericList<int>(2);

            genericList.Add(2);
            genericList.Add(3);

            Console.WriteLine(genericList.ToString());


            genericList.Add(7);
            genericList.RemoveElement(2);
            genericList.Add(7777);

            Console.WriteLine(genericList.ToString());

            var takenElement = genericList.FindElementByIndex(3);

            Console.WriteLine(takenElement);

            genericList.InsertAtPosition(1, 99999999);

            Console.WriteLine(genericList.ToString());
        }
    }
}
