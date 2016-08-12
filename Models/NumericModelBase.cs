using EPiServer.DataAnnotations;
using EPiServer.Personalization.VisitorGroups;
using EPiServer.Framework.Localization;
using FiftyOne.Foundation.Mobile.Detection;
using System;
using System.Linq;

namespace FiftyOneDegrees.Models
{
    public abstract class NumericModelBase : CriterionModelBase
    {
        [Ignore]
        public double Min { get; protected set; }

        [Ignore]
        public double Max { get; protected set; }

        [Ignore]
        public string RangeMessage { get; private set; }

        public NumericModelBase()
        {
            var name = GetType().Name.Replace("Range", "");
            var property = WebProvider.ActiveProvider.DataSet.Properties[name];
            if (property != null && property.Values.Count > 0)
            {
                var values = property.Values.Select(i => i.ToDouble()).OrderBy(i => i);
                Min = values.First();
                Max = values.Last();
                RangeMessage = String.Format(
                    LocalizationService.Current.GetString(
                        "/messages/FiftyOneDegrees/numeric"),
                    property.Name,
                    Min, 
                    Max);
            }
            else
            {
                Min = double.MinValue;
                Max = double.MaxValue;
                RangeMessage = String.Empty;
            }
        }

        public override ICriterionModel Copy()
        {
            return base.ShallowCopy();
        }
    }
}
