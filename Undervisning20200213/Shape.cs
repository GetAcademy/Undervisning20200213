using System;
using System.Collections.Generic;
using System.Text;

namespace Undervisning20200213
{
    abstract class Shape
    {
        public string ShapeName { get; protected set; } = "noe";
        public abstract double CalculateArea();
        public abstract void ReadValues();
    }
}
