using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Refers to the version or subversion of the browser.",
        DisplayName = "Browser Version",
        ScriptUrl = "ClientResources/Criteria/StringCriterion.js",
        LanguagePath = "")]

    public class BrowserVersion : VersionCriterionBase<Models.BrowserVersion>
    {
    }
}
