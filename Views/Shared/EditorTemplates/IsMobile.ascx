<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<FiftyOneDegrees.Models.IsMobile>" %>
<%@ Assembly Name="FiftyOneDegrees" %>
<%@ Import Namespace="EPiServer.Personalization.VisitorGroups.Criteria" %>
<%@ Import Namespace="EPiServer.Personalization.VisitorGroups" %>
<%@ Import Namespace="FiftyOneDegrees.Helpers" %>

<div class="epi-criteria-grouping">
    <span class="epi-criteria-inlineblock">
        <% =Html.DojoEditorFor(x => x.Condition) %>
    </span>
    <% =Html.UpgradeLink("IsMobile") %>
</div>