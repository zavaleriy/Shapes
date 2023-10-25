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
        private new readonly double height; // Высота пирамиды
        private readonly string? foot; // Основание пирамиды

        // Квадрат
        private new readonly float width;

        public Pyramid(double height, float width)
            : base(0, 0, 0)
        {
            this.height = height;
            this.width = width;
            foot = "квадрат";
        }

        // Прямоугольник
        private readonly double length;

        public Pyramid(double height, float width, double length)
            : base(0, 0, 0)
        {
            this.height = height;
            this.width = width;
            this.length = length;
            foot = "прямоугольник";
        }

        // Круг
        private readonly double side;
        private new readonly double radius;

        public Pyramid(double height, double side)
            : base(0, 0, 0)
        {
            this.height = height;
            this.side = side;
            radius = Math.Round(Math.Sqrt(side*side - height*height), 2);
            foot = "круг";
        }

        // Треугольник
        public Pyramid(double height, double side1, double side2, double side3)
            : base(side1, side2, side3)
        {
            this.height = height;
            foot = "треугольник";
        }

        

        public new void Out() => Console.WriteLine($"Площадь пирамиды: {Math.Round(Area(),2)}\n" +
            $"Объем: {Math.Round(Volume(), 2)}");

        private new double Area()
        {
            double area = 0;
            switch (foot)
            {
                case "квадрат":
                    double areaFoot = Area(width: width);
                    double apothem = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width / (2 * Math.Tan(Math.PI / 4)), 2));
                    area = areaFoot + (4 * width * apothem / 2);
                    break;

                case "прямоугольник":
                    double temp = width * Math.Sqrt(Math.Pow(length / 2, 2) + Math.Pow(height, 2)) + length * Math.Sqrt(Math.Pow(width / 2, 2) + Math.Pow(height, 2));
                    area = Area(width, length) + temp;
                    break;

                case "круг":
                    Console.WriteLine($"Радиус: {radius,2}");
                    area = Math.PI * radius * (radius + side);
                    break;

                case "треугольник":
                    area = Area(side1,side2,side3);
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
                    volume = (double) 1 / 3 * Area(width: width) * height;
                    break;

                case "прямоугольник":
                    volume = (double) 1 / 3 * Area(width, length) * height;
                    break;

                case "круг":
                    volume = (double) 1 / 3 * Math.PI * radius * radius * height;
                    break;

                case "треугольник":
                    volume = (double) 1 / 3 * Area(side1, side2, side3) * height;
                    break;
            }
            return volume;
        }



    }
}
