using FiftyOne.Foundation.Mobile.Detection.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FiftyOneDegreesVisitorGroupGenerator
{
    internal static class Upgrade
    {
        internal static XmlWriter CreateXml(string fileName)
        {
            var writer = XmlWriter.Create(
                File.CreateText(fileName),
                new XmlWriterSettings()
                {
                    Encoding = Encoding.UTF8,
                    ConformanceLevel = ConformanceLevel.Document,
                    NewLineHandling = NewLineHandling.Entitize,
                    Indent = true,
                    IndentChars = "\t",
                    CheckCharacters = true,
                    NewLineChars = "\r\n",
                    NewLineOnAttributes = true
                });
            writer.WriteStartDocument();
            writer.WriteStartElement("languages");
            writer.WriteStartElement("language");
            writer.WriteAttributeString("name", "English");
            writer.WriteAttributeString("id", "en");
            writer.WriteStartElement(Constants.PROJECT_NAME.ToLower());
            writer.WriteStartElement("upgrade");
            writer.WriteElementString("button", Constants.UpgradeButton);
            return writer;
        }

        internal static void Write(XmlWriter writer, Property property, string suffix = "")
        {
            writer.WriteStartElement((property.Name + suffix).LowerCase());
            writer.WriteElementString(
                "title", 
                String.Format(Constants.UpgradeMessage, 
                    String.Join(", ", property.Maps.Where(i => 
                        i.StartsWith("Enterprise") || 
                        i.StartsWith("Premium"))),
                    property.DisplayName()));
            writer.WriteElementString(
                "url",
                String.Format(Constants.UpgradeUrl, property.Name));
            writer.WriteEndElement();
        }

        internal static void Close(XmlWriter writer)
        {
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
