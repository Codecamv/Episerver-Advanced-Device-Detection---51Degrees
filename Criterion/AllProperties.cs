
using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Use any available 51Degrees property and value combination.",
        DisplayName = "All Properties",
        ScriptUrl = "ClientResources/Criteria/AllPropertiesCriterion.js",
        LanguagePath = "")]
    public class AllProperties : AllPropertiesCriterionBase<Models.AllProperties>
    {
    }
}
