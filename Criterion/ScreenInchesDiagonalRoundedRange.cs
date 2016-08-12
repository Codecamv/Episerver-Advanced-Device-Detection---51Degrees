using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Ranged - The diagonal size of the device's screen in inches rounded to the nearest whole number. This property will return the value 'Unknown' for desktop or for devices which do not have an integrated screen.",
        DisplayName = "Screen Inches Diagonal Rounded (Range)",
        ScriptUrl = "ClientResources/Criteria/RangeCriterion.js",
        LanguagePath = "")]

    public class ScreenInchesDiagonalRoundedRange : RangeCriterionBase<Models.ScreenInchesDiagonalRoundedRange>
    {
    }
}
