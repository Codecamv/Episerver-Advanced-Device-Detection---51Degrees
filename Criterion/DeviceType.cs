using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Indicates the type of the device based on values set in other properties, such as IsMobile, IsTablet, IsSmartphone, IsSmallScreen etc. Note that if the device runs on a smart operating system such as Android, Windows Phone etc. but the screen size is less than 2.5 inches, the 'DeviceType' property returns 'SmallScreen'.",
        DisplayName = "Device Type",
        LanguagePath = "")]

    public class DeviceType : EnumCriterionBase<Models.DeviceType>
    {
    }
}
