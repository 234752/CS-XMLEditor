using System;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;
using System.Xml.XPath;

namespace CourseEditor
{
    public partial class Timetable : Form
    {
        public Timetable()
        {
            InitializeComponent();
        }

        private void ClearLabels()
        {
            this.numLabel.Text = "No";
            this.nameLabel.Text = "NAME";
            this.idLabel.Text = "ID";
            this.ectsLabel.Text = "ECTS";
            this.lecLabel.Text = "LECTURE H";
            this.tutLabel.Text = "TUTORIAL H";
            this.labLabel.Text = "LABORATORY H";
            this.dateLabel.Text = "DATE GRADED";
            this.weightLabel.Text = "WEIGHT";
        }

        private void DisplayCourses(XDocument document)
        {
            var baseNamespace = new XmlNamespaceManager(new NameTable());
            baseNamespace.AddNamespace("n", "timetable.pl");
            
            int i = 0;
            foreach (XElement el in document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE", baseNamespace))
            {
                this.numLabel.Text += "\n" + i.ToString();
                this.nameLabel.Text += "\n"+ document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:NAME | /n:COURSES_LIST/n:COURSES/n:COURSE/n:POLISH_NAME", baseNamespace).ElementAt(i).Value;

                this.idLabel.Text += "\n" + document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:ID", baseNamespace).ElementAt(i).Value;

                this.ectsLabel.Text += "\n" + document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:ECTS", baseNamespace).ElementAt(i).Value;

                this.lecLabel.Text += "\n" + document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:LECTURE_H", baseNamespace).ElementAt(i).Value;

                this.tutLabel.Text += "\n" + document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:TUTORIAL_H", baseNamespace).ElementAt(i).Value;

                this.labLabel.Text += "\n" + document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:LABORATORY_H", baseNamespace).ElementAt(i).Value;

                this.dateLabel.Text += "\n" + document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:GRADING_DATE", baseNamespace).ElementAt(i).Value;

                this.weightLabel.Text += "\n" + document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:WEIGHT", baseNamespace).ElementAt(i).Value;
                
                i++;
                
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string filename = this.fileInput.Text;
            XDocument document = XDocument.Load(filename);
            ClearLabels();
            DisplayCourses(document);
        }
    }
}