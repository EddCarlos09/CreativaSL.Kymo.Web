var Carrito = function () {
    "use strict";
    //function to 
    var runAddCart = function () {
        $("#addCart").click(function (event) {
            event.preventDefault();
            var color = $('#input-sort-color').val();
            var talla = $('#input-sort-size').val();
            var cantidad = $('#qtybutton').val();
            var idProducto = $('#addCart').data('sku');
            var EsRopa = $('#addCart').data('ropa');
            console.log("AddCarrito ( " + idProducto + ", " + color + ", " + talla + ", " + EsRopa + ", " + cantidad + ")");
            if (EsRopa = true) {
                if (color == 0) {
                    $('.ErrorAddCart').removeClass('color');
                    document.getElementById('ErrorAddCart').innerHTML = '';
                    $('.errorColor').addClass('color');
                    document.getElementById('errorColor').innerHTML = "Seleccione un color de ropa";
                }
                else if (talla == 0) {
                    $('.errorColor').removeClass('color');
                    document.getElementById('errorColor').innerHTML = '';
                    $('.errorTalla').addClass('color');
                    document.getElementById('errorTalla').innerHTML = "Seleccione un talla de ropa";
                }
                else {
                    $('.errorTalla').removeClass('color');
                    document.getElementById('errorTalla').innerHTML = '';

                    var data = new FormData();
                    data.append('IDProducto', idProducto);
                    data.append('IDColor', color);
                    data.append('IDTalla', talla);
                    data.append('Cantidad', cantidad);

                    $.ajax({
                        type: 'POST',
                        url: '../sfrmAddItemCart.aspx',
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
                }
            }
            else
            {
                $('.ErrorAddCart').removeClass('color');
                document.getElementById('ErrorAddCart').innerHTML = '';
                var data = new FormData();
                data.append('IDProducto', idProducto);
                data.append('IDColor', color);
                data.append('IDTalla', talla);
                data.append('Cantidad', cantidad);

                $.ajax({
                    type: 'POST',
                    url: '../sfrmAddItemCart.aspx',
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
            }
            return false;
        });
    };
    return {
        //main function to initiate template pages
        init: function () {
            runAddCart();
        }
    };
}();