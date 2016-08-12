using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Refers to the diagonal size of the device's screen in inches. This property is not applicable for a device that does not have a screen and will return the value 'Unknown' for desktop.",
        DisplayName = "Screen Inches Diagonal",
        ScriptUrl = "ClientResources/Criteria/NumberTextBox.js",
        LanguagePath = "")]

    public class ScreenInchesDiagonal : NumericCriterionBase<Models.ScreenInchesDiagonal>
    {
    }
}
