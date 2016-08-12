using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Refers to the name of the software platform (operating system) the device is using.",
        DisplayName = "Platform Name",
        ScriptUrl = "ClientResources/Criteria/StringCriterion.js",
        LanguagePath = "")]

    public class PlatformName : StringCriterionBase<Models.PlatformName>
    {
    }
}
