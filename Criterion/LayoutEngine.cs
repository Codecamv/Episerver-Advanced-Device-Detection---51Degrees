using EPiServer.Personalization.VisitorGroups;

namespace FiftyOneDegrees.Criterion
{
    [VisitorGroupCriterion(
        Category = "51Degrees Criteria",
        Description = "Refers to the name of the embedded technology the browser uses to display formatted content on the screen.",
        DisplayName = "Layout Engine",
        LanguagePath = "")]

    public class LayoutEngine : EnumCriterionBase<Models.LayoutEngine>
    {
    }
}
