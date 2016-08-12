using EPiServer.Personalization.VisitorGroups;
using FiftyOneDegrees.Enums;
using EPiServer.Web.Mvc.VisitorGroups;
using System.ComponentModel.DataAnnotations;

namespace FiftyOneDegrees.Models
{
    public abstract class BooleanModel : CriterionModelBase, ICriterionModel
    {
        [Required, DojoWidget(SelectionFactoryType = typeof(EnumSelectionFactory))]
        public BooleanValueCondition Condition { get; set; }

        public override ICriterionModel Copy()
        {
            return base.ShallowCopy();
        }
    }
}
