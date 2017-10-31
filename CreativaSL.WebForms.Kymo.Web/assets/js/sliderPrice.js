var Slider = function () {
    "use strict";
    //function to 
    var runSlider = function () {
        /*----------------------------
	     price-slider active
	    ------------------------------ */
        //var maxp = 
        //var minp = ;
        //console.log(maxp + ' - ' + minp);
            $("#slider-range").slider({
                range: true,
                min: $('#rngPrice').data('min'),
                max: $('#rngPrice').data('max'),
                values: [$('#rngPrice').data('min'), $('#rngPrice').data('max')],
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


//<aside class="single-aside price-aside fix">
//<div class="heading-title aside-title pos-rltv">
//    <h5 class="uppercase">Precio</h5> 
//</div>
//<div class="price_filter">
//    <div id="slider-range" ></div>
//    <div class="price_slider_amount">
//        <input type="text" id="amount" name="amount" placeholder="Add Your Price" />
//        <input type="submit" value="Filter" /> 
//    </div>
//</div>
//</aside>