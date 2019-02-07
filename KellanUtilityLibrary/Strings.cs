using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace KellanUtilityLibrary
{
    public class Strings
    {
        public static bool ValidPhoneNumber(string phoneNumber)
        {
            Regex regex = new Regex(@"^(\d{3}-)?\d{3}-\d{4}");
            var match = regex.IsMatch(phoneNumber);
            return match;
        }

        public static bool ValidZipCode(string zipCode)
        {
            Regex regex = new Regex(@"^(\d{5})(-)?(\d{4})?");
            var match = regex.IsMatch(zipCode);
            return match;
        }

        public static bool EqualIgnoreCase(string strA, string strB)
        {
            var result = string.Compare(strA.ToUpper(), strB.ToUpper());
            bool returnResult;
            if (result == 0)
            {
                returnResult = true;
            }
            else
            {
                returnResult = false;
            }
            return returnResult;
        }
    }
}
