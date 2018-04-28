/* TimeConversion.cs
 * 
 * TimeConversion class for Project C
 * 
 * Revision History
 *      Jaden Ahn, 2018-03-21: Created
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
            double multiplier = GetMultiplier(ModifyInput(convertFrom), ModifyInput(convertTo));
            return value * multiplier;
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
        private static double GetMultiplier(string convertFrom, string convertTo)
        {
            double multiplier = 1.0;

            if (convertFrom == "seconds")
            {
                switch (convertTo)
                {
                    case "seconds":
                        multiplier = 1.0;
                        break;
                    case "minutes":
                        multiplier = (1.0 / 60.0);
                        break;
                    case "hours":
                        multiplier = (1.0 / 60.0 / 60.0);
                        break;
                    case "days":
                        multiplier = (1.0 / 60.0 / 60.0 / 24.0);
                        break;
                    default:
                        break;
                }
            }
            else if (convertFrom == "minutes")
            {
                switch (convertTo)
                {
                    case "seconds":
                        multiplier = 60.0;
                        break;
                    case "minutes":
                        multiplier = 1.0;
                        break;
                    case "hours":
                        multiplier = (1.0 / 60.0);
                        break;
                    case "days":
                        multiplier = (1.0 / 60.0 / 24.0);
                        break;
                    default:
                        break;
                }
            }
            else if (convertFrom == "hours")
            {
                switch (convertTo)
                {
                    case "seconds":
                        multiplier = 60.0 * 60.0;
                        break;
                    case "minutes":
                        multiplier = 60.0;
                        break;
                    case "hours":
                        multiplier = 1.0;
                        break;
                    case "days":
                        multiplier = (1.0 / 24.0);
                        break;
                    default:
                        break;
                }

            }
            else if (convertFrom == "days")
            {
                switch (convertTo)
                {
                    case "seconds":
                        multiplier = 24.0 * 60.0 * 60.0;
                        break;
                    case "minutes":
                        multiplier = 24.0 * 60.0;
                        break;
                    case "hours":
                        multiplier = 24.0;
                        break;
                    case "days":
                        multiplier = 1.0;
                        break;
                    default:
                        break;
                }
            }

            return multiplier;
        }
    }
}
