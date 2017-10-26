var Tallas = function () {
    "use strict";
    //function to 
    var runCargarTallas = function () {
        $("#input-sort-color").change(function (event) {
            event.preventDefault();
            var color = $('#input-sort-color').val();
            var idProducto = $('#addCart').data('sku');
            var data = new FormData();
            data.append('IDProducto', idProducto);
            data.append('IDColor', color);
            $.ajax({
                type: 'POST',
                url: '../sfrmTallas.aspx',
                contentType: false,
                dataType: "json",
                data: data,
                processData: false,
                cache: false,
                success: function (result) {
                    $("#input-sort-size option").remove();
                    $("#input-sort-size").append('<option value="0">Seleccione</option>');
                    $.each(result, function (key, value) {
                        $("#input-sort-size").append('<option value="' + value.IDTalla + '">' + value.Descripcion + '</option>');
                    });
                },
                error: function () {
                    $("#input-sort-size option").remove();
                    $("#input-sort-size").append('<option value="0">Seleccione</option>');
                }
            });

            return false;
        });
    };
    return {
        //main function to initiate template pages
        init: function () {
            runCargarTallas();
        }
    };
}();