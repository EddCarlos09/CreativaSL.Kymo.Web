//function ENVIAR() {
//    $("#IDBTNKYMO").click(function () {
//        var Nombre = $('#Nombre').val();
//        var Mensaje = $('#Comentario').val();
//        var data = new FormData();
//        data.append('Nombre', Nombre);
//        data.append('Mensaje', Mensaje);
//        $.ajax({
//            type: 'POST',
//            url: 'sfrmTestimonial.aspx',
//            contentType: false,
//            dataType: "json",
//            data: data,
//            processData: false,
//            cache: false,
//            success: function (Resultado2) {
//                if (Resultado2.resultado == 1) {
//                    $('#Nombre').val('');
//                    $('#Comentario').val('');
//                    $('.close').click();
//                    // document.getElementById('form').style.display = "none";
//                    document.getElementById('Gracias').innerHTML = "Gracias por escribirnos";
//                }
//            },
//            error: function () {
//                document.getElementById('Gracias').innerHTML = "Error al enviar los datos .Intente mas tarde";
//            }
//        });
//        return false;
//    });
//}
//$(document).ready(function() {
//    $("#IDBTNKYMO").click(function () {
//        var Nombre = $('#Nombre').val();
//        var Mensaje = $('#Comentario').val();
//        var expr = /^(?!\s+$)[A-Za-z\u00E1\u00E9\u00ED\u00F3\u00FA\u00C1\u00C9\u00CD\u00D3\u00DA\u00DC\u00FC\u00f1\u00d1\.\,\s]+$/;
//        if (!expr.test(Nombre) || !expr.test(Mensaje)) {
//        }
//        else {
//            $("#IDKYMO").submit();
//            var data = new FormData();
//            data.append('Nombre', Nombre);
//            data.append('Mensaje', Mensaje);
//            $.ajax({
//                type: 'POST',
//                url: 'sfrmTestimonial.aspx',
//                contentType: false,
//                dataType: "json",
//                data: data,
//                processData: false,
//                cache: false,
//                success: function (Resultado2) {
//                    if (Resultado2.resultado == 1) {
//                        $('#Nombre').val('');
//                        $('#Comentario').val('');
//                        $('.close').click();
//                        // document.getElementById('form').style.display = "none";
//                        document.getElementById('Gracias').innerHTML = "Gracias por escribirnos";
//                    }
//                },
//                error: function () {
//                    document.getElementById('Gracias').innerHTML = "Error al enviar los datos .Intente mas tarde";
//                }
//            });
//            return false;
//        }
//    });
//});

//function ValidarEnviar() {
//    $(this).submit(function (e) {
//        e.preventDefault();
//        var Nombre = $('#Nombre').val();
//        var Mensaje = $('#Comentario').val();
//        var expr = /^(?!\s+$)[A-Za-z\u00E1\u00E9\u00ED\u00F3\u00FA\u00C1\u00C9\u00CD\u00D3\u00DA\u00DC\u00FC\u00f1\u00d1\.\,\s]+$/;
//        if (!expr.test(Nombre) || !expr.test(Mensaje)) {
//            $('#Error').addClass('color');
//            document.getElementById('Error').innerHTML = "Por favor ingrese su nombre o comentario";
//        }
//        else {
//            $('#Error').removeClass('color');
//            var data = new FormData();
//            data.append('Nombre', Nombre);
//            data.append('Mensaje', Mensaje);
//            $.ajax({
//                type: 'POST',
//                url: 'sfrmTestimonial.aspx',
//                contentType: false,
//                dataType: "json",
//                data: data,
//                processData: false,
//                cache: false,
//                success: function (Resultado2) {
//                    if (Resultado2.resultado == 1) {
//                        $('#Nombre').val('');
//                        $('#Comentario').val('');
//                        $('.close').click();
//                        // document.getElementById('form').style.display = "none";
//                        document.getElementById('Gracias').innerHTML = "Gracias por escribirnos";
//                    }
//                },
//                error: function () {
//                    document.getElementById('Gracias').innerHTML = "Error al enviar los datos .Intente mas tarde";
//                }
//            });
//            return false;
//        }
//    });
//}