using System.Text;
using System.Xml;

namespace ReadXML
{
    class FileRead
    {
        public string ReadXml()
        {    
            Circle figureOfCircle = new Circle();
            Triangle figureOfTriangle = new Triangle();
            XmlDocument fXml = new XmlDocument();
            fXml.Load("shapes.xml");
            StringBuilder outputBuilder = new StringBuilder();
            XmlNodeList nodeList = fXml.GetElementsByTagName("shapes").Item(0).ChildNodes;
            int count = 1;
            foreach (XmlNode node in nodeList)
            {
                if (node.Name == "circle")
                {
                    string shapeOutput = figureOfCircle.CalculateSquare(node, count++);
                    outputBuilder.Append(shapeOutput).Append('\n');
                }
                else if (node.Name == "triangle")
                {
                    string shapeOutput2 = figureOfTriangle.CalculateSquare(node, count++);
                    outputBuilder.Append(shapeOutput2).Append('\n');
                }
            }
            return outputBuilder.ToString();
        }
    }
}
