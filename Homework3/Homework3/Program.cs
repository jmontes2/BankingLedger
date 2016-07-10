using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main()
        {
            int secsDay    = 86400;
            int secsHour   = 3600;
            int secsMinute = 60;
            int Days       = 0;
            int Hours      = 0;
            int Minutes    = 0;

            // Accept number of seconds from user
            Console.Write("Enter the number of seconds: ");
            int numSeconds = int.Parse(Console.ReadLine());

            // Convert seconds entered into Days, Hours, Minutes and Seconds
            int remainder = numSeconds;
            if (numSeconds >= secsDay) {    // At least 1 day
                Days = Math.DivRem(numSeconds, secsDay, out remainder);
                numSeconds = remainder;
            }
            if (numSeconds >= secsHour) {   // At least 1 hour
                Hours = Math.DivRem(numSeconds, secsHour, out remainder);
                numSeconds = remainder;
            }
            if (numSeconds >= secsMinute) { // At least 1 minute
                Minutes = Math.DivRem(numSeconds, secsMinute, out remainder);
                numSeconds = remainder;
            }
            Console.WriteLine("Days: {0}, Hours: {1}, Minutes: {2}, Seconds: {3}", Days, Hours, Minutes, numSeconds);
            Console.ReadLine();
        }
    }
}
