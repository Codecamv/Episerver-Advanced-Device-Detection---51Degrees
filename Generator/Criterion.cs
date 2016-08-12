using FiftyOne.Foundation.Mobile.Detection.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyOneDegreesVisitorGroupGenerator
{
    internal static class Criterion
    {
        internal static void Write(string folder, Property property, string suffix = "")
        {
            var contents = Helper.GetResourceAsString(
                property.TemplatePrefix(suffix) +
                "Criterion.cs");
            contents = contents.Replace(
                "{Name}", 
                property.Name);
            contents = contents.Replace(
                "{Display Name}", 
                property.DisplayName());
            contents = contents.Replace(
                "{Description}", 
                property.Description);
            File.WriteAllText(Path.Combine(
                folder, 
                property.Name + suffix + ".cs"), contents);
        }
    }
}
