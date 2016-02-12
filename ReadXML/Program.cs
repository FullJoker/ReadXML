using System;

namespace ReadXML
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            ILoadFile view = new FileReader();
            var nameFile = "shapes.xml";
            view.LoadXmlFile(nameFile);
            Console.ReadKey();
        }
    }
}
