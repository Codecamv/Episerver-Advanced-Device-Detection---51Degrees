using EPiServer.Data.Dynamic;
using EPiServer.Personalization.VisitorGroups;
using FiftyOneDegrees.Business;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FiftyOneDegrees.Models
{
    [EPiServerDataStore(AutomaticallyCreateStore = true)]
    public class AllProperties : StringModel
    {
        [Required, DojoWidget(
            SelectionFactoryType = typeof(PropertySelectionFactory<SelectListItem>)
            )]
        public string Property { get; set; }
    }
}
