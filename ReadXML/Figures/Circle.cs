using System;

namespace ReadXML.Figures
{
    class Circle : Shape//Watch Shape.cs
    {
        protected double Diameter { get; set; }
        public Circle(int id, string name, string color, double diameter): base(id,name,color)
        {
            Diameter = diameter;
        }
        public override double CalculateSquare()
        {
            double radius = (Diameter)/2;
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
