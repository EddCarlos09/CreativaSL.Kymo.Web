var Busqueda = function () {
    "use strict";
    //function to 
    var runBusqueda = function () {

        //Cambio de cantidad de registros
        $('.product-show').delegate("#input-amount", "change", function (e) {
            location.href = generarEnlace();
            
        });

        //Cambio de ordenamiento
        $('.product-type').delegate("#input-sort", "change", function (e) {
            location.href = generarEnlace();
            //generarEnlace();
        });

        //Búsqueda por familia
        $('.product-cat').delegate(".famsearch", "click", function (e) {
            e.preventDefault();
            // Obtener el botón donce se hizo click
            var $button = $(this);
            // Obtener el id de la familia
            var idFamilia = $button.data('sku');
            var textFam = $button.text();
            // Insertar el script para id familia
            $("ul.erase").append("<li class='closed'>" + textFam + "<div class='erase-area'><a href='#' data-sku='" + idFamilia + "' data-type='CT'><i class='fa fa-times-circle'></i></a></div></li>");
            //Generar el enlace final
            location.href = generarEnlace();
            return false;
        });

        //Búsqueda por color
        $('ul.color-filter').delegate("a[class=color-1]", "click", function (e) {
            e.preventDefault();
            // Obtener el botón donce se hizo click
            var $button = $(this);
            // Obtener el id de la familia
            var idColor = $button.data('sku');
            var textColor = $button.text();
            // Insertar el script para id familia
            $("ul.erase").append("<li class='closed'>" + textColor + "<div class='erase-area'><a href='#' data-sku='" + idColor + "' data-type='CL'><i class='fa fa-times-circle'></i></a></div></li>");
            //Generar el enlace final
            location.href = generarEnlace();
            return false;
        });

        //Búsqueda por talla
        $('ul.size-filter').delegate("a[class=size-xl]", "click", function (e) {
            e.preventDefault();
            // Obtener el botón donce se hizo click
            var $button = $(this);
            // Obtener el id de la familia
            var idTalla = $button.data('sku');
            var textTalla = $button.text();
            // Insertar el script para id familia
            $("ul.erase").append("<li class='closed'>" + textTalla + "<div class='erase-area'><a href='#' data-sku='" + idTalla + "' data-type='TL'><i class='fa fa-times-circle'></i></a></div></li>");
            //Generar el enlace final
            location.href = generarEnlace();
            return false;
        });
        
        //Eliminar tag de búsqueda
        $('ul.erase').delegate("a", "click", function (e) {
            e.preventDefault();
            // Obtener el botón donde se hizo click
            var $button = $(this);
            //console.log("click remove");
            // Obtener el li padre
            $button.parents('li').remove();
            //Generar el enlace final
            location.href = generarEnlace();
            return false;
        });

        //Rango de precios tag de búsqueda
        $('.price_filter').delegate("#btnPrice", "click", function (e) {
            e.preventDefault();
            var $button = $(this);            
            var MinPrice = $("#slider-range").slider("values", 0);
            var maxPrice = $("#slider-range").slider("values", 1);
            $("ul.erase").append("<li class='closed'> $ " +  MinPrice + ".00 - $ " + maxPrice + ".00<div class='erase-area'><a href='#' data-min='" + MinPrice + "' data-max='" + maxPrice +"' data-type='RP'><i class='fa fa-times-circle'></i></a></div></li>");
            //Generar el enlace final
            location.href = generarEnlace();
            return false;
        });

        //Cambio de página
        var currentPage = 1;
        $('ul.page-numbers').delegate("a.page-numbers", "click", function (e) {
            e.preventDefault();
            var totalPages = $('ul.page-numbers').data('pages');
            var $button = $(this);
            currentPage = getCurrentPage();
            if ($button.hasClass('prev'))
            {
                if (currentPage > 1)
                    currentPage = currentPage - 1;
                else
                    return;
            }
            else if ($button.hasClass('next'))
            {
                if (currentPage < totalPages)
                    currentPage = currentPage + 1;
                else
                    return;
            }
            else
            {
                currentPage = $button.text();
            }
            ///console.log("Pagina: " + currentPage);
            ///var aux = 0;
            //$("ul.page-numbers").find('li').each(function() {
            //    if (parseInt($(this).text()) == currentPage) {
            //        $(this).addClass('current');
            //    }
            //    else {
            //        $(this).removeClass('current');
            //    }
            //    console.log("span: " + aux);
            //    aux++;
            //});
            location.href = generarEnlace();
            return false;
        });

        //Funcion para obtener el tipo de búsqueda
        function getTipoBusqueda()
        {
            var tb = parseInt($('#tb20ds').val());
            var strTipo = '';
            switch(tb)
            {
                case 1: strTipo ='Hombre'
                    break;
                case 2: strTipo = 'Mujer'
                    break;
                case 3: strTipo = 'Accesorio'
                    break;
                default: strTipo = 'Buscar'
                    break;
            }
            return strTipo;
        }

        //Generar enlace final con la combinación de búsqueda establecida
        function generarEnlace()
        {
            var urlReturn = "/Products/" + getTipoBusqueda();
            var NumPage = currentPage; //getCurrentPage();
            var MaxRows = $('#input-amount').val();
            var TipoOrden = $('#input-sort').val();
            //console.log("Tipo de orden: " + TipoOrden);
            var BandFirst = false;
            //Tipo de orden
            if (TipoOrden > 0) {
                if (BandFirst === false)
                    urlReturn = urlReturn + "?"
                else
                    urlReturn = urlReturn + "&"
                urlReturn = urlReturn + "OB=" + TipoOrden;
                BandFirst = true;
            }
            //Numero de página
            if (NumPage > 0) {
                if (BandFirst === false)
                    urlReturn = urlReturn + "?"
                else
                    urlReturn = urlReturn + "&"
                urlReturn = urlReturn + "NP=" + NumPage;
                BandFirst = true;
            }
            //Numero de página
            if (MaxRows > 0) {
                if (BandFirst === false)
                    urlReturn = urlReturn + "?"
                else
                    urlReturn = urlReturn + "&"
                urlReturn = urlReturn + "MR=" + MaxRows;
                BandFirst = true;
            }

            
            $("ul.erase").find("a").each(function () {
                var tp = $(this).data('type');
                if (tp === 'RP') {
                    var minp = $(this).data('min');
                    var maxp = $(this).data('max');
                    if (BandFirst === false)
                        urlReturn = urlReturn + "?"
                    else
                        urlReturn = urlReturn + "&"
                    urlReturn = urlReturn + "PI=" + minp + "&PF=" + maxp;
                    BandFirst = true;
                }
                else
                {
                    var id = $(this).data('sku');
                    console.log(tp + " : " + id);
                    if (BandFirst === false)
                        urlReturn = urlReturn + "?"
                    else
                        urlReturn = urlReturn + "&"
                    urlReturn = urlReturn + tp + "=" + id;
                    BandFirst = true;
                }
            });

            return urlReturn;
        }
        //Funcion auxiliar para encontrar la página actual
        function getCurrentPage()
        {
            var $result = $('ul.page-numbers span.current');
            var NumPage = parseInt($result.text());
            if (isNaN(NumPage))
                NumPage = 0;
            return NumPage;
        }
    };
    return {
        //main function to initiate template pages
        init: function () {
            runBusqueda();
        }
    };
}();