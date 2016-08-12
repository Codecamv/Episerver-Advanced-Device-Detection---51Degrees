using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "{Description}",
        DisplayName = "{Display Name}",
        LanguagePath = "")]

    public class {Name} : BooleanCriterionBase<Models.{Name}>
    {
    }
}
