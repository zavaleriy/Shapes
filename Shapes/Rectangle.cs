﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Square
    {
        protected private readonly double height; // Высота

        public Rectangle(float width, double height) 
            : base(width)
        {
            this.height = height;
        }

        public new void Out() => Console.WriteLine($"Периметр прямоугольника: {Perimeter(width, height)}\n" +
            $"Площадь прямоугольника: {Area(width, height)}");

        protected double Perimeter(float width, double height) => 2 * (width + height);

        protected double Area(float width, double height) => width * height;


    }
}
