using System;
using System.Collections.Generic;
using System.Xml;
using ReadXML.Figures;

namespace ReadXML
{
    class FileReader : ILoadFile
    {
        List<Shape> listShapes = new List<Shape>(); 
        XmlDocument fileXml = new XmlDocument();
        public void LoadXmlFile(string fileName)
        {
            try
            {
                fileXml.Load(fileName);
            }
            catch (Exception)
            {
                Console.WriteLine("Указанный файл не найден" +" "+ fileName);
            }
            XmlNodeList nodeShapes = fileXml.GetElementsByTagName("shapes").Item(0).ChildNodes;
            int id = 1;
            foreach (XmlNode node in nodeShapes)
            {
                XmlElement element = (XmlElement) node;
                if (node.Name == "circle")
                {
                    string nameCircle = node.Name;
                    string colorCircle = GetOneTagByName(element, "color");
                    string diameterRaw = GetOneTagByName(element, "diameter");
                    listShapes.Add(new Circle(id++,nameCircle,colorCircle,double.Parse(diameterRaw)));
                }
                else if (node.Name == "triangle")
                {
                    string nameTriangle = node.Name;
                    string colorTriangle = GetOneTagByName(element, "color");
                    string sideA = GetOneTagByName(element, "side1");
                    string sideB = GetOneTagByName(element, "side2");
                    string sideC = GetOneTagByName(element, "side3");
                    listShapes.Add(new Triangle(id++,nameTriangle,colorTriangle,double.Parse(sideA),double.Parse(sideB),double.Parse(sideC)));
                }
            }
            foreach (var read in listShapes)
            {
                Console.WriteLine(read);
            }
        }
        public static string GetOneTagByName(XmlElement element, string tagName)
        {
            return element.GetElementsByTagName(tagName).Item(0).InnerText;
        }
    }
}
