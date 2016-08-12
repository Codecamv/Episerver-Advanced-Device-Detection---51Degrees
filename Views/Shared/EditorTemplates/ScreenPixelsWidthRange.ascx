<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<FiftyOneDegrees.Models.ScreenPixelsWidthRange>" %>
<%@ Assembly Name="FiftyOneDegrees" %>
<%@ Import Namespace="EPiServer.Personalization.VisitorGroups.Criteria" %>
<%@ Import Namespace="EPiServer.Personalization.VisitorGroups" %>
<%@ Import Namespace="FiftyOneDegrees.Helpers" %>

<div class="epi-criteria-grouping" data-property-name="ScreenPixelsWidth" data-min="<% =Model.Min %>" data-max="<% =Model.Max %>" >
    <style>
        .dijitNumberTextBox { width: 100%; }
    </style>
    <span class="epi-criteria-inlineblock">
        <% =Html.DojoEditorFor(x => x.Condition) %>
    </span>
    <% 
        var upgrade = Html.UpgradeLink("ScreenPixelsWidth");
        if (upgrade == null) {
    %>
    <span class="epi-criteria-inlineblock" style="width: 100px;">
        <% =Html.DojoEditorFor(x => x.Lower) %>
    </span>
    <span class="epi-criteria-inlineblock" style="width: 300px;">
        <span id="rangeSlider">
        </span>
    </span>
    <span class="epi-criteria-inlineblock" style="width: 100px;">
        <% =Html.DojoEditorFor(x => x.Upper) %>
    </span>
    <% } else { %>
    <% =upgrade %>
    <% } %>
</div>