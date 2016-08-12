using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyOneDegreesVisitorGroupGenerator
{
    internal class Helper
    {
        internal static string GetResourceAsString(string name)
        {
            return new StreamReader(
                typeof(Enum).Assembly.GetManifestResourceStream(
                    "FiftyOneDegreesVisitorGroupGenerator.templates." + name)).
                ReadToEnd();
        }
    }
}
