using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shapes
    {
        private int width; // Ширина

        public Square(int width)
        {
            this.width = width;
        }

        public double Perimeter() => 4 * width;

        public double Area() => width * width;


    }
}
