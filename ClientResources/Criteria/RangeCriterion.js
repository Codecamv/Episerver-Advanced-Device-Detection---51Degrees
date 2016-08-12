dojo.require("dojox.form.RangeSlider");
dojo.require("dojo.NodeList-traverse");

// %2E needed to overcome a bug with some deployments where . (dot) is 
// converted to / (slash).
dojo.require('xstyle!dojox/form/resources/RangeSlider%2Ecss');

(function () {
    return {
        uiCreated: function (namingContainer, settings) {
            var container = dojo.query("#" + namingContainer + "rangeSlider")[0];
            if (container) {
                var min = dojo.query(container).closest("[data-min]")[0];
                var max = dojo.query(container).closest("[data-max]")[0];
                var lower = dijit.byId(namingContainer + "Lower");
                console.debug(lower);
                var upper = dijit.byId(namingContainer + "Upper");
                console.debug(upper);
                if (min && max && lower && upper) {
                    var minValue = min.getAttribute("data-min");
                    var maxValue = max.getAttribute("data-max");
                    lower.constraints.min = minValue;
                    lower.constraints.max = maxValue;
                    upper.constraints.min = minValue;
                    upper.constraints.max = maxValue;
                    var lowerValue = lower.get("value");
                    var upperValue = upper.get("value");
                    var rangeSlider = new dojox.form.HorizontalRangeSlider({
                        showButtons: false,
                        value: [lowerValue ? lowerValue : minValue, upperValue ? upperValue : maxValue],
                        minimum: minValue,
                        maximum: maxValue,
                        intermediateChanges: true,
                        style: "width:300px;",
                        onChange: function (value) {
                            this.lower.set("value", Math.round(value[0]));
                            this.upper.set("value", Math.round(value[1]));
                        }
                    }, "rangeSlider");
                    rangeSlider.lower = lower;
                    rangeSlider.upper = upper;
                    lower.rangeSlider = rangeSlider;
                    upper.rangeSlider = rangeSlider;
                    rangeSlider.placeAt(container);
                    lower.onChange = function (e) {
                        if (e >= this.rangeSlider.minimum && e <= this.rangeSlider.maximum) {
                            this.rangeSlider.value[0] = e;
                        }
                    }
                    upper.onChange = function (e) {
                        if (e <= this.rangeSlider.maximum && e >= this.rangeSlider.minimum) {
                            this.rangeSlider.value[1] = e;
                        }
                    }
                }
            }
        }
    }
})();