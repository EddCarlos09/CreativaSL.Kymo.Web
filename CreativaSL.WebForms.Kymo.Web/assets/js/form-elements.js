var FormElements = function() {"use strict";
    //function to initiate Select2
	var runSelect2 = function () {
	    var nodoTr = document.getElementsByClassName("search-select");
	    if (nodoTr.length > 0) {
	        $(".search-select").select2({
	            placeholder: " -- Seleccione -- ",
	            allowClear: false
	        });
	    }
	};
	return {
		//main function to initiate template pages
		init: function() {
			runSelect2();
		}
	};
}();
