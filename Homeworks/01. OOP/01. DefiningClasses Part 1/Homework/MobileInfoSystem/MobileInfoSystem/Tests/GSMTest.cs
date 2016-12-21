namespace MobileInfoSystem
{
    using System;
    using System.Collections.Generic;
    using MobileInfoSystem.Enums;

    public class GSMTest
    {
        public static void TestingGsmClass()
        {
            var collectionOfGSM = new List<GSM>();

            var htc = new GSM(
                "One",
                "HTC",
                1555,
                "Bai Ivan",
                new Battery(
                    "OOPG2",
                    BatteryType.NiCd,
                    10,
                    2000),
                new Display(
                    "AO111C", 
                    10));

            var samsung = new GSM(
                "Galaxy S7",
                "Samsung",
                2000,
                "James",
                new Battery(
                    "OUDG3",
                    BatteryType.LiIon,
                    2,
                    3000),
                new Display(
                    "HtRy4",
                    22));

            var huawei = new GSM(
                "P9",
                "Huawei",
                3000,
                "Mike",
                new Battery(
                    "FFG3",
                    BatteryType.NiMH,
                    1,
                    3989),
                new Display(
                    "TG6&",
                    32));

            collectionOfGSM.Add(htc);
            collectionOfGSM.Add(samsung);
            collectionOfGSM.Add(huawei);

            foreach (var gsm in collectionOfGSM)
            {
                Console.Write(gsm.ToString());
            }

            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
