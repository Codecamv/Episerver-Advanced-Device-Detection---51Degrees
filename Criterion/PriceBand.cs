using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Indicates a price range describing the recommended retail price of the device at the date of first release in its home market, inclusive of tax (where applicable).  Prices are in United States Dollars (USD); if the price is not originally in USD it will be converted to USD using the relevant exchange rate at the time of launch. Prices are for the SIM-free version of the device (if applicable). In cases where there are several versions of the same model of the device, the price will reflect the device that was used to populate the specifications. In cases where the price is not stated by the manufacturer, another reliable source will be used. If the device is released immediately to the global market then the price will be based on the US market.",
        DisplayName = "Price Band",
        LanguagePath = "")]

    public class PriceBand : EnumCriterionBase<Models.PriceBand>
    {
    }
}
