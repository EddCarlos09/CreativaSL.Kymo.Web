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
            // Insertar el script para id familia
            //var TipoBusq = "Hombre";
            //Generar el enlace final
            location.href =  generarEnlace(); 
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
            console.log("tipo de busqueda: " + tb);
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

            //"/Products/" + TipoBusq + "?CT=" + idFamilia;

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