using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IConsole console = new RealConsole();
            // create an instance of ProgramUI so we can execute the Run method
            ProgramUI ui = new ProgramUI(console);
            ui.Run();
        }
    }
}
