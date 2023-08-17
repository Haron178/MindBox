using System.Net.WebSockets;

namespace GeometricShapeLib
{
    public class Circle : GeometricShape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Circle")
        {
            if (radius <= 0)
                throw new ArgumentException("Radius cannot be negative or be zero");
            Radius = radius;
        }

        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
    } 
}