var Carrito = function () {
    "use strict";
    //function to 
    var runAddCart = function () {
        $("#addCart").click(function (event) {
            event.preventDefault();
            var color = $('#input-sort-color').val();
            var talla = $('#input-sort-size').val();
            var cantidad = $('#qtybutton').val();
            var idProducto = $('#addCart').data('sku')
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
                
                data: data,
                processData: false,
                cache: false,
                success: function (result) {
                    console.log(result);
                },
                error: function () {
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