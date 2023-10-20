﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Pyramid : IShape
    {
        private readonly double side; // Длина стороны основания
        private readonly double height; // Высота пирамиды
        private readonly double amountSides; // Количества сторон пирамиды
        private double perimeter;
        private double apothem;

        public Pyramid(double side, double height, double amountSides)
        {
            this.side = side;
            this.height = height;
            this.amountSides = amountSides;
        }

        public void Out() => Console.WriteLine($"Периметр пирамиды: {Perimeter()}\n" +
            $"Площадь пирамиды: {Math.Round(Area(),2)}\n" +
            $"Апофема: {apothem}");

        private double Perimeter() => perimeter = amountSides * side;

        //// Площадь боковой поверхности правильной пирамиды через высоту (Это не общая площадь поверхности правильной пирамиды по высоте)
        private double Area()
        {
            // Апофема
            apothem = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(side / (2 * Math.Tan(Math.PI / amountSides)), 2));

            // Площадь
            return .5 * perimeter * apothem;
        }

    }
}