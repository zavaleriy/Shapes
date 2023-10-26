using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Pyramid : Triangle
    {
        private readonly double height;

        public Pyramid(double height, double side1, double side2, double side3)
            : base(side1, side2, side3)
        {
            this.height = height;
        }

        public override void Out() => Console.WriteLine($"Площадь пирамиды: {Math.Round(CalcArea(),2)}\n" +
            $"Объем: {Math.Round(Volume(), 2)}");

        private double CalcArea() => Area();

        private double Volume() => (double)1 / 3 * Area() * height;




    }
}
