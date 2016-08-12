using EPiServer.Personalization.VisitorGroups;
using FiftyOne.Foundation.Mobile.Detection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using log4net;

namespace FiftyOneDegrees.Business
{
    public class PropertyValueSelectionFactory<T> : ISelectionFactory
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(PropertySelectionFactory<T>));

        public IEnumerable<SelectListItem> GetSelectListItems(Type propertyType)
        {
            try
            {
                return GetValuesList(typeof(T));
            }
            catch (Exception ex) 
            {
                Log.Info(ex);
            }
            return new List<SelectListItem>();
        }

        private IEnumerable<SelectListItem> GetValuesList(Type propertyType)
        {
            var data = WebProvider.ActiveProvider.DataSet;
            return data.Properties[propertyType.Name].Values.OrderBy(i => 
                i.Name).Select(k => 
                new SelectListItem() { Text = k.Name, Value = k.Name });
        }
    }
}
