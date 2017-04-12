using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prod1 = new Product();
            prod1.Name = "gizmo";
            prod1.Price = 9.99m;
            prod1.Qty = 25;

            Product prod2 = new Product();
            Product prod3 = new Product("Widget", 7.99m);
            DiscountProduct food1 = new DiscountProduct();
            DiscountProduct food2 = new DiscountProduct("box", 7.99m);
            DiscountProduct food3 = new DiscountProduct("box", 7.99m, 24, 10);


            Console.WriteLine(prod1);
            Console.WriteLine(prod2);
            Console.WriteLine(prod3);
            Console.WriteLine(food1);
            Console.WriteLine(food2);
            Console.WriteLine(food3);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
