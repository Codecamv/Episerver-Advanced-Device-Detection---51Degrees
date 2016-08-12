using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "The device is classified as a tablet if the manufacturer sells the device primarily as a tablet, or if the device is primarily advertised as a phablet and has a screen size equal to or greater than 7 inches.",
        DisplayName = "Is Tablet",
        LanguagePath = "")]

    public class IsTablet : BooleanCriterionBase<Models.IsTablet>
    {
    }
}
