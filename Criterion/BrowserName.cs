using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Refers to the name of the browser. Many mobile browsers, by default, come with an operating system (OS). Unless specifically named, these browsers are named after the accompanying OS and/or the layout engine. ",
        DisplayName = "Browser Name",
        ScriptUrl = "ClientResources/Criteria/StringCriterion.js",
        LanguagePath = "")]

    public class BrowserName : StringCriterionBase<Models.BrowserName>
    {
    }
}
