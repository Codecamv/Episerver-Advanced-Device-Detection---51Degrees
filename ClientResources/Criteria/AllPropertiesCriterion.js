dojo.require("epi-cms.ErrorDialog");
dojo.require("dojo.NodeList-traverse");
dojo.require("dojo.store.Memory");

(function () {
    return {
        uiCreated: function (namingContainer, settings) {
            var propertyWidget = dijit.byId(namingContainer + "Property");
            if (propertyWidget) {
                propertyWidget.onChange = function (propertyName) {
                    dojo.xhrGet({
                        url: '../../FiftyOneDegrees/StringCriterion/GetValuesForProperty',
                        content: { propertyName: propertyName },
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