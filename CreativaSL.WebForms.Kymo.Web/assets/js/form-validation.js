var FormValidator = function () {
	"use strict";
    // function to initiate Validation Sample 1
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
                // mark the current input as valid and display OK icon
                $(element).closest('.form-group').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form) {
                successHandler1.show();
                errorHandler1.hide();
                // submit form
                //$('#form').submit();
                this.submit();
            }
        });
    };
    // function to initiate Validation Sample 2
    return {
        //main function to initiate template pages
        init: function () {
            runValidator1();
        }
    };
}();