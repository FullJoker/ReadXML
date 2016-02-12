using System;
using System.Collections.Generic;
using System.Xml;
using ReadXML.Figures;

namespace ReadXML
{
    class FileReader : ILoadFile//TODO: WATCH ILoadFile.cs
    {				//TODO: create abstract class FileReader
				//TODO: create class XmlReader
        List<Shape> listShapes = new List<Shape>(); //TODO: rename. NAMING EXAMPLE: List<Shape> shapes OR shapesList OR listOfShapes
        XmlDocument fileXml = new XmlDocument();    //TODO: rename. NAMING EXAMPLE: XmlDocument xmlDocument
        public void LoadXmlFile(string fileName)    //TODO: REANAME. Naming example: ReadFile(<>)
        {					    //NOTE: think about IParser -> AbstractParser -> XmlParser 
            try
            {
                fileXml.Load(fileName);
            }
            catch (Exception)	//NOTE: if it 
            {
                Console.WriteLine("Указанный файл не найден" +" "+ fileName);
            }
            XmlNodeList nodeShapes = fileXml.GetElementsByTagName("shapes").Item(0).ChildNodes; //TODO: rename. For example: XmlNodeList shapesList OR JUST shapes
            int id = 1;
            foreach (XmlNode node in nodeShapes)//for each XmlNode xmlNode in xmlList do
            {			
		//TODO: THIS CODE LOOKS BETTER:
		//Shape shape;	 	
                XmlElement element = (XmlElement) node; //WTF?
		//[0]SAME LINE: string name = node.Name;
		//[1]SAME LINE: string color = GetOneTagByName(element, "color");
                if (node.Name == "circle")
                {
                    string nameCircle = node.Name;//[0];
                    string colorCircle = GetOneTagByName(element, "color");//[1]
                    string diameterRaw = GetOneTagByName(element, "diameter"); //TODO: double d = double.Parse(GetOneTagByName(element, "diameter"));
                    listShapes.Add(new Circle(id++,nameCircle,colorCircle,double.Parse(diameterRaw)));
		    //shape = new Circle(name, color, d);
                }
                else if (node.Name == "triangle")
                {
                    string nameTriangle = node.Name;//[0]
                    string colorTriangle = GetOneTagByName(element, "color");//[1]
                    string sideA = GetOneTagByName(element, "side1");
                    string sideB = GetOneTagByName(element, "side2");
                    string sideC = GetOneTagByName(element, "side3");
                    listShapes.Add(new Triangle(id++,nameTriangle,colorTriangle,double.Parse(sideA),double.Parse(sideB),double.Parse(sideC)));
		    //shape = new Triangle(name, color, a,b,c);
                }
		//shapesList.Add(shape);
            }
            foreach (var read in listShapes)//WHAT?
            {
                Console.WriteLine(read);//WRITE "READ" ? (0_o)
            }
        }
        public static string GetOneTagByName(XmlElement element, string tagName) //TODO: GetColor(Node), GetDiametr(Node), List<double> GetSides(Node)
        {
            return element.GetElementsByTagName(tagName).Item(0).InnerText;
        }
    }
}
