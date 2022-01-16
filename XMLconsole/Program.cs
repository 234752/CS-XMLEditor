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
            
            int i = 0;
            foreach (XElement el in document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE", baseNamespace))
            {
                
                var name = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:NAME | /n:COURSES_LIST/n:COURSES/n:COURSE/n:POLISH_NAME", baseNamespace).ElementAt(i).Value;
                var id = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:ID", baseNamespace).ElementAt(i).Value;
                var ECTS = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:ECTS", baseNamespace).ElementAt(i).Value;
                var lectures = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:LECTURE_H", baseNamespace).ElementAt(i).Value;
                var tutorials = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:TUTORIAL_H", baseNamespace).ElementAt(i).Value;
                var labs = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:LABORATORY_H", baseNamespace).ElementAt(i).Value;
                var date = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:GRADING_DATE", baseNamespace).ElementAt(i).Value;
                var weight = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:WEIGHT", baseNamespace).ElementAt(i).Value;
                i++;
                Console.WriteLine(name + id + ECTS + lectures + tutorials + labs + date + weight);
            }
            

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
