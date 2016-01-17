using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadXML
{
    public class Shape
    {
        public static string CIRCLE_SHAPE_NAME = "circle";
        public static string TRIANGLE_SHAPE_NAME = "triangle";

        public static string buildShape(XmlNode node, int number)
        {
            XmlElement element = (XmlElement)node;
            string nodeName = node.Name;
            string color = Program.getOneTagByName(element, "color");

            double area;
            if (CIRCLE_SHAPE_NAME.Equals(nodeName))
            {
                string diameterRaw = Program.getOneTagByName(element, "diameter");
                double radius = Double.Parse(diameterRaw) / 2;
                area = Math.Pow(radius, 2) * Math.PI;
            }
            else if (TRIANGLE_SHAPE_NAME.Equals(nodeName))
            {
                string side1Raw = Program.getOneTagByName(element, "side1");
                string side2Raw = Program.getOneTagByName(element, "side2");
                string side3Raw = Program.getOneTagByName(element, "side3");
                double side1 = Double.Parse(side1Raw);
                double side2 = Double.Parse(side2Raw);
                double side3 = Double.Parse(side3Raw);
                double perimeter = (side1 + side2 + side3) / 2;
                area = Math.Sqrt(perimeter * (perimeter - side1) * (perimeter - side2) * (perimeter - side3));
            }
            else
            {
                throw new Exception("Неизвестный Тип фигуры. Имя Узла: " + nodeName);
            }
           return Program.buildOutputShape(nodeName, color, area, number);
        }
    }
}
