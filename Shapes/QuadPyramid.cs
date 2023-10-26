using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class QuadPyramid : Rectangle
    {
        private readonly double heightPyramid;

        public QuadPyramid(double heightPyramid, double width, double height)
            : base(width, height)
        {
            this.heightPyramid = heightPyramid;
        }

        public override void Out() => Console.WriteLine($"Площадь пирамиды: {Math.Round(CalcArea(), 2)}\n" +
            $"Объем: {Math.Round(Volume(), 2)}");

        private double CalcArea()
        {
            double temp = width * Math.Sqrt(Math.Pow(height / 2, 2) + Math.Pow(heightPyramid, 2)) + height * Math.Sqrt(Math.Pow(width / 2, 2) + Math.Pow(heightPyramid, 2));
            return Area() + temp;
        }

        private double Volume() => (double)1 / 3 * Area() * heightPyramid;

        



    }
}
