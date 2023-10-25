using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Square
    {
        protected readonly double height; // Высота

        public Rectangle(double width, double height) 
            : base(width)
        {
            this.height = height;
        }

        public override void Out() => Console.WriteLine($"Периметр прямоугольника: {Perimeter(width, height)}\n" +
            $"Площадь прямоугольника: {Area(width, height)}");

        protected double Perimeter(double width, double height) => 2 * (width + height);

        protected double Area(double width, double height) => width * height;


    }
}
