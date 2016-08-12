using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Refers to the name of the company that manufactures the device or primarily sells it, e.g. Samsung.",
        DisplayName = "Hardware Vendor",
        ScriptUrl = "ClientResources/Criteria/StringCriterion.js",
        LanguagePath = "")]

    public class HardwareVendor : StringCriterionBase<Models.HardwareVendor>
    {
    }
}
