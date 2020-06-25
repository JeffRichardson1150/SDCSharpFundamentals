using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _99_ReferenceTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare 5-10 variables
            // Initialize at least 5 of them. You cannot have more than 2 of any type.
            // Bonus: If you finish that make an enum. 
            // Console Writeline all initialized values
            int integerVar = 2;
            double doubleVar = 252.23d;
            decimal decimalVar = 39392.323m;
            char charVar = 'j';
            string stringVar = "Jeff";
            bool booleanVar = true;
            //enum MusicType { Jazz, Blues, Rock, ClassicRock, Zydeco, Polka, Reggae, Classical };
            //MusicType favoriteMusic = MusicType.Blues;
            string[] stringArray = { "Indiana", "Illinois", "Ohio", "Michigan", "Iowa", "Kentucky" };
            stringArray[4] = "Wisconsin";
            int[] intArray = { 50, 100, 150, 200, 250, 300 };
            List<string> listOfStrings = new List<string>();
            listOfStrings.Add("Cap'n Crunch");
            listOfStrings.Add("Frosted Flakes");
            listOfStrings.Add("Fruit Loops");
            Queue<string> queueOfStrings = new Queue<string>();
            queueOfStrings.Enqueue("Naked Gun");
            queueOfStrings.Enqueue("Naked Gun 2 1/2");

            Console.WriteLine(integerVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(booleanVar);
            foreach (string stringValue in stringArray)
                {
                Console.WriteLine(stringValue);
                }
            foreach (string stringValue in listOfStrings)
            {
                Console.WriteLine(stringValue);
            }

            Console.ReadKey();

            // Reference Type -(Possible topic - Amazon Shipping)
            // Composite -
            // Print to the console a welcome message, a spam email, and a random sentence that reuses the value of one of your strings more than once.
            // Bonus - use the following string in all of the above.	
            // string color = “gold”;
            // string welcomeMessage = *use composite to form string*
            // Console.WriteLine(welcomeMessage);

            string customerTitle = "Mr.";
            string customerLastName = "Richardson";

            string concatenatedMsg = "Hello, " + customerTitle + " " + customerLastName + ". Welcome to C#.";
            string compositeMsg = string.Format("Hello, {0} {1}. Welcome to C#.", customerTitle, customerLastName);
            string interpolatedMsg = $"Hello, {customerTitle} {customerLastName},Welcome to C#.";


            Console.WriteLine(concatenatedMsg);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(compositeMsg);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(interpolatedMsg);

            Console.ReadKey();

            // Make a List<> that holds the first 6 fruits you can think of. 
            // Bonus - order them alphabetically
            // Bonus - add them all at the same time.


        }
    }
}
