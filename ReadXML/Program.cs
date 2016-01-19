using System;
using System.Xml;

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
            Read showOfFigure = new Read();
            Console.WriteLine(showOfFigure.XmlRead());
            Console.ReadKey();
        }
    }
}
