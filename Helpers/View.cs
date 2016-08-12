using EPiServer.Personalization.VisitorGroups;
using System;
using System.Web.Mvc;
using EPiServer.Framework.Localization;
using EPiServer.Web.Mvc.Html;
using System.Collections.Generic;
using FiftyOne.Foundation.Mobile.Detection;

namespace FiftyOneDegrees.Helpers
{
    public static class View
    {
        public static MvcHtmlString UpgradeLink(this HtmlHelper html, string propertyName)
        {
            MvcHtmlString result = null;
            if (WebProvider.ActiveProvider.DataSet.Properties[propertyName] == null)
            {
                var title = GetString(propertyName, "title");
                var url = new EPiServer.Url(GetString(propertyName, "url"));
                result = new MvcHtmlString(String.Format(
                    "<a target=\"_blank\" href=\"{0}\" class=\"epi-visibleLink\" title=\"{1}\">{2}</a>",
                    url,
                    title,
                    LocalizationService.Current.GetString("/FiftyOneDegrees/upgrade/button")));
            }
            return result;
        }

        private static string GetString(string propertyName, string attribute)
        {
            return LocalizationService.Current.GetString(String.Format(
                "/FiftyOneDegrees/upgrade/{0}/{1}",
                propertyName.ToLowerInvariant(),
                attribute.ToLowerInvariant()));
        }
    }
}
