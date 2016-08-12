using EPiServer.Personalization.VisitorGroups;
using EPiServer.Web.Mvc.VisitorGroups;
using System.ComponentModel.DataAnnotations;
using EPiServer.Data.Dynamic;

namespace FiftyOneDegrees.Models
{
    [EPiServerDataStore(AutomaticallyCreateStore = true)]
    public class PriceBand : EnumModel
    {
        [Required, DojoWidget(SelectionFactoryType = typeof(EnumSelectionFactory))]
        public Enums.PriceBand Value { get; set; }
    }
}