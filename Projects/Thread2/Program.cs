using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread2
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadTest test = new ThreadTest();
            new Thread(test.Go).Start(); // run the new thread
            
            test.Go(); // start own thread

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
