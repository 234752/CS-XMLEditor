using System.Xml;
using System;



namespace XMLeditor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            

            XmlDocument doc = new XmlDocument();
            
            

            doc.Load("courses.xml");
            
            doc.Save(Console.Out);


        }

        


    }

 
}