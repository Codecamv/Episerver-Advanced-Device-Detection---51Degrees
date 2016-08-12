using System.Security.Principal;
using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    public class EnumCriterionBase<T> : CriterionBase<T> where T : Models.EnumModel, new()
    {
        public override bool IsMatch(IPrincipal principal, System.Web.HttpContextBase httpContext)
        {
            bool value = false;

            bool.TryParse(httpContext.Request.Browser[typeof(T).Name], out value);

            switch (Model.Condition)
            {
                case Enums.EnumValueCondition.Is:
                    return value;
                case Enums.EnumValueCondition.IsNot:
                    return value == false;
                default:
                    return false;
            }
        }
    }
}
