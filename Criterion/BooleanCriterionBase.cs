using System.Security.Principal;
using EPiServer.Personalization.VisitorGroups;
using FiftyOneDegrees.Enums;

namespace FiftyOneDegrees.Criterion
{
    public class BooleanCriterionBase<T> : CriterionBase<T> where T : Models.BooleanModel, new()
    {
        public override bool IsMatch(IPrincipal principal, System.Web.HttpContextBase httpContext)
        {
            bool value = false;

            bool.TryParse(httpContext.Request.Browser[typeof(T).Name], out value);

            switch (Model.Condition)
            {
                case BooleanValueCondition.True:
                    return value;
                case BooleanValueCondition.False:
                    return value == false;
                default:
                    return false;
            }
        }
    }
}
