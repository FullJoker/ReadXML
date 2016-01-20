using System;
using System.Xml;

namespace ReadXML
{
    public class Program 
    {
        public static string GetOneTagByName(XmlElement element, string tagName)
        {
            return element.GetElementsByTagName(tagName).Item(0).InnerText;
        }

        public static string BuildOutputShape(string name, string color, double area, int number)
        {
            return "#" + number + " " + name + ":" + color + " - " + string.Format("{0:0.##}", area);
        }

        public static void Main(string[] args)
        {
            ReadFile reader = new ReadFile();
            Console.WriteLine(reader.XmlRead());
            Console.ReadKey();
        }
    }
}
