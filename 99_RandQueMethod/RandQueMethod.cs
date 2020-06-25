using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_RandQueMethod
{
    // This project isn't practical but shows how to
    //   > pass a queue to a method to up updated and then use it in the Main
    //   > use the Random method
    class RandQueMethod
    {
        static void Main(string[] args)
        {
            Queue<string> firstInFirstOut = new Queue<string>();
            FillQueue(firstInFirstOut);

            string customerTitle = "Mr.";
            string customerLastName = "Richardson";


            // string interpolatedMsg = $"Hello, {customerTitle} {customerLastName}, Please stop {doing} {whos} {what}. We've received too many complaints.";


            string interpolatedMsg = $"Hello, {customerTitle} {customerLastName}, Please stop {firstInFirstOut.Dequeue()} {firstInFirstOut.Dequeue()} {firstInFirstOut.Dequeue()}. We've received too many complaints.";

            Console.WriteLine(interpolatedMsg);
            Console.ReadKey();
        }

        public static void FillQueue(Queue<string> stringQueue)
        {
            // arrays of possible actions, with who's what, what you're doing it with.
            string[] doingArray = { "eating", "wearing", "sucking on", "sleeping with", "smelling" };
            string[] whosArray = { "my", "your mother's", "Megan Fox's", "Joe Biden's", "Bill Burr's", "your grandma's" };
            string[] whatArray = { "red solo cup", "underwear", "broken tooth", "dandruff", "stinky shoe" };

            // Select a random number for each array. Specify a max number that is 1 more than the length of the array
            Random doingNbr = new Random();
            int randomDoing = doingNbr.Next(6);
            Random whosNbr = new Random();
            int randomWhos = whosNbr.Next(7);
            Random whatNbr = new Random();
            int randomWhat = whatNbr.Next(7);

            // pull the indexed item out of the array and push it onto the queue
            stringQueue.Enqueue(doingArray[randomDoing]);
            stringQueue.Enqueue(whosArray[randomWhos]);
            stringQueue.Enqueue(whatArray[randomWhat]);

        }

    }
}
