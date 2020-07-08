using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _99_ScopeExample
{
    class Program
    {
        int cOne = 5;
        cOne = 30;   // ERROR - out of scope ==>> this is a problem with doing an assignment in the
        public void Main(string[] args)
        {
            Console.WriteLine("hello");
        }
        public void Second(string[] args)
        {
            Console.WriteLine("goodbye");
        }
    }
}
