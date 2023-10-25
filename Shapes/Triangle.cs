using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : Circle
    {
        protected private readonly double side1;
        protected private readonly double side2;
        protected private readonly double side3;

        public Triangle(double side1, double side2, double side3)
            : base(0)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public override void Out() => Console.WriteLine($"{Type()} треугольник\n" +
            $"Периметр треугольника: {Perimeter(side1, side2, side3)}\n" +
            $"Площадь треугольника: {Area(side1,side2,side3)}");

        protected double Perimeter(double side1, double side2, double side3) => side1 + side2 + side3;

        protected double Area(double side1, double side2, double side3)
        {
            double semiperimeter = Perimeter(side1, side2, side3) / 2;
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
