<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCarritoDatos.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmCarritoDatos" %>

<asp:Content ContentPlaceHolderID="cphPrincipal" runat="server">

    <!--breadcumb area start -->
        <!--breadcumb area start -->
        <%  System.Globalization.CultureInfo esMX = new System.Globalization.CultureInfo("es-MX");
            var imgTitle = _dataCart.ListaImagenes.Find(x => x.NumPosition == 1);
            if (imgTitle == null)
            {
        %>
            <div class="breadcumb-area breadcumb overlay pos-rltv" style="background:rgba(0, 0, 0, 0) url('assets/images/bg/breadcumb.jpg') no-repeat scroll 0 0;">
        <%}
        else
        {
            Response.Write("<div class='breadcumb-area breadcumb overlay pos-rltv' style='background:rgba(0, 0, 0, 0) url(" + imgTitle.UrlImagen + ") no-repeat scroll 0 0;'>");
        }%>
            <div class="bread-main">
                <div class="bred-hading text-center">
                    <%
                        var _dataTitle = _dataCart.ListaTextos.Find(x => x.NumPosition == 1);
                        if(_dataTitle != null)
                        {
                            Response.Write("<h5>" + _dataTitle.Texto + "</h5>");
                        }
                    %>
                </div>
                <ol class="breadcrumb">
                    <li class="home"><a title="Go to Home Page" href="/Home">Home</a></li>
                    <li class="active">Carrito</li>
                </ol>
            </div>
        </div>
        <!--breadcumb area end -->
        
        <!--cart-checkout-area start -->
        <div id="cart" class="cart-checkout-area  pt-30">
            <div class="container">
                <div class="row">
                    <div class="product-area">
                        <%--<div class="title-tab-product-category">
                            <div class="col-md-12 text-center pb-60">
                                <ul class="nav heading-style-3" role="tablist">
                                    <li role="presentation" class="active shadow-box"><a href="#cart" aria-controls="cart" role="tab" data-toggle="tab"><span>01</span> Carrito de compras</a></li>
                                    <li role="presentation" class="shadow-box"><a href="#checkout" aria-controls="checkout" role="tab" data-toggle="tab"><span>02</span>Datos </a></li>
                                    <li role="presentation" class="shadow-box"><a href="#complete-order" aria-controls="complete-order" role="tab" data-toggle="tab"><span>03</span> Orden completada</a></li>
                                </ul>
                            </div>
                        </div>--%>
                        <div class="clearfix"></div>
                        <div class="col-sm-12">
                            <div class="content-tab-product-category pb-70">
                            <!-- Tab panes -->
                            <div class="tab-content">
                                <div role="tabpanel" class="tab-pane  fade in active" id="checkout">
                                    <!-- Checkout are start-->
                                    <div class="checkout-area">
                                        <div class="">
                                            <div class="row">
                                                <div class="col-md-12 col-sm-12 col-xs-12">
                                                    <div class="coupne-customer-area mb50">
                                                      <div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
                                                      <div class="panel panel-checkout">
                                                        <div class="panel-heading" role="tab" id="headingTwo">
                                                          <h4 class="panel-title">
                                                          <img src="images/icons/acc.jpg" alt="">
                                                           ¿Ya eres cliente? 
                                                            <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
                                                               Click aquí
                                                            </a>
                                                          </h4>
                                                        </div>
                                                        <div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
                                                          <div class="panel-body">
                                                            <div class="sm-des pb20">
                                                                Si has comprado con nosotros antes, por favor pon tus datos en los campos.
                                                            </div>
                                                            <div class="first-last-area">
                                                                <div class="input-box mtb-20">
                                                                    <label>Usuario</label>
                                                                    <input type="email" placeholder="Your Email" class="info" name="email">
                                                                </div>
                                                                <div class="input-box mb-20">
                                                                    <label>Contraseña</label>
                                                                    <input type="password" placeholder="Password" class="info" name="padd">
                                                                </div>
                                                                <div class="frm-action cc-area">
                                                                    <div class="input-box tci-box">
                                                                       <a href="#" class="btn-def btn2">Login</a>
                                                                    </div>
                                                                    <span>
                                                                <input type="checkbox" class="remr"> Recordar 
                                                                </span>
                                                                    <a class="forgotten forg" href="#">Olvide contraseña</a>
                                                                </div>
                                                            </div>
                                                          </div>
                                                        </div>
                                                      </div>
                                                    </div>  
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-xs-12">
                                                            <div class="billing-details">
                                                                <div class="contact-text right-side">
                                                                    <h2>Detalles del cliente</h2>
                                                                    <form id="contact-form" method="post">
                                                                        <div class="col-md-12">
                                                                            <div class=" col-md-8">
                                                                                <div class="login-reg">
                                                                                    <h3>Registrase</h3>
                                                                                    <div class="row">
                                                                                        <div class="input-box mb-20 col-md-4">
                                                                                            <label class="control-label">Nombre</label>
                                                                                            <input type="text" name="Nombre" id="Nombre" runat="server" value="" placeholder="Tu Nombre">
                                                                                        </div>
                                                                                        <div class="input-box mb-20 col-md-4">
                                                                                            <label class="control-label">Apellido Paterno</label>
                                                                                            <input type="text" name="ApPaterno" id="ApPaterno" runat="server" value="" placeholder="Apellido Paterno">
                                                                                        </div>
                                                                                        <div class="input-box mb-20 col-md-4">
                                                                                            <label class="control-label">Apellido Materno</label>
                                                                                            <input type="text" name="ApMaterno" id="ApMaterno" runat="server" value="" placeholder="Apellido Materno">
                                                                                        </div>
                                                                                    </div>

                                                                                    <div class="row">
                                                                                        <div class="input-box mb-20 col-md-6">
                                                                                            <label class="control-label">Fecha de nacimiento</label>
                                                                                            <input type="text" id="datepicker" name="datepicker"  runat="server" value="" placeholder="Fecha de nacimiento">
                                                                                        </div>
                                                                                        <div class="input-box mb-20 col-md-6">
                                                                                            <label class="control-label">Sexo</label>
                                                                                            <select name="cmbGenero" id="cmbGenero" class="form-control search-select">
                                                                                                <option value="">&nbsp;</option>
                                                                                                <% foreach (var Item in _ListaGenero)
                                                                                                    {
                                                                                                        Response.Write("<option value='" + Item.IdGenero.ToString() + "'>" + Item.NombreGenero.ToString() + "</option>");
                                                                                                        //if (Item.IdGenero == this.IDGenero)
                                                                                                        //{
                                                                                                        //    Response.Write("<option value='" + Item.IdGenero.ToString() + "'selected>" + Item.NombreGenero.ToString() + "</option>");
                                                                                                        //}
                                                                                                        //else
                                                                                                        //{
                                                                                                        //    Response.Write("<option value='" + Item.IdGenero.ToString() + "'>" + Item.NombreGenero.ToString() + "</option>");
                                                                                                        //}
                                                                                                    } %>
                                                                                            </select>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="row">
                                                                                        <div class="input-box mb-20 col-md-6">
                                                                                            <label class="control-label">Dirección</label>
                                                                                            <input type="text" name="Direccion" id="Direccion" runat="server" value="" placeholder="Dirección">
                                                                                        </div>
                                                                                         <div class="input-box mb-20 col-md-6">
                                                                                            <label class="control-label">Colonias</label>
                                                                                            <input type="text" name="Colonia" id="Colonia" runat="server" value="" placeholder="Colonia">
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
                                                                                                        //if (Item.IdEstado == this.IDEstado)
                                                                                                        //{
                                                                                                        //    Response.Write("<option value='" + Item.IdEstado.ToString() + "' selected>" + Item.DescrpcionEs.ToString() + "</option>");
                                                                                                        //}
                                                                                                        //else
                                                                                                        //{

                                                                                                        //}
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
                                                                                    <div class="ship-acc-body">
                                                                                    <div class="row"><br /><br /><br /><br /></div>
                                                                                    <div class="row"><br /><br /><br /><br /></div>
                                                                                        </div>
                                                                                </div>
                                                                            </div>
                                                                            <div class=" col-md-4">
                                                                                <div class="login-reg">
                                                                                    <h3>Sobre su cuenta</h3>
                                                                                    <div class="row">
                                                                                        <div class="input-box mb-20 col-md-12">
                                                                                            <label class="control-label">Teléfono</label>
                                                                                            <input type="text" name="Telefono" id="Telefono" runat="server" value="" placeholder="Telefono">
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="row">
                                                                                        <div class="input-box mb-20 col-md-12">
                                                                                            <label class="control-label">Correo Electrónico</label>
                                                                                            <input type="text" name="Correo" id="Correo" runat="server" value="" placeholder="nombre@dominio.com">
                                                                                        </div>
                                                                                    </div>
                                                                                     <div class="row">
                                                                                        <div class=" mb-20 col-md-12 col-xs-12">
                                                                                            <div class="ship-toggle pb20">
                                                                                                <input type="checkbox" id="ship-toggle" value="true">
                                                                                                <label for="ship-toggle">¿Modificar Contraseña?</label>
                                                                                            </div>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="ship-acc-body">
                                                                                        <div class="row">
                                                                                            <div class="input-box mb-20 col-md-12">
                                                                                                <label class="control-label">Contraseña</label>
                                                                                                <input type="password" name="Contrasena" id="Contrasena" runat="server" value="" placeholder="">
                                                                                            </div>
                                                                                        </div>
                                                                                        <div class="row">
                                                                                            <div class="input-box mb-20 col-md-12">
                                                                                                <label class="control-label">Repetir Contraseña</label>
                                                                                                <input type="password" name="Contrasena2" id="Contrasena2" runat="server" value="" placeholder="">
                                                                                            </div>
                                                                                        </div>
                                                                                    </div>
                                                                                    <div class="row">
                                                                                        <div class=" mb-20 col-md-12 col-xs-12">
                                                                                            <input type="checkbox" name="CkRecibir" id="CkRecibir"value="true" style="width: 15px;"><label style="width: 250px; padding-left: 20px;">Quiero recibir correo electrónico ofertas y novedades</label>
                                                                                        </div>
                                                                                    </div>
                                                                                     <div class="row"><br /></div>
                                                                                </div>
                                                                            </div>
                                                                            <div class="frm-action">
                                                                                <div class="input-box mt-20">
                                                                                    <button class="btn-def btn2 btn-kymo" type="submit">Guardar</button>
                                                                                    <%--a class="btn-def btn2" href="#">Registrase</a>--%>
                                                                                </div>
                                                                               <%-- <div class="input-box tci-box">
                                                                                    <button class="btn-def btn2 btn-kymo" type="submit">Registrase</button>
                                                                                </div>--%>
                                                                            </div>
                                                                        </div>
                                                                    </form>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Checkout are end-->
                                </div>
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>    
        <!--cart-checkout-area end--> 
    
</asp:Content>

<asp:Content ContentPlaceHolderID="cphScripts" runat="server">
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script src="../assets/js/form-validation.js"></script>
    <script src="../assets/js/carrito.js"></script>
    <script src="../assets/js/Estado.js"></script>
    <script>
        jQuery(document).ready(function () {
            FormValidator.init(4);
            Carrito.init();
            Estado.init();
            $("#datepicker").datepicker({
                changeMonth: true,
                changeYear: true,
                yearRange: "1950:2002"
            });
              $.ajaxSetup({
                    async: false
                });
                document.getElementById('cmbEstado').value=<%=this.IDEstado%>;
                $("#cmbEstado").trigger('change');
                document.getElementById('cmbMunicipio').value=<%=this.IDMunicipio%>;
                $("#cmbMunicipio").trigger('change.select2');
                document.getElementById('cmbGenero').value=<%=this.IDGenero%>;
                $("#cmbGenero").trigger('change.select2');
                $.ajaxSetup({
                    async: true
                });
        });
    </script>
</asp:Content>