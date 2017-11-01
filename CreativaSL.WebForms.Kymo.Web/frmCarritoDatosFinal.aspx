<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmCarritoDatosFinal.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmCarritoDatosFinal" %>

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
                                 <div role="tabpanel" class="tab-pane  fade in active" id="complete-order">
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