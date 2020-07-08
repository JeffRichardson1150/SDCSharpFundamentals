using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{
    // enums are constants. declare outside of the class (our program). Use PASCAL-casing for naming (all caps)
    // enums generally contain all possible values for the type
    enum PastryType { Cake, Cupcake, Croissant, Donut, Cookie, Scone, Danish };
    class Program
    {
        static void Main(string[] args)
        {
            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false;
            isDeclaredAndInitialized = true;

            char character = 'a';
            char symbol = '&';
            char num = '5';
            char space = ' ';
            char specialCharacter = '\n';  // new line character

            // Whole Numbers
            byte byteExample = 255; // range of byte type is -256 to 255
            sbyte sByteExample = -128; // range of sbyte is -128 to 127
            short shortExample = 32767; // range of short is 32768 to 32767 (?)
            Int16 anotherShortExample = -32768; // Int16 and short are the same
            int intMin = -2147483648;
            Int32 intMAx = 2147483647; // Int32 and int are the same
            long longExample = 9223372036854775807; // 9,223,372,036,854,775,807
            Int64 longMin = -9223372036854775808; // Int64 is the same as long

            // Breakpointing - for debugger - @ LHS (left of the numbers) click & put a red dot on this line for debugger to stop
            // "Start" button will run up to & before this breakpoint.  Step Into executes this line & points to next line.
            int a = 7;
            int b = -7000;

            byte age = 104;

            // Decimal Numbers
            float floatExample = 1.045231f; // float requires an 'f' suffix
            double doubleExample = 1.789053278907036d; // 'd' suffix is optional; defaults to double
            double doubleExample2 = 1.789053278907036;  //  max value of double
            decimal decimalExample = 1.2578907289045789789789789787897m; // 'm' suffix for decimal; this is max value

            Console.WriteLine(1.2578907289045789789789789787897f); // writes 1.257891
            Console.WriteLine(1.2578907289045789789789789787897d); // writes 1.25789072890458
            Console.WriteLine(1.2578907289045789789789789787897m); // writes 1.2578907289045789789789789788

            Console.ReadLine();  // or Console.ReadKey() - what's the difference?

            // Enums
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Donut;

            // Structs - number types are Structs but they have a default of 0 vs null (as with other Structs)
            Int32 numX = 42; // this is a Struct. It defaults to 0
            DateTime today = DateTime.Today; // assign today's date
            DateTime birthday = new DateTime(1962, 10, 19); // new up an instance of DateTime; This has overloads - hover over the () and select ticks or kind / a year, month, day / 

        }
    }
}
