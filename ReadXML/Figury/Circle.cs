using System;
using System.Xml;

namespace ReadXML
{
    class Circle : Shape
    {
        public override string BuildShape(XmlNode node, int number)
        {
            XmlElement element = (XmlElement)node;
            nodeName = node.Name;
            color = Program.GetOneTagByName(element, "color");
            if (CIRCLE_SHAPE_NAME.Equals(nodeName))
            {
                diameterRaw = Program.GetOneTagByName(element, "diameter");
                double radius = double.Parse(diameterRaw) / (double)2;
                area = Math.Pow(radius, 2) * Math.PI;
            }
            return Program.BuildOutputShape(nodeName, color, area, number);
        }
    }
}
