using System;
using System.Xml;

namespace ReadXML
{
    abstract class Shape
    {
        protected string color;
        protected double area;

        public abstract string CalculateSquare(XmlNode node, int number);

    }
}
