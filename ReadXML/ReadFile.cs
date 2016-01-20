using System.Text;
using System.Xml;

namespace ReadXML
{
    class ReadFile
    {
        public string XmlRead()
        {
            Circle figureOfCircle = new Circle();
            Triangle figureOfTriangle = new Triangle();
            XmlDocument fXml = new XmlDocument();
            fXml.Load("shapes.xml");
            StringBuilder outputBuilder = new StringBuilder();
            XmlNodeList nodeList = fXml.GetElementsByTagName("circle");
            XmlNodeList nodeList2 = fXml.GetElementsByTagName("triangle");
            int count = 1;
            foreach (XmlNode node in nodeList)
            {
                if (node.NodeType == XmlNodeType.Element)
                {
                    string shapeOutput = figureOfCircle.BuildShape(node, count++);
                    outputBuilder.Append(shapeOutput).Append('\n');
                }

            }
            foreach (XmlNode node in nodeList2)
            {
                if (node.NodeType == XmlNodeType.Element)
                {
                    string shapeOutput2 = figureOfTriangle.BuildShape(node, count++);
                    outputBuilder.Append(shapeOutput2).Append('\n');
                }
            }
            return outputBuilder.ToString();
        }
    }
}
