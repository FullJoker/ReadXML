using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Schema;


namespace ReadXML
{
    public class Program 
    {
        public static string getOneTagByName(XmlElement element, string tagName)
        {
            return element.GetElementsByTagName(tagName).Item(0).InnerText;
        }

        public static string buildOutputShape(string name, string color, double area, int number)
        {
            return "#" + number + " " + name + ":" + color + " - " + string.Format("{0:0.##}", area);
        }

        public static void Main(string[] args)
        {
            XmlDocument fXml = new XmlDocument();
            fXml.Load("shapes.xml");
            try
            {
                XmlNodeList nodesOfShapes = fXml.GetElementsByTagName("shapes").Item(0).ChildNodes;
                StringBuilder outputBuilder = new StringBuilder();
                int count = 1;
                foreach (XmlNode node in nodesOfShapes)
                {
                    if (node.NodeType == XmlNodeType.Element)
                    {
                        string shapeOutput = Shape.buildShape(node, count++);
                        outputBuilder.Append(shapeOutput).Append('\n');
                    }
                }
                System.Console.WriteLine(outputBuilder.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
