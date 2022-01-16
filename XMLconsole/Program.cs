using System;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;
using System.Xml.XPath;


namespace editor
{
    class XMLeditor
    {

        static bool ValidateThis(XDocument document)
        {

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(null, "format.xsd");
            schemas.Add(null, "types.xsd");


            try { document.Validate(schemas, null); }
            catch ( XmlSchemaException xsd)
            {
                return false;
            }
            return true;
        }

        static void PrintThis(XDocument document)
        {
            var baseNamespace = new XmlNamespaceManager(new NameTable());
            baseNamespace.AddNamespace("n", "timetable.pl");
            var name = document.XPathSelectElement("/n:COURSES_LIST/n:READ_ME/n:INDEX", baseNamespace).Value;

            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {

            string filename = "courses.xml";

            //filename = Console.ReadLine();
            XDocument courses = XDocument.Load(filename);


            if (ValidateThis(courses)) Console.WriteLine("pogChamp");
            else Console.WriteLine("notPogChamp");

            PrintThis(courses);

            //courses.Save(Console.Out);
        }
    }
}
