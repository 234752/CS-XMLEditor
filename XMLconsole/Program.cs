using System;
using System.Xml.Linq;


namespace editor
{
    class XMLeditor
    {
        static void Main(string[] args)
        {

            string filename = @"courses.xml";

            filename = Console.ReadLine();
            XDocument courses = XDocument.Load(filename);

            


            courses.Save(Console.Out);
        }
    }
}
