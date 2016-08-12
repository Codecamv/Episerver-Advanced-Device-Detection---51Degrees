using FiftyOne.Foundation.Mobile.Detection;
using System.Linq;
using System.Web.Mvc;

namespace FiftyOneDegrees.Controllers
{
    [Authorize(Roles = "CmsAdmins, VisitorGroupAdmins")]
    public class StringCriterionController : Controller
    {
        public JsonResult GetValuesForProperty(string propertyName)
        {
            var property = WebProvider.ActiveProvider.DataSet.Properties[propertyName];
            if (property != null)
            {
                return Json(new {
                        identifier = "id",
                        label = "name",
                        items = property.Values.OrderBy(i => 
                            i.Name).Select(i => 
                            new { id = i.Name, name = i.Name })
                    }, JsonRequestBehavior.AllowGet);
            }
            return null;
        }
    }
}
