using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "{Description}",
        DisplayName = "{Display Name}",
        ScriptUrl = "ClientResources/Criteria/NumberTextBox.js",
        LanguagePath = "")]

    public class {Name} : NumericCriterionBase<Models.{Name}>
    {
    }
}
