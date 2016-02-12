using System;

namespace ReadXML
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            ILoadFile view = new FileReader();//TODO: Again
            var nameFile = "shapes.xml";      //AND AGAIN
            view.LoadXmlFile(nameFile);	      //AND AGAIN
            Console.ReadKey();		      //RENAME THIS!!!
        }
    }
}
//oh, look! Boobs! (.Y.)
