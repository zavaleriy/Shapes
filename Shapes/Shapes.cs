using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal interface Shapes //// class Shapes
    {
        /// <summary>
        /// Получить периметр фигуры
        /// </summary>
        double Perimeter(); //// public virtual double Perimeter() => 0;

        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        double Area(); //// public virtual double Area() => 0
    }

}
