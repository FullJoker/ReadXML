using System;

namespace ReadXML.Figures
{
    class Triangle : Shape//watch Shape.cs
    {
        protected double SideA { get; set; }
        protected double SideB { get; set; }
        protected double SideC { get; set; }
        public Triangle(int id, string name, string color, double sideA, double sideB, double sideC): base(id,name,color)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public override double CalculateSquare()
        {
            double perimeter = (SideA + SideB + SideC) /2;
            return Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
        }
    }
}
