/* TimeConversion.cs
 * 
 * TimeConversion class for Project A
 * 
 * Revision History
 *      Jaden Ahn, 2018-03-21: Created
 *                             Added ModifyInputStub and deleted ModifyInput
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
            double multiplier = GetMultiplierStub(ModifyInputStub(convertFrom), ModifyInputStub(convertTo));
            return value * multiplier;
        }
        private static string ModifyInputStub(string input)
        {
            return "s";
        }

        private static double GetMultiplierStub(string convertFrom, string convertTo)
        {
            return 2.0;
        }
    }
}
