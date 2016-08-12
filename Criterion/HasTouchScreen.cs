using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Indicates if the device has a touch screen. This property will return 'False' for a device that does not have an integrated screen.",
        DisplayName = "Has Touch Screen",
        LanguagePath = "")]

    public class HasTouchScreen : BooleanCriterionBase<Models.HasTouchScreen>
    {
    }
}
