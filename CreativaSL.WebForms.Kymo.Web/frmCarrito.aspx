<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCarrito.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmCarrito" %>

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
        <div class="cart-checkout-area  pt-30">
            <div class="container">
                <div class="row">
                    <div class="product-area">
                        <div class="title-tab-product-category">
                            <div class="col-md-12 text-center pb-60">
                                <ul class="nav heading-style-3" role="tablist">
                                    <li role="presentation" class="active shadow-box"><a href="#cart" aria-controls="cart" role="tab" data-toggle="tab"><span>01</span> Carrito de compras</a></li>
                                    <li role="presentation" class="shadow-box"><a href="#checkout" aria-controls="checkout" role="tab" data-toggle="tab"><span>02</span>Datos </a></li>
                                    <li role="presentation" class="shadow-box"><a href="#complete-order" aria-controls="complete-order" role="tab" data-toggle="tab"><span>03</span> Orden completada</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                        <div class="col-sm-12">
                            <div class="content-tab-product-category pb-70">
                            <!-- Tab panes -->
                            <div class="tab-content">
                                <div role="tabpanel" class="tab-pane fade in active" id="cart">
                                    <!-- cart are start-->
                                    <div class="cart-page-area">
                                       <form method="post" action="#">
                                                   <div class="table-responsive mb-20">
                                                    <table class="shop_table-2 cart table">
                                                        <thead>
                                                            <tr>
                                                                <th class="product-name ">Producto</th>
                                                                <th class="product-price ">Precio</th>
                                                                <th class="product-quantity">Cantidad</th>
                                                                <%--<th class="product-subtotal">Importe</th>
                                                                <th class="product-discount">Descuento</th>--%>
                                                                <th class="product-subtotal ">Subtotal</th>
                                                                <th class="product-remove">Remover</th>
                                                            </tr>
                                                        </thead>
                                                        <tbody>
                                                            <% foreach (var itemDet in _dataCart.ListaVentaDetalle)
                                                                { %>
                                                            <tr class="cart_item">
                                                                <td class="item-title"> <a href="/Product/<%=itemDet.Producto.IdProducto%>"><%=itemDet.Producto.NombreProducto %></a></td>
                                                                <td class="item-price"> 
                                                                    <% Response.Write(string.Format(esMX,"{0:c}", itemDet.PrecioVenta));%>  
                                                                </td>
                                                                <td class="item-qty">
                                                                    <div class="cart-quantity">
                                                                        <div class="product-qty">
                                                                            <div class="cart-quantity">
                                                                                <div class="cart-plus-minus">
                                                                                    <div class="dec qtybutton2">-</div>
                                                                                    <input value="<%=itemDet.Cantidad%>" data-sku="<%=itemDet.Producto.IdProducto%>" data-talla ="<%=itemDet.Producto.Talla.IdTalla %>" data-color="<%=itemDet.Producto.Color.IdColor %>" name="qtybutton" class="cart-plus-minus-box" type="text">
                                                                                    <div class="inc qtybutton2">+</div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </td>
                                                                <%--<td class="subtotal-price"><strong><%Response.Write(string.Format(esMX,"{0:c}", itemDet.Subtotal)); %></strong></td>
                                                                <td class="discount"><strong><%Response.Write(string.Format(esMX,"{0:c}", itemDet.Descuento)); %></strong></td>--%>
                                                                <td class="total-price"><strong><%Response.Write(string.Format(esMX,"{0:c}", itemDet.Total)); %></strong></td>
                                                                <td class="remove-item"><a href="#" class="removeCart" data-sku="<%=itemDet.Producto.IdProducto %>" data-talla ="<%=itemDet.Producto.Talla.IdTalla %>" data-color="<%=itemDet.Producto.Color.IdColor %>"><i class="fa fa-trash-o"></i></a></td>
                                                            </tr>
                                                            <%} %>
                                                        </tbody>
                                                    </table>
                                                    </div>


                                                    <div class="cart-bottom-area">
                                                        <div class="row">
                                                            <div class="col-md-8 col-sm-7 col-xs-12">
                                                                <div class="update-coupne-area">
                                                                    <div class="update-continue-btn text-right pb-20">
                                                                        <%--<a href="#" class="btn-def btn2">Actualizar</a>--%>
                                                                        <a href="/Product" class="btn-def btn2">Continuar comprando</a>
                                                                    </div>
                                                                    
                                                                    <div id="cuponInsert" class="cupon-insert <%if (!string.IsNullOrEmpty(_dataCart.CodigoVale)) Response.Write("hidden");%>">
                                                                        <div class="coupn-area">
                                                                            <div class="catagory-title cat-tit-5 mb-20">
                                                                                <h3>Cupón</h3> 
                                                                                <p>Introduce tu código aquí</p>
                                                                            </div>                                           
                                                                            <div class="input-box input-box-2 mb-20">
                                                                                <input type="text" placeholder="Cupón" class="info" name="cupon" id="cupon"> 
                                                                            </div>
                                                                            <a href="#" class="btn-def btn2" id="btnAplicarCupon">Canjear cupón</a>
                                                                        </div>
                                                                    </div>

                                                                    <div id="contCod" class="cont-cod <%if (string.IsNullOrEmpty(_dataCart.CodigoVale)) Response.Write("hidden");%>">
                                                                        <div class="coupn-area">
                                                                            <div class="catagory-title cat-tit-5 mb-20">
                                                                                <h3>Código de cupón: <%=_dataCart.CodigoVale %></h3> 
                                                                            </div>                                           
                                                                            <div class="input-box input-box-2 mb-20">
                                                                               <h5 id="codigoCupon"></h5>
                                                                            </div>
                                                                            <a href="#" class="btn-def btn2" id="btnEliminarCupon">Eliminar cupón</a>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="col-md-4 col-sm-5 col-xs-12">
                                                                <div class="cart-total-area">
                                                                    <div class="catagory-title cat-tit-5 mb-20 text-right">
                                                                            <h3>Total</h3> 
                                                                     </div>
                                                                     <div class="sub-shipping">
                                                                         <p>Subtotal <span id="cartST"><%Response.Write(string.Format(esMX,"{0:c}", _dataCart.Subtotal)); %></span></p>
                                                                         <p>Descuento <span id="cartDT"><%Response.Write(string.Format(esMX,"{0:c}", _dataCart.Descuento)); %></span></p>
                                                                     </div>
                                                                     <div class="shipping-method text-right">
                                                                            <div class="shipp">
                                                                                <input type="radio" name="ship" id="pay-toggle1" value="1">
                                                                                <label for="pay-toggle1">Entrega a domicilio</label>
                                                                            </div>
                                                                            <div class="shipp">
                                                                                <input type="radio" name="ship" id="pay-toggle3" value="2">
                                                                                <label for="pay-toggle3">Entrega en sucursal</label>
                                                                            </div>
                                                                            <%--<p><a href="#">Calcular envío</a></p>--%>
                                                                     </div>
                                                                     <div class="process-cart-total">
                                                                         <p>Total <span id="cartTT"><%Response.Write(string.Format(esMX,"{0:c}", _dataCart.Total)); %></span></p>
                                                                     </div>
                                                                     <div class="process-checkout-btn text-right">
                                                                         <a class="btn-def btn2" href="#">Siguiente</a>
                                                                     </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </form>
                                    </div>
                                    <!-- cart are end-->
                                </div>
                                <div role="tabpanel" class="tab-pane  fade in " id="checkout">
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
                                                      <div class="panel panel-checkout">
                                                        <div class="panel-heading" role="tab" id="headingThree">
                                                          <h4 class="panel-title">
                                                          <img src="images/icons/acc.jpg" alt="">
                                                           ¿Tienes un cupón? 
                                                            <a class="collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
                                                               Click aquí para introducir código
                                                            </a>
                                                          </h4>
                                                        </div>
                                                        <div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
                                                          <div class="panel-body coupon-body">

                                                            <div class="first-last-area">
                                                                <div class="input-box mtb-20">
                                                                    <input type="text" placeholder="Coupon Code" class="info" name="code">
                                                                </div>
                                                                <div class="frm-action">
                                                                    <div class="input-box tci-box">
                                                                       <a href="#" class="btn-def btn2">Canjear cupón</a>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                          </div>
                                                        </div>
                                                      </div>
                                                    </div>  
                                                    </div>
                                                    <div class="row">
                                                        <div class="col-md-6 col-xs-12">
                                                            <div class="billing-details">
                                                                <div class="contact-text right-side">
                                                                      <h2>Detalles de facturación</h2>
                                                            <form action="#">
                                                              <div class="row">
                                                                   <div class="col-md-6 col-sm-6 col-xs-12">
                                                                        <div class="input-box mb-20">
                                                                            <label>Nombre <em>*</em></label>
                                                                            <input type="text" name="namm" class="info" placeholder="First Name">
                                                                        </div>
                                                                   </div>
                                                                   <div class="col-md-6 col-sm-6 col-xs-12">
                                                                    <div class="input-box mb-20">
                                                                        <label>Apellidos<em>*</em></label>
                                                                        <input type="text" name="namm" class="info" placeholder="Last Name">
                                                                    </div>
                                                                    </div>
                                                                    <div class="col-md-12 col-sm-12 col-xs-12">
                                                                        <div class="input-box mb-20">
                                                                            <label>Nombre de empresa</label>
                                                                            <input type="text" name="cpany" class="info" placeholder="Company Name"> 
                                                                        </div>
                                                                    </div>

                                                               <div class="col-md-6 col-sm-6 col-xs-12">
                                                                    <div class="input-box mb-20">
                                                                        <label>Correo<em>*</em></label>
                                                                        <input type="email" name="email" class="info" placeholder="Your Email">
                                                                    </div>
                                                                    </div>
                                                                     <div class="col-md-6 col-sm-6 col-xs-12">
                                                                    <div class="input-box mb-20">
                                                                        <label>Teléfono<em>*</em></label>
                                                                        <input type="text" name="phone" class="info" placeholder="Phone Number">
                                                                    </div>
                                                               </div>

                                                               <div class="col-md-12 col-sm-12 col-xs-12">
                                                                <div class="input-box mb-20">
                                                                <label>Pais<em>*</em></label>
                                                                    <select class="selectpicker select-custom" data-live-search="true">
                                                                      <option data-tokens="Bangladesh">Bangladesh</option>
                                                                      <option data-tokens="India">India</option>
                                                                      <option data-tokens="Pakistan">Pakistan</option>
                                                                      <option data-tokens="Pakistan">Pakistan</option>
                                                                      <option data-tokens="Srilanka">Srilanka</option>
                                                                      <option data-tokens="Nepal">Nepal</option>
                                                                      <option data-tokens="Butan">Butan</option>
                                                                      <option data-tokens="USA">USA</option>
                                                                      <option data-tokens="England">England</option>
                                                                      <option data-tokens="Brazil">Brazil</option>
                                                                      <option data-tokens="Canada">Canada</option>
                                                                      <option data-tokens="China">China</option>
                                                                      <option data-tokens="Koeria">Koeria</option>
                                                                      <option data-tokens="Soudi">Soudi Arabia</option>
                                                                      <option data-tokens="Spain">Spain</option>
                                                                      <option data-tokens="France">France</option>
                                                                       <option data-tokens="México">México</option>
                                                                    </select>

                                                                </div>
                                                               </div>

                                                               <div class="col-md-12 col-sm-12 col-xs-12">
                                                                <div class="input-box mb-20">
                                                                    <label>Dirección <em>*</em></label>
                                                                    <input type="text" name="add1" class="info mb-10" placeholder="Street Address">
                                                                    <input type="text" name="add2" class="info mt10" placeholder="Apartment, suite, unit etc. (optional)">
                                                                </div>
                                                                </div>
                                                                <div class="col-md-12 col-sm-12 col-xs-12">
                                                                    <div class="input-box mb-20">
                                                                        <label>Ciudad <em>*</em></label>
                                                                        <input type="text" name="add1" class="info" placeholder="Town/City">
                                                                    </div>
                                                                </div>

                                                                    
                                                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                                                        <div class="input-box">
                                                                            <label>Código postal<em>*</em></label>
                                                                            <input type="text" name="zipcode" class="info" placeholder="Zip Code">
                                                                        </div>
                                                                    </div>
                                                                <div class="col-md-12 col-sm-12 col-xs-12">
                                                                    <div class="create-acc clearfix mtb-20">
                                                                        <div class="acc-toggle">
                                                                            <input type="checkbox" id="acc-toggle">
                                                                            <label for="acc-toggle">¿Crear una cuenta ?</label>
                                                                        </div>
                                                                        <div class="create-acc-body">
                                                                           <div class="sm-des">
                                                                              Cree una cuenta ingresando la información a continuación. Si es un cliente que regresa por favor ingrese en la parte superior de la página.
                                                                           </div>
                                                                            <div class="input-box">
                                                                                <label>Contraseña de la cuenta <em>*</em></label>
                                                                                <input type="password" name="pass" class="info" placeholder="Password">
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                                </div>
                                                            </form>
                                                            </div>
                                                        </div>
                                                        </div>
                                                        <div class="col-md-6 col-xs-12">
                                                            <div class="billing-details">
                                                                <div class="right-side">
                                                                    <div class="ship-acc clearfix">
                                                                    <div class="ship-toggle pb20">
                                                                        <input type="checkbox" id="ship-toggle">
                                                                        <label for="ship-toggle">¿Envia a una direccion diferente?</label>
                                                                    </div>
                                                                    <div class="ship-acc-body">
                                                                        <form action="#">
                                                                            <div class="row">
                                                                                <div class="col-md-6 col-sm-6 col-xs-12">
                                                                                    <div class="input-box mb-20">
                                                                                        <label>Nombre <em>*</em></label>
                                                                                        <input type="text" name="namm" class="info" placeholder="First Name"> </div>
                                                                                </div>
                                                                                <div class="col-md-6 col-sm-6 col-xs-12">
                                                                                    <div class="input-box mb-20">
                                                                                        <label>Apellidos<em>*</em></label>
                                                                                        <input type="text" name="namm" class="info" placeholder="Last Name"> </div>
                                                                                </div>
                                                                                <div class="col-md-12 col-sm-12 col-xs-12">
                                                                                    <div class="input-box mb-20">
                                                                                        <label>Nombre de emrpesa</label>
                                                                                        <input type="text" name="cpany" class="info" placeholder="Company Name"> </div>
                                                                                </div>
                                                                                <div class="col-md-6 col-sm-6 col-xs-12">
                                                                                    <div class="input-box mb-20">
                                                                                        <label>Email <em>*</em></label>
                                                                                        <input type="email" name="email" class="info" placeholder="Your Email"> </div>
                                                                                </div>
                                                                                <div class="col-md-6 col-sm-6 col-xs-12">
                                                                                    <div class="input-box mb-20">
                                                                                        <label>Teléfono<em>*</em></label>
                                                                                        <input type="text" name="phone" class="info" placeholder="Phone Number"> </div>
                                                                                </div>
                                                                               <!--  <div class="col-md-12 col-sm-12 col-xs-12">
                                                                                    <div class="input-box mb-20">
                                                                                        <label>Country <em>*</em></label>
                                                                                        <select class="selectpicker select-custom" data-live-search="true">
                                                                                            <option data-tokens="Bangladesh">Bangladesh</option>
                                                                                            <option data-tokens="India">India</option>
                                                                                            <option data-tokens="Pakistan">Pakistan</option>
                                                                                            <option data-tokens="Pakistan">Pakistan</option>
                                                                                            <option data-tokens="Srilanka">Srilanka</option>
                                                                                            <option data-tokens="Nepal">Nepal</option>
                                                                                            <option data-tokens="Butan">Butan</option>
                                                                                            <option data-tokens="USA">USA</option>
                                                                                            <option data-tokens="England">England</option>
                                                                                            <option data-tokens="Brazil">Brazil</option>
                                                                                            <option data-tokens="Canada">Canada</option>
                                                                                            <option data-tokens="China">China</option>
                                                                                            <option data-tokens="Koeria">Koeria</option>
                                                                                            <option data-tokens="Soudi">Soudi Arabia</option>
                                                                                            <option data-tokens="Spain">Spain</option>
                                                                                            <option data-tokens="France">France</option>
                                                                                        </select>
                                                                                    </div>
                                                                                </div> -->
                                                                                <div class="col-md-12 col-sm-12 col-xs-12">
                                                                                    <div class="input-box mb-20">
                                                                                        <label>Dirección <em>*</em></label>
                                                                                        <input type="text" name="add1" class="info mb-10" placeholder="Street Address">
                                                                                        <input type="text" name="add2" class="info mt10" placeholder="Apartment, suite, unit etc. (optional)"> </div>
                                                                                </div>
                                                                                <div class="col-md-12 col-sm-12 col-xs-12">
                                                                                    <div class="input-box mb-20">
                                                                                        <label>Ciudad <em>*</em></label>
                                                                                        <input type="text" name="add1" class="info" placeholder="Town/City"> </div>
                                                                                </div>
                                                                             
                                                                                <div class="col-md-6 col-sm-6 col-xs-12">
                                                                                    <div class="input-box mb-20">
                                                                                        <label>Código postal<em>*</em></label>
                                                                                        <input type="text" name="zipcode" class="info" placeholder="Zip Code"> </div>
                                                                                </div>
                                                                            </div>
                                                                        </form>
                                                                    </div>
                                                                    </div>
                                                                <div class="form">
                                                                    <div class="input-box">
                                                                        <label>Notas</label>
                                                                        <textarea placeholder="Notas acerca de tu pédido" class="area-tex"></textarea>
                                                                    </div>
                                                                </div>
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
                                <div role="tabpanel" class="tab-pane  fade in" id="complete-order">
                                    <div class="row">
                                        <div class="col-xs-12">
                                        <div class="checkout-payment-area">
                                            <div class="checkout-total mt20">
                                               <h3>Tu orden</h3>
                                           <form action="#" method="post">
                                           <div class="table-responsive">
                                                <table class="checkout-area table">
                                               <thead>
                                                <tr class="cart_item check-heading">
                                                    <td class="ctg-type"> Productos</td>
                                                    <td class="cgt-des"> Total</td>
                                                </tr>
                                                </thead>
                                                <tbody>
                                                    <tr class="cart_item check-item prd-name">
                                                        <td class="ctg-type"> Aenean sagittis × <span>1</span></td>
                                                        <td class="cgt-des"> $1,026.00</td>
                                                    </tr>
                                                    <tr class="cart_item check-item prd-name">
                                                        <td class="ctg-type"> Aenean sagittis × <span>1</span></td>
                                                        <td class="cgt-des"> $1,026.00</td>
                                                    </tr>
                                                    <tr class="cart_item">
                                                        <td class="ctg-type"> Subtotal</td>
                                                        <td class="cgt-des">$2,052.00</td>
                                                    </tr>
                                                    <tr class="cart_item">
                                                        <td class="ctg-type">Shipping</td>
                                                            <td class="cgt-des ship-opt">
                                                                <div class="shipp">
                                                                    <input type="radio" id="pay-toggle" name="ship">
                                                                    <label for="pay-toggle">Flat Rate: <span>$03</span></label>
                                                                </div>
                                                                <div class="shipp">
                                                                    <input type="radio" id="pay-toggle2" name="ship">
                                                                    <label for="pay-toggle2">Free Shipping</label>
                                                                </div>
                                                         </td>
                                                    </tr>
                                                    <tr class="cart_item">
                                                        <td class="ctg-type crt-total"> Total</td>
                                                        <td class="cgt-des prc-total"> $ 2,055.00 </td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                           </div>
                                        </form>
                                        </div>
                                            <div class="payment-section mt-20 clearfix">
                                                <div class="pay-toggle">
                                                    <form action="#">
                                                       <div class="pay-type-total">
                                                        <div class="pay-type">
                                                            <input type="radio" id="pay-toggle01" name="pay">
                                                            <label for="pay-toggle01">Direct Bank Transfer</label>
                                                        </div>
                                                        <div class="pay-type">
                                                            <input type="radio" id="pay-toggle02" name="pay">
                                                            <label for="pay-toggle02">Cheque Payment</label>
                                                        </div>
                                                        <div class="pay-type">
                                                            <input type="radio" id="pay-toggle03" name="pay">
                                                            <label for="pay-toggle03">Cash on Delivery</label>
                                                        </div>
                                                        <div class="pay-type">
                                                            <input type="radio" id="pay-toggle04" name="pay">
                                                            <label for="pay-toggle04">Paypal</label>
                                                        </div>
                                                        </div>
                                                        <div class="input-box mt-20">
                                                            <a class="btn-def btn2" href="#">Place order</a>
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
                        </div>
                    </div>
                </div>
            </div>
        </div>    
        <!--cart-checkout-area end--> 

</asp:Content>

<asp:Content ContentPlaceHolderID="cphScripts" runat="server">
    <script src="../assets/js/carrito.js"></script>
    <script>
        jQuery(document).ready(function () {
            Carrito.init();
        });
    </script>
</asp:Content>