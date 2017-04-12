using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            Circle shape1 = new Circle(5);
            Circle circle1 = new Circle(1);
            Rectangle rec1 = new Rectangle(2, 3);

            //Shape2D[] shapes = new Shape2D[3];
            //shapes[0] = shape1;
            //shapes[1] = circle1;
            //shapes[2] = rec1;

            object[] shapestest = { shape1, circle1, rec1 };
            Hashtable hashlists = new Hashtable();
            List<string> tables = new List<string>();


            foreach (object shape in shapestest)
            {
                Type type = shape.GetType();
                //var temp = Activator.CreateInstance(type, new Object[] { });
                //temp = shape;
                var oldlisttype = typeof(List<>);
                
                if (!tables.Contains(type.ToString()))
                {
                    tables.Add(type.ToString());
                    Console.WriteLine("adding " + type + " of list");
                    var temp = Activator.CreateInstance(oldlisttype, new Object[] { });
                               
                }
                //hashlists[type]

                //MethodInfo addMethod = oldlisttype.GetMethod("Add");              
                //addMethod.Invoke(hashlists[type], new Object[] { temp });
                //Console.WriteLine("adding item to " + type + " list");

                Console.WriteLine(oldlisttype);
                MethodInfo method = type.GetMethod("CalculateArea");
                Console.WriteLine("Shape " + i + " area: " + method.Invoke(shape, null));               
                i++;
            }

            Console.WriteLine("Press Key...");
            Console.ReadKey();
        }
    }
}
