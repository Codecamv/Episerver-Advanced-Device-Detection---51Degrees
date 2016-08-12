using System;
using System.Security.Principal;
using EPiServer.Personalization.VisitorGroups;
using FiftyOneDegrees.Enums;

namespace FiftyOneDegrees.Criterion
{
    public class AllPropertiesCriterionBase<T> : CriterionBase<T> where T : Models.AllProperties, new()
    {
        public override bool IsMatch(IPrincipal principal, System.Web.HttpContextBase httpContext)
        {
            var value = httpContext.Request.Browser[Model.Property];
            if (value != null)
            {
                switch (Model.Condition)
                {
                    case StringValueCondition.Contains:
                        return value.Contains(Model.Value);
                    case StringValueCondition.DoesNotContain:
                        return value.Contains(Model.Value) == false;
                    case StringValueCondition.DoesNotEqual:
                        return value.Equals(Model.Value, StringComparison.InvariantCultureIgnoreCase) == false;
                    case StringValueCondition.EndsWith:
                        return value.EndsWith(Model.Value, StringComparison.InvariantCultureIgnoreCase);
                    case StringValueCondition.Equals:
                        return value.Equals(Model.Value, StringComparison.InvariantCultureIgnoreCase);
                    case StringValueCondition.StartsWith:
                        return value.StartsWith(Model.Value, StringComparison.InvariantCultureIgnoreCase);
                    default:
                        return false;
                }
            }
            return false;
        }
    }
}
