var FormValidatorNews = function () {
	"use strict";

    // funcion para validad newsletters
    var runValidator1 = function () {
        var form1 = $('#formnews');
        var errorHandler1 = $('.errorHandler', form1);
        var successHandler1 = $('.successHandler', form1);
       
        $('#formnews').validate({
            errorElement: "span", // contain the error msg in a span tag
            errorClass: 'help-block color',
            errorPlacement: function (error, element) { // render error placement for each input type
                if (element.attr("type") == "radio" || element.attr("type") == "checkbox") { // for chosen elements, need to insert the error after the chosen container
                    error.insertAfter($('.newLer'));
                } else if (element.attr("name") == "dd" || element.attr("name") == "mm" || element.attr("name") == "yyyy") {
                    error.insertAfter($('.newLer'));
                } else {
                    error.insertAfter($('.newLer'));
                    // for other inputs, just perform default behavior
                }
            },
            ignore: "",
            rules: {
                CorreoElectronico: {
                    required: true,
                    email: true
                }
            },
            messages: {
                CorreoElectronico: {
                    required: "Por favor, Ingrese un correo Electr&oacute;nico",
                    email: "EL formato del correo electrono es Nombre@dominio.com"
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
                $(element).closest('.newLer').removeClass('has-success').addClass('has-error').find('.symbol').removeClass('ok').addClass('required');
                // add the Bootstrap error class to the control group
            },
            unhighlight: function (element) { // revert the change done by hightlight
                $(element).closest('.newLer').removeClass('has-error');
                // set error class to the control group
            },
            success: function (label, element) {
                label.addClass('help-block valid');
                label.removeClass('color');
                // mark the current input as valid and display OK icon
                $(element).closest('.newLer').removeClass('has-error').addClass('has-success').find('.symbol').removeClass('required').addClass('ok');
            },
            submitHandler: function (form) {
                successHandler1.show();
                errorHandler1.hide();
                // submit form
                //$('#form').submit();
                //this.submit();
                var CorreoElectronico = $('#CorreoElectronico').val();
                var data = new FormData();
                data.append('CorreoElectronico', CorreoElectronico);
                $.ajax({
                    type: 'POST',
                    url: 'sfrmSucribete.aspx',
                    contentType: false,
                    data: data,
                    processData: false,
                    cache: false,
                    success: function () {
                        $('#CorreoElectronico').val('');
                        //var padre = document.getElementById('IdNews');
                        //var hijo = document.getElementById('formnews');
                        //padre.removeChild(hijo);
                        document.getElementById('NewsL').innerHTML = "Gracias por suscribirte";
                    },
                    error: function () {
                        document.getElementById('NewsL').innerHTML = "Error al suscribirte. Intente mas tarde";
                    }
                });
                return false;
            }
        });
    };

    return {
        //main function to initiate template pages
        init: function () {
           runValidator1();
        }
    };
}();