using EPiServer.Personalization.VisitorGroups;
using FiftyOneDegrees.Enums;
using EPiServer.Web.Mvc.VisitorGroups;
using System.ComponentModel.DataAnnotations;
using FiftyOne.Foundation.Mobile.Detection;
using System.Linq;
using System.Collections.Generic;

namespace FiftyOneDegrees.Models
{
    public abstract class RangeModel : NumericModelBase
    {
        [Required, DojoWidget(SelectionFactoryType = typeof(EnumSelectionFactory))]
        public RangeValueCondition Condition { get; set; }

        [Required, DojoWidget(WidgetType = "dijit.form.NumberTextBox")]
        public double Lower { get; set; }

        [Required, DojoWidget(WidgetType = "dijit.form.NumberTextBox")]
        public double Upper { get; set; }

        public RangeModel()
        {
            var values = GetValues();
            Min = values.First();
            Max = values.Last();
        }

        public override ICriterionModel Copy()
        {
            return base.ShallowCopy();
        }

        private IEnumerable<double> GetValues()
        {
            var name = GetType().Name.Replace("Range", "");
            var property = WebProvider.ActiveProvider.DataSet.Properties[name];
            if (property != null && property.Values.Count > 0)
            {
                return property.Values.Select(i => i.ToDouble()).OrderBy(i => i);
            }
            return new double[] { double.MinValue, double.MaxValue };
        }
    }
}
