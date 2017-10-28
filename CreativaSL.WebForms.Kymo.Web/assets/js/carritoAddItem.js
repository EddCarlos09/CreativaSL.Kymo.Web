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
            console.log("AddCarrito ( " +idProducto + ", " + color + ", " + talla + ", " + cantidad + ")");
            
            var data = new FormData();
            data.append('IDProducto', idProducto);
            data.append('IDColor', color);
            data.append('IDTalla', talla);
            data.append('Cantidad', cantidad);

            $.ajax({
                type: 'POST',
                url: '../sfrmAddItemCart.aspx',
                contentType: false,
                dataType:"json",
                data: data,
                processData: false,
                cache: false,
                success: function (result) {
                    console.log(result.resultado);
                    //Ir a carrito o mostrar mensaje de error
                    if(result.resultado == 1)
                    {
                        location.href = "/Carrito";
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
            runAddCart();
        }
    };
}();