using EPiServer.Personalization.VisitorGroups;
using FiftyOneDegrees.Enums;
using EPiServer.Web.Mvc.VisitorGroups;
using System.ComponentModel.DataAnnotations;

namespace FiftyOneDegrees.Models
{
    public abstract class VersionModel : CriterionModelBase
    {
        [Required, DojoWidget(SelectionFactoryType = typeof(EnumSelectionFactory))]
        public VersionValueCondition Condition { get; set; }

        [Required, DojoWidget(
            WidgetType = "dijit.form.ComboBox"
            )]
        public string Value { get; set; }

        public override ICriterionModel Copy()
        {
            return base.ShallowCopy();
        }
    }
}
