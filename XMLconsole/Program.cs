using System;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;


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

        static void Main(string[] args)
        {

            string filename = "courses.xml";

            //filename = Console.ReadLine();
            XDocument courses = XDocument.Load(filename);

            //XmlSchemaSet schemas = new XmlSchemaSet();
            //schemas.Add(null, "format.xsd");
            //schemas.Add(null, "types.xsd");

            if (ValidateThis(courses)) Console.WriteLine("pogChamp");
            else Console.WriteLine("notPogChamp");

            

            //courses.Save(Console.Out);
        }
    }
}
