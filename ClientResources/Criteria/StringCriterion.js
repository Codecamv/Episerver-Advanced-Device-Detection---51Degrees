dojo.require("epi-cms.ErrorDialog");
dojo.require("dojo.NodeList-traverse");
dojo.require("dojo.store.Memory");

(function () {
    return {
        uiCreated: function (namingContainer, settings) {
            var widget = dojo.byId(namingContainer + 'Value');
            if (widget) {
                var parent = dojo.query(widget).closest("[data-property-name]")[0];
                if (parent) {
                    dojo.xhrGet({
                        url: '../../FiftyOneDegrees/StringCriterion/GetValuesForProperty',
                        content: { propertyName: parent.getAttribute("data-property-name") },
                        handleAs: 'json',
                        preventCache: false,
                        error: epi.cms.ErrorDialog.showXmlHttpError,
                        load: function (jsonData) {
                            var widget = dijit.byId(namingContainer + 'Value');
                            widget.store = new dojo.store.Memory({
                                data: jsonData
                            });
                        }
                    });
                }
            }
        }
    }
})();