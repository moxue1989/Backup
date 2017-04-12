using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    enum Seasons {Spring, Summer, Fall, Winter};
    class Program
    {
        const int NR_SEASONS = 4;
        static void Main(string[] args)
        {
            decimal[] sales = new decimal[NR_SEASONS]; // seasonal sales
            decimal totalSales = 0; // total sales in the year
            // for each season collect sales value
            for(Seasons season = Seasons.Spring; season <= Seasons.Winter; season++)
            {
                Console.WriteLine("Enter sales amount in: " + season.ToString());
                sales[(int)season] = Convert.ToDecimal(Console.ReadLine());
                totalSales += sales[(int)season];
            }

            // display values from array sales
            Console.WriteLine("sales for each season are: ");
            for(Seasons season = Seasons.Spring; season <= Seasons.Winter; season++)
            {
                Console.WriteLine(season.ToString() + ": " + sales[(int)season]);
            }
            Console.WriteLine("Total sales in the year: " + totalSales.ToString());
            Console.WriteLine("Press key to continue");
            Console.ReadKey();
        }
    }
}
