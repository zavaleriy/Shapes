using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class QuadPyramid : Rectangle
    {
        private readonly double heightPyramid; // Высота пирамиды

        private readonly string? foot; // Основание пирамиды

        public QuadPyramid(double heightPyramid, double width)
            : base(width, 0)
        {
            this.heightPyramid = heightPyramid;
            foot = "квадрат";
        }

        public QuadPyramid(double heightPyramid, double width, double height)
            : base(width, height)
        {
            this.heightPyramid = heightPyramid;
            foot = "прямоугольник";
        }

        public override void Out() => Console.WriteLine($"Площадь пирамиды: {Math.Round(Area(), 2)}\n" +
            $"Объем: {Math.Round(Volume(), 2)}");

        private new double Area()
        {
            double area = 0;
            switch (foot)
            {
                case "квадрат":
                    double areaFoot = Area(width);
                    double apothem = Math.Sqrt(Math.Pow(heightPyramid, 2) + Math.Pow(width / (2 * Math.Tan(Math.PI / 4)), 2));
                    area = areaFoot + (4 * width * apothem / 2);
                    break;
                case "прямоугольник":
                    double temp = width * Math.Sqrt(Math.Pow(height / 2, 2) + Math.Pow(heightPyramid, 2)) + height * Math.Sqrt(Math.Pow(width / 2, 2) + Math.Pow(heightPyramid, 2));
                    area = Area(width, height) + temp;
                    break;
            }
            return area;
        }

        private double Volume()
        {
            double volume = 0;
            switch (foot)
            {
                case "квадрат":
                    volume = (double)1 / 3 * Area(width) * heightPyramid;
                    break;
                case "прямоугольник":
                    volume = (double)1 / 3 * Area(width, height) * heightPyramid;
                    break;
            }
            return volume;
        }



    }
}
