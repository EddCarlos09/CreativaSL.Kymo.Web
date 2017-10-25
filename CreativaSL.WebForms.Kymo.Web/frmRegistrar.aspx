<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmRegistrar.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmRegistrar" %>
<asp:Content runat="server" ContentPlaceHolderID="cphPrincipal">

<div class="breadcumb-area breadcumb-6 overlay pos-rltv">
            <div class="bread-main">
                <div class="bred-hading text-center">
                    <h5>Registrar</h5> </div>
                <ol class="breadcrumb">
                    <li class="home"><a title="Go to Home Page" href="index.html">Home</a></li>
                    <li class="active">Registrar</li>
                </ol>
            </div>
        </div>
        <!--breadcumb area end -->
        <!-- Account Area Start -->
    <div class="account-area ptb-80">
        <div class="container">
            <div class="row">
                <h1 id="Correcto" style="text-align:center; background-color:#75ea00; border-radius: 50px;"></h1>
                <h1 id="CorrectoError" style="text-align:center; background-color:#ff0000; border-radius: 50px;"></h1>
                <div id="IdRegistrar" class="col-sm-12 col-xs-12 lr2">
                    <form id="contact-form" method="post" onsubmit="ValidarContacto()">
                        <div class="col-md-12">
                            <div class=" col-md-8">
                                <div class="login-reg">
                                    <h3>Registrase</h3>
                                  <div class="row">
                                        <div class="input-box mb-20 col-md-4">
                                        <label class="control-label">Nombre</label>
                                        <input type="text" name="Nombre" id="Nombre" value="" placeholder="Tu Nombre">
                                    </div>
                                    <div class="input-box mb-20 col-md-4">
                                        <label class="control-label">Apellido Paterno</label>
                                        <input type="text" name="ApPaterno" id="ApPaterno" value="" placeholder="Apellido Paterno">
                                    </div>
                                    <div class="input-box mb-20 col-md-4">
                                        <label class="control-label">Apellido Materno</label>
                                        <input type="text" name="ApMaterno" id="ApMaterno" value="" placeholder="Apellido Materno">
                                    </div>
                                  </div>
                                    
                                   <div class="row">
                                       <div class="input-box mb-20 col-md-6">
                                        <label class="control-label">Fecha de nacimiento</label>
                                        <input type="text" id="datepicker" name="datepicker" value="" placeholder="Fecha de nacimiento">
                                    </div>
                                        <div class="input-box mb-20 col-md-6">
                                        <label class="control-label">Sexo</label>
                                        <select name="cmbGenero" id="cmbGenero" class="form-control search-select">
                                            <option value="">&nbsp;</option>
                                            <% foreach (var Item in _ListaGenero)
                                                {
                                                    Response.Write("<option value='" + Item.IdGenero.ToString() + "'>" + Item.NombreGenero.ToString() + "</option>");
                                                } %>
                                        </select>
                                    </div>
                                   </div>
                                    <div class="row">
                                        <div class="input-box mb-20 col-md-6">
                                        <label class="control-label">Tu Código postal</label>
                                        <input type="text" name="CP" id="CP" value="" placeholder="Tu Código postal">
                                    </div>
                                    <div class="input-box mb-20 col-md-6">
                                        <label class="control-label">Dirección</label>
                                        <input type="text" name="Direccion" id="Direccion" value="" placeholder="Dirección">
                                    </div>
                                    </div>
                                    <div class="row">
                                        <div class="input-box mb-20 col-md-3">
                                        <label class="control-label">No. Exterior</label>
                                        <input type="text" name="NExterior" id="NExterior" value="" placeholder="No. Exterior">
                                    </div>
                                    <div class="input-box mb-20 col-md-3">
                                        <label class="control-label">No. Interior</label>
                                        <input type="text" name="NInterior" id="NInterior" value="" placeholder="No. Interior">
                                    </div>
                                     <div class="input-box mb-20 col-md-6">
                                        <label class="control-label">Colonias</label>
                                        <input type="text" name="Colonia" id="Colonia" value="" placeholder="Colonia">
                                    </div>
                                    </div>
                                    <div class="row">
                                        <div class="input-box mb-20 col-md-6">
                                        <label class="control-label">Estado</label>
                                        <select id="cmbEstado" name="cmbEstado" class="form-control search-select">
                                            <option value="">&nbsp;</option>
                                            <% foreach (var Item in _ListaEstado)
                                                {
                                                    Response.Write("<option value='" + Item.IdEstado.ToString() + "'>" + Item.DescrpcionEs.ToString() + "</option>");
                                                } %>
                                        </select>
                                    </div>
                                    <div class="input-box mb-20 col-md-6">
                                        <label class="control-label">Municipio</label>
                                        <select name="cmbMunicipio" id="cmbMunicipio" class="form-control search-select">
                                            <option value="">&nbsp;</option>
                                        </select>
                                    </div>
                                    </div>
                                </div>
                            </div>
                            <div class=" col-md-4">
                                <div class="login-reg">
                                    <h3>Sobre su cuenta</h3>
                                    <div class="input-box mb-20 col-md-12">
                                        <label class="control-label">Teléfono</label>
                                        <input type="text" name="Telefono" id="Telefono" value="" placeholder="Telefono">
                                    </div>

                                    <div class="input-box mb-20 col-md-12">
                                        <label class="control-label">Correo Electrónico</label>
                                        <input type="text" name="Correo" id="Correo" value="" placeholder="nombre@dominio.com">
                                    </div>
                                    <div class="input-box mb-20 col-md-12">
                                        <label class="control-label">Contraseña</label>
                                        <input type="password" name="Contrasena" id="Contrasena" value="" placeholder="">
                                    </div>
                                    <div class="input-box mb-20 col-md-12">
                                        <label class="control-label">Repetir Contraseña</label>
                                        <input type="password" name="Contrasena2" id="Contrasena2" value="" placeholder="">
                                    </div>
                                    <div class=" mb-20 col-md-12 col-xs-12">
                                        <input type="checkbox" name="CkRecibir" id="CkRecibir" value="true" style="width: 15px;"><label style="width: 250px; padding-left: 20px;">Quiero recibir correo electrónico ofertas y novedades</label>
                                    </div>
                                </div>
                            </div>
                            <div class="frm-action">
                                <div class="input-box tci-box">
                                     <button class="btn-def btn2" type="submit">Registrase</button>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div>
    </div>
    </asp:Content>
    <asp:Content runat="server" ContentPlaceHolderID="cphScripts">    
        <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
        <script src="../assets/js/form-validation.js"></script>
        <script>
            jQuery(document).ready(function() {
                FormValidator.init();
                $( "#datepicker" ).datepicker({
                    changeMonth: true,
                    changeYear: true,
                    yearRange: "1950:2002"
                });
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
            });
        </script>
        <script>
         function ValidarContacto() {
                 $(this).submit(function (e) {
                     e.preventDefault();
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
                         success: function (respuesta) {
                             console.log(respuesta);
                             var padre = document.getElementById('IdRegistrar');
                             var hijo = document.getElementById('contact-form');
                             padre.removeChild(hijo);
                             // document.getElementById('form').style.display = "none";
                             document.getElementById('Correcto').innerHTML = "Gracias por registrase";
                         },
                         error: function () {
                             document.getElementById('CorrectoError').innerHTML = "Error al enviar los datos .Intente mas tarde";
                         }
                     });
                     return false;
                 });
         }
            </script>
    </asp:Content>