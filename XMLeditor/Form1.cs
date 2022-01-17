using System;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;
using System.Xml.XPath;

namespace XMLeditor
{
    public partial class Form1 : Form
    {
        static XDocument LoadDoc(string filename)
        {
            XDocument document = XDocument.Load(filename);
            return document;
        }
        static string PrintThis(XDocument document)
        {
            var baseNamespace = new XmlNamespaceManager(new NameTable());
            baseNamespace.AddNamespace("n", "timetable.pl");
            string result="";
            int i = 0;
            foreach (XElement el in document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE", baseNamespace))
            {
                var name = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:NAME | /n:COURSES_LIST/n:COURSES/n:COURSE/n:POLISH_NAME", baseNamespace).ElementAt(i).Value;
                string s = "                                                 ";
                name += s.Substring(name.Length);
                var id = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:ID", baseNamespace).ElementAt(i).Value;
                id += "    ";
                var ECTS = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:ECTS", baseNamespace).ElementAt(i).Value;
                s = "      ";
                ECTS += s.Substring(ECTS.Length);
                var lectures = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:LECTURE_H", baseNamespace).ElementAt(i).Value;
                s = "        ";
                lectures += s.Substring(lectures.Length);
                var tutorials = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:TUTORIAL_H", baseNamespace).ElementAt(i).Value;
                s = "        ";
                tutorials += s.Substring(tutorials.Length);
                var labs = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:LABORATORY_H", baseNamespace).ElementAt(i).Value;
                s = "        ";
                labs += s.Substring(labs.Length);
                var date = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:GRADING_DATE", baseNamespace).ElementAt(i).Value;
                s = "              ";
                date += s.Substring(date.Length);
                var weight = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:WEIGHT", baseNamespace).ElementAt(i).Value;
                //s = "        ";
                //weight += s.Substring(weight.Length);
                i++;
                result += (name + id + ECTS + lectures + tutorials + labs + date + weight) + "\n";
            }
            return result;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = this.textBox1.Text;
            
            XDocument courses = LoadDoc(filename);
            this.label2.Text = PrintThis(courses);
        }
    }
}