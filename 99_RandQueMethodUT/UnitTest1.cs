using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _99_RandQueMethodUT
{
    public static void FillQueue(Queue<string>)
    {
        //Queue<string> firstInFirstOut = new Queue<string>();
        firstInFirstOut.Enqueue("I'm first!");
        firstInFirstOut.Enqueue("I'm next");
        //string firstItem = firstInFirstOut.Dequeue();
        //return firstInFirstOut;
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            Queue<string> firstInFirstOut = new Queue<string>();
            FillQueue(firstInFirstOut);
            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);


        }
    }
}
