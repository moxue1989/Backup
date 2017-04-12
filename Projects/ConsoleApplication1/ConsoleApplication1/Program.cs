using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double num = 1.0 / 3;
            //Console.WriteLine(num.ToString("f3"));

            //double percent = 0.15;
            //percent++;
            //Console.WriteLine("Percent is: " + percent.ToString("p")); // percent format
            //double x = 1.567;
            //int y = (int)Math.Round(x); // no implicit conversion double to int
            //Console.WriteLine(x + " " + y);

            //y = 29;
            //x = y;

            //string numStr = "123458888888888888";
            //long num = Convert.ToInt64(numStr);

            int x = 5, y;
            y = x++;
            Console.WriteLine("x = {1}, y = {0}", x, y);
            
            Console.WriteLine("\n\npress any key to finish");
            Console.ReadKey();
        }
    }
}
