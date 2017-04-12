using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExprDemo
{

    class Program
    {
        delegate void TestDelegate(int[] ar); // defines type that can store reference to a local function
        static void Main(string[] args)
        {
            int[] myNums = { 5, 2, 7, 9, 10, 4 };
            TestDelegate BumpUp = ar => { for(int i = 0; i< ar.Length; i++) ar[i]++; }; // statement lambda

            Console.WriteLine("Unsorted numbers:\n");
            PrintArray(myNums);

            Sort(myNums);
            Console.WriteLine("\nSorted numbers:\n");
            PrintArray(myNums);

            Console.WriteLine("\nIncrementing elements of the array:");
            BumpUp(myNums);
            PrintArray(myNums);

            Console.WriteLine("\nPress akey");
            Console.ReadKey();

        }

        static void Sort(int[] array) => Array.Sort(array);   

        static void PrintArray(int[] array)
        {
            foreach (int el in array) Console.Write(el.ToString() + "\t");
            Console.WriteLine();
        }
    }
}