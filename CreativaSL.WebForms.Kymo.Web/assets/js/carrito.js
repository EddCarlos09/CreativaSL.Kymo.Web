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
                        console.log(result.resultado + "" + result.mensaje);
                        if(result.resultado == 1)
                        {
                            var codigoCupon = $('#cupon').val();
                            $('#cuponInsert').addClass('hidden');
                            $('#contCod').removeClass('hidden');
                            document.getElementById('codigoCupon').innerHTML = codigoCupon;
                            $('#cartDT').text(result.descuento);
                            $('#cartTT').text(result.total);
                            $('.error').removeClass('color');
                            document.getElementById('errorCupon').innerHTML = '';
                            $('.errorEli').removeClass('color');
                            document.getElementById('errorEliCupon').innerHTML = '';
                        }
                        else
                        {
                            $('.error').addClass('color');
                            document.getElementById('errorCupon').innerHTML = result.mensaje;
                        }
                    },
                    error: function () {
                        $('.error').addClass('color');
                        document.getElementById('errorCupon').innerHTML = "Error de conexión. Intente más tarde";
                    }
                });
            }
            else
            {
                $('.error').addClass('color');
                document.getElementById('errorCupon').innerHTML = "Ingrese un código válido";
            }
            return false;
        });

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
                    if (result.resultado == 1) {
                        var codigoCupon = $('#cupon').val();
                        $('#contCod').addClass('hidden');
                        $('#cuponInsert').removeClass('hidden');
                        $('#codigoCupon').val('');
                        document.getElementById("cupon").value = "";
                        $('#cartDT').text(result.descuento);
                        $('#cartTT').text(result.total);
                        $('.error').removeClass('color');
                        document.getElementById('errorCupon').innerHTML = '';
                        $('.errorEli').addClass('color');
                        document.getElementById('errorEliCupon').innerHTML = '';
                    }
                    else {
                        $('.errorEli').addClass('color');
                        document.getElementById('errorEliCupon').innerHTML = result.mensaje;
                    }
                },
                error: function () {
                    $('.errorEli').addClass('color');
                    document.getElementById('errorEliCupon').innerHTML = "Error de conexión. Intente más tarde";
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

        $("#validarR").click(function (event) {
            event.preventDefault();
            var Radio = document.getElementsByName("ship");
            var ship = -1
            if ($('#TablaProducto >tbody >tr').length == 0) {
                $('.errorEntr').addClass('color');
                document.getElementById('ValEntraga').innerHTML = "¡No tiene campras en sus carrito!";
            }
            else
            {
                for (var i = 0; i < Radio.length; i++) {
                    if (Radio[i].checked) {
                        ship = i;
                        $('.errorEntr').removeClass('color');
                        document.getElementById('ValEntraga').innerHTML = '';
                        location.href = "/frmCarritoDatos.aspx";
                    }
                }
                if (ship == -1) {
                    $('.errorEntr').addClass('color');
                    document.getElementById('ValEntraga').innerHTML = "Seleccion el medio de entrega del producto";
                }
            }
        });
    };
    return {
        //main function to initiate template pages
        init: function () {
            runCart();
        }
    };
}();