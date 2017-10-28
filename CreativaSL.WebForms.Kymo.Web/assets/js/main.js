/*

Template:  clothing- Responsive Multi-purpose HTML5 Template
Template URI: http://bootexperts.com
Description: This is html5 template
Author: BootExperts
Author URI: http://bootexperts.com
Version: 1.0

*/
/*================================================
[  Table of contents  ]
================================================
	01. jQuery MeanMenu
	02. wow js active
	03. scrollUp jquery active
	04. slick carousel 

 
======================================
[ End table content ]
======================================*/


(function($) {
    "use strict";

    /*-------------------------------------------
    	01. jQuery MeanMenu
    --------------------------------------------- */
    jQuery('nav#dropdown').meanmenu();


    /*-------------------------------------------
    	02. wow js active
    --------------------------------------------- */
    new WOW().init();


	/*--------------------------
	 scrollUp
	---------------------------- */	
	$.scrollUp({
        scrollText: "<i class='zmdi zmdi-arrow-merge'></i>",
        easingType: 'linear',
        scrollSpeed: 900,
        animation: 'fade'
    }); 

	/*-------------------------------------------
	04. slick carousel 
	--------------------------------------------- */    
	$('.new-arrival-slider-active').slick({
	slidesToShow: 4,
	slidesToScroll: 1,
	autoplay: false,
	autoplaySpeed: 5000,
	dots: false,
	arrows: true,
	prevArrow: '<div class="arrow-left"><i class="zmdi zmdi-chevron-left"></i></div>',
	nextArrow: '<div class="arrow-right"><i class="zmdi zmdi-chevron-right"></i></div>',
	responsive: [
	{  breakpoint: 1169,  settings: { slidesToShow: 4,  }  },
	{  breakpoint: 969,   settings: { slidesToShow: 3,  }  },
	{  breakpoint: 767,   settings: { slidesToShow: 2, }   },
	{  breakpoint: 479,   settings: { slidesToShow: 1, }   },
	]
	});  
	
	$('.ctg-slider-active').slick({
	slidesToShow: 1,
	slidesToScroll: 1,
	autoplay: false,
	autoplaySpeed: 5000,
	dots: false,
	arrows: false,
	prevArrow: '<div class="arrow-left"><i class="zmdi zmdi-chevron-left"></i></div>',
	nextArrow: '<div class="arrow-right"><i class="zmdi zmdi-chevron-right"></i></div>',
	responsive: [
	{  breakpoint: 1169,  settings: { slidesToShow: 1,  }  },
	{  breakpoint: 969,   settings: { slidesToShow: 1,  }  },
	{  breakpoint: 767,   settings: { slidesToShow: 1, }   },
	{  breakpoint: 479,   settings: { slidesToShow: 1, }   },
	]
	});
	$('.total-rectnt-slider').slick({
	slidesToShow: 1,
	slidesToScroll: 1,
	autoplay: false,
	autoplaySpeed: 5000,
	dots: false,
	arrows: false,
	responsive: [
	{  breakpoint: 1169,  settings: { slidesToShow: 1,  }  },
	{  breakpoint: 969,   settings: { slidesToShow: 1,  }  },
	{  breakpoint: 767,   settings: { slidesToShow: 1, }   },
	{  breakpoint: 479,   settings: { slidesToShow: 1, }   },
	]
	});
	
	$('.active-slider').slick({
	slidesToShow: 1,
	slidesToScroll: 1,
	autoplay: false,
	autoplaySpeed: 5000,
	dots: true,
	arrows: false,
	responsive: [
	{  breakpoint: 1169,  settings: { slidesToShow: 1,  }  },
	{  breakpoint: 969,   settings: { slidesToShow: 1,  }  },
	{  breakpoint: 767,   settings: { slidesToShow: 1, }   },
	{  breakpoint: 479,   settings: { slidesToShow: 1, }   },
	]
	});
	
	$('.total-brand').slick({
	slidesToShow: 6,
	slidesToScroll: 1,
	autoplay: false,
	autoplaySpeed: 5000,
	dots: false,
	arrows: false,
	responsive: [
	{  breakpoint: 1169,  settings: { slidesToShow: 6,  }  },
	{  breakpoint: 969,   settings: { slidesToShow: 5,  }  },
	{  breakpoint: 767,   settings: { slidesToShow: 4, }   },
	{  breakpoint: 479,   settings: { slidesToShow: 3, }   },
	]
	});
	
	$('.team-carasoul').slick({
	slidesToShow: 4,
	slidesToScroll: 1,
	autoplay: false,
	autoplaySpeed: 5000,
	dots: false,
	arrows: false,
	responsive: [
	{  breakpoint: 1169,  settings: { slidesToShow: 3,  }  },
	{  breakpoint: 969,   settings: { slidesToShow: 3,  }  },
	{  breakpoint: 767,   settings: { slidesToShow: 2, }   },
	{  breakpoint: 479,   settings: { slidesToShow: 1, }   },
	]
	});
    
    $('.total-blog').slick({
	slidesToShow: 3,
	slidesToScroll: 1,
	autoplay: false,
	autoplaySpeed: 5000,
	dots: false,
	arrows: false,
	responsive: [
	{  breakpoint: 1169,  settings: { slidesToShow: 3,  }  },
	{  breakpoint: 969,   settings: { slidesToShow: 2,  }  },
	{  breakpoint: 767,   settings: { slidesToShow: 1, }   },
	{  breakpoint: 479,   settings: { slidesToShow: 1, }   },
	]
	});
	
	$('.total-blog-2').slick({
	slidesToShow: 2,
	slidesToScroll: 1,
	autoplay: false,
	autoplaySpeed: 5000,
	dots: false,
	arrows: false,
	responsive: [
	{  breakpoint: 1169,  settings: { slidesToShow: 2,  }  },
	{  breakpoint: 969,   settings: { slidesToShow: 2,  }  },
	{  breakpoint: 767,   settings: { slidesToShow: 1, }   },
	{  breakpoint: 479,   settings: { slidesToShow: 1, }   },
	]
	});
	$('.total-blog-3').slick({
	slidesToShow: 2,
	slidesToScroll: 1,
	autoplay: false,
	autoplaySpeed: 5000,
	dots: false,
	arrows: false,
	responsive: [
	{  breakpoint: 1169,  settings: { slidesToShow: 2,  }  },
	{  breakpoint: 969,   settings: { slidesToShow: 1,  }  },
	{  breakpoint: 767,   settings: { slidesToShow: 1, }   },
	{  breakpoint: 479,   settings: { slidesToShow: 1, }   },
	]
	});
	
    /*----------------------------
     fancybox active
    ------------------------------ */
    $(document).ready(function() {
        $('.fancybox').fancybox();
    });

    
    /*************************
      tooltip
    *************************/
	    $('[data-toggle="tooltip"]').tooltip({
        animated: 'fade',
        placement: 'top',
        container: 'body'
    });

	
	/*----------------------------
	 price-slider active
	------------------------------ */  
	  $( "#slider-range" ).slider({
	   range: true,
	   min: 40,
	   max: 600,
	   values: [ 40, 600 ],
	   slide: function( event, ui ) {
		$( "#amount" ).val( "$" + ui.values[ 0 ] + " - $" + ui.values[ 1 ] );
	   }
	  });
	  $( "#amount" ).val( "$" + $( "#slider-range" ).slider( "values", 0 ) +
	   " - $" + $( "#slider-range" ).slider( "values", 1 ) );
	   
    /*----------------------------
    Countdown active
    ------------------------------ */
    $('[data-countdown]').each(function () {
        var $this = $(this),
            finalDate = $(this).data('countdown');
        $this.countdown(finalDate, function (event) {
            $this.html(event.strftime('<span class="cdown days"><span class="time-count">%-D</span> <p>Days</p></span><span class="cdown hour"><span class="time-count">%-H</span> <p>Hour</p></span><span class="cdown minutes"><span class="time-count">%M</span> <p>Min</p></span> <span class="cdown second"><span class="time-count">%S</span> <p>Sec</p></span>'));
        });
    });
	
	
    
    /*----------------------------
	 active match height
	------------------------------ */ 
    $(function () {
        $('.item').matchHeight();
    });
    
    /*----------------------------
	 treeview active
	------------------------------ */  
	$("#cat-treeview ul").treeview({
		animated: "normal",
		persist: "location",
		collapsed: true,
		unique: true,
	});
	
	/*----------------------------
     cart-plus-minus-button
    ------------------------------ */
	$(".cart-plus-minus")
	$(".qtybutton").on("click", function () {
	    var $button = $(this);
	    var oldValue = $button.parent().find("input").val();
	    var maxValue = $('#qtybutton').data('max');
	    var minValue = $('#qtybutton').data('min');
	    if ($button.text() == "+") {

	        console.log("MAX: " + maxValue);
	        if (oldValue < maxValue) {
	            var newVal = parseFloat(oldValue) + 1;
	        } else {
	            newVal = maxValue;
	        }
	    } else {
	        // Don't allow decrementing below zero
	        console.log("Min: " + minValue);
	        if (oldValue > minValue) {
	            var newVal = parseFloat(oldValue) - 1;
	        } else {
	            newVal = minValue;
	        }
	    }
	    $button.parent().find("input").val(newVal);
	});

	$(".cart-plus-minus")
	$(".qtybutton2").on("click", function () {
	    var $button = $(this);
	    var oldValue = $button.parent().find("input").val();
	    if ($button.text() == "+") {
	        var newVal = parseFloat(oldValue) + 1;
	    } else {
	        // Don't allow decrementing below zero
	        if (oldValue > 1) {
	            var newVal = parseFloat(oldValue) - 1;
	        } else {
	            newVal = 1;
	        }
	    }

	    // modificar cantidad de un producto
	    var IdProducto = $button.parent().find("input").data('sku');
	    var IdTalla = $button.parent().find("input").data('talla');
	    var IdColor = $button.parent().find("input").data('color');
	    console.log("idproducto: " + IdProducto);
	    console.log("idtalla: " + IdTalla);
	    console.log("idcolor: " + IdColor);
	    $button.parent().find("input").val(newVal);
	});

	
	
		$('.acc-toggle').on('click', function(){
		if ($('.acc-toggle input').is(':checked')) {
			$('.create-acc-body').slideDown();
		}else{
			$('.create-acc-body').slideUp();
		}
	});
		
	$('.ship-toggle').on('click', function(){
		if ($('.ship-toggle input').is(':checked')) {
			$('.ship-acc-body').slideDown();
		}else{
			$('.ship-acc-body').slideUp();
		}
	});
		
	
	 $('body').on('click', '.panel-close', function(e) {
            $(this).parents(".cart-single-wraper").fadeOut();
            //Actualizar Carrito 
            //Peticion JAVASCRIPT 
            e.preventDefault();
        });

})(jQuery);

	$(window).scroll(function() {
	if ($(this).scrollTop() > 1){ 
		$('#sticky-header').addClass("sticky");
	  }
	  else{
		$('#sticky-header').removeClass("sticky");
	  }
});

	//Estrellas de productos//
    $('.estrellas').starrr({
    rating:3,
    change: function (e, valor) {             
        document.getElementById("ValueHiddenField").value = valor;
    }
});
 $('#file-input').change(function(e) {
    
      addImage(e); 
     });

     function addImage(e){
      var file = e.target.files[0],
      imageType = /image.*/;
    
      if (!file.type.match(imageType))
       return;
  
      var reader = new FileReader();
      reader.onload = fileOnload;
      reader.readAsDataURL(file);
     }
  
     function fileOnload(e) {
      var result=e.target.result;
      
      $('#imgpreview').attr("src",result);
     }