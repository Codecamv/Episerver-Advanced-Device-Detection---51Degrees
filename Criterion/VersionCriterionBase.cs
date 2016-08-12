using System.Security.Principal;
using EPiServer.Personalization.VisitorGroups;
using FiftyOneDegrees.Enums;
using System;
using System.Linq;

namespace FiftyOneDegrees.Criterion
{
    public class VersionCriterionBase<T> : CriterionBase<T> where T : Models.VersionModel, new()
    {
        /// <summary>
        /// Used to split strings into version numbers separated by dots.
        /// </summary>
        private static char[] DOT = new char[] { '.' };

        public override bool IsMatch(IPrincipal principal, System.Web.HttpContextBase httpContext)
        {
            var stringValue = httpContext.Request.Browser[typeof(T).Name];
            var value = CreateVersion(stringValue);
            var target = CreateVersion(Model.Value);

            if (value != null && target != null)
            {
                // Compare the two versions using the CompareTo method of
                // the Version class.
                return Evaluate(Model.Condition, value, target);
            }
            else
            {
                // Compare the two versions using string comparison.
                return Evaluate(Model.Condition, stringValue, Model.Value);
            }
        }

        /// <summary>
        /// Convers the string value into a Version instance if it contains
        /// numbers separated by dots. If no version can be returned then
        /// null is returned.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static Version CreateVersion(string value)
        {
            Version version = null;
            if (value != null)
            {
                var segments = value.Split(DOT, StringSplitOptions.RemoveEmptyEntries);
                if (segments.Length > 0)
                {
                    var numbers = segments.Select(i =>
                        ToNumber(i)).Where(i =>
                        i != null).Select(i =>
                        i.Value).ToArray();
                    switch (numbers.Length)
                    {
                        case 0:
                            break;
                        case 1:
                            version = new Version(numbers[0], 0);
                            break;
                        case 2:
                            version = new Version(numbers[0], numbers[1]);
                            break;
                        case 3:
                            version = new Version(numbers[0], numbers[1], numbers[2]);
                            break;
                        default:
                        case 4:
                            version = new Version(numbers[0], numbers[1], numbers[2], numbers[3]);
                            break;
                    }
                }
            }
            return version;
        }

        private static int? ToNumber(string value)
        {
            int number;
            return int.TryParse(value, out number) ? number : new int?();
        }

        /// <summary>
        /// Evaluates the value to the target based on the condition applied.
        /// </summary>
        /// <typeparam name="V">
        /// Type of value and target (String or Version)
        /// </typeparam>
        /// <param name="condition"></param>
        /// <param name="value"></param>
        /// <param name="target"></param>
        /// <returns>
        /// True if the condition for the value and target are satisified, 
        /// otherwise false.
        /// </returns>
        private static bool Evaluate<V>(
            VersionValueCondition condition,
            V value, 
            V target) where V : IComparable<V>
        {
            switch (condition)
            {
                case VersionValueCondition.EqualTo:
                    return value.Equals(target);
                case VersionValueCondition.GreaterThan:
                    return value.CompareTo(target) > 0;
                case VersionValueCondition.GreaterThanOrEqualTo:
                    return value.CompareTo(target) >= 0;
                case VersionValueCondition.LessThan:
                    return value.CompareTo(target) < 0;
                case VersionValueCondition.LessThanOrEqualTo:
                    return value.CompareTo(target) <= 0;
                case VersionValueCondition.NotEqualTo:
                    return value.Equals(target) == false;
                default:
                    return false;
            }
        }
    }
}
