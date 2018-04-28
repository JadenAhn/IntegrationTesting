/* TimeConversion.cs
 * 
 * TimeConversion class for Project B
 * 
 * Revision History
 *      Jaden Ahn, 2018-03-21: Created
 *                             Added GetMultiplierStub and deleted GetMultiplier
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    public static class TimeConversion
    {
        public static double Convert(double value, string convertFrom, string convertTo)
        {
            double multiplier = GetMultiplierStub(ModifyInput(convertFrom), ModifyInput(convertTo));
            return value * multiplier;
        }

        private static double GetMultiplierStub(string convertFrom, string convertTo)
        {
            return 2.0;
        }

        private static string ModifyInput(string input)
        {
            string result = "";

            switch (input)
            {
                case "seconds":
                case "Seconds":
                case "s":
                case "S":
                    result = "seconds";
                    break;
                case "minutes":
                case "Minutes":
                case "m":
                case "M":
                    result = "minutes";
                    break;
                case "hours":
                case "Hours":
                case "h":
                case "H":
                    result = "hours";
                    break;
                case "days":
                case "Days":
                case "d":
                case "D":
                    result = "days";
                    break;
                default:
                    throw new ArgumentException("Incorrect time unit");
            }

            return result;
        }
    }
}
