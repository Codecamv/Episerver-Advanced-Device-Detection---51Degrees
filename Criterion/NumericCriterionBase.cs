using System.Security.Principal;
using EPiServer.Personalization.VisitorGroups;
using FiftyOneDegrees.Enums;

namespace FiftyOneDegrees.Criterion
{
    public class NumericCriterionBase<T> : CriterionBase<T> where T : Models.NumericModel, new()
    {
        public override bool IsMatch(IPrincipal principal, System.Web.HttpContextBase httpContext)
        {
            double value = 0;

            double.TryParse(httpContext.Request.Browser[typeof(T).Name], out value);

            switch (Model.Condition)
            {
                case NumericValueCondition.EqualTo:
                    return value.Equals(Model.Value);
                case NumericValueCondition.GreaterThan:
                    return value > Model.Value;
                case NumericValueCondition.GreaterThanOrEqualTo:
                    return value >= Model.Value;
                case NumericValueCondition.LessThan:
                    return value < Model.Value;
                case NumericValueCondition.LessThanOrEqualTo:
                    return value <= Model.Value;
                case NumericValueCondition.NotEqualTo:
                    return value != Model.Value;
                default:
                    return false;
            }
        }
    }
}
