<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="frmDetallePedidos.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmDetallePedidos" %>
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
            <div role="tabpanel" class="tab-pane fade in" id="devlopment">
                                    <form action="#" method="post">
                                        <div class="table-responsive">
                                            <table class="checkout-area table text-center">
                                                <thead>
                                                    <tr class="cart_item check-heading">
                                                        <td class="ctg-type"> Folio</td>
                                                        <td class="ctg-type"> Fecha Venta</td>
                                                        <td class="ctg-type"> Producto</td>
                                                        <td class="cgt-des"> Total</td>
                                                    </tr>
                                                </thead>
                                                <%foreach(var item in PedidoDetalle.ListaVentaDetalle) {%>
                                                <tbody>
                                                    <tr class="cart_item check-item prd-name">
                                                        <td class="ctg-type"><%=item.Producto.NombreProducto %><span>  </span></td>
                                                        <td class="cgt-des"><%=item.Subtotal %></td>
                                                    </tr>
                                                    <tr class="cart_item">
                                                        <td class="ctg-type"> Subtotal</td>
                                                        <td class="cgt-des"><%=item.Subtotal %></td>
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
                                                        <td class="cgt-des prc-total"><%=item.Total %></td>
                                                    </tr>
                                                </tbody>
                                                <%} %>
                                            </table>
                                        </div>
                                        <div class="text-right">
                                            <a class="btn-def btn2" href="#">Save</a>
                                        </div>
                                    </form>
                                </div>
        </div>
</asp:Content>
