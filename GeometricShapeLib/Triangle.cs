using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeLib
{
    public class Triangle : GeometricShape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public static double Delta = 0.0001;

        public Triangle(double side1, double side2, double side3) : base("Triangle")
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("Side cannot be negative or be zero");
            C = Math.Max(side1, Math.Max(side3, side2));
            if (C == side1)
            {
                B = side2;
                A = side3;
            }
            else if (C == side2)
            {
                B = side1;
                A = side3;
            }
            else
            {
                B = side1;
                A = side2;
            }
            if (C >= A + B) 
            {
                throw new ArgumentException("Side of a triangle cannot be longer than the sum of the other sides");
            }
        }
        public override double GetArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - C) * (p - B));
        }
        public bool IsRectangular()
        {
            if ((C * C) - (A * A + B * B) <= Delta)
            {
                return true;
            }
            return false;
        }
    }
}
