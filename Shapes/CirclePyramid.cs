using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class CirclePyramid : Circle
    {
        private readonly double height;
        private readonly double side;

        public CirclePyramid(double height, double radius)
            : base(radius)
        {
            this.height = height;
            side = Math.Round(Math.Sqrt(height * height + radius * radius), 2);
        }

        public override void Out() => Console.WriteLine($"Образующая: {side}\n" +
            $"Площадь пирамиды: {Math.Round(Area(), 2)}\n" +
           $"Объем: {Math.Round(Volume(), 2)}");

        private new double Area() => Math.PI * radius * (radius + side);
        
        private double Volume() => (double)1 / 3 * Math.PI * radius * radius * height;


    }
}
