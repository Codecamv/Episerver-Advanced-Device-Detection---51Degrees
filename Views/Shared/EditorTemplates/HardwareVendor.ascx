<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<FiftyOneDegrees.Models.HardwareVendor>" %>
<%@ Assembly Name="FiftyOneDegrees" %>
<%@ Import Namespace="EPiServer.Personalization.VisitorGroups.Criteria" %>
<%@ Import Namespace="EPiServer.Personalization.VisitorGroups" %>
<%@ Import Namespace="FiftyOneDegrees.Helpers" %>

<div class="epi-criteria-grouping" data-property-name="HardwareVendor">
    <span class="epi-criteria-inlineblock">
        <% =Html.DojoEditorFor(x => x.Condition) %>
    </span>
    <span class="epi-criteria-inlineblock">
        <% =Html.DojoEditorFor(x => x.Value) %>
    </span>
    <% =Html.UpgradeLink("HardwareVendor") %>
</div>