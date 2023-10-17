using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shapes
    {
        private int width; // Ширина
        private int height; // Высота

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public double Perimeter() => 2 * (width + height);

        public double Area() => height * width;


    }
}
