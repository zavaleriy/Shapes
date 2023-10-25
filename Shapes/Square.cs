using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shape
    {
        protected private readonly float width; // Ширина

        public Square(float width)
        {
            this.width = width;
        }

        public new void Out() => Console.WriteLine($"Периметр квадрата: {Perimeter(width)}\n" +
            $"Площадь квадрата: {Area(width)}");

        protected float Perimeter(float width) => 4 * width;

        protected float Area(float width) => width * width;


    }
}
