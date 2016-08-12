using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Indicates if the device can receive and make telephone calls using available bearers without any additional software such as VoIP. Devices that support voice calls do not necessarily support phone calls.",
        DisplayName = "Supports Phone Calls",
        LanguagePath = "")]

    public class SupportsPhoneCalls : BooleanCriterionBase<Models.SupportsPhoneCalls>
    {
    }
}
