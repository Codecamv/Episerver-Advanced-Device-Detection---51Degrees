using EPiServer.Personalization.VisitorGroups;
using FiftyOne.Foundation.Mobile.Detection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using log4net;

namespace FiftyOneDegrees.Business
{
    public class PropertySelectionFactory<T> : ISelectionFactory
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(PropertySelectionFactory<T>));

        public IEnumerable<SelectListItem> GetSelectListItems(Type propertyType)
        {
            try
            {
                return GetPropertyList(typeof(T));
            }
            catch (Exception ex) 
            {
                Log.Info(ex);
            }
            return new List<SelectListItem>();
        }

        private IEnumerable<SelectListItem> GetPropertyList(Type propertyType)
        {
            var data = WebProvider.ActiveProvider.DataSet;
            return data.Properties.OrderBy(i => i.Name).Select(k => 
                new SelectListItem() { Text = k.Name, Value = k.Name }).OrderBy(i => i.Text);
        }
    }
}
