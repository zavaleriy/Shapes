using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : IShape
    {
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;
        private double perimeter;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public void Out() => Console.WriteLine($"{Type()} треугольник\n" +
            $"Периметр треугольника: {Perimeter()}\n" +
            $"Площадь треугольника: {Area()}");

        private double Perimeter() => perimeter = side1 + side2 + side3;

        private double Area()
        {
            double semiperimeter = perimeter / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        }

        public string? Type()
        {
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                return "Не существует";
            else if (side1 == side2 && side1 == side3)
                return "Равносторонний";
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                return "Равнобедренный";
            else
                return "Разносторонний";
        }

    }
}
