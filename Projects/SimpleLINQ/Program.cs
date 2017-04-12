using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = {2.5, 3.7, 5.9, 1.3, 0, -2.5}; // data source

            // define the query (get non negative numbers in desc order)
            var sampleNumbers = from element in numbers
                where element >= 0
                orderby element descending
                select element;

            // execute the query
            foreach (var num in sampleNumbers)
            {
                Console.WriteLine(num);
            }




            Console.ReadKey();
        }
    }
}
