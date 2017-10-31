var DelCarrito = function () {
    "use strict";
    //function to 
    var runDelCart = function () {
        $("#delCart").click(function (event) {
            event.preventDefault();
            var color = $('#PruebadelCart').data('color');
            var talla = $('#PruebadelCart').data('talla');
            var cantidad = $('#PruebadelCart').val();
            var idProducto = $('#PruebadelCart').data('sku');
            var EsRopa = $('#addCart').data('ropa');
            console.log("AddCarrito ( " + idProducto + ", " + color + ", " + talla + ", " + EsRopa + ", " + cantidad + ")");
                    var data = new FormData();
                    data.append('IDProducto', idProducto);
                    data.append('IDColor', color);
                    data.append('IDTalla', talla);
                    data.append('Cantidad', cantidad);

                    $.ajax({
                        type: 'POST',
                        url: '../sfrmEliminarItemCart.aspx',
                        contentType: false,
                        dataType: "json",
                        data: data,
                        processData: false,
                        cache: false,
                        success: function (result) {
                            console.log(result.resultado);
                            //Ir a carrito o mostrar mensaje de error
                            if (result.resultado == 1) {
                                location.href = "/Carrito";
                            }
                        },
                        error: function () {
                            $('.ErrorAddCart').addClass('color');
                            document.getElementById('ErrorAddCart').innerHTML = "Error de conexión. Intente más tarde";
                        }
                    });
            return false;
        });

        $("#MasCart").click(function (event) {
            event.preventDefault();
            var color = $('#PruebadelCart').data('color');
            var talla = $('#PruebadelCart').data('talla');
            var cantidad = $('#PruebadelCart').val();
            var idProducto = $('#PruebadelCart').data('sku');
            var EsRopa = $('#addCart').data('ropa');
            console.log("AddCarrito ( " + idProducto + ", " + color + ", " + talla + ", " + EsRopa + ", " + cantidad + ")");
            var data = new FormData();
            data.append('IDProducto', idProducto);
            data.append('IDColor', color);
            data.append('IDTalla', talla);
            data.append('Cantidad', cantidad);

            $.ajax({
                type: 'POST',
                url: '../sfrmMasItemCart.aspx',
                contentType: false,
                dataType: "json",
                data: data,
                processData: false,
                cache: false,
                success: function (result) {
                    console.log(result.resultado);
                    //Ir a carrito o mostrar mensaje de error
                    if (result.resultado == 1) {
                        location.href = "/Carrito";
                    }
                },
                error: function () {
                    $('.ErrorAddCart').addClass('color');
                    document.getElementById('ErrorAddCart').innerHTML = "Error de conexión. Intente más tarde";
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