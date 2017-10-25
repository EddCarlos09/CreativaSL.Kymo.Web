var Contacto = function () {
    "use strict";
    //function to 
    var runContacto = function ValidarEnviar() {
        var Nombre = $('#Nombre').val();
        var Correo = $('#Correo').val();
        var Telefono = $('#Telefono').val();
        var Direccion = $('#Direccion').val();
        var Mensaje = $('#Mensaje').val();
        var data = new FormData();
        data.append('Nombre', Nombre);
        data.append('Correo', Correo);
        data.append('Telefono', Telefono);
        data.append('Direccion', Direccion);
        data.append('Mensaje', Mensaje);
        $.ajax({
            type: 'POST',
            url: 'sfrmContactanos.aspx',
            contentType: false,
            data: data,
            processData: false,
            cache: false,
            success: function () {
                var padre = document.getElementById('IDContacto');
                var hijo = document.getElementById('contact-form');
                padre.removeChild(hijo);
                // document.getElementById('form').style.display = "none";
                document.getElementById('form-messege').innerHTML = "Gracias por contactarnos";
            },
            error: function (status, error) {
                document.getElementById('form-messege').innerHTML = "Error al enviar los datos .Intente mas tarde";
                alert('' + error);
            }
        });
        return false;
    };
    return {
        //main function to initiate template pages
        init: function () {
            runContacto();
        }
    };
}();