using System;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;
using System.Xml.XPath;

namespace CourseEditor
{
    public partial class Timetable : Form
    {
        public XDocument document;

        public Timetable()
        {
            InitializeComponent();
        }

        private void ClearLabels()
        {
            this.authorLabel.Text = "";
            this.numLabel.Text = "";
            this.semLabel.Text = "";
            this.nameLabel.Text = "";
            this.idLabel.Text = "";
            this.ectsLabel.Text = "";
            this.lecLabel.Text = "";
            this.tutLabel.Text = "";
            this.labLabel.Text = "";
            this.dateLabel.Text = "";
            this.weightLabel.Text = "";
            this.errorLabel.Text = "";
        }
        private void ClearSEMLabels()
        {
            this.SEMnumLabel.Text = "";
            this.SEMnameLabel.Text = "";
            this.SEMdateLabel.Text = "";
            this.SEMhourLabel.Text = "";
            this.SEMyearLabel.Text = "";
            this.errorLabel.Text = "";
        }

        private void DisplayCourses()
        {
            var baseNamespace = new XmlNamespaceManager(new NameTable());
            baseNamespace.AddNamespace("n", "timetable.pl");
            XNamespace ns = "timetable.pl";

            this.authorLabel.Text = "author: " + document.XPathSelectElements("/n:COURSES_LIST/n:READ_ME/n:AUTHOR", baseNamespace).First().Value
                + ",     id: " + document.XPathSelectElements("/n:COURSES_LIST/n:READ_ME/n:INDEX", baseNamespace).First().Value;

            int i = 0;
            foreach (XElement el in document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE", baseNamespace))
            {
                this.numLabel.Text += "\n" + document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(i).Attribute("nr").Value.Substring(1);

                this.semLabel.Text += "\n" + document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(i).Attribute("semID").Value.Substring(1);

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
        private void DisplaySemesters()
        {
            
            XNamespace ns = "timetable.pl";


            int i = 0;
            foreach (XElement el in document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER"))
            {
                this.SEMnumLabel.Text += "\n" + document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(i).Attribute("semID").Value.Substring(1);

                this.SEMnameLabel.Text += "\n" + document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(i).Element(ns+"S_NAME").Value;

                this.SEMdateLabel.Text += "\n" + document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(i).Element(ns + "END_DATE").Value;

                this.SEMhourLabel.Text += "\n" + document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(i).Element(ns + "END_HOUR").Value;

                this.SEMyearLabel.Text += "\n" + document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(i).Attribute("year").Value;

                i++;

            }
        }

        private bool ValidateDocument(XDocument target)
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(null, "format.xsd");
            schemas.Add(null, "types.xsd");


            try { target.Validate(schemas, null); }
            catch (XmlSchemaException xsd)
            {
                return false;
            }
            return true;
        }

        private bool AddCourse()
        {

            try
            {
                XDocument updated = new XDocument(document);
                int number0 = int.Parse(this.numInput.Text);
                string sem0 = this.semInput.Text;
                string name0 = this.nameInput.Text;
                string id0 = this.idInput.Text;
                int ects0 = int.Parse(this.ectsInput.Text);
                int lec0 = int.Parse(this.lecInput.Text);
                int tut0 = int.Parse(this.tutInput.Text);
                int lab0 = int.Parse(this.labInput.Text);
                string date0 = this.dateInput.Text;
                double w = ects0 / 30.0;
                string weight0 = w.ToString("F2");
            

                XNamespace ns = "timetable.pl";

            
        if(date0=="")
            {
                    
                    XNamespace ns_xsi = "http://www.w3.org/2001/XMLSchema-instance";
                    updated.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Add(
                new XElement(ns + "COURSE",
                    new XAttribute("nr", "C" + number0),
                    new XAttribute("semID", "S" + sem0),
                    new XElement(ns + "NAME", name0),
                    new XElement(ns + "ID", id0),
                    new XElement(ns + "ECTS", ects0),
                    new XElement(ns + "LECTURE_H", lec0),
                    new XElement(ns + "TUTORIAL_H", tut0),
                    new XElement(ns + "LABORATORY_H", lab0),
                    new XElement(ns + "GRADING_DATE", new XAttribute("graded", false), new XAttribute(ns_xsi + "nil",true)),
                    new XElement(ns + "WEIGHT", weight0)
                    ));
                    
                }

        else    updated.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Add(
                new XElement(ns + "COURSE",
                    new XAttribute("nr", "C" + number0),
                    new XAttribute("semID", "S" + sem0),
                    new XElement(ns + "NAME", name0),
                    new XElement(ns + "ID", id0),
                    new XElement(ns + "ECTS", ects0),
                    new XElement(ns + "LECTURE_H", lec0),
                    new XElement(ns + "TUTORIAL_H", tut0),
                    new XElement(ns + "LABORATORY_H", lab0),
                    new XElement(ns + "GRADING_DATE", new XAttribute("graded", true), date0),
                    new XElement(ns + "WEIGHT", weight0)
                    ));

            if (ValidateDocument(updated))
            {
                document = updated;
                return true;
            }
            }
            catch (System.Exception ex)
            {
                return false;
            }

            return false;
        }

        private bool AddSemester()
        {

            try
            {
                XDocument updated = new XDocument(document);
                int number0 = int.Parse(this.SEMnumInput.Text);
                string name0 = this.SEMnameInput.Text;
                string date0 = this.SEMdateInput.Text;
                string hour0 = this.SEMhourInput.Text;
                int year0 = number0/2 + number0 % 2;



                XNamespace ns = "timetable.pl";


                

                updated.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Add(
                     new XElement(ns + "SEMESTER",
                        new XAttribute("semID", "S"+number0),
                        new XAttribute("year", year0),
                        new XElement(ns +"S_NAME", name0),
                        new XElement(ns +"END_DATE", date0),
                        new XElement(ns +"END_HOUR", hour0)
                         ));

                if (ValidateDocument(updated))
                {
                    document = updated;
                    return true;
                }
            }
            catch (System.Exception ex)
            {
                return false;
            }

            return false;
        }

        private void DisplayByIndex(int index0)
        {            
            var baseNamespace = new XmlNamespaceManager(new NameTable());
            baseNamespace.AddNamespace("n", "timetable.pl");
            XNamespace ns = "timetable.pl";

            int index = document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE")
                .Where(x => x.Attribute("nr").Value == "C" + index0.ToString()).Last().ElementsBeforeSelf().Count();

            if (index >= 0 && index < document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").Count())
            {
                this.semEdit.Text = document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Attribute("semID").Value.Substring(1);
                this.nameEdit.Text = document.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:NAME | /n:COURSES_LIST/n:COURSES/n:COURSE/n:POLISH_NAME", baseNamespace).ElementAt(index).Value;
                this.idEdit.Text = document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "ID").Value;
                this.ectsEdit.Text = document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "ECTS").Value;
                this.lecEdit.Text = document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "LECTURE_H").Value;
                this.tutEdit.Text = document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "TUTORIAL_H").Value;
                this.labEdit.Text = document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "LABORATORY_H").Value;
                this.dateEdit.Text = document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "GRADING_DATE").Value;
            }
            else throw new System.Exception();
        }

        private void DisplaySEMByIndex(int index0)
        {
            
            XNamespace ns = "timetable.pl";

            int index = document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER")
                .Where(x => x.Attribute("semID").Value == "S" + index0.ToString()).Last().ElementsBeforeSelf().Count();

            if (index >= 0 && index < document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").Count())
            {
                this.SEMnameEdit.Text = document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(index).Element(ns + "S_NAME").Value;
                this.SEMdateEdit.Text = document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(index).Element(ns + "END_DATE").Value;
                this.SEMhourEdit.Text = document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(index).Element(ns + "END_HOUR").Value;
            }
            else throw new System.Exception();
        }

        private void DeleteByIndex(int index0)
        {
            XNamespace ns = "timetable.pl";

        int index = document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE")
                .Where(x => x.Attribute("nr").Value == "C" + index0.ToString()).Last().ElementsBeforeSelf().Count();

            if (index >= 0 && index < document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").Count())
            {
                XDocument deleted = new XDocument(document);
                deleted.Element(ns +"COURSES_LIST").Element(ns +"COURSES").Descendants(ns +"COURSE").ElementAt(index).Remove();
                if(ValidateDocument(deleted)) document = deleted;
                else throw new System.Exception();
            }
            else throw new System.Exception();
        }

        private void DeleteSEMByIndex(int index0)
        {
            XNamespace ns = "timetable.pl";

            int index = document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER")
                    .Where(x => x.Attribute("semID").Value == "S" + index0.ToString()).Last().ElementsBeforeSelf().Count();

            if (index >= 0 && index < document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").Count())
            {
                XDocument deleted = new XDocument(document);
                deleted.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(index).Remove();
                if (ValidateDocument(deleted)) document = deleted;
                else throw new System.Exception();
            }
            else throw new System.Exception();
        }

        private void EditByIndex(int index0)
        {
            XNamespace ns_xsi = "http://www.w3.org/2001/XMLSchema-instance";
            var baseNamespace = new XmlNamespaceManager(new NameTable());
            baseNamespace.AddNamespace("n", "timetable.pl");
            XNamespace ns = "timetable.pl";

            int index = document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE")
                    .Where(x => x.Attribute("nr").Value == "C" + index0.ToString()).Last().ElementsBeforeSelf().Count();

            XDocument edited = new XDocument(document);

            if (index >= 0 && index < document.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").Count())
            {
                edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Attribute("semID").Value = "S" + this.semEdit.Text.ToString();
                edited.XPathSelectElements("/n:COURSES_LIST/n:COURSES/n:COURSE/n:NAME | /n:COURSES_LIST/n:COURSES/n:COURSE/n:POLISH_NAME", baseNamespace).ElementAt(index).Value = this.nameEdit.Text;
                edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "ID").Value = this.idEdit.Text;
                edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "ECTS").Value = this.ectsEdit.Text;
                edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "LECTURE_H").Value = this.lecEdit.Text;
                edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "TUTORIAL_H").Value = this.tutEdit.Text;
                edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "LABORATORY_H").Value = this.labEdit.Text;
                double w = int.Parse( this.ectsEdit.Text) / 30.0;
                string weight0 = w.ToString("F2");
                edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "WEIGHT").Value = weight0;

                if (edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "GRADING_DATE").Attribute("graded").Value=="true"
                    && this.dateEdit.Text=="")
                {
                    edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "GRADING_DATE").Attribute("graded").Value = "false";
                    edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "GRADING_DATE")
                        .Add(new XAttribute(ns_xsi + "nil", true));
                }else
                if(edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "GRADING_DATE").Attribute("graded").Value == "false"
                    && this.dateEdit.Text!="")
                {
                    edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "GRADING_DATE").Attribute("graded").Value = "true";
                    edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "GRADING_DATE")
                        .Attribute(ns_xsi + "nil").Remove();
                }


                edited.Element(ns + "COURSES_LIST").Element(ns + "COURSES").Descendants(ns + "COURSE").ElementAt(index).Element(ns + "GRADING_DATE").Value = this.dateEdit.Text;

                if (ValidateDocument(edited)) document = edited;
                else throw new System.Exception();
            }
            else throw new System.Exception();

        }

        private void EditSEMByIndex(int index0)
        {
            
            XNamespace ns = "timetable.pl";

            int index = document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER")
                    .Where(x => x.Attribute("semID").Value == "S" + index0.ToString()).Last().ElementsBeforeSelf().Count();

            XDocument edited = new XDocument(document);

            if (index >= 0 && index < document.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").Count())
            {
                
                edited.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(index).Element(ns + "S_NAME").Value = this.SEMnameEdit.Text;
                edited.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(index).Element(ns + "END_DATE").Value = this.SEMdateEdit.Text;
                edited.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(index).Element(ns + "END_HOUR").Value = this.SEMhourEdit.Text;

                int number0 = int.Parse(this.SEMNoEdit.Text);
                int year0 = number0 / 2 + number0 % 2;
                edited.Element(ns + "COURSES_LIST").Element(ns + "SEMESTERS").Descendants(ns + "SEMESTER").ElementAt(index).Attribute("year").Value = year0.ToString();


                if (ValidateDocument(edited)) document = edited;
                else throw new System.Exception();
            }
            else throw new System.Exception();

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string filename = this.fileInput.Text;
            try
            {
                document = XDocument.Load(filename);
                if (ValidateDocument(document))
                {
                    ClearLabels();
                    ClearSEMLabels();
                    DisplaySemesters();
                    DisplayCourses();
                }
                else this.errorLabel.Text = "Cannot validate this document. Please make sure that it is validated XML document.";
            }
            catch (System.Exception ex)
            {
                this.errorLabel.Text = "Cannot load this document. Please make sure that entered name is proper.";
            }

            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (AddCourse())
            {
                ClearLabels();
                DisplayCourses();
            }
            else this.errorLabel.Text = "Cannot add course. Please make sure that entered data is valid.";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string outputName = this.fileOutput.Text;
                document.Save(outputName);
            }catch (System.Exception ex)
            {
                this.errorLabel.Text = "Cannot save this file. Please make sure it has proper extension.";         
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = int.Parse(this.NoEdit.Text);
                DisplayByIndex(selectedIndex);
                ClearLabels();
                DisplayCourses();
            }catch (System.Exception ex)
            {
                this.errorLabel.Text = "Cannot display selected course. Please make sure that such index exists.";
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = int.Parse(this.NoEdit.Text);
                DeleteByIndex(selectedIndex);
                ClearLabels();
                DisplayCourses();
            }
            catch (System.Exception ex)
            {
                this.errorLabel.Text = "Cannot delete selected course. Please make sure that such index exists and that document will be valid after deletion.";
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = int.Parse(this.NoEdit.Text);
                EditByIndex(selectedIndex);
                ClearLabels();
                DisplayCourses();
            }
            catch (System.Exception ex)
            {
                this.errorLabel.Text = "Cannot edit selected course. Please make sure that such index exists and entered data is valid.";
            }
        }

        private void SEMaddButton_Click(object sender, EventArgs e)
        {
            if (AddSemester())
            {
                ClearSEMLabels();
                DisplaySemesters();
            }
            else this.errorLabel.Text = "Cannot add semester. Please make sure that entered data is valid.";
        }

        private void SEMdisplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = int.Parse(this.SEMNoEdit.Text);
                DisplaySEMByIndex(selectedIndex);
                ClearSEMLabels();
                DisplaySemesters();
            }
            catch (System.Exception ex)
            {
                this.errorLabel.Text = "Cannot display selected semester. Please make sure that such index exists.";
            }
        }

        private void SEMdeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = int.Parse(this.SEMNoEdit.Text);
                DeleteSEMByIndex(selectedIndex);
                ClearSEMLabels();
                DisplaySemesters();
            }
            catch (System.Exception ex)
            {
                this.errorLabel.Text = "Cannot delete selected semester. Please make sure that such index exists and that document will be valid after deletion.";
            }
        }

        private void SEMeditButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = int.Parse(this.SEMNoEdit.Text);
                EditSEMByIndex(selectedIndex);
                ClearSEMLabels();
                DisplaySemesters();
            }
            catch (System.Exception ex)
            {
                this.errorLabel.Text = "Cannot edit selected semester. Please make sure that such index exists and entered data is valid.";
            }
        }

    }
}