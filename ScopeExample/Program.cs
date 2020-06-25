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
        int c1 = 5;
        public void Main(string[] args)
        {
            int m1 = 10;
            c1 = 10;
            m2 = 10;   // ERROR - out of scope
        }
        public void Second(string[] args)
        {
            int m2 = 20;
            m1 = 20;   // ERROR - out of scope
            c1 = 20;
        }
        c1 = 30;   // ERROR - out of scope ==>> this is a problem with doing an assignment in the Class; not a scope problems
        m1 = 30;   // ERROR - out of scope
        m2 = 30;   // ERROR - out of scope

    }
}
