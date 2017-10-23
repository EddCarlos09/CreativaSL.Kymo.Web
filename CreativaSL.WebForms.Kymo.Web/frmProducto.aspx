<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmProducto.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmProducto" %>

<asp:Content runat="server" ContentPlaceHolderID="cphPrincipal">

     <!--breadcumb area start -->
         <%  var imgTitle = _dataProduct.ListaImagenes.Find(x => x.NumPosition == 1);
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
                                                    Response.Write("<li class='active'><a href='#view" + _aux + "' class='shadow-box' aria-controls='view" + _aux + "' data-toggle='tab'><img src='" + item.UrlImagen + "' alt='" + item.Alt + "' title='" + item.Title + "' /></a></li><li>");
                                                else
                                                    Response.Write("<li><a href='#view" + _aux + "' class='shadow-box' aria-controls='view" + _aux + "' data-toggle='tab'><img src='" + item.UrlImagen + "' alt='" + item.Alt + "' title='" + item.Title + "' /></a></li><li>");
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
                                        Response.Write("<div role='tabpanel' class='tab-pane active' id=view" + _aux + "'><div class='product-img'><a class='fancybox' data-fancybox-group='group' href='" +item.UrlImagen + "'><img src='" + item.UrlImagen + "' alt='" + item.Alt + "' title='" + item.Title + "' /></a></div></div>");
                                    else
                                        Response.Write("<div role='tabpanel' class='tab-pane' id=view" + _aux + "'><div class='product-img'><a class='fancybox' data-fancybox-group='group' href='" +item.UrlImagen + "'><img src='" + item.UrlImagen + "' alt='" + item.Alt + "' title='" + item.Title + "' /></a></div></div>");
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
                                                    Response.Write("<a href='#' tabindex='0'><i class='fa fa-star'></i></a>");
                                                else
                                                    Response.Write("<a href='#' tabindex='0'><i class='fa fa-star-o'></i></a>");
                                            }
                                           %>
                                    </div>
                                    <div class="prodcut-price">
                                        <div class="new-price">
                                            <% System.Globalization.CultureInfo esMX = new System.Globalization.CultureInfo("es-MX");
                                                Response.Write(string.Format(esMX,"Desde {0:c}", _dataProduct.Producto.MinPrecio));
                                            %> 
                                        </div>
                                        <%--<div class="old-price"> <del>$250</del> </div>--%>
                                    </div>
                                </div>
                            </div>
                            
                            <div class="sp-des">
                                <p><%=_dataProduct.Producto.Observaciones %></p>
                            </div>
                            <div class="sp-bottom-des">
                            <div class="single-product-option">
                                <div class="sort product-type">
                                    <label>Color: </label>
                                    <select id="input-sort-color">
                                        <option value="#">Red</option>
                                        <option value="#">Blue</option>
                                        <option value="#">Green</option>
                                        <option value="#">Purple</option>
                                        <option value="#">Yellow</option>
                                        <option value="#">Black</option>
                                        <option value="#">Grey</option>
                                        <option value="#">White</option>
                                        <option value="#" selected>Chose Your Color</option>
                                    </select>
                                </div>
                                <div class="sort product-type">
                                    <label>Size: </label>
                                    <select id="input-sort-size">
                                        <option value="#">S</option>
                                        <option value="#">M</option>
                                        <option value="#">L</option>
                                        <option value="#">XL</option>
                                        <option value="#">XXL</option>
                                        <option value="#" selected="">Chose Your Size</option>
                                    </select>
                                </div>
                            </div>
                            <div class="quantity-area">
                                <label>Qty :</label>
                                <div class="cart-quantity">
                                    <form action="#" method="POST" id="myform">
                                        <div class="product-qty">
                                            <div class="cart-quantity">
                                                <div class="cart-plus-minus">
                                                    <div class="dec qtybutton">-</div>
                                                        <input type="text" value="02" name="qtybutton" class="cart-plus-minus-box">
                                                    <div class="inc qtybutton">+</div>
                                                </div>
                                            </div>
                                        </div>
                                    </form>
                                </div>
                            </div>
                            <div class="social-icon socile-icon-style-1">
                                <ul>
                                    <li><a href="#" data-tooltip="Add To Cart" class="add-cart add-cart-text" data-placement="left" tabindex="0">Add To Cart<i class="fa fa-cart-plus"></i></a></li>
                                </ul>
                            </div>
                      </div>
                  </div>
              </div>
          </div>  
        </div>
        </div>
        <!--single-protfolio-area are start-->
        
        <!--descripton-area start -->
        <div class="descripton-area">
            <div class="container">
                <div class="row">
                    <div class="product-area tab-cars-style">
                        <div class="title-tab-product-category">
                            <div class="col-md-12 text-center">
                                <ul class="nav mb-40 heading-style-2" role="tablist">
                                    <li role="presentation"><a href="#newarrival" aria-controls="newarrival" role="tab" data-toggle="tab">Description</a></li>
                                    <li role="presentation" class="active"><a href="#bestsellr" aria-controls="bestsellr" role="tab" data-toggle="tab">Review</a></li>
                                    <li role="presentation"><a href="#specialoffer" aria-controls="specialoffer" role="tab" data-toggle="tab">Tags</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                        <div class="col-sm-12">
                            <div class="content-tab-product-category">
                            <!-- Tab panes -->
                            <div class="tab-content">
                                <div role="tabpanel" class="tab-pane fix fade in" id="newarrival">
                                    <div class="review-wraper">
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim
                                            <br> veniam, quis nostrud exercitation.</p>
                                        <h5>ABOUT ME</h5>
                                        <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English</p>
                                        <h5>SIZE & FIT</h5>
                                        <ul>
                                            <li>Model wears: Style Photoliya U2980</li>
                                            <li>Model's height: 185”66</li>
                                        </ul>
                                        <h5>Overview</h5>
                                        <p>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form.</p>
                                    </div>
                                </div>
                                <div role="tabpanel" class="tab-pane fix fade in active" id="bestsellr">
                                    <div class="review-wraper">
                                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim <br> veniam, quis nostrud exercitation.</p>
                                       <h5>SIZE & FIT</h5>
                                       <ul>
                                           <li>Model wears: Style Photoliya U2980</li>
                                           <li>Model's height: 185”66</li>
                                       </ul>
                                        <h5>ABOUT ME</h5>
                                        <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English</p>
                                       <h5>Overview</h5>
                                       <p>There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable.There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form.</p>
                                    </div>
                                </div>
                                <div role="tabpanel" class="tab-pane fix fade in" id="specialoffer">
                                    <ul class="tag-filter">
                                        <li><a href="#">Fashion</a></li>
                                        <li><a href="#">Women</a></li>
                                        <li><a href="#">Winter</a></li>
                                        <li><a href="#">Street Style</a></li>
                                        <li><a href="#">Style</a></li>
                                        <li><a href="#">Shop</a></li>
                                        <li><a href="#">Collection</a></li>
                                        <li><a href="#">Spring 2016</a></li>
                                        <li><a href="#">Street Style</a></li>
                                        <li><a href="#">Style</a></li>
                                        <li><a href="#">Shop</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>    
        <!--descripton-area end--> 
        
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
                        <div class="col-md-3">
                            <!-- single product start-->
                            <div class="single-product">
                                <div class="product-img">
                                    <div class="product-label">
                                        <div class="new">New</div>
                                    </div>
                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                        <a href="single-product.html"> <img alt="" src="../assets/images/product/01.jpg" class="primary-image"> <img alt="" src="../assets/images/product/02.jpg" class="secondary-image"> </a>
                                    </div>
                                    <div class="product-icon socile-icon-tooltip text-center">
                                        <ul>
                                            <li><a href="#" data-tooltip="Add To Cart" class="add-cart" data-placement="left"><i class="fa fa-cart-plus"></i></a></li>
                                            <li><a href="#" data-tooltip="Wishlist" class="w-list"><i class="fa fa-heart-o"></i></a></li>
                                            <li><a href="#" data-tooltip="Compare" class="cpare"><i class="fa fa-refresh"></i></a></li>
                                            <li><a href="#" data-tooltip="Quick View" class="q-view" data-toggle="modal" data-target=".modal"><i class="fa fa-eye"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="product-text">
                                    <div class="prodcut-name"> <a href="single-product.html">Quisque fringilla</a> </div>
                                    <div class="prodcut-ratting-price">
                                        <div class="prodcut-price">
                                            <div class="new-price"> $220 </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- single product end-->
                        </div>                          
                        <div class="col-md-3">
                            <!-- single product start-->
                            <div class="single-product">
                                <div class="product-img">
                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                        <a href="single-product.html"> <img alt="" src="../assets/images/product/03.jpg" class="primary-image"> <img alt="" src="../assets/images/product/04.jpg" class="secondary-image"> </a>
                                    </div>
                                    <div class="product-icon socile-icon-tooltip text-center">
                                        <ul>
                                            <li><a href="#" data-tooltip="Add To Cart" class="add-cart" data-placement="left"><i class="fa fa-cart-plus"></i></a></li>
                                            <li><a href="#" data-tooltip="Wishlist" class="w-list"><i class="fa fa-heart-o"></i></a></li>
                                            <li><a href="#" data-tooltip="Compare" class="cpare"><i class="fa fa-refresh"></i></a></li>
                                            <li><a href="#" data-tooltip="Quick View" class="q-view" data-toggle="modal" data-target=".modal"><i class="fa fa-eye"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="product-text">
                                    <div class="prodcut-name"> <a href="single-product.html">Quisque fringilla</a> </div>
                                    <div class="prodcut-ratting-price">
                                        <div class="prodcut-price">
                                            <div class="new-price"> $220 </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- single product end-->
                        </div>                          
                        <div class="col-md-3">
                            <!-- single product start-->
                            <div class="single-product">
                                <div class="product-img">
                                    <div class="product-label">
                                        <div class="new">Sale</div>
                                    </div>
                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                        <a href="single-product.html"> <img alt="" src="../assets/images/product/02.jpg" class="primary-image"> <img alt="" src="../assets/images/product/03.jpg" class="secondary-image"> </a>
                                    </div>
                                    <div class="product-icon socile-icon-tooltip text-center">
                                        <ul>
                                            <li><a href="#" data-tooltip="Add To Cart" class="add-cart" data-placement="left"><i class="fa fa-cart-plus"></i></a></li>
                                            <li><a href="#" data-tooltip="Wishlist" class="w-list"><i class="fa fa-heart-o"></i></a></li>
                                            <li><a href="#" data-tooltip="Compare" class="cpare"><i class="fa fa-refresh"></i></a></li>
                                            <li><a href="#" data-tooltip="Quick View" class="q-view" data-toggle="modal" data-target=".modal"><i class="fa fa-eye"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="product-text">
                                    <div class="prodcut-name"> <a href="single-product.html">Quisque fringilla</a> </div>
                                    <div class="prodcut-ratting-price">
                                        <div class="prodcut-ratting"> 
                                            <a href="#"><i class="fa fa-star"></i></a> 
                                            <a href="#"><i class="fa fa-star"></i></a> 
                                            <a href="#"><i class="fa fa-star"></i></a> 
                                            <a href="#"><i class="fa fa-star"></i></a> 
                                            <a href="#"><i class="fa fa-star-o"></i></a> 
                                        </div>
                                        <div class="prodcut-price">
                                            <div class="new-price"> $220 </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- single product end-->
                        </div>                          
                        <div class="col-md-3">
                            <!-- single product start-->
                            <div class="single-product">
                                <div class="product-img">
                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                        <a href="single-product.html"> <img alt="" src="../assets/images/product/04.jpg" class="primary-image"> <img alt="" src="../assets/images/product/03.jpg" class="secondary-image"> </a>
                                    </div>
                                    <div class="product-icon socile-icon-tooltip text-center">
                                        <ul>
                                            <li><a href="#" data-tooltip="Add To Cart" class="add-cart" data-placement="left"><i class="fa fa-cart-plus"></i></a></li>
                                            <li><a href="#" data-tooltip="Wishlist" class="w-list"><i class="fa fa-heart-o"></i></a></li>
                                            <li><a href="#" data-tooltip="Compare" class="cpare"><i class="fa fa-refresh"></i></a></li>
                                            <li><a href="#" data-tooltip="Quick View" class="q-view" data-toggle="modal" data-target=".modal"><i class="fa fa-eye"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="product-text">
                                    <div class="prodcut-name"> <a href="single-product.html">Quisque fringilla</a> </div>
                                    <div class="prodcut-ratting-price">
                                        <div class="prodcut-price">
                                            <div class="new-price"> $220 </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- single product end-->
                        </div>                          
                        <div class="col-md-3">
                            <!-- single product start-->
                            <div class="single-product">
                                <div class="product-img">
                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                        <a href="single-product.html"> <img alt="" src="../assets/images/product/05.jpg" class="primary-image"> <img alt="" src="../assets/images/product/06.jpg" class="secondary-image"> </a>
                                    </div>
                                    <div class="product-icon socile-icon-tooltip text-center">
                                        <ul>
                                            <li><a href="#" data-tooltip="Add To Cart" class="add-cart" data-placement="left"><i class="fa fa-cart-plus"></i></a></li>
                                            <li><a href="#" data-tooltip="Wishlist" class="w-list"><i class="fa fa-heart-o"></i></a></li>
                                            <li><a href="#" data-tooltip="Compare" class="cpare"><i class="fa fa-refresh"></i></a></li>
                                            <li><a href="#" data-tooltip="Quick View" class="q-view" data-toggle="modal" data-target=".modal"><i class="fa fa-eye"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="product-text">
                                    <div class="prodcut-name"> <a href="single-product.html">Quisque fringilla</a> </div>
                                    <div class="prodcut-ratting-price">
                                        <div class="prodcut-ratting"> 
                                            <a href="#"><i class="fa fa-star"></i></a> 
                                            <a href="#"><i class="fa fa-star"></i></a> 
                                            <a href="#"><i class="fa fa-star"></i></a> 
                                            <a href="#"><i class="fa fa-star"></i></a> 
                                            <a href="#"><i class="fa fa-star-o"></i></a> </div>
                                        <div class="prodcut-price">
                                            <div class="new-price"> $220 </div>
                                            <div class="old-price"> <del>$250</del> </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <!-- single product end-->
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--new arrival area end-->

</asp:Content>