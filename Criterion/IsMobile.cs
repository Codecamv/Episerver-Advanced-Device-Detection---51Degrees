using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Indicates if the device's primary data connection is wireless and the device is designed to operate mostly by battery power (e.g. mobile phone, smartphone or tablet). This property does not indicate if the device is a mobile phone or not. Laptops are not classified as mobile devices under this definition and so 'IsMobile' will be 'False'.",
        DisplayName = "Is Mobile",
        LanguagePath = "")]

    public class IsMobile : BooleanCriterionBase<Models.IsMobile>
    {
    }
}
