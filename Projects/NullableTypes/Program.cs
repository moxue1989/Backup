using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? number = 20;
            int? nullNumber = null;
            int value = 0;
            try
            {
                //int value = nullNumber.Value;
                //int value = (int) nullNumber;
                //int value2 = (int) number;
                value = nullNumber ?? -1;
                Console.WriteLine(value);

                value = number ?? -1;
                Console.WriteLine(value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType() + ex.Message);
            }

            bool? flag = null;
            if (flag ?? true)
            Console.WriteLine(flag);

            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();

            string mystr = "daa";
        }
    }
}
