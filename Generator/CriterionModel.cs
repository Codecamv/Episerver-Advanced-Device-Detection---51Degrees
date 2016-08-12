using FiftyOne.Foundation.Mobile.Detection.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyOneDegreesVisitorGroupGenerator
{
    internal static class CriterionModel
    {
        internal static void Write(string folder, Property property, string suffix = "")
        {
            var contents = Helper.GetResourceAsString(
                property.TemplatePrefix(suffix) + 
                "CriterionModel.cs");
            contents = contents.Replace(
                "{Name}", 
                property.Name);
            File.WriteAllText(Path.Combine(
                folder, 
                property.Name + suffix + ".cs"), contents);
        }
    }
}
