var Estado = function () {
    var runEstado = function () {
        $("#cmbEstado").change(function () {
            $("#cmbEstado option:selected").each(function () {
                elegido = $(this).val();
                $("#cmbMunicipio option").remove();
                $.ajaxSetup({
                    async: false
                });
                $.getJSON('sfrmMunicipios.aspx?estado=' + elegido, function (data) {
                    $("#cmbMunicipio").append('<option value="">&nbsp;</option>');
                    $.each(data, function (key, value) {
                        $("#cmbMunicipio").append('<option value="' + value.IDMunicipio + '">' + value.Descripcion + '</option>');
                    });
                });
                $("#cmbMunicipio").trigger('change.select2');
                $.ajaxSetup({
                    async: true
                });

            });
        });
    };
return {
    //main function to initiate template pages
    init: function () {
        runEstado();
    }
};
}();