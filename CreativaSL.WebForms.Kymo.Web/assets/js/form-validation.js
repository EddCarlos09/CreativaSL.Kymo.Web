var FormValidator = function () {
	"use strict";
    // Funcion para validar registrar
    var runValidator1 = function () {
        var form1 = $('#contact-form');
        var errorHandler1 = $('.errorHandler', form1);
        var successHandler1 = $('.successHandler', form1);
        $.validator.addMethod("NombreVal", function () {
            var urlAux = document.getElementById("Nombre").value;
            var expReg = /^(?!\s+$)[A-Za-z\u00E1\u00E9\u00ED\u00F3\u00FA\u00C1\u00C9\u00CD\u00D3\u00DA\u00DC\u00FC\u00f1\u00d1\s]+$/;
             if (expReg.test(urlAux))
                {
                    return true;
                }
                else {
                    return false;
                }
        }, 'Por favor, Escriba un nombre correcto');
        $.validator.addMethod("ApPaterno", function () {
            var urlAux = document.getElementById("Nombre").value;
            var expReg = /^(?!\s+$)[A-Za-z\u00E1\u00E9\u00ED\u00F3\u00FA\u00C1\u00C9\u00CD\u00D3\u00DA\u00DC\u00FC\u00f1\u00d1\s]+$/;
            if (expReg.test(urlAux)) {
                return true;
            }
            else {
                return false;
            }
        }, 'Por favor, Escriba el apellido paterno');
        $.validator.addMethod("ApMaterno", function () {
            var urlAux = document.getElementById("Nombre").value;
            var expReg = /^(?!\s+$)[A-Za-z\u00E1\u00E9\u00ED\u00F3\u00FA\u00C1\u00C9\u00CD\u00D3\u00DA\u00DC\u00FC\u00f1\u00d1\s]+$/;
            if (expReg.test(urlAux)) {
                return true;
            }
            else {
                return false;
            }
        }, 'Por favor, Escriba el apellido materno');
        $.validator.addMethod("phoneNumbers", function () {
            var AuxTelefono = document.getElementById("Telefono").value;
            var expReg = /^[0-9]{10}$/;
            if (expReg.test(AuxTelefono)) {
                return true;
            }
            else {
                return false;
            }
        }, 'Verifique que n&uacute;mero telef&oacute;nico cuente con el formato a 10 d&iacute;gitos.');

        $('#contact-form').validate({
            errorElement: "span", // contain the error msg in a span tag
            errorClass: 'help-block color',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.attr("name") == "dd" || element.attr("name") == "mm" || element.attr("name") == "yyyy") {
                    error.insertAfter($(element).closest('.form-group').children('div'));
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {
                Nombre: "NombreVal",
                ApPaterno: "ApPaterno",
                ApMaterno: "ApMaterno",
                datepicker: {
                    required: true
                },
                cmbGenero: {
                    required: true
                },
                Direccion: {
                    required: true
                },
                CP: {
                    required: true,
                    number: true,
                    maxlength: 6
                },
                NExterior: {
                    required: true,
                    number: true,
                    maxlength: 7
                },
                cmbEstado: {
                    required: true
                },
                cmbMunicipio: {
                    required: true
                },
                Colonia: {
                    required: true
                },
                Correo: {
                    required: true,
                    email: true
                },
                Telefono: "phoneNumbers",
                Contrasena: {
                    required: true,
                    minlength: 8,
                    maxlength: 15
                },
                Contrasena2: {
                    required: true,
                    equalTo: "#Contrasena"
                }
                },
            messages: {
                datepicker: "Por favor, selecciones una fecha de nacimiento",
                cmbGenero: "Por favor, seleccione su g&eacute;nero",
                Direccion: "Por favor, ingrese su direcci&oacute;n",
                CP: {
                    required: "Por favor, ingrese el N&#176; c&oacute;digo postal",
                    number: "Por favor, ingrese un n&uacute;mero valido",
                    maxlength: "El campo tiene un limite de 6 n&uacute;meros"
                },
                NExterior: {
                    required: "Por favor, ingrese el N&#176; Exterior",
                    number: "Por favor, ingrese un n&uacute;mero valido",
                    maxlength: "El campo tiene un limite de 7 n&uacute;meros"
                 },
                cmbEstado: "Por favor, seleccione el estado",
                cmbMunicipio: "Por favor, seleccion el municipio",
                Colonia: "Por favor, ingrese su colonia",
                Correo: {
                    required: "Por favor, Ingrese un correo Electr&oacute;nico",
                    email: "EL formato del correo electrono es Nombre@dominio.com"
                },
                Contrasena: {
                    required: "Por favor, Ingrese la contrase&ntilde;a",
                    minlength: "Por favor, la contrase&ntilde;a debe tener un minimo de 8 carcateres",
                    maxlength: "Por favor, la contrase&ntilde;a debe tener un maximo de 15 carcateres"
                },
                Contrasena2: {
                    required: "Por favor, confirme su contrase&ntilde;a",
                    equalTo: "Por favor, verfique las contrase&ntilde;a no coinciden"
                }

            },
            groups: {
                DateofBirth: "dd mm yyyy",
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler1.hide();
                errorHandler1.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                label.removeClass('color');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form) {
                successHandler1.show();
                errorHandler1.hide();
                // submit form
                //$('#form').submit();
                //this.submit();
                var Nombre = $('#Nombre').val();
                var ApPaterno = $('#ApPaterno').val();
                var ApMaterno = $('#ApMaterno').val();
                var FechaNac = $('#datepicker').val();
                var Genero = $('#cmbGenero').val();
                var CP = $('#CP').val();
                var Direccion = $('#Direccion').val();
                var NExterior = $('#NExterior').val();
                var NInterior = $('#NInterior').val();
                var CmbEstado = $('#cmbEstado').val();
                var CmbMunicipio = $('#cmbMunicipio').val();
                var Colonia = $('#Colonia').val();
                var Telefono = $('#Telefono').val();
                var Correo = $('#Correo').val();
                var Contarena = $('#Contrasena').val();
                var Contrasena2 = $('#Contrasena2').val();
                var CkRecibir = $('#CkRecibir').val();
                var data = new FormData();
                data.append('Nombre', Nombre);
                data.append('ApPaterno', ApPaterno);
                data.append('ApMaterno', ApMaterno);
                data.append('datepicker', FechaNac);
                data.append('cmbGenero', Genero);
                data.append('CP', CP);
                data.append('Direccion', Direccion);
                data.append('NExtarior', NExterior);
                data.append('NInterior', NInterior);
                data.append('cmbEstado', CmbEstado);
                data.append('cmbMunicipio', CmbMunicipio);
                data.append('Colonia', Colonia);
                data.append('Telefono', Telefono);
                data.append('Correo', Correo);
                data.append('Contrasena', Contrasena);
                data.append('CkRecibir', CkRecibir);
                $.ajax({
                    type: 'POST',
                    url: 'sfrmRegistrar.aspx',
                    contentType: false,
                    data: data,
                    processData: false,
                    cache: false,
                    success: function () {
                        $('#Nombre').val('');
                        $('#ApPaterno').val('');
                        $('#ApMaterno').val('');
                        $('#datepicker').val('');
                        $('#cmbGenero').val('');
                        $('#CP').val('');
                        $('#Direccion').val('');
                        $('#NExterior').val('');
                        $('#NInterior').val('');
                        $('#cmbEstado').val('');
                        $('#cmbMunicipio').val('');
                        $('#Colonia').val('');
                        $('#Telefono').val('');
                        $('#Correo').val('');
                        $('#Contrasena').val('');
                        $('#Contrasena2').val('');
                        //var padre = document.getElementById('IdRegistrar');
                        //var hijo = document.getElementById('contact-form');
                        //padre.removeChild(hijo);
                        document.getElementById('Correcto').innerHTML = "Gracias por registrase";
                    },
                    error: function () {
                        document.getElementById('CorrectoError').innerHTML = "Error al enviar los datos .Intente mas tarde";
                    }
                });
                return false;
            }
        });
    };

    var runValidator2 = function () {
        var form1 = $('#contact-form');
        var errorHandler1 = $('.errorHandler', form1);
        var successHandler1 = $('.successHandler', form1);
        $.validator.addMethod("NombreVal", function () {
            var urlAux = document.getElementById("Nombre").value;
            var expReg = /^(?!\s+$)[A-Za-z\u00E1\u00E9\u00ED\u00F3\u00FA\u00C1\u00C9\u00CD\u00D3\u00DA\u00DC\u00FC\u00f1\u00d1\s]+$/;
            if (expReg.test(urlAux)) {
                return true;
            }
            else {
                return false;
            }
        }, 'Por favor, Escriba un nombre correcto');
        $.validator.addMethod("phoneNumbers", function () {
            var AuxTelefono = document.getElementById("Telefono").value;
            var expReg = /^[0-9]{10}$/;
            if (expReg.test(AuxTelefono)) {
                return true;
            }
            else {
                return false;
            }
        }, 'Verifique que n&uacute;mero telef&oacute;nico cuente con el formato a 10 d&iacute;gitos.');

        $('#contact-form').validate({
            errorElement: "span", // contain the error msg in a span tag
            errorClass: 'help-block color',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.attr("name") == "dd" || element.attr("name") == "mm" || element.attr("name") == "yyyy") {
                    error.insertAfter($(element).closest('.form-group').children('div'));
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {
                Telefono: "phoneNumbers",
                Correo: {
                    required: true,
                    email: true
                },
                Nombre: "NombreVal",
                Direccion: {
                    required: true
                },
                Mensaje: {
                    required: true,
                    minlength: 100
                }

            },
            messages: {
                Correo: {
                    required: "Por favor, ingrese un correo electr&oacute;nico",
                    email: "EL formato del correo electrono es Nombre@dominio.com"
                },
                Direccion: {
                    required: "Por favor,ingrese su direcci&oacute;n"
                },
                Mensaje: {
                    required: "Por favor, ingrese el mensaje",
                    minlength: "Por favor, el mensaje tiene un minimo de 100 carcateres"
                }

            },
            groups: {
                DateofBirth: "dd mm yyyy",
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler1.hide();
                errorHandler1.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                label.removeClass('color');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form) {
                successHandler1.show();
                errorHandler1.hide();
                // submit form
                //$('#form').submit();
                //this.submit();
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
                        $('#Nombre').val('');
                        $('#Correo').val('');
                        $('#Telefono').val('');
                        $('#Direccion').val('');
                        $('#Mensaje').val('');
                        //var padre = document.getElementById('IDContacto');
                        //var hijo = document.getElementById('contact-form');
                        //padre.removeChild(hijo);
                        document.getElementById('formValidar').innerHTML = "Gracias por contactarnos";
                    },
                    error: function () {
                        document.getElementById('formValidar').innerHTML = "Error al enviar los datos .Intente mas tarde";
                    }
                });
                return false;
            }
        });
    };

    var runValidator3 = function () {
        var form1 = $('#IDKYMO');
        var errorHandler1 = $('.errorHandler', form1);
        var successHandler1 = $('.successHandler', form1);
        $.validator.addMethod("NombreVal", function () {
            var urlAux = document.getElementById("Nombre").value;
            var expReg = /^(?!\s+$)[A-Za-z\u00E1\u00E9\u00ED\u00F3\u00FA\u00C1\u00C9\u00CD\u00D3\u00DA\u00DC\u00FC\u00f1\u00d1\s]+$/;
            if (expReg.test(urlAux)) {
                return true;
            }
            else {
                return false;
            }
        }, 'Por favor, Escriba un nombre correcto');
      
        $('#IDKYMO').validate({
            errorElement: "span", // contain the error msg in a span tag
            errorClass: 'help-block color',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($(element).closest('.form-group').children('div').children().last());
                } else if (element.attr("name") == "dd" || element.attr("name") == "mm" || element.attr("name") == "yyyy") {
                    error.insertAfter($(element).closest('.form-group').children('div'));
                } else {
                    error.insertAfter(element);
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {
                Nombre: "NombreVal",
                Comentario: {
                    required: true,
                    minlength: 100
                }

            },
            messages: {
                Comentario: {
                    required: "Por favor, ingrese el Comentario",
                    minlength: "Por favor, el comentario tiene un minimo de 100 carcateres"
                }
            },
            groups: {
                DateofBirth: "dd mm yyyy",
            },
            invalidHandler: function (event, validator) { //display error alert on form submit
                successHandler1.hide();
                errorHandler1.show();
            },
            highlight: function (element) {
                $(element).closest('.help-block').removeClass('valid');
                // display OK icon
                $(element).closest('.form-group').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.form-group').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                label.removeClass('color');
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form) {
                successHandler1.show();
                errorHandler1.hide();
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
                    error: function () {
                        document.getElementById('form-messege').innerHTML = "Error al enviar los datos .Intente mas tarde";
                    }
                });
                // submit form
                //$('#form').submit();
                this.submit();
            }
        });
    };

    return {
        //main function to initiate template pages
        init: function (Aux) {
            switch (Aux) {
                case 1: runValidator1();
                    break;
                case 2: runValidator2();
                    break;
                case 3: runValidator3();
                    break;
            }
        }
    };
}();