using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread2
{
     public class ThreadTest
    {
        private bool done = false;
        public void Go()
        {
            if (!done)
            {
                Console.WriteLine("done");
                Thread.Sleep(1000); // sleeps for a second
                done = true;
            }
        }
    }
}
