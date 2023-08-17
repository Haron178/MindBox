using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapeLib
{
    public abstract class GeometricShape
    {
        public string Name { get; private set; }

        public abstract double GetArea();

        public GeometricShape(string name) 
        {
            Name = name;
        }
    }
}
