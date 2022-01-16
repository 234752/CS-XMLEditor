using System;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;
using System.Xml.XPath;


namespace editor
{
    class XMLeditor
    {
        static XDocument LoadDoc(string filename)
        {
            XDocument document = XDocument.Load(filename);
            return document;
        }

        static bool ValidateThis(XDocument document)
        {

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(null, "format.xsd");
            schemas.Add(null, "types.xsd");


            try { document.Validate(schemas, null); }
            catch (XmlSchemaException xsd)
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
                string s = "                                                  ";
                name += s.Substring(name.Length);
                var id = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:ID", baseNamespace).ElementAt(i).Value;
                id += "    ";
                var ECTS = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:ECTS", baseNamespace).ElementAt(i).Value;
                s = "      ";
                ECTS+= s.Substring(ECTS.Length);
                var lectures = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:LECTURE_H", baseNamespace).ElementAt(i).Value;
                s = "        ";
                lectures+=s.Substring(lectures.Length);
                var tutorials = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:TUTORIAL_H", baseNamespace).ElementAt(i).Value;
                s = "        ";
                tutorials +=s.Substring(tutorials.Length);
                var labs = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:LABORATORY_H", baseNamespace).ElementAt(i).Value;
                s = "        ";
                labs+=s.Substring(labs.Length);
                var date = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:GRADING_DATE", baseNamespace).ElementAt(i).Value;
                s = "              ";
                date+=s.Substring(date.Length);
                var weight = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:WEIGHT", baseNamespace).ElementAt(i).Value;
                s = "        ";
                weight+=s.Substring(weight.Length);
                i++;
                Console.WriteLine(name + id  + ECTS  + lectures  + tutorials  + labs  + date  + weight);
            }
        }

        static bool AddCourse(XDocument document)
        {

            Console.Write("Name:"); string name0 = Console.ReadLine();
            Console.Write("ID:"); string id0 = Console.ReadLine();
            Console.Write("ECTS:"); int ects0 = int.Parse(Console.ReadLine());
            Console.Write("Lecture h:"); int lec0 = int.Parse(Console.ReadLine());
            Console.Write("Tutorial h:"); int tut0 = int.Parse(Console.ReadLine());
            Console.Write("Laboratory h:"); int lab0 = int.Parse(Console.ReadLine());
            Console.Write("Date graded:"); string date0 = Console.ReadLine();
            double w = ects0 / 30;
            string weight0 = w.ToString("F2");

            XNamespace ns = "timetable.pl";

            document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Add(
            new XElement(ns + "COURSE",
                new XElement(ns + "NAME", name0),
                new XElement(ns + "ID", id0),
                new XElement(ns + "ECTS", ects0),
                new XElement(ns + "LECTURE_H", lec0),
                new XElement(ns + "TUTORIAL_H", tut0),
                new XElement(ns + "LABORATORY_H", lab0),
                new XElement(ns + "GRADING_DATE", date0),
                new XElement(ns + "WEIGHT", weight0)
                ));





            //if(!ValidateThis(document)) document.Element(ns + "COURSES_LIST").Element(ns + "READ_ME").Element(ns+"LINE").Remove();



            return false;                                               //DELETE THIS LATER
        }

        static void Main(string[] args)
        {
            string filename = "courses.xml";
            filename = Console.ReadLine();
            XDocument courses = LoadDoc(filename);


            //if (ValidateThis(courses)) Console.WriteLine("pogChamp");
            //else Console.WriteLine("notPogChamp");

            AddCourse(courses);
            courses.Save(filename);


            PrintThis(courses);

            
        }
    }
}
