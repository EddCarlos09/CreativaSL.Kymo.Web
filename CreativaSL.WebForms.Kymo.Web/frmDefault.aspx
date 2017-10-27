<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmDefault.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmDefault" %>

<asp:Content runat="server" ContentPlaceHolderID="cphPrincipal">

    <!--slider area start-->
        <div class="slider-area pos-rltv carosule-pagi cp-line">
            <div class="active-slider">
                <%foreach (var item in _ListaBanner)
                    {%>
                        <div class="single-slider pos-rltv">
                            <div class="slider-img">
                                <%--<img src="assets/images/slider/slider02.jpg" alt="<%=item.Alt%>" title="<%=item.Title%>"">--%>
                                <img src="<%=item.UrlImagen%>" alt="<%=item.Alt%>" title="<%=item.Title%>"">
                            </div>
                            <div class="slider-content pos-abs">
                                <h4><%=item.TextoInicial%></h4>
                                <h1 class="uppercase pos-rltv underline"><%=item.TextoPrincipal%></h1>
                                <%if (item.Comprar == true)
                                    { %>
                                        <a href="<%=item.UrlDestino%>" class="btn-def btn-white" target="_blank"><%=item.TextoButton%></a>
                                <%} %>
                            </div>
                        </div>
                    <%} %>
            </div>
        </div>
        <!--slider area start-->
        
        <!--delivery service start-->
        <div class="delivery-service-area ptb-30">
            <div class="container">
                <div class="row">
                    <div class="col-md-3 col-sm-6 col-xs-12">
                        <div class="single-service shadow-box text-center">
                            <img src="assets/images/icons/garantee.png" alt="">
                            <h5>Precios Accesibles</h5>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 col-xs-12">
                        <div class="single-service shadow-box text-center">
                            <img src="assets/images/icons/coupon.png" alt="">
                            <h5>Cupones de descuento</h5>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 col-xs-12">
                        <div class="single-service shadow-box text-center">
                            <img src="assets/images/icons/delivery.png" alt="">
                            <h5>Envio</h5>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-6 col-xs-12">
                        <div class="single-service shadow-box text-center">
                            <img src="assets/images/icons/support.png" alt="">
                            <h5>Soporte en compras</h5>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--delivery service start-->
        
        <!--branding-section-area start-->
        <div class="branding-section-area">
            <div class="container">
                <div class="row">
                    <div class="active-slider pos-rltv carosule-pagi cp-line pagi-02">
                        <div class="single-slider">
                            <div class="col-lg-7 col-md-6 col-sm-6 col-xs-12"> 
                                <div class="brand-img text-center">
                                    <img src="assets/images/team/branding1.png" alt=""> 
                                </div>
                            </div>
                            <div class="col-lg-5 col-md-6 col-sm-6 col-xs-12">
                                <div class="brand-content ptb-55">
                                    <div class="brand-text color-lightgrey">
                                        <h6>Este invierno</h6>
                                        <h2 class="uppercase montserrat">Brand Cortta</h2>
                                        <h3 class="montserrat">$200.00</h3>
                                        <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
                                        <div class="social-icon-wraper mt-35">
                                            <div class="social-icon">
                                                <ul>
                                                    <li><a href="#"><i class="zmdi zmdi-shopping-cart"></i></a></li>
                                                    <!-- <li><a href="#"><i class="zmdi zmdi-favorite-outline"></i></a></li> -->
                                                    <li><a href="#" data-tooltip="Quick View" class="q-view" data-toggle="modal" data-target=".modal" tabindex="0"><i class="zmdi zmdi-eye"></i></a></li>
                                                    <li><a href="#"><i class="zmdi zmdi-repeat"></i></a></li>

                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="brand-timer shadow-box-2 mt-50">
                                        <div class="timer-wraper text-center">
                                            <div class="timer">
                                                <div data-countdown="2015/02/01"></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="single-slider">
                            <div class="col-lg-7 col-md-6 col-sm-6 col-xs-12"> 
                                <div class="brand-img text-center">
                                    <img src="assets/images/team/branding2.png" alt=""> 
                                </div>
                            </div>
                            <div class="col-lg-5 col-md-6 col-sm-6 col-xs-12">
                                <div class="brand-content ptb-55">
                                    <div class="brand-text color-lightgrey">
                                        <h6>Deportes</h6>
                                        <h2 class="uppercase montserrat">Brand Cortta</h2>
                                        <h3 class="montserrat">$200.00</h3>
                                        <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
                                        <div class="social-icon-wraper mt-35">
                                            <div class="social-icon">
                                                <ul>
                                                    <li><a href="#"><i class="zmdi zmdi-shopping-cart"></i></a></li>
                                                    <!-- <li><a href="#"><i class="zmdi zmdi-favorite-outline"></i></a></li> -->
                                                    <li><a href="#" data-tooltip="Quick View" class="q-view" data-toggle="modal" data-target=".modal" tabindex="0"><i class="zmdi zmdi-eye"></i></a></li>
                                                    <li><a href="#"><i class="zmdi zmdi-repeat"></i></a></li>

                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="brand-timer shadow-box-2 mt-50">
                                        <div class="timer-wraper text-center">
                                            <div class="timer">
                                                <div data-countdown="2017/02/01"></div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="single-slider">
                            <div class="col-lg-7 col-md-6 col-sm-6 col-xs-12"> 
                                <div class="brand-img text-center">
                                    <img src="assets/images/team/branding3.png" alt=""> 
                                </div>
                            </div>
                            <div class="col-lg-5 col-md-6 col-sm-6 col-xs-12">
                                <div class="brand-content ptb-55">
                                    <div class="brand-text color-lightgrey">
                                        <h6>Inicio de Clases</h6>
                                        <h2 class="uppercase montserrat">Brand Cortta</h2>
                                        <h3 class="montserrat">$200.00</h3>
                                        <p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</p>
                                        <div class="social-icon-wraper mt-35">
                                            <div class="social-icon">
                                                <ul>
                                                    <li><a href="#"><i class="zmdi zmdi-shopping-cart"></i></a></li>
                                                    <!-- <li><a href="#"><i class="zmdi zmdi-favorite-outline"></i></a></li> -->
                                                    <li><a href="#" data-tooltip="Quick View" class="q-view" data-toggle="modal" data-target=".modal" tabindex="0"><i class="zmdi zmdi-eye"></i></a></li>
                                                    <li><a href="#"><i class="zmdi zmdi-repeat"></i></a></li>

                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="brand-timer shadow-box-2 mt-50">
                                        <div class="timer-wraper text-center">
                                            <div class="timer">
                                                <div data-countdown="2019/02/01"></div>
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
        <!--branding-section-area end-->
        
        <!--new arrival area start-->
        <div class="new-arrival-area pt-70">
            <div class="container">
                <div class="row">
                   <div class="col-xs-12 text-center">
                       <div class="heading-title heading-style pos-rltv mb-50 text-center">
                           <h5 class="uppercase">Productos</h5>
                       </div>
                   </div>
                   <div class="clearfix"></div>
                    <div class="total-new-arrival new-arrival-slider-active carsoule-btn">                           
                        <div class="col-md-3">
                            <!-- single product start-->
                            <div class="single-product">
                                <div class="product-img">
                                    <div class="product-label">
                                        <div class="new">Nuevo</div>
                                    </div>
                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                        <a href="single-product.html"> <img alt="" src="assets/images/product/01.jpg" class="primary-image"> <img alt="" src="assets/images/product/02.jpg" class="secondary-image"> </a>
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
                                    <div class="prodcut-name"> <a href="/Product/ID0001">Quisque fringilla</a> </div>
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
                                        <a href="single-product.html"> <img alt="" src="assets/images/product/03.jpg" class="primary-image"> <img alt="" src="assets/images/product/04.jpg" class="secondary-image"> </a>
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
                                        <div class="new">Oferta</div>
                                    </div>
                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                        <a href="single-product.html"> <img alt="" src="assets/images/product/02.jpg" class="primary-image"> <img alt="" src="assets/images/product/03.jpg" class="secondary-image"> </a>
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
                                        <a href="single-product.html"> <img alt="" src="assets/images/product/04.jpg" class="primary-image"> <img alt="" src="assets/images/product/03.jpg" class="secondary-image"> </a>
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
                                        <a href="single-product.html"> <img alt="" src="assets/images/product/05.jpg" class="primary-image"> <img alt="" src="assets/images/product/06.jpg" class="secondary-image"> </a>
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
        
       
        
        <!--discunt-featured-onsale-area start -->
        <div class="discunt-featured-onsale-area pt-60">
            <div class="container">
                <div class="row">
                    <div class="product-area tab-cars-style">
                        <div class="title-tab-product-category">
                            <div class="col-md-12 text-center">
                                <ul class="nav mb-40 heading-style-2" role="tablist">
                                    <li role="presentation" class="active"><a href="#newarrival" aria-controls="newarrival" role="tab" data-toggle="tab">Nuevos productos</a></li>
                                    <li role="presentation"><a href="#bestsellr" aria-controls="bestsellr" role="tab" data-toggle="tab">Más vendidos</a></li>
                                    <li role="presentation"><a href="#specialoffer" aria-controls="specialoffer" role="tab" data-toggle="tab">Promociones</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="clearfix"></div>
                        <div class="content-tab-product-category">
                            <!-- Tab panes -->
                            <div class="tab-content">
                                <div role="tabpanel" class="tab-pane fade in active" id="newarrival">
                                    <div class="total-new-arrival new-arrival-slider-active carsoule-btn">                           
                                        <div class="col-md-3">
                                            <!-- single product start-->
                                            <div class="single-product">
                                                <div class="product-img">
                                                    <div class="product-label">
                                                        <div class="new">Nuevo</div>
                                                    </div>
                                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/01.jpg" class="primary-image"> <img alt="" src="assets/images/product/02.jpg" class="secondary-image"> </a>
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
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/03.jpg" class="primary-image"> <img alt="" src="assets/images/product/04.jpg" class="secondary-image"> </a>
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
                                                        <div class="new">Nuevo</div>
                                                    </div>
                                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/02.jpg" class="primary-image"> <img alt="" src="assets/images/product/03.jpg" class="secondary-image"> </a>
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
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/04.jpg" class="primary-image"> <img alt="" src="assets/images/product/03.jpg" class="secondary-image"> </a>
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
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/05.jpg" class="primary-image"> <img alt="" src="assets/images/product/06.jpg" class="secondary-image"> </a>
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
                                <div role="tabpanel" class="tab-pane  fade in" id="bestsellr">
                                    <div class="total-new-arrival new-arrival-slider-active carsoule-btn">                           
                                        <div class="col-md-3">
                                            <!-- single product start-->
                                            <div class="single-product">
                                                <div class="product-img">
                                                    <div class="product-label">
                                                        <div class="new">Oferta</div>
                                                    </div>
                                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/01.jpg" class="primary-image"> <img alt="" src="assets/images/product/02.jpg" class="secondary-image"> </a>
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
                                                        <div class="new">Oferta</div>
                                                    </div>
                                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/02.jpg" class="primary-image"> <img alt="" src="assets/images/product/03.jpg" class="secondary-image"> </a>
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
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/04.jpg" class="primary-image"> <img alt="" src="assets/images/product/03.jpg" class="secondary-image"> </a>
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
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/03.jpg" class="primary-image"> <img alt="" src="assets/images/product/04.jpg" class="secondary-image"> </a>
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
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/05.jpg" class="primary-image"> <img alt="" src="assets/images/product/06.jpg" class="secondary-image"> </a>
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
                                <div role="tabpanel" class="tab-pane  fade in" id="specialoffer">
                                    <div class="total-new-arrival new-arrival-slider-active carsoule-btn"> 
                                        <div class="col-md-3">
                                            <!-- single product start-->
                                            <div class="single-product">
                                                <div class="product-img">
                                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/04.jpg" class="primary-image"> <img alt="" src="assets/images/product/03.jpg" class="secondary-image"> </a>
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
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/05.jpg" class="primary-image"> <img alt="" src="assets/images/product/06.jpg" class="secondary-image"> </a>
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
                                        <div class="col-md-3">
                                            <!-- single product start-->
                                            <div class="single-product">
                                                <div class="product-img">
                                                    <div class="product-label">
                                                        <div class="new">Oferta</div>
                                                    </div>
                                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/01.jpg" class="primary-image"> <img alt="" src="assets/images/product/02.jpg" class="secondary-image"> </a>
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
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/03.jpg" class="primary-image"> <img alt="" src="assets/images/product/04.jpg" class="secondary-image"> </a>
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
                                                        <div class="new">Oferta</div>
                                                    </div>
                                                    <div class="single-prodcut-img  product-overlay pos-rltv">
                                                        <a href="single-product.html"> <img alt="" src="assets/images/product/02.jpg" class="primary-image"> <img alt="" src="assets/images/product/03.jpg" class="secondary-image"> </a>
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
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>    
        <!--discunt-featured-onsale-area end-->  
        
        <!--testimonial-area-start-->
       <%  var imgTitle = _ListaImagenes.Find(x => x.NumPosition == 1);
            if (imgTitle == null)
            {
        %>
            <div class="testimonial-area overlay ptb-70 mt-70" style="background: rgba(0, 0, 0, 0) url('../images/bg/testimonial.jpg') no-repeat fixed 0 0 / cover;">
        <%}
        else
        {
            Response.Write("<div class='testimonial-area overlay ptb-70 mt-70' style='background:rgba(0, 0, 0, 0) url(" + imgTitle.UrlImagen + ") no-repeat fixed 0 0 / cover;'>");
        }%>
             <div class="container">
                 <div class="row">
                    <div class="col-xs-12 text-center">
                        <div class="heading-title color-lightgrey mb-40 text-center">
                            <h5 id="Gracias" class="uppercase">Testimoniales</h5> 
                        </div>
                    </div>
                     <div class="col-xs-12">
                         <div class="total-testimonial active-slider carosule-pagi pagi-03">
                             <%foreach (var itemTes in _ListaTestimoniales)
                                 {%>
                             <div class="single-testimonial">
                                 <div class="testimonial-content color-lightgrey">
                                     <div class="name-degi pos-rltv">
                                         <h5><%=itemTes.NombreCompleto%></h5>
                                         <p></p>
                                     </div>
                                     <div class="testi-text">
                                         <p><%=itemTes.Comentario%></p>
                                     </div>
                                 </div>
                             </div>
                             <%} %>
                         </div>
                          <a href="#" class="btn btn-primary" title="" style="background: #333;" data-toggle="modal" data-target="#exampleModal">Comentanos</a>
                     </div>
                 </div>
             </div>
         </div>        
        <!--testimonial-area-end-->
        
       <!-- Modal -->
<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true" style="top: 100px;">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header" style="background: #abcd40;">
        <h5 class="modal-title text-center" id="exampleModalLabel" style="color: white; width: 50%;margin-left: 25%;">Comentanos</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close" style="margin-top: -25px;">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <form id="IDKYMO" method="post" accept-charset="utf-8">
      <div class="modal-body">
       
          <div class="form-group input-box mb-20 ">
              <label>Nombre</label>
              <input id="Nombre"type="text" name="Nombre" value="" >
              
          </div>
          <div class="form-group ">
              <label>Comentario</label>
              <textarea name="Comentario" id="Comentario" cols="60"></textarea>
          </div>
          <p id="Error"></p>
      </div>
      <div class="modal-footer" style="background: #abcd40;">
        <button type="button" class="btn btn-secondary" data-dismiss="modal" style="color: black;">Close</button>
        <button id="IDBTNKYMO" type="submit" class="btn btn-warning current">Enviar</button>
      </div>
       </form>
    </div>
  </div>
</div>
<!--====  modal  ====-->
        
       
        
        <!--brand area are start-->
    <div class="brand-area ptb-60">
        <div class="container">
            <div class="row">
                <div class="total-brand">
                    <%foreach (var item in _ListaPatrocinadores)
                        {%>
                        <div class="col-md-3">
                            <div class="single-brand shadow-box">
                                <a href="<%=item.UrlDestino%>">
                                    <%--<img src="assets/images/brand/01.png" alt="<%=item.Alt%>" title="<%=item.Title%>">--%>
                                    <img src="<%=item.UrlImagen%>" alt="<%=item.Alt%>" title="<%=item.Title%>">
                                </a>
                            </div>
                        </div>
                    <%} %>
                </div>
            </div>
        </div>
    </div>
        <!--brand area are start-->


    
</asp:Content>

<asp:Content ContentPlaceHolderID="cphScripts" runat="server">
<script src="../assets/js/form-validation.js"></script>
    <script>
        jQuery(document).ready(function () {
            FormValidator.init(3);
        });
    </script>
    
    <script>
        
    </script>
    </asp:Content>