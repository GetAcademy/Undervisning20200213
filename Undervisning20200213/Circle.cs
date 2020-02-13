using System;
using System.Collections.Generic;
using System.Text;

namespace Undervisning20200213
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
            ShapeName = "sirkel";
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void ReadValues()
        {
            Console.Write("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
        }
    }
}
