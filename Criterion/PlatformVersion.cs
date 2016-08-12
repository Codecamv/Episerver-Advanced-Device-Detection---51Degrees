using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Refers to the version or subversion of the software platform.",
        DisplayName = "Platform Version",
        ScriptUrl = "ClientResources/Criteria/StringCriterion.js",
        LanguagePath = "")]

    public class PlatformVersion : VersionCriterionBase<Models.PlatformVersion>
    {
    }
}
