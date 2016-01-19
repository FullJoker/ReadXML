using System.Text;
using System.Xml;

namespace ReadXML
{
    class Read
    {
        public string XmlRead()
        {
            Circle figureOfCircle = new Circle();
            Triangle figureOfTriangle = new Triangle();
            XmlDocument fXml = new XmlDocument();
            fXml.Load("shapes.xml");
            StringBuilder outputBuilder = new StringBuilder();
            XmlNodeList nodeLst = fXml.GetElementsByTagName("circle");
            XmlNodeList nodeLst2 = fXml.GetElementsByTagName("triangle");
            int count = 1;
            foreach (XmlNode node in nodeLst)
            {
                if (node.NodeType == XmlNodeType.Element)
                {
                    string shapeOutput = figureOfCircle.buildShape(node, count++);
                    outputBuilder.Append(shapeOutput).Append('\n');
                }

            }
            foreach (XmlNode node in nodeLst2)
            {
                if (node.NodeType == XmlNodeType.Element)
                {
                    string shapeOutput2 = figureOfTriangle.buildShape(node, count++);
                    outputBuilder.Append(shapeOutput2).Append('\n');
                }
            }
            return outputBuilder.ToString();
        }
    }
}
