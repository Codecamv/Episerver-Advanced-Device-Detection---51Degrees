<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<FiftyOneDegrees.Models.PlatformVendor>" %>
<%@ Assembly Name="FiftyOneDegrees" %>
<%@ Import Namespace="EPiServer.Personalization.VisitorGroups.Criteria" %>
<%@ Import Namespace="EPiServer.Personalization.VisitorGroups" %>
<%@ Import Namespace="FiftyOneDegrees.Helpers" %>

<div class="epi-criteria-grouping" data-property-name="PlatformVendor">
    <span class="epi-criteria-inlineblock">
        <% =Html.DojoEditorFor(x => x.Condition) %>
    </span>
    <span class="epi-criteria-inlineblock">
        <% =Html.DojoEditorFor(x => x.Value) %>
    </span>
    <% =Html.UpgradeLink("PlatformVendor") %>
</div>