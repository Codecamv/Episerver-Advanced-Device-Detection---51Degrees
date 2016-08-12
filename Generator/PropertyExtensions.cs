using FiftyOne.Foundation.Mobile.Detection.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiftyOneDegreesVisitorGroupGenerator
{
    internal static class PropertyExtensions
    {
        internal static string LowerCase(this Property property)
        {
            return property.Name.LowerCase();
        }

        internal static string LowerCase(this Value value)
        {
            return value.Name.LowerCase();
        }

        internal static string LowerCase(this String value)
        {
            return new String(value.NoSpace().Select(i =>
                char.ToLowerInvariant(i)).ToArray());
        }

        internal static string ElementName(this Value value)
        {
            return "v" + new String(value.Name.Select(i =>
                char.IsLetterOrDigit(i) ? i : '_').Select(i =>
                char.ToLowerInvariant(i)).ToArray());
        }

        internal static string NoSpace(this Property property)
        {
            return property.Name.NoSpace();
        }

        internal static string NoSpace(this Value value)
        {
            return value.Name.NoSpace();
        }

        internal static string NoSpace(this string value)
        {
            return new String(value.Where(i =>
                char.IsWhiteSpace(i) == false).ToArray());
        }

        internal static string DisplayName(this Property property)
        {
            return GetDisplayName(property.Name);
        }

        internal static string DisplayName(this Value value)
        {
            return GetDisplayName(value.Name);
        }

        private static string GetDisplayName(string value)
        {
            var chars = new LinkedList<char>(value);
            var current = chars.First.Next;
            while (current != null)
            {
                if (char.IsUpper(current.Value))
                {
                    chars.AddBefore(current, ' ');
                }
                current = current.Next;
            }
            return new String(chars.ToArray());
        }

        internal static string TemplatePrefix(this Property property, string suffix)
        {
            if (suffix.Equals("Range"))
            {
                return "Range";
            }
            if (Constants.LookupProperties.Contains(property.Name))
            {
                return "Enum";
            }
            if (property.Name.EndsWith("Version"))
            {
                return "Version";
            }
            if (property.ValueType == typeof(string) ||
                "HardwareVendor" == property.Name)
            {
                return "String";
            }
            if (property.ValueType == typeof(bool))
            {
                return "Boolean";
            }
            if (property.ValueType == typeof(int) ||
                property.ValueType == typeof(double))
            {
                return "Numeric";
            }
            throw new ArgumentException(String.Format(
                "Property '{0}' with type '{1}' not supported",
                property.Name,
                property.ValueType.Name));
        }
    }
}
