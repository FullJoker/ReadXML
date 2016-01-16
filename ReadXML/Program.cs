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
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("shapes.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            XmlNodeList nodeLst = xDoc.GetElementsByTagName("circle");
            XmlNodeList nodeLst2 = xDoc.GetElementsByTagName("triangle");
            XmlNodeList nodesOfShapes = xDoc.GetElementsByTagName("shapes").Item(0).ChildNodes;

            for (int i = 0; i < nodeLst.Count; i++)
            {
                XmlNode fstNode = nodeLst.Item(i);
                if (fstNode.NodeType == XmlNodeType.Element)
                {
                    XmlElement elj = (XmlElement)fstNode;
                    XmlNodeList nljx = elj.GetElementsByTagName("color");
                    XmlElement eljx = (XmlElement)nljx.Item(0);
                    XmlNodeList nljy = elj.GetElementsByTagName("diameter");
                    XmlElement eljy = (XmlElement)nljy.Item(0);
                    Console.WriteLine("Описания фигуры: {0}", eljx.InnerText);
                    double radius = Double.Parse(eljy.InnerText) / 2;
                    double area = Math.Pow(radius, 2) * Math.PI;
                    Console.WriteLine(string.Format("Площадь: {0:0.##}", area));
                }
            }
            for (int i = 0; i < nodeLst2.Count; i++)
            {
                XmlNode fstNode2 = nodeLst2.Item(i);
                if (fstNode2.NodeType == XmlNodeType.Element)
                {
                    XmlElement elj = (XmlElement)fstNode2;
                    XmlNodeList nljx = elj.GetElementsByTagName("color");
                    XmlElement eljx = (XmlElement)nljx.Item(0);
                    XmlNodeList nljy = elj.GetElementsByTagName("side1");
                    XmlElement eljy = (XmlElement)nljy.Item(0);
                    XmlNodeList nljz = elj.GetElementsByTagName("side2");
                    XmlElement eljz = (XmlElement)nljz.Item(0);
                    XmlNodeList nlje = elj.GetElementsByTagName("side3");
                    XmlElement elje = (XmlElement)nlje.Item(0);
                    Console.WriteLine("Описания фигуры: {0}", eljx.InnerText);
                    double y = (Double.Parse(eljy.InnerText));
                    double z = (Double.Parse(eljz.InnerText));
                    double e = (Double.Parse(elje.InnerText));
                    double p = (y + z + e) / 2;
                    Console.WriteLine(string.Format("Площадь: {0:0.##}", p));
                }
            }
            Console.Read();
        }
    }
}
