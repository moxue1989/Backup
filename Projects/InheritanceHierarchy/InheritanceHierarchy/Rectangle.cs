using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHierarchy
{
    public class Rectangle
    {
        private double height, width;

        public Rectangle()
        {

        }

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double CalculateArea()
        {
            return height * width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (height + width);
        }
    }
}
