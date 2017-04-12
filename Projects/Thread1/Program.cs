using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread1
{
    class Program
    {
        // a thread of its own
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);
            // run the thread
            t.Start();
            // main wait till t finishes before continuing
            //t.Join();
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }

            t.Join();
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }

        static void WriteY()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("y");
            }
        }
    }
}
