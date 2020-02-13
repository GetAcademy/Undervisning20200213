using System;
using System.Collections.Generic;

namespace Undervisning20200213
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            var areaSum = 0.0;
            while (true)
            {
                Console.Write("Velg form, f for firkant eller s for sirkel: ");
                var form = Console.ReadLine()?.ToUpper();
                if (form != "S" && form != "F") continue;

                var shape = form == "S" ? (Shape) new Circle() : new Rectangle();
                shapes.Add(shape);
                shape.ReadValues();
                var area = shape.CalculateArea();
                areaSum += area;
                var shapeTxt = shape.ShapeName;
                Console.WriteLine($"Du valgte {shapeTxt}. Areal = {area:F4} Totalt areal = {areaSum:F4}");
            }
        }
    }
}
