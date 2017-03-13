namespace BoolConversionMain
{
    using System;

    public class BoolConvertor
    {
        const int MaxCount = 6;

        public void ConvertBoolToString(bool boolForConversion)
        {
            string convertedBool = boolForConversion.ToString();

            Console.WriteLine(convertedBool);
        }
    }
}
