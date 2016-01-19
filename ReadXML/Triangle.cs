using System;
using System.Xml;

namespace ReadXML
{
    class Triangle : Shape
    {
        public static string TRIANGLE_SHAPE_NAME = "triangle";
        public override string buildShape(XmlNode node, int number)
        {
            XmlElement element = (XmlElement)node;
            nodeName = node.Name;
            color = Program.getOneTagByName(element, "color");
            if (TRIANGLE_SHAPE_NAME.Equals(nodeName))
            {
                string side1Raw = Program.getOneTagByName(element, "side1");
                string side2Raw = Program.getOneTagByName(element, "side2");
                string side3Raw = Program.getOneTagByName(element, "side3");
                double side1 = Double.Parse(side1Raw);
                double side2 = Double.Parse(side2Raw);
                double side3 = Double.Parse(side3Raw);
                double perimeter = (side1 + side2 + side3) / (double)2;
                area = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
            }
            return Program.buildOutputShape(nodeName, color, area, number);
        }
    }
}
