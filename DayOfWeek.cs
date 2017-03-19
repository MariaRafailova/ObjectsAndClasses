using System;
using System.Globalization;

namespace DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            string dateAsText = Console.ReadLine();

            DateTime date = DateTime.ParseExact(
            dateAsText, "d-M-yyyy",
            CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
