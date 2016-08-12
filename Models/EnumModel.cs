using EPiServer.Personalization.VisitorGroups;
using FiftyOneDegrees.Enums;
using EPiServer.Web.Mvc.VisitorGroups;
using System.ComponentModel.DataAnnotations;

namespace FiftyOneDegrees.Models
{
    public abstract class EnumModel : CriterionModelBase
    {
        [Required, DojoWidget(SelectionFactoryType = typeof(EnumSelectionFactory))]
        public EnumValueCondition Condition { get; set; }

        public override ICriterionModel Copy()
        {
            return base.ShallowCopy();
        }
    }
}
