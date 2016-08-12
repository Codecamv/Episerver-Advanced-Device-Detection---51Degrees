using System.Security.Principal;
using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    public class RangeCriterionBase<T> : CriterionBase<T> where T : Models.RangeModel, new()
    {
        public override bool IsMatch(IPrincipal principal, System.Web.HttpContextBase httpContext)
        {
            double value;
            var name = typeof(T).Name.Replace("Range", "");

            if (double.TryParse(httpContext.Request.Browser[name], out value))
            {
                var result = value >= Model.Min && value <= Model.Max;
                switch (Model.Condition)
                {
                    case Enums.RangeValueCondition.Between:
                        return result;
                    case Enums.RangeValueCondition.IsNotBetween:
                        return result == false;
                    default:
                        return false;
                }
            }
            return false;
        }
    }
}
