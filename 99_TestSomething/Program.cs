using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _99_TestSomething
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 3;

            double adouble = Convert.ToDouble(a);
            double bdouble = Convert.ToDouble(b);

            double quotient = a / b;
            double quotientDouble = adouble / bdouble;

            Console.WriteLine(quotient);
            Console.WriteLine(quotientDouble);

            Console.ReadLine();
        }
    }
}
