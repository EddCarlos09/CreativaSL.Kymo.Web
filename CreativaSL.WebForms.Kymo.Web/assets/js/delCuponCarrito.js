var DelCuponCarrito = function () {
    "use strict";
    //function to 
    var runDelCart = function () {
        $("#btnEliminarCupon").click(function (event) {
            event.preventDefault();
                $.ajax({
                    type: 'POST',
                    url: '../sfrmDelCupon.aspx',
                    contentType: false,
                    dataType: "json",
                    processData: false,
                    cache: false,
                    success: function (result) {
                        if(result.resultado == 1)
                        {
                            var codigoCupon = $('#cupon').val();
                            $('#contCod').addClass('hidden');
                            $('#cuponInsert').removeClass('hidden');
                            $('#codigoCupon').val('');
                            document.getElementById("cupon").value = "";
                            $('#cartDT').text(result.descuento);
                            $('#cartTT').text(result.total);
                        }
                        else
                        {
                            //result.mensaje
                            //Mostrar mensaje de error
                        }
                    },
                    error: function () {
                        //Mostrar mensaje de error
                    }
                });
            return false;
        });

    };
    return {
        //main function to initiate template pages
        init: function () {
            runDelCart();
        }
    };
}();