using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KellanUtilityLibrary;

namespace TestKellanUtilityLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] zips = { "12345", "123456789", "12345-6789" };
            foreach(var zip in zips)
            {
                Console.WriteLine($"{zip} is " + (Strings.ValidZipCode(zip) ? "" : " not ") + "valid");
            }
            
            var phone1 = "322-8888";
            var phone1valid = Strings.ValidPhoneNumber(phone1);
            if (phone1valid)
            {
                Console.WriteLine($"{phone1} is valid.");
            }
            else
            {
                Console.WriteLine($"{phone1} is NOT valid.");
            }

            var phone2 = "513-322-8888";
            var phone2valid = Strings.ValidPhoneNumber(phone2);
            if (phone2valid)
            {
                Console.WriteLine($"{phone2} is valid.");
            }
            else
            {
                Console.WriteLine($"{phone2} is NOT valid.");
            }

            var phone3 = "513-322-888";
            var phone3valid = Strings.ValidPhoneNumber(phone3);
            if (phone3valid)
            {
                Console.WriteLine($"{phone3} is valid.");
            }
            else
            {
                Console.WriteLine($"{phone3} is NOT valid.");
            }

            var zip1 = "45459";
            var zip1Valid = Strings.ValidZipCode(zip1);
            if (zip1Valid)
            {
                Console.WriteLine($"{zip1} is valid.");
            }
            else
            {
                Console.WriteLine($"{zip1} is NOT valid.");
            }

            var zip2 = "454591234";
            var zip2Valid = Strings.ValidZipCode(zip2);
            if (zip2Valid)
            {
                Console.WriteLine($"{zip2} is valid.");
            }
            else
            {
                Console.WriteLine($"{zip2} is NOT valid.");
            }

            var zip3 = "45459-1234";
            var zip3Valid = Strings.ValidZipCode(zip3);
            if (zip3Valid)
            {
                Console.WriteLine($"{zip3} is valid.");
            }
            else
            {
                Console.WriteLine($"{zip3} is NOT valid.");
            }

            var result = Strings.EqualIgnoreCase("ABC", "abc");
            if(result == true)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("NOT Equal");
            }
            Console.ReadKey();
        }
    }
}
