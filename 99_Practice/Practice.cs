using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_Practice
{
    class Practice
    {

		static void stringPrint(string stringOne, string stringTwo)
		{
			Console.WriteLine(stringOne);
		}
		static void Main(string[] args)
        {
			// 1)
			 int intVariable = 3;
			 string stringVariable = "Jeff";
			 DateTime birthday = new DateTime(1962, 10, 19);

				int a = 10;
				int b = 8;
				int difference = a - b;
				Console.WriteLine(difference);


			stringPrint("Happy", "Birthday");

			Console.WriteLine("What are you wearing?");
			string wearing = Console.ReadLine();
			switch (wearing)
		{
			case "suit":
				Console.WriteLine("What a sharp dresser.");
				break;
			case "shorts":
				Console.WriteLine("Yes.It’s hot out.");
				break;
			case "nothing":
				Console.WriteLine("Happy Birthday!");
				break;
			default:
				Console.WriteLine("I’m sure it looks nice.");
				break;
		}
		Console.ReadKey();

		bool happy = true;
		if (happy)
		{
			Console.WriteLine("yay!");
		}
		else
		{
			Console.WriteLine("Don’t worry.");
		}

		Console.WriteLine("What's your annual income?");
		string incomeInput = Console.ReadLine();
		decimal income = Convert.ToDecimal(incomeInput);
		if (income >= 1000 && income <= 10000)
		{
			Console.WriteLine("Between 1000 & 10,000");
		}
		else if (income >= 11000 && income <= 50000)
		{
			Console.WriteLine("Between 11,000 & 50,000");
		}
		else if (income >= 51000 && income <= 100000)
		{
			Console.WriteLine("Between 51,000 & 100,000");
		}
		else
		{
			Console.WriteLine("Less than 1,000 or over 100,000");
		}
		Console.WriteLine(income);

		Console.ReadKey();
        }
    }
}
