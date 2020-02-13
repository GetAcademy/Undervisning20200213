using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Undervisning20200213
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            ShapeName = "rektangel";
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override void ReadValues()
        {
            Console.Write("Width: ");
            Width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());
        }
    }
}
