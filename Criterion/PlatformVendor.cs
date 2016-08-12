using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Refers to the name of the company that developed the operating system.",
        DisplayName = "Platform Vendor",
        ScriptUrl = "ClientResources/Criteria/StringCriterion.js",
        LanguagePath = "")]

    public class PlatformVendor : StringCriterionBase<Models.PlatformVendor>
    {
    }
}
