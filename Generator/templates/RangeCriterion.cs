using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Ranged - {Description}",
        DisplayName = "{Display Name} (Range)",
        ScriptUrl = "ClientResources/Criteria/RangeCriterion.js",
        LanguagePath = "")]

    public class {Name}Range : RangeCriterionBase<Models.{Name}Range>
    {
    }
}
