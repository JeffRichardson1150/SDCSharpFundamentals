using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        // Let's create a method
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double AddTwoNumbers(double one, double two)
        {
            double sum = one + two;
            return sum;
        }

        private int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }

        [TestMethod]
        // 1) Access Modifier (public) : who is able to access
        // 2) Return Type (void) : it's not returning anything (otherwise it will be a type of the return)
        // 3) Method Signature (TestMethod1) : the method name and parameters
        // 4) Body (between the squigly brackets)
        public void MethodExecution()
        {
            // We can directly reference the SayHello method because we're still in the scope of the class (TestClass)
            SayHello("Jeff");
            SayHello("Krista");

            int inputOne = 7;
            int inputTwo = 12;
            int sum = AddTwoNumbers(inputOne, inputTwo);
            Console.WriteLine(sum);
            double doubleSum = AddTwoNumbers(242.2d, 234.5d);

            int myAge = CalculateAge(new DateTime(1892, 11, 24));
            Console.WriteLine("My age is: " + myAge);
        }
    }
}
