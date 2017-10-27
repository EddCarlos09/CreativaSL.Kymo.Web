var Carrito = function () {
    "use strict";
    //function to 
    var runCart = function () {
        $("#btnAplicarCupon").click(function (event) {
            event.preventDefault();
            var codigo = $('#cupon').val();
            var patron = /^[A-Za-znñ0-9]+$/;
            if (!codigo.search(patron)) {
                var data = new FormData();
                data.append('Codigo', codigo);
                $.ajax({
                    type: 'POST',
                    url: '../sfrmAddCupon.aspx',
                    contentType: false,
                    dataType: "json",
                    data: data,
                    processData: false,
                    cache: false,
                    success: function (result) {
                        if(result.resultado == 1)
                        {
                            var codigoCupon = $('#cupon').val();
                            $('#cuponInsert').addClass('hidden');
                            $('#contCod').removeClass('hidden');
                            document.getElementById('codigoCupon').innerHTML = codigoCupon;
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
            }
            else
            {
                console.log("Ingrese un código válido")
            }
            return false;
        });

        
        $("a[class=removeCart]").click(function (event) {
            event.preventDefault();
            var $button = $(this);
            var idProducto = $button.data('sku');
            var idTalla = $button.data('talla');
            var idColor = $button.data('color');
            //console.log("Eliminar: sku=" + idProducto + ", talla=" + idTalla + ", color=" + idColor);
            var data = new FormData();
            data.append('IDProducto', idProducto);
            data.append('IDTalla', idTalla);
            data.append('IDColor', idColor);
            $.ajax({
                type: 'POST',
                url: '../sfrmDelItemCart.aspx',
                contentType: false,
                dataType: "json",
                data: data,
                processData: false,
                cache: false,
                success: function (result) {
                    console.log(result.resultado);
                    //Eliminar la fila correspondiente
                    var fila = $button.parents('tr');
                    fila.remove();
                    $('#cartST').text(result.subtotal);
                    $('#cartDT').text(result.descuento);
                    $('#cartTT').text(result.total);
                    if(result.id_vale=='')
                    {
                        console.log("idvale vacio");
                        if ($('#cuponInsert').hasClass('hidden'))
                        {
                            $('#contCod').addClass('hidden');
                            $('#cuponInsert').removeClass('hidden');
                            document.getElementById('codigoCupon').innerHTML = '';
                        }
                        else {
                            console.log("tiene clase hidden");
                            
                        }
                    }
                    else
                    {
                        console.log("idvale lleno");
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
            runCart();
        }
    };
}();