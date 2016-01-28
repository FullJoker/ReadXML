using System;
using System.Xml;

namespace ReadXML
{
    class Circle : Shape
    {
        public override string CalculateSquare(XmlNode node, int number)
        {
            XmlElement element = (XmlElement)node;
            color = Program.GetOneTagByName(element, "color");
            string diameterRaw = Program.GetOneTagByName(element, "diameter");
            double radius = double.Parse(diameterRaw) / (double)2;
            area = Math.Pow(radius, 2) * Math.PI;
            return Program.BuildOutputShape(node.Name, color, area, number);
        }
    }
}
