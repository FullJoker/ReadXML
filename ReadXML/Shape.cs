using System.Xml;

namespace ReadXML
{
    class Shape
    {
        public string nodeName;
        public string color;
        public double area;
        public virtual string buildShape(XmlNode node, int number)
        {
            return Program.buildOutputShape(nodeName, color, area, number);
        }

    }
}
