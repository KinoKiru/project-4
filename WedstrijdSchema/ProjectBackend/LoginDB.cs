using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace ProjectBackend
{
    class LoginDB
    {
        private const string Path = @"..\..\login.xml";

        public static List<login> GetLogin()
        {
            List<login> customers = new List<login>();

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            XmlReader xmlIn = XmlReader.Create(Path, settings);

            if (xmlIn.ReadToDescendant("login"))
            {
                // maakt een customer aan, gooit vervolgens de dingen die hij kan lezen in de xml
                // in de customer en blijft dit doen todat er geen meer is 
                do
                {
                    login login = new login();
                    xmlIn.ReadStartElement("login");
                    login.Email =
                        xmlIn.ReadElementContentAsString();
                    login.Usernname =
                        xmlIn.ReadElementContentAsString();
                    login.WachtWoord =
                        xmlIn.ReadElementContentAsString();
                    customers.Add(login);
                }
                while (xmlIn.ReadToNextSibling("login"));
            }

            // sluit de file en returned de list
            xmlIn.Close();

            return customers;
        }
        public static void SaveLogin(List<login> logins)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Logins");

            // write each product object to the xml file
            foreach (login login in logins)
            {
                xmlOut.WriteStartElement("login");
                xmlOut.WriteElementString("email",
                    login.Email);
                xmlOut.WriteElementString("username",
                    login.Usernname);
                xmlOut.WriteElementString("wachtwoord",
                    login.WachtWoord);
                xmlOut.WriteEndElement();
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
    }
}
