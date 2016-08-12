dojo.require("epi-cms.ErrorDialog");
dojo.require("dojo.NodeList-traverse");

(function () {
    return {
        uiCreated: function (namingContainer, settings) {
            var container = dojo.query("#" + namingContainer + "Value")[0];
            if (container) {
                var min = dojo.query(container).closest("[data-min]")[0];
                var max = dojo.query(container).closest("[data-max]")[0];
                var widget = dijit.byId(namingContainer + 'Value');
                if (widget && min && max) {
                    widget.constraints.min = min.getAttribute("data-min");
                    widget.constraints.max = max.getAttribute("data-max");
                }
            }
        }
    }
})();