using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            string input;
            double sum = 0d;
            double[] numbers;
            Console.WriteLine("How many elements in array?");
            size = Convert.ToInt32(Console.ReadLine());
            numbers = new double[size];
            // read values
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine("\n Enter value #: " + (i + 1));
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                sum += numbers[i];
            }
            // display numbers
            Console.WriteLine("\n The numbers are");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i].ToString() + "\t");
            }
            Console.WriteLine("\n The average is " + sum/size);
            // display numbers with for each
            foreach(double elem in numbers)
            {
                Console.Write(elem + "\t");
            }

            Console.WriteLine("\n Press any key to continue");
            Console.ReadKey();
        }
    }
}
