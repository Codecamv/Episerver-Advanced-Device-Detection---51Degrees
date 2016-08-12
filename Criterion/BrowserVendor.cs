using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Refers to the name of the company which created the browser.",
        DisplayName = "Browser Vendor",
        ScriptUrl = "ClientResources/Criteria/StringCriterion.js",
        LanguagePath = "")]

    public class BrowserVendor : StringCriterionBase<Models.BrowserVendor>
    {
    }
}
