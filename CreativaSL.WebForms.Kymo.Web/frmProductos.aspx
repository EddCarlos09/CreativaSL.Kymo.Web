<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmProductos.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmProductos" %>

<asp:Content runat="server" ContentPlaceHolderID="cphPrincipal">

    <!--breadcumb area start -->
         <% var imgTitle = _datosBusqueda.ListaImagenes.Find(x => x.NumPosition == 1);
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
                        var _dataTitle = _datosBusqueda.ListaTextos.Find(x => x.NumPosition == 1);
                        if (_dataTitle != null)
                        {
                            Response.Write("<h5>" + _dataTitle.Texto + "</h5>");
                        }
                    %>
                </div>
                <ol class="breadcrumb">
                    <li class="home"><a title="Go to Home Page" href="/Home">Home</a></li>
                    <li class="active">Productos</li>
                </ol>
            </div>
        </div>
        <!--breadcumb area end -->
        
        <!--shop main area are start-->
        <div class="shop-main-area ptb-70">
            <div class="container">
                <div class="row">
                    <!--shop sidebar start-->
                    <div class="col-md-3 col-sm-4 col-xs-12">
                        <div class="row">
                            <div class="shop-sidebar">
                               <!--single aside start-->
                                <aside class="single-aside search-aside search-box">
                                    <form action="#">
                                        <div class="input-box">
                                            <%--<input class="single-input" placeholder="Buscar...." type="text">
                                            <button class="src-btn sb-2"><i class="fa fa-search"></i></button>--%>
                                        </div>
                                    </form>
                                 </aside>
                                <!--single aside end-->
                                
                                <!--single aside start-->
                                <aside class="single-aside catagories-aside">
                                    <div class="heading-title aside-title pos-rltv">
                                        <h5 class="uppercase">Filtro</h5> 
                                    </div>
                                    <div id="search-treeview" class="product-cat">
                                        <ul class="erase treeview">
                                            <% if (_datosBusqueda.BandFamilia)
                                                {
                                                    Response.Write("<li class='closed'>" + _datosBusqueda.Familia.Descripcion + "<div class='erase-area'><a href='#' data-sku='" + _datosBusqueda.Familia.IdFamilia  +"' data-type='CT'><i class='fa fa-times-circle'></i></a></div></li>");
                                                } %>
                                            <% if (_datosBusqueda.BandColor)
                                                {
                                                    Response.Write("<li class='closed'>Color " + _datosBusqueda.Color.Descripcion + "<div class='erase-area'><a href='#' data-sku='" + _datosBusqueda.Color.IdColor  +"' data-type='CL'><i class='fa fa-times-circle'></i></a></div></li>");
                                                } %>
                                            <% if (_datosBusqueda.BandTalla)
                                                {
                                                    Response.Write("<li class='closed'>" + _datosBusqueda.Talla.Descripcion + "<div class='erase-area'><a href='#' data-sku='" + _datosBusqueda.Talla.IdTalla  +"' data-type='TL'><i class='fa fa-times-circle'></i></a></div></li>");
                                                } %>
                                            <% if (_datosBusqueda.BandRangoPrecios)
                                                {
                                                    System.Globalization.CultureInfo esMX = new System.Globalization.CultureInfo("es-MX");
                                                    Response.Write("<li class='closed'>" + string.Format(esMX,"{0:c}", _datosBusqueda.PrecioInicial) + " - " + string.Format(esMX,"{0:c}", _datosBusqueda.PrecioFinal) + "<div class='erase-area'><a href='#' data-min='" + _datosBusqueda.PrecioInicial  +"' data-max='" + _datosBusqueda.PrecioFinal + "' data-type='RP'><i class='fa fa-times-circle'></i></a></div></li>");
                                                } %>
                                        </ul>
                                    </div>
                                </aside>
                                <!--single aside end-->

                                <!--single aside start-->
                                <%if (!_datosBusqueda.BandFamilia)
                                        { %>
                                <aside class="single-aside catagories-aside">
                                    <div class="heading-title aside-title pos-rltv">
                                        <h5 class="uppercase">Categorías</h5> 
                                    </div>
                                    <div id="cat-treeview" class="product-cat">
                                        <ul>
                                            <%foreach (var itemFam in _datosBusqueda.ListaFamilias)
                                        { %>
                                                    <li class="closed"><a href="#" class="famsearch" data-sku="<%=itemFam.IdFamilia%>"><%=itemFam.Descripcion%>(<%=itemFam.CantidadProductos %>)</a></li>
                                            <%} %>
                                        </ul>
                                    </div>
                                </aside>
                                <%} %>
                                <!--single aside end-->
                                
                                <!--single aside start-->
                                <%if (!_datosBusqueda.BandRangoPrecios)
                                    { %>
                                <aside class="single-aside price-aside fix">
                                    <div class="heading-title aside-title pos-rltv">
                                        <h5 class="uppercase">Precio</h5> 
                                    </div>
                                    <div class="price_filter"  id="rngPrice" data-max="<%=(int)_datosBusqueda.MaxPrice %>" data-min="<%=(int)_datosBusqueda.MinPrice %>">
                                        <div id="slider-range" ></div>
                                        <div class="price_slider_amount">
                                            <input type="text" id="amount" name="amount" data-minvalue="100" data-maxvalue="1000" placeholder="Add Your Price" />
                                            <input type="submit" id="btnPrice" value="Filter" /> 
                                        </div>
                                    </div>
                                </aside>
                                <%} %>
                                <!--single aside end-->
                                
                                <%if (!_datosBusqueda.BandColor)
                                        { %>
                                <!--single aside start-->
                                <aside class="single-aside color-aside">
                                    <div class="heading-title aside-title pos-rltv">
                                        <h5 class="uppercase">Color</h5> 
                                    </div>
                                    <ul class="color-filter mt-30">
                                        <%foreach (var itemColor in _datosBusqueda.ListaColor)
                                        { %>
                                            <li><a href="#" class="color-1" data-sku="<%=itemColor.IdColor%>"><%=itemColor.Descripcion %></a></li>
                                        <%} %>
                                    </ul>
                                </aside>
                                <%} %>
                                <!--single aside end-->
                                
                                <!--single aside start-->
                                <%if (!_datosBusqueda.BandTalla)
                                    { %>
                                <aside class="single-aside size-aside">
                                    <div class="heading-title aside-title pos-rltv">
                                        <h5 class="uppercase">Talla</h5> 
                                    </div>
                                    <ul class="size-filter mt-30 order">
                                        <%foreach (var itemTalla in _datosBusqueda.ListaTallas)
                                                                   { %>
                                                <li><a href="#" class="size-xl" data-sku="<%=itemTalla.IdTalla %>"><%=itemTalla.Descripcion %></a></li>
                                        <%} %>
                                    </ul>
                                </aside>
                                <%} %>
                                
                                
                                <!--single aside start-->
                                
                                <!--single aside end-->
                                
                               
                            </div>
                        </div>
                    </div>
                    <!--shop sidebar end-->
                    
                    <!--main-shop-product start-->
                    <div class="col-md-9 col-sm-8 col-xs-12">
                        <div class="shop-wraper">
                          <div class="col-xs-12">
                               <div class="shop-area-top">
                                  <div class="row">
                                       <div class="col-lg-6 col-md-9 col-sm-9 col-xs-12">
                                           <div class="">
                                               <input id="tb20ds" type="hidden" value="<%=_datosBusqueda.IdTipoBusqueda %>" />
                                           </div>
                                       <div class="sort product-show">
                                           <label>Vista</label>
                                            <select id="input-amount">
                                                <%foreach (var itemMR in _datosBusqueda.ListaCantidadRegistros)
                                                    {
                                                        Response.Write("<option value='" + itemMR + "' " + (itemMR == _datosBusqueda.MaxRows ? "selected": string.Empty) + " >" + itemMR + "</option>");

                                                    }%>
                                            </select>
                                        </div>
                                        <div class="sort product-type">
                                            <label>Ordenar por</label>
                                            <select id="input-sort">
                                                <option value="0" <%=_datosBusqueda.TipoOrden == 0 ? "selected" : string.Empty %> >Default</option>
                                                <option value="1" <%=_datosBusqueda.TipoOrden == 1 ? "selected" : string.Empty %> >Nombre (A - Z)</option>
                                                <option value="2" <%=_datosBusqueda.TipoOrden == 2 ? "selected" : string.Empty %> >Nombre (Z - A)</option>
                                                <option value="3" <%=_datosBusqueda.TipoOrden == 3 ? "selected" : string.Empty %> >Precio (Men &gt; May)</option>
                                                <option value="4" <%=_datosBusqueda.TipoOrden == 4 ? "selected" : string.Empty %> >Precio (May &gt; Men)</option>
                                            </select>
                                        </div>
                                    </div>
                                    <div class="col-lg-3 col-md-3 col-sm-3 col-xs-12">
                                        <div class="list-grid-view text-center">
                                            <%--<ul class="nav" role="tablist">
                                                <li role="presentation"  class="active"><a href="#grid" aria-controls="grid" role="tab" data-toggle="tab"><i class="zmdi zmdi-widgets"></i></a></li>
                                                <li role="presentation"><a href="#list" aria-controls="list" role="tab" data-toggle="tab"><i class="zmdi zmdi-view-list-alt"></i></a></li>
                                            </ul>--%>
                                        </div>
                                    </div>
                                       <div class="col-lg-3 hidden-md hidden-sm hidden-xs">
                                        <div class="total-showing text-right">
                                            Mostrar <span><%=_datosBusqueda.RegistroInicial%></span> a <span><%= _datosBusqueda.RegistroFinal %></span> del total <span><%=_datosBusqueda.TotalRegistros%></span>
                                        </div>
                                    </div>
                                   </div>
                               </div>
                           </div>
                       <div class="clearfix"></div>
                       <div class="shop-total-product-area clearfix mt-35">
                        <!-- Tab panes -->
                        <div class="tab-content">
                            <!--tab grid are start-->
                            <div role="tabpanel" class="tab-pane fade in active" id="grid">
                                <div class="total-shop-product-grid">
                                    <%foreach (var itemProd in _datosBusqueda.ListaProductosResultado)
                                        { %>
                                        <div class="col-md-4 col-sm-6 item">
                                        <!-- single product start-->
                                        <div class="single-product">
                                            <div class="product-img">
                                                <div class="product-label red">
                                                </div>
                                                <div class="single-prodcut-img  product-overlay pos-rltv">
                                                    <a href="/Product/<%=itemProd.IdProducto %>"> <img alt="<%=itemProd.ImagenPrincipal.Alt %>" title="<%=itemProd.ImagenPrincipal.Title %>" src="<%=itemProd.ImagenPrincipal.UrlImagen %>" class="primary-image"> <img alt="<%=itemProd.ImagenPrincipal.Alt %>" title="<%=itemProd.ImagenPrincipal.Title %>" src="<%=itemProd.ImagenPrincipal.UrlImagen %>" class="secondary-image"></a>
                                                </div>
                                                <div class="product-icon socile-icon-tooltip text-center">
                                                    <ul>
                                                        <li><a href="/Product/<%=itemProd.IdProducto %>" data-tooltip="Agregar al carrito" class="add-cart" data-placement="left"><i class="fa fa-cart-plus"></i></a></li>
                                                        <%--<li><a href="#" data-tooltip="Wishlist" class="w-list"><i class="fa fa-heart-o"></i></a></li>
                                                        <li><a href="#" data-tooltip="Compare" class="cpare"><i class="fa fa-refresh"></i></a></li>
                                                        <li><a href="#" data-tooltip="Quick View" class="q-view" data-toggle="modal" data-target=".modal"><i class="fa fa-eye"></i></a></li>--%>
                                                    </ul>
                                                </div>
                                            </div>
                                            <div class="product-text">
                                                <div class="prodcut-name"> <a href="/Product/<%=itemProd.IdProducto %>""><%=itemProd.NombreProducto %></a> </div>
                                                <div class="prodcut-ratting-price">
                                                    <div class="prodcut-ratting"> 
                                                        <%for (int i = 1; i <= 5; i++)
                                                        {
                                                            if (i <= itemProd.Valoracion)
                                                                Response.Write("<a href='javascript:;' tabindex='0'><i class='fa fa-star'></i></a>");
                                                            else
                                                                Response.Write("<a href='javascript:;' tabindex='0'><i class='fa fa-star-o'></i></a>");
                                                        }
                                                       %>                                                        
                                                    </div>
                                                    <div class="prodcut-price">
                                                        <div class="new-price"> Desde <%=itemProd.MinPrecio %> </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <!-- single product end-->
                                     </div>    
                                    <%} %>
                                </div>
                            </div>
                            <!--shop grid are end-->
                            
                            <!--pagination start-->
                            <div class="col-md-12 col-sm-12 col-xs-12">
                                <div class="pagination-btn text-center">
                                    <ul class="page-numbers" data-pages="<%=_datosBusqueda.TotalPaginas %>">
                                       <li><a href="#" class="prev page-numbers"><i class="zmdi zmdi-long-arrow-left"></i></a></li>
                                        <%for(int i= 1; i<= _datosBusqueda.TotalPaginas; i++)
                                            {
                                                if(i == _datosBusqueda.NumPagina)
                                                {
                                                    Response.Write("<li><span class='page-numbers current' id='np" + i + "'>" + i + "</span></li>");
                                                }
                                                else
                                                {
                                                    Response.Write("<li><a href='#' class='page-numbers' id='np" + i + "'>" + i + "</a></li>");
                                                }
                                            }  %>
                                        <li><a href="#" class="next page-numbers"><i class="zmdi zmdi-long-arrow-right"></i></a></li>
                                    </ul>
                                </div>
                            </div>
                            <!--pagination end-->
                            </div>
                       </div>
                    </div>
                    </div>
                    <!--main-shop-product start-->
                </div>
            </div>
        </div>
        <!--shop main area are end-->

</asp:Content>
<asp:Content ContentPlaceHolderID="cphScripts" runat="server">
    <script src="/assets/js/sliderPrice.js"></script>
    <script src="/assets/js/productos.js"></script>
    <script>
        jQuery(document).ready(function () {
            Slider.init();
            Busqueda.init();
        });
    </script>
</asp:Content>