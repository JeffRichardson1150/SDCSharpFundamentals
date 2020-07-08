using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_ConvertStringToNumbers
{
    class ConvertString
    {
        static void Main(string[] args)
        {
            // Cast a double as a decimal
            double dbl = 1.2345D;
            decimal dec = (decimal)dbl;
            Console.WriteLine(dec);

            // Convert using Convert methods
            decimal stringToDecimal = Convert.ToDecimal("100.123456789012345");
                Console.WriteLine("decimal " + stringToDecimal);
            float stringToFloat = Convert.ToSingle("100.123456789012345");
                Console.WriteLine("stringToFloat " + stringToFloat);
            double stringToDouble = Convert.ToDouble("100.123456789012345");
                Console.WriteLine("stringToDouble " + stringToDouble);
            short stringToShort = Convert.ToInt16("-32768");
                Console.WriteLine("stringToShort " + stringToShort);
            int stringToInt = Convert.ToInt32("-2147483648");
                Console.WriteLine("stringToInt " + stringToInt);
            long stringToLong = Convert.ToInt64("-9223372036854775808");
                Console.WriteLine("stringToLong " + stringToLong);
            ushort stringToUshort = Convert.ToUInt16("32768");
                Console.WriteLine("stringToUshort " + stringToUshort);
            uint stringToUint = Convert.ToUInt32("2147483647");
                Console.WriteLine("stringToUint " + stringToUint);
            ulong stringToUlong = Convert.ToUInt64("9223372036854775807");
                Console.WriteLine("stringToUlong " + stringToUlong);


            // Convert using Parse methods
            string l = "10";
            int length = Int32.Parse(l);
            Console.WriteLine(length);

            // I don't have all the "using"s for NumberStyles, 
            //  int parsed;
            //  parsed = Int16.Parse("100"); // returns 100
            //  Console.WriteLine(parsed);
            //  parsed = Int16.Parse("(100)", NumberStyles.AllowParentheses); // returns -100
            //   Console.WriteLine(parsed);

            //   parsed = int.Parse("30,000", NumberStyles.AllowThousands, new CultureInfo("en-au"));// returns 30000
            //   Console.WriteLine(parsed);
            // parsed = int.Parse("$ 10000", NumberStyles.AllowCurrencySymbol); //returns 10000
            // Console.WriteLine(parsed);
            // parsed = int.Parse("-100", NumberStyles.AllowLeadingSign); // returns -100
            // Console.WriteLine(parsed);
            // parsed = int.Parse(" 100 ", NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite); // returns 100
            // Console.WriteLine(parsed);

            // parsed = Int64.Parse("2147483649"); // returns 2147483649
            // Console.WriteLine(parsed);

            Console.ReadKey();
        }
    }
}
