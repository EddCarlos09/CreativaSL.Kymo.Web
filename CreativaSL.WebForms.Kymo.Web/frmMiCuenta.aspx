<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMiCuenta.aspx.cs" MasterPageFile="~/Site.Master" Inherits="CreativaSL.WebForms.Kymo.Web.frmMiCuenta" %>
<asp:Content runat="server" ContentPlaceHolderID="cphPrincipal">
    <!--breadcumb area start -->
        <div class="breadcumb-area overlay pos-rltv">
            <div class="bread-main">
                <div class="bred-hading text-center">
                    <h5>My Account</h5> </div>
                <ol class="breadcrumb">
                    <li class="home"><a title="Go to Home Page" href="index.html">Home</a></li>
                    <li class="active">Account</li>
                </ol>
            </div>
        </div>
        <!--breadcumb area end -->
        
        <!--service idea area are start -->
        <div class="idea-area  ptb-80">
            <div class="container">
                <div class="row">
                    <div class="col-md-3 col-sm-4 col-xs-12">
                        <div class="idea-tab-menu">
                            <ul class="nav idea-tab" role="tablist">
                                <li role="presentation" class="active"><a href="#creativity" aria-controls="creativity" role="tab" data-toggle="tab">Informacion Personal</a></li>
                                <li role="presentation"><a href="#ideas" aria-controls="ideas" role="tab" data-toggle="tab">Direccion de entrega</a></li>
                                <li role="presentation"><a href="#design" aria-controls="design" role="tab" data-toggle="tab">Detalles de facturacion</a></li>
                                <li role="presentation"><a href="#devlopment" aria-controls="devlopment" role="tab" data-toggle="tab">Mis Pedidos</a></li>
                                <li role="presentation"><a href="#markenting" aria-controls="markenting" role="tab" data-toggle="tab">Metodos de Pago</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-9 col-sm-8 col-xs-12">
                        <div class="idea-tab-content">
                            <!-- Tab panes -->
                            <%--<%foreach (var item in _listaCliente.ListaCliente)
                                {%>--%>
                            <div class="tab-content">
                                <div role="tabpanel" class="tab-pane fade in active" id="creativity">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Nombre <em>*</em></label>
                                            <input type="text" name="namm" class="info" placeholder=<%--<%=item.Nombre%>--%>/>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Apellido Paterno<em>*</em></label>
                                            <input type="text" name="namm" class="info" placeholder=<%--<%=item.ApPat %>--%> />
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Apellido Materno<em>*</em></label>
                                            <input type="text" name="namm" class="info" placeholder=<%--<%=item.ApMat %>--%> />
                                        </div>
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Correo Electronico<em>*</em></label>
                                            <input type="email" name="email" class="info" placeholder=<%--<%=item.Correo %>--%> />
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Numero de telefono<em>*</em></label>
                                            <input type="text" name="phone" class="info" placeholder=<%--<%=item.Telefono %>--%> />
                                        </div>
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Contraseña<em>*</em></label>
                                            <input type="password" name="email" class="info" placeholder=<%--<%=item.Password %>--%> />
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Confirmar Contraseña<em>*</em></label>
                                            <input type="password" name="phone" class="info" placeholder=<%--<%=item.Password %>--%> />
                                        </div>
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Pais <em>*</em></label>
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
                                                <option data-tokens=143>France</option>
                                                
                                            </select>
                                        </div>
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Ciudad <em>*</em></label>
                                            <input type="text" name="add1" class="info" placeholder=<%--<%=item.IdMunicipio %>--%> />
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Estado <em>*</em></label>
                                            <select class="selectpicker select-custom" data-live-search="true">
                                                <option data-tokens="Barisal">Barisal</option>
                                                <option data-tokens="Dhaka">Dhaka</option>
                                                <option data-tokens="Kulna">Kulna</option>
                                                <option data-tokens="Rajshahi">Rajshahi</option>
                                                <option data-tokens="Sylet">Sylet</option>
                                                <option data-tokens="Chittagong">Chittagong</option>
                                                <option data-tokens="Rangpur">Rangpur</option>
                                                <option data-tokens="Maymanshing">Maymanshing</option>
                                                <option data-tokens="Cox">Cox's Bazar</option>
                                                <option data-tokens="Saint">Saint Martin</option>
                                                <option data-tokens="Kuakata">Kuakata</option>
                                                <option data-tokens="Sajeq">Sajeq</option>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Codigo Postal<em>*</em></label>
                                            <input type="text" name="zipcode" class="info" placeholder="Zip Code">
                                        </div>
                                    </div>
                                    <div class="col-md-12 col-sm-12 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Direccion <em>*</em></label>
                                            <input type="text" name="add1" class="info mb-10" placeholder=<%--<%=item.Direccion %>--%> />
                                        </div>
                                    </div>
                                    <div class=" col-md-6 col-sm-8 col-xs-12">
                                        <div class="checkbox checkbox-2">
                                            <label>
                                                <small>
                                                    <input name="signup" type="checkbox">Deseo suscribirme al newsletter.
                                                </small>
                                            </label>
                                            <br>
                                            <label>
                                                <small>
                                                    <input name="signup" type="checkbox">He leido los terminos y condiciones<a href="#">Politica de Privacidad</a>
                                                </small>
                                            </label>
                                        </div>
                                    </div>
                                    <%--<%} %>--%>
                                    <div class="col-md-6 col-sm-4 col-xs-12 text-right">
                                        <a class="btn-def btn2" href="#">Guardar</a>
                                    </div>
                                </div>
                                <div role="tabpanel" class="tab-pane fade in" id="ideas">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Nombre <em>*</em></label>
                                            <input type="text" name="namm" class="info" placeholder="First Name">
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Apellido Paterno<em>*</em></label>
                                            <input type="text" name="namm" class="info" placeholder="Last Name">
                                        </div>
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Correo Electronico<em>*</em></label>
                                            <input type="email" name="email" class="info" placeholder="Your Email">
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Numero de telefono<em>*</em></label>
                                            <input type="text" name="phone" class="info" placeholder="Phone Number">
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Pais <em>*</em></label>
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
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Ciudad<em>*</em></label>
                                            <input type="text" name="add1" class="info" placeholder="Town/City">
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Estado <em>*</em></label>
                                            <select class="selectpicker select-custom" data-live-search="true">
                                                <option data-tokens="Barisal">Barisal</option>
                                                <option data-tokens="Dhaka">Dhaka</option>
                                                <option data-tokens="Kulna">Kulna</option>
                                                <option data-tokens="Rajshahi">Rajshahi</option>
                                                <option data-tokens="Sylet">Sylet</option>
                                                <option data-tokens="Chittagong">Chittagong</option>
                                                <option data-tokens="Rangpur">Rangpur</option>
                                                <option data-tokens="Maymanshing">Maymanshing</option>
                                                <option data-tokens="Cox">Cox's Bazar</option>
                                                <option data-tokens="Saint">Saint Martin</option>
                                                <option data-tokens="Kuakata">Kuakata</option>
                                                <option data-tokens="Sajeq">Sajeq</option>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Codigo Postal<em>*</em></label>
                                            <input type="text" name="zipcode" class="info" placeholder="Zip Code">
                                        </div>
                                    </div>
                                    <div class="col-md-12 col-sm-12 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Direccion <em>*</em></label>
                                            <input type="text" name="add1" class="info mb-10" placeholder="Street Address">
                                            <input type="text" name="add2" class="info mt10" placeholder="Apartment, suite, unit etc. (optional)">
                                        </div>
                                    </div>
                                    <div class="col-xs-12 text-right">
                                        <a class="btn-def btn2" href="#">Guardar</a>
                                    </div>
                                </div>
                                <div role="tabpanel" class="tab-pane fade in" id="design">
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Nombre<em>*</em></label>
                                            <input type="text" name="namm" class="info" placeholder="First Name">
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Apellido Paterno<em>*</em></label>
                                            <input type="text" name="namm" class="info" placeholder="Last Name">
                                        </div>
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Correo Electronico<em>*</em></label>
                                            <input type="email" name="email" class="info" placeholder="Your Email">
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Numero de Telefono<em>*</em></label>
                                            <input type="text" name="phone" class="info" placeholder="Phone Number">
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Pais <em>*</em></label>
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
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Ciudad<em>*</em></label>
                                            <input type="text" name="add1" class="info" placeholder="Town/City">
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Estado<em>*</em></label>
                                            <select class="selectpicker select-custom" data-live-search="true">
                                                <option data-tokens="Barisal">Barisal</option>
                                                <option data-tokens="Dhaka">Dhaka</option>
                                                <option data-tokens="Kulna">Kulna</option>
                                                <option data-tokens="Rajshahi">Rajshahi</option>
                                                <option data-tokens="Sylet">Sylet</option>
                                                <option data-tokens="Chittagong">Chittagong</option>
                                                <option data-tokens="Rangpur">Rangpur</option>
                                                <option data-tokens="Maymanshing">Maymanshing</option>
                                                <option data-tokens="Cox">Cox's Bazar</option>
                                                <option data-tokens="Saint">Saint Martin</option>
                                                <option data-tokens="Kuakata">Kuakata</option>
                                                <option data-tokens="Sajeq">Sajeq</option>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Codigo Postal<em>*</em></label>
                                            <input type="text" name="zipcode" class="info" placeholder="Zip Code">
                                        </div>
                                    </div>
                                    <div class="col-md-12 col-sm-12 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Direccion<em>*</em></label>
                                            <input type="text" name="add1" class="info mb-10" placeholder="Street Address">
                                            <input type="text" name="add2" class="info mt10" placeholder="Apartment, suite, unit etc. (optional)">
                                        </div>
                                    </div>
                                    <div class="col-xs-12 text-right">
                                        <a class="btn-def btn2" href="#">Guardar</a>
                                    </div>
                                </div>                                
                                <div role="tabpanel" class="tab-pane fade in" id="devlopment">
                                    <form action="#" method="post">
                                        <div class="table-responsive">
                                            <table class="checkout-area table text-center">
                                                <thead>
                                                    <tr class="cart_item check-heading">
                                                        <td class="ctg-type">Folio</td>                                                        
                                                        <td class="cgt-des">Fecha Venta</td>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <%foreach(var item1 in _listaPedido.ListaVentaDetalle) {%>
                                                    <tr class="cart_item check-item prd-name">
                                                        <%Response.Write("<td class='ctg-type'><a href='frmDetallePedidos.aspx?op=2&id="+item1.IdCarritoDetalle+"'style='color:black'>" + item1.Folio + "</a></td>"); %>
                                                        <td class="ctg-type"><%=item1.FechaVenta.ToShortDateString()%></td>
                                                    </tr>
                                                    <%} %>
                                                </tbody>
                                            </table>
                                        </div>
                                        <div class="text-right">
                                            <a class="btn-def btn2" href="#">Save</a>
                                        </div>
                                    </form>
                                </div>
                                
                                <div role="tabpanel" class="tab-pane fade in" id="markenting">
                                    <div class="col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Tipo de Pago<em>*</em></label>
                                            <select class="selectpicker select-custom" data-live-search="true">
                                                <option data-tokens="paypal">Paypal</option>
                                                <option data-tokens="visa">visa</option>
                                                <option data-tokens="master-card">master-card</option>
                                                <option data-tokens="discover">discover</option>
                                                <option data-tokens="payneor">payneor</option>
                                                <option data-tokens="skrill">skrill</option>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Numero de Tarjeta<em>*</em></label>
                                            <input type="text" name="email" class="info" placeholder="Card Number">
                                        </div>
                                    </div>
                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Codigo de Seguridad<em>*</em></label>
                                            <input type="text" name="phone" class="info" placeholder="Security Code">
                                        </div>
                                    </div>


                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Mes <em>*</em></label>
                                            <select class="selectpicker select-custom" data-live-search="true">
                                                <option data-tokens="Januray">Januray</option>
                                                <option data-tokens="February">February</option>
                                                <option data-tokens="March">March</option>
                                                <option data-tokens="April">April</option>
                                                <option data-tokens="May">May</option>
                                                <option data-tokens="June">June</option>
                                                <option data-tokens="July">July</option>
                                                <option data-tokens="August">August</option>
                                                <option data-tokens="September">September</option>
                                                <option data-tokens="Ocotober">Ocotober</option>
                                                <option data-tokens="November">November</option>
                                                <option data-tokens="December">December</option>
                                            </select>
                                        </div>
                                    </div>

                                    <div class="col-md-6 col-sm-6 col-xs-12">
                                        <div class="input-box mb-20">
                                            <label>Año<em>*</em></label>
                                            <select class="selectpicker select-custom" data-live-search="true">
                                                <option data-tokens="2016">2016</option>
                                                <option data-tokens="2017">2017</option>
                                                <option data-tokens="2018">2018</option>
                                                <option data-tokens="2019">2019</option>
                                                <option data-tokens="2020">2020</option>
                                                <option data-tokens="2021">2021</option>
                                                <option data-tokens="2022">2022</option>
                                                <option data-tokens="2023">2023</option>
                                                <option data-tokens="2024">2024</option>
                                                <option data-tokens="2025">2025</option>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="payment-btn-area mt-20">
                                        <div class="col-md-4 col-sm-4 col-xs-12 text-left">
                                            <a class="btn-def btn2" href="#">Pagar Ahora</a>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12 text-center">
                                            <a class="btn-def btn2" href="#">Cancelar Orden</a>
                                        </div>
                                        <div class="col-md-4 col-sm-4 col-xs-12 text-right">
                                            <a class="btn-def btn2" href="#">Continuar</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </asp:Content>