using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Shape
    {
        /// <summary>
        /// Вывод периметра и площади фигуры
        /// </summary>
        public virtual void Out() => Console.WriteLine($"Периметр: {Perimeter()}" +
            $"Площадь: {Area()}");

        // Получить периметр фигуры
        protected double Perimeter() => 0;


        // Получить площадь фигуры
        protected double Area() => 0;

    }

}
