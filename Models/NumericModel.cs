using EPiServer.Personalization.VisitorGroups;
using FiftyOneDegrees.Enums;
using EPiServer.Web.Mvc.VisitorGroups;
using System.ComponentModel.DataAnnotations;

namespace FiftyOneDegrees.Models
{
    public abstract class NumericModel : NumericModelBase
    {
        [Required, DojoWidget(SelectionFactoryType = typeof(EnumSelectionFactory))]
        public NumericValueCondition Condition { get; set; }

        [Required, DojoWidget(WidgetType = "dijit.form.NumberTextBox")]
        public double Value { get; set; }

        public override ICriterionModel Copy()
        {
            return base.ShallowCopy();
        }
    }
}
