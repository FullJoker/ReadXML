using System;
using System.Xml;

namespace ReadXML
{
    class Circle : Shape
    {
        public static string CIRCLE_SHAPE_NAME = "circle";
        public override string buildShape(XmlNode node, int number)
        {
            XmlElement element = (XmlElement)node;
            nodeName = node.Name;
            color = Program.getOneTagByName(element, "color");
            if (CIRCLE_SHAPE_NAME.Equals(nodeName))
            {
                string diameterRaw = Program.getOneTagByName(element, "diameter");
                double radius = Double.Parse(diameterRaw) / (double)2;
                area = Math.Pow(radius, 2) * Math.PI;
            }
            return Program.buildOutputShape(nodeName, color, area, number);
        }
    }
}
