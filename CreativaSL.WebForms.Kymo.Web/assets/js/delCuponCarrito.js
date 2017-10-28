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

        
        $("a[class=removeCart]").click(function (event) {
            event.preventDefault();
            var $button = $(this);
            var idProducto = $button.data('sku');
            var idTalla = $button.data('talla');
            var idColor = $button.data('color');            
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
                beforeSend: function () {
                    /*SE CREA NUEVO ELEMENTO */
                    var sidebar = document.querySelector('#cart');
                    var nuevoDivElemento = document.createElement('div');
                    var nuevaImagen = document.createElement('img');
                    nuevoDivElemento.setAttribute("id", "load");
                    nuevoDivElemento.setAttribute("style", "display:none;position:fixed;width:100%;height:100%;background:rgba(0,0,0,0.3);z-index:10000;top:0;");
                    nuevoDivElemento.setAttribute('class', 'text-center');
                    /*nuevaImagen.setAttribute('src', 'images/icons/ajax-loader.gif');*/
                    nuevaImagen.setAttribute('style', 'position:relative; top:350px');
                    sidebar.appendChild(nuevoDivElemento);
                    nuevoDivElemento.appendChild(nuevaImagen);
                    $('#load').toggle(1000);
                    
                },
                success: function (result) {
                    //Eliminar la fila correspondiente
                    var fila = $button.parents('tr');
                    fila.remove();
                    $('#cartST').text(result.subtotal);
                    $('#cartDT').text(result.descuento);
                    $('#cartTT').text(result.total);
                    if(result.id_vale=='')
                    {
                        if ($('#cuponInsert').hasClass('hidden'))
                        {
                            $('#contCod').addClass('hidden');
                            $('#cuponInsert').removeClass('hidden');
                            document.getElementById('codigoCupon').innerHTML = '';
                        }
                        else {
                        }
                    }
                    else
                    {
                    }
                },
                error: function () {
                    //Mostrar mensaje de error
                },
                complete: function () {
                    $('#load').toggle(1000);
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