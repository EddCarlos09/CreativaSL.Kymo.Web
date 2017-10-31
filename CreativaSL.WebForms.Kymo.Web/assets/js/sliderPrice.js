var Slider = function () {
    "use strict";
    //function to 
    var runSlider = function () {
            /*----------------------------
	         price-slider active
	        ------------------------------ */
        var minPrice = $("#amount2").data('minValue');
        var maxPrice = $("#amount2").data('maxValue');
            console.log(minPrice + ' ' + maxPrice);
            $("#slider-range").slider({
                range: true,
                min: 100,
                max: 1000,
                values: [100, 1000],
                slide: function (event, ui) {
                    $("#amount").val("$" + ui.values[0] + " - $" + ui.values[1]);
                }
            });
            $("#amount").val("$" + $("#slider-range").slider("values", 0) +
                " - $" + $("#slider-range").slider("values", 1));
        };
    return {
        //main function to initiate template pages
        init: function () {
            runSlider();
        }
    };
}();
