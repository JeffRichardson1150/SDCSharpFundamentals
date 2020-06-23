using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Loop
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total += 1;  // total = total + 1
            }

            total = 0;
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("You did it");
                    break;
                }
                total++;  // total = total + 1;
            }

            Random rand = new Random();
            int someCount;
            bool keepLooping = true;
            while (keepLooping)
            {
                someCount = rand.Next(0, 20);  // pick a number ( >= 0 && < 20 )

                if (someCount == 6 || someCount == 10)
                {
                    Console.WriteLine("continue with someCount = " + someCount);
                    continue;  // skip what follows; loop again
                }
                Console.WriteLine(someCount);
                if (someCount == 15)
                {
                    Console.WriteLine("We're gonna stop looping with someCount = " + someCount);
                    keepLooping = false;
                }
            }


            // For Loops
            int studentCount = 21;
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Nick", "Adam", "AJ", "Austin", "Severa", "Tim" };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Hello there! " + students[i]);
            }


            // For Each Loop
            foreach (string student in students)
            {
                Console.WriteLine(student + " is in the class today");
            }

            string myName = "Amanda Joy Knight";
            foreach(char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }


            // Do While Loop - always executes at least once; it doesn't check the condition until after the first iteration
            int iterator = 8;
            do
            {
                Console.WriteLine("Hello! " + iterator);
                iterator++;
            }
            while (iterator < 5);

            Console.ReadKey();
        }
    }
}
