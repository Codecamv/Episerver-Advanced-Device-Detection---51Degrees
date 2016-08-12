using FiftyOne.Foundation.Mobile.Detection.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyOneDegreesVisitorGroupGenerator
{
    internal static class Enum
    {
        internal static void Write(string folder, Property property)
        {
            var contents = Helper.GetResourceAsString("Enum.cs");
            contents = contents.Replace("{Name}", property.Name);
            contents = contents.Replace("{Enum}", GetEnumeration(property));
            File.WriteAllText(Path.Combine(folder, property.Name + ".cs"), contents);
        }

        private static string GetEnumeration(Property property)
        {
            var sb = new StringBuilder();
            foreach(var value in property.Values.OrderBy(i => i.Name))
            {
                if (String.IsNullOrWhiteSpace(value.Description) == false)
                {
                    sb.AppendFormat("\t\t// {0}\r\n", value.Description);
                }
                sb.AppendFormat("\t\t[FiftyOneKey(\"{0}\")]\r\n", value.Name);
                sb.AppendFormat("\t\t{0},\r\n", value.ElementName());
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
