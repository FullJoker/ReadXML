﻿using System;
using System.Xml;

namespace ReadXML
{
    class Triangle : Shape
    {
        public override string BuildShape(XmlNode node, int number)
        {
            XmlElement element = (XmlElement)node;
            nodeName = node.Name;
            color = Program.GetOneTagByName(element, "color");
            if (TRIANGLE_SHAPE_NAME.Equals(nodeName))
            {
                string side1Raw = Program.GetOneTagByName(element, "side1");
                string side2Raw = Program.GetOneTagByName(element, "side2");
                string side3Raw = Program.GetOneTagByName(element, "side3");
                double side1 = double.Parse(side1Raw);
                double side2 = double.Parse(side2Raw);
                double side3 = double.Parse(side3Raw);
                double perimeter = (side1 + side2 + side3) / (double)2;
                area = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
            }
            return Program.BuildOutputShape(nodeName, color, area, number);
        }
    }
}