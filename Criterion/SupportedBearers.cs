using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Refers to the list of wireless data technologies supported by the device, including Bluetooth. If the device supports phone calls, the SMS value is also returned.",
        DisplayName = "Supported Bearers",
        LanguagePath = "")]

    public class SupportedBearers : EnumCriterionBase<Models.SupportedBearers>
    {
    }
}
