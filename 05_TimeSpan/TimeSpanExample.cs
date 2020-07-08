using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_TimeSpan
{
    class TimeSpanExample
    {
        static void Main(string[] args)
        {
            DateTime birthday = new DateTime(1962, 10, 19);

            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            Console.WriteLine(years);

            Console.ReadKey();
        }
    }
}
