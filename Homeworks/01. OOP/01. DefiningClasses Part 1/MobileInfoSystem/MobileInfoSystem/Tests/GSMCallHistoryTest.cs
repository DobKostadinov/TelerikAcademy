namespace MobileInfoSystem
{
    using System;
    using System.Linq;
    using MobileInfoSystem.Enums;

    public class GSMCallHistoryTest
    {
        public static void TestingCallHistory()
        {
            Console.WriteLine("----Problem 8, 9, 10----");

            var gsm = new GSM("HH", "Nokia", 199, "Az", new Battery("JJY", BatteryType.LiIon, 7, 10), new Display("JHYUIS", 24));
            gsm.AddCall(new Call(DateTime.Now, "+35976567889", 30));
            gsm.AddCall(new Call(DateTime.Now.AddHours(-7), "+359896787865", 539));
            gsm.AddCall(new Call(DateTime.Now.AddHours(-7), "+359896733365", 223));

            // Print info about the calls
            Console.WriteLine("Calls info");
            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine(call.ToString());
            }

            // Calculate the price for total call duration
            var priceForPaying = GSM.CalculateTotalAmountForCalls(gsm.CallHistory, 0.37);
            Console.WriteLine($"\nPrice for paying: {priceForPaying} $");

            // Find the longest call by using linq extensions
            Call longestCall = gsm.CallHistory.OrderByDescending(x => x.Duration).First();

            gsm.CallHistory.Remove(longestCall);

            var priceForPayingAfterRemovingTheLongest = GSM.CalculateTotalAmountForCalls(gsm.CallHistory, 0.37);
            Console.WriteLine($"Price for paying after removing the longest call: {priceForPayingAfterRemovingTheLongest} $");

            gsm.ClearCallHistory();
        }
    }
}
