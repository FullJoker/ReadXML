using System;
using System.Xml;

namespace ReadXML
{
    abstract class Shape
    {
        public string nodeName;
        public string color;
        public string diameterRaw;
        public double area;
        public static string TRIANGLE_SHAPE_NAME = "triangle";
        public static string CIRCLE_SHAPE_NAME = "circle";

        public abstract string BuildShape(XmlNode node, int number);

    }
}
