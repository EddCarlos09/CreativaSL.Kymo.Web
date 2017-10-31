<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmProducto.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmProducto" %>

<asp:Content ContentPlaceHolderID="cphPrincipal" runat="server">
<!--breadcumb area start -->
         <%  var imgTitle = _dataProduct.ListaImagenes.Find(x => x.NumPosition == 1);
            if (imgTitle == null)
            {
        %>
            <div class="breadcumb-area breadcumb overlay pos-rltv" style="background:rgba(0, 0, 0, 0) url('../assets/images/bg/breadcumb.jpg') no-repeat scroll 0 0;">
        <%}
        else
        {
            Response.Write("<div class='breadcumb-area breadcumb overlay pos-rltv' style='background:rgba(0, 0, 0, 0) url(" + imgTitle.UrlImagen + ") no-repeat scroll 0 0;'>");
        }%>
            <div class="bread-main">
                <div class="bred-hading text-center">
                    <%
                        var _dataTitle = _dataProduct.ListaTextos.Find(x => x.NumPosition == 1);
                        if(_dataTitle != null)
                        {
                            Response.Write("<h5>" + _dataTitle.Texto + "</h5>");
                        }
                    %>
                </div>
                <ol class="breadcrumb">
                    <li class="home"><a title="Go to Home Page" href="/Home">Home</a></li>
                    <li class="active">Detalle</li>
                </ol>
            </div>
        </div>
        <!--breadcumb area end -->
        
        <!--single-protfolio-area are start-->
        <div class="single-protfolio-area ptb-70">
            <div class="container">
                <div class="row">
                    <div class="col-md-7 col-sm-12 col-xs-12">
                       <div class="portfolio-thumbnil-area">
                            <div class="product-more-views">
                                <div class="tab_thumbnail" data-tabs="tabs">
                                    <div class="thumbnail-carousel">
                                        <ul>
                                            <% int _aux = 1;
                                                foreach (var item in _dataProduct.Producto.ListaImagenesThumb)
                                                {
                                                    if (_aux == 1)
                                                        Response.Write("<li class='active'><a href='#view" + _aux + "' class='shadow-box' aria-controls='view" + _aux + "' data-toggle='tab'><img src='" + item.UrlImagen + "' alt='" + item.Alt + "' title='" + item.Title + "' /></a></li>");
                                                    else
                                                        Response.Write("<li><a href='#view" + _aux + "' class='shadow-box' aria-controls='view" + _aux + "' data-toggle='tab'><img src='" + item.UrlImagen + "' alt='" + item.Alt + "' title='" + item.Title + "' /></a></li>");
                                                    _aux++;
                                                } %>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                            <div class="tab-content active-portfolio-area pos-rltv">
                               <div class="social-tag">
                                  <a href="#"><i class="zmdi zmdi-share"></i></a>
                               </div>
                                <% _aux = 1;
                                    foreach (var item in _dataProduct.Producto.ListaImagenes)
                                    {
                                        if (_aux == 1)
                                            Response.Write("<div role='tabpanel' class='tab-pane active' id='view" + _aux + "'><div class='product-img'><a class='fancybox' data-fancybox-group='group' href='" +item.UrlImagen + "'><img src='" + item.UrlImagen + "' alt='" + item.Alt + "' title='" + item.Title + "' /></a></div></div>");
                                        else
                                            Response.Write("<div role='tabpanel' class='tab-pane' id='view" + _aux + "'><div class='product-img'><a class='fancybox' data-fancybox-group='group' href='" +item.UrlImagen + "'><img src='" + item.UrlImagen + "' alt='" + item.Alt + "' title='" + item.Title + "' /></a></div></div>");
                                        _aux++;
                                    } %>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-5 col-sm-12 col-xs-12">
                        <div class="single-product-description">
                            <div class="sp-top-des">
                                    <h3><% =_dataProduct.Producto.NombreProducto %> <span><% %></span></h3>
                                    <div class="prodcut-ratting-price">
                                        <div class="prodcut-ratting"> 
                                            <%for (int i = 1; i <= 5; i++)
                                            {
                                                if (i <= _dataProduct.Producto.Valoracion)
                                                    Response.Write("<a href='javascript:;' tabindex='0'><i class='fa fa-star'></i></a>");
                                                else
                                                    Response.Write("<a href='javascript:;' tabindex='0'><i class='fa fa-star-o'></i></a>");
                                            }
                                           %>
                                        </div>
                                        <div class="prodcut-price">
                                            <div class="new-price">
                                            <% System.Globalization.CultureInfo esMX = new System.Globalization.CultureInfo("es-MX");
                                                Response.Write(string.Format(esMX,"Desde {0:c}", _dataProduct.Producto.MinPrecio));
                                            %> 
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            <div class="sp-des">
                                <p><%=_dataProduct.Producto.Observaciones %></p>
                            </div>
                            <div class="sp-bottom-des">
                            <% if (_dataProduct.Producto.EsRopa)
                                     { %>
                                <div class="single-product-option">
                                    <div class="sort product-type">
                                        <label>Color: </label>
                                        <select id="input-sort-color">
                                            <option value="0" selected>Seleccione</option>
                                            <% foreach (var itemColor in _dataProduct.Producto.ListaColores)
                                             {
                                                 Response.Write("<option value='" + itemColor.IdColor + "'>" + itemColor.Descripcion + "</option>");
                                             } %>
                                        </select>
                                        <div><span class="errorColor" id="errorColor" style="display: block; width: 271px;"></span></div>
                                    </div>
                                    <div class="sort product-type">
                                        <label>Talla: </label>
                                        <select id="input-sort-size">
                                            <option value="0" selected="">Seleccione</option>
                                        </select>
                                        <div> <span class="errorTalla" id="errorTalla" style="display: block; width: 271px;"></span></div>
                                    </div>
                                </div>
                                <% } %>
                                <div class="quantity-area">
                                    <label>Qty :</label>
                                    <div class="cart-quantity">
                                        <form action="#" method="POST" id="myform">
                                            <div class="product-qty">
                                                <div class="cart-quantity">
                                                    <div class="cart-plus-minus">
                                                        <div id="decProd" class="dec qtybutton">-</div>
                                                        <input type="text" value="1" data-ropa="<%=_dataProduct.Producto.EsRopa %>" name="qtybutton" id="qtybutton" class="cart-plus-minus-box" data-max="5" data-min="1">
                                                        <div id="incProd" class="inc qtybutton">+</div>
                                                    </div>
                                                </div>
                                                <div><span class="ErrorMin" id="ErrorMin" style="display: block;"></span></div>
                                            </div>
                                        </form>
                                    </div>
                                </div>
                                <div class="social-icon socile-icon-style-1">
                                    <div class="buy-button-error-messages">
                                        <span class="buy-button-error-message" data-error-code="item.max.quantity.overflow">No es posible agregar más productos, has llegado al límite permitido</span>
                                        <span class="buy-button-error-message" data-error-code="cart.items.max.quantity.overflow">No es posible agregar más productos, has llegado al límite permitido</span>
                                        <span class="buy-button-error-message" data-error-code="cart.max.quantity.overflow">No es posible agregar más productos, has llegado al límite permitido</span>
                                        <span id="default-error" class="buy-button-error-message" data-error-code="product.buy.server.error">Se ha producido un error, vuelva a intentarlo más tarde</span>
                                    </div>
                                    <ul>                                    
                                        <li><a href="#" id="addCart" data-tooltip="Add To Cart" data-ropa="<%=_dataProduct.Producto.EsRopa %>" data-sku="<%=_dataProduct.Producto.IdProducto %>" class="add-cart add-cart-text" data-placement="left" tabindex="0">Add To Cart<i class="fa fa-cart-plus"></i></a></li>
                                    </ul>
                                </div>
                                <div><span class="ErrorAddCart" id="ErrorAddCart" style="display: block;"></span></div>
                            </div>

                        </div>
                    </div>
                </div>  
            </div>
        </div>
        <!--single-protfolio-area are start-->
        
        <!--new arrival area start-->
        <div class="new-arrival-area ptb-70">
            <div class="container">
                <div class="row">
                   <div class="col-xs-12 text-center">
                       <div class="heading-title heading-style pos-rltv mb-50 text-center">
                           <h5 class="uppercase">Productos relacionados</h5>
                       </div>
                   </div>
                   <div class="clearfix"></div>
                    <div class="total-new-arrival new-arrival-slider-active carsoule-btn">                           
                        <%foreach (var itemProdRel in _dataProduct.Producto.ListaProductosRelacionados)
                            { %>
                            <div class="col-md-3">
                                <!-- single product start-->
                                <div class="single-product">
                                    <div class="product-img">
                                        <div class="product-label">
                                        </div>
                                        <div class="single-prodcut-img  product-overlay pos-rltv">
                                            <a href="/Product/<%=itemProdRel.IdProducto%>"> <img alt="<%=itemProdRel.ImagenPrincipal.Alt%>" src="<%=itemProdRel.ImagenPrincipal.UrlImagen%>" class="primary-image"> <img alt="<%=itemProdRel.ImagenPrincipal.Alt%>" src="<%=itemProdRel.ImagenPrincipal.UrlImagen %>" class="secondary-image"> </a>
                                        </div>
                                        <div class="product-icon socile-icon-tooltip text-center">
                                            <%--<ul>
                                                <li><a href="#" data-tooltip="Add To Cart" class="add-cart" data-placement="left"><i class="fa fa-cart-plus"></i></a></li>
                                                <li><a href="#" data-tooltip="Wishlist" class="w-list"><i class="fa fa-heart-o"></i></a></li>
                                                <li><a href="#" data-tooltip="Compare" class="cpare"><i class="fa fa-refresh"></i></a></li>
                                                <li><a href="#" data-tooltip="Quick View" class="q-view" data-toggle="modal" data-target=".modal"><i class="fa fa-eye"></i></a></li>
                                            </ul>--%>
                                        </div>
                                    </div>
                                    <div class="product-text">
                                        <div class="prodcut-name"> <a href="/Product/<%=itemProdRel.IdProducto %>"><%=itemProdRel.NombreProducto%></a> </div>
                                        <div class="prodcut-ratting-price">
                                            <div class="prodcut-price">
                                                <div class="new-price"><%=itemProdRel.MinPrecio %></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <!-- single product end-->
                            </div>
                        <%} %>
                    </div>
                </div>
            </div>
        </div>
    
</asp:Content>

<asp:Content ContentPlaceHolderID="cphScripts" runat="server">
    <script src="../assets/js/carritoAddItem.js"></script>
    <script src="../assets/js/cargarTallas.js"></script>
    <script>
        jQuery(document).ready(function () {
            Carrito.init();
            Tallas.init();
        });
    </script>
</asp:Content>