using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread3
{
    class Program
    {
        // a thread of its own
        static void Main(string[] args)
        {
            Thread t = new Thread(() => WriteChar("y"));
            // run the thread
            t.Start(); // provide argument for thread at start 

            // main wait till t finishes before continuing
            //t.Join();
            WriteChar("x");

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }

        static void WriteChar(string ch)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(ch);
            }
        }
    }
}
