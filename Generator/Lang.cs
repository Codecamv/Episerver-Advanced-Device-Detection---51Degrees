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
    /// <summary>
    /// Methods related to the production of the XML language file.
    /// </summary>
    internal static class Lang
    {
        internal static XmlWriter CreateXml(string fileName)
        {
            var writer = XmlWriter.Create(
                File.CreateText(fileName), 
                new XmlWriterSettings() { 
                    Encoding = Encoding.UTF8, 
                    ConformanceLevel = ConformanceLevel.Document, 
                    NewLineHandling = NewLineHandling.Entitize,
                    Indent = true,
                    IndentChars = "\t",
                    CheckCharacters = true,
                    NewLineChars = "\r\n",
                    NewLineOnAttributes = true });
            writer.WriteStartDocument();
            writer.WriteStartElement("languages");
            writer.WriteStartElement("language");
            writer.WriteAttributeString("name", "English");
            writer.WriteAttributeString("id", "en");
            writer.WriteStartElement("enums");
            writer.WriteStartElement(Constants.PROJECT_NAME.ToLower());
            writer.WriteStartElement("enums");
            WriteValueConditions(writer, "enum", Constants.ValueConditionsEnum);
            WriteValueConditions(writer, "boolean", Constants.ValueConditionsBoolean);
            WriteValueConditions(writer, "string", Constants.ValueConditionsString);
            WriteValueConditions(writer, "numeric", Constants.ValueConditionsNumeric);
            WriteValueConditions(writer, "version", Constants.ValueConditionsVersion);
            WriteValueConditions(writer, "range", Constants.ValueConditionsRange);
            return writer;
        }

        internal static void Write(XmlWriter writer, Property property)
        {
            WriteValues(writer, property);
        }

        private static void WriteValues(XmlWriter writer, Property property)
        {
            writer.WriteComment(property.Description);
            writer.WriteStartElement(property.Name.ToLower());
            foreach (var value in property.Values)
            {
                writer.WriteComment(value.Description);
                writer.WriteStartElement(value.ElementName());
                writer.WriteString(value.Name);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        private static void WriteValueConditions(XmlWriter writer, string prefix, string[] conditions)
        {
            writer.WriteStartElement(prefix + Constants.VALUE_CONDITION);
            foreach (var condition in conditions)
            {
                WriteCondition(writer, condition);
            }
            writer.WriteEndElement();
        }

        private static void WriteCondition(XmlWriter writer, string name)
        {
            writer.WriteStartElement(name.LowerCase());
            writer.WriteString(name);
            writer.WriteEndElement();
        }

        internal static void Close(XmlWriter writer)
        {
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
