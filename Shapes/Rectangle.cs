using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Square
    {
        private readonly int height; // Высота

        public Rectangle(int width, int height) 
            : base(width)
        {
            this.height = height;
        }

        public new void Out() => Console.WriteLine($"Периметр прямоугольника: {Perimeter()}\n" +
            $"Площадь прямоугольника: {Area()}");

        private new double Perimeter() => 2 * (width + height);

        private new double Area() => height * width;


    }
}
