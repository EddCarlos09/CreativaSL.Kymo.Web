<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmNosotros.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmNosotros" %>

<asp:Content runat="server" ContentPlaceHolderID="cphPrincipal">

    <!--breadcumb area start -->
        <%  var imgTitle = _dataAboutUs.ListaImagenes.Find(x => x.NumPosition == 1);
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
                        var _dataTitle = _dataAboutUs.ListaTextos.Find(x => x.NumPosition == 1);
                        if(_dataTitle != null)
                        {
                            Response.Write("<h5>" + _dataTitle.Texto + "</h5>");
                        }
                    %>
                </div>
                <ol class="breadcrumb">
                    <li class="home"><a title="Go to Home Page" href="/Home">Inicio</a></li>
                    <li class="active">Nosotros</li>
                </ol>
            </div>
        </div>
        <!--breadcumb area end -->
    
        <% bool bandAux = true;
            foreach (var itemQS in _dataAboutUs.ListaSeccionA)
            {  %>    
        <!-- about-us-area start-->
        <div class="about-us-area ptb-70">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12 text-center">
                       <div class="heading-title heading-style pos-rltv mb-50 text-center">
                           <h5 class="uppercase"><%=itemQS.Titulo %></h5>
                       </div>
                   </div>
                    <%if (bandAux)
                        { %>
                   <div class="about-us-wrap">
                       <div class="col-md-6 col-sm-12 col-xs-12">
                           <div class="about-img"><img src="<%=itemQS.ImagenSeccion.UrlImagen %>" alt="<%=itemQS.ImagenSeccion.Alt %>" title="<%=itemQS.ImagenSeccion.Title %>"></div>
                       </div>
                       <div class="col-md-6 col-sm-12 col-xs-12">
                           <div class="about-des">
                               <% =itemQS.TextoHTML %>
                           </div>
                       </div>
                   </div>
                    <% }
                    else
                    { %>
                    <div class="about-us-wrap">
                       <div class="col-md-6 col-sm-12 col-xs-12">
                           <div class="about-des">
                               <% =itemQS.TextoHTML %>
                           </div>
                       </div>
                       <div class="col-md-6 col-sm-12 col-xs-12">
                           <div class="about-img"><img src="<%=itemQS.ImagenSeccion.UrlImagen %>" alt="<%=itemQS.ImagenSeccion.Alt %>" title="<%=itemQS.ImagenSeccion.Title %>"></div>
                       </div>
                   </div>
                    <% } %>
                </div>
            </div>
        </div>
        <!-- about-us-area end-->
        <% bandAux = !bandAux; } %>

    
        
        <!--choose us area start-->
        <% if (_dataAboutUs.ListaSeccionB.Count > 0) { %>
        <div class="discunt-featured-onsale-area pt-60">
            <div class="container">
                <div class="row">
                    <div class="product-area tab-cars-style">
                         <div class="col-xs-12 text-center">
                       <div class="heading-title heading-style pos-rltv mb-50 text-center">
                           <%   var _dataTitleSeccion = _dataAboutUs.ListaTextos.Find(x => x.NumPosition == 2);
                                if(_dataTitleSeccion != null)
                                {
                                    Response.Write("<h5 class='uppercase'>" + _dataTitleSeccion.Texto + "</h5>");
                                }
                            %>
                           
                       </div>
                   </div>
                        <div class="clearfix"></div>
                        <div class="content-tab-product-category">
                            <!-- Tab panes -->
                            <div class="tab-content">
                                <div role="tabpanel" class="tab-pane fade in active" id="newarrival2">
                                    <div class="total-new-arrival new-arrival-slider-active carsoule-btn"> 
                                        <% foreach (var itemSeccionB in _dataAboutUs.ListaSeccionB)
                                            { %>                          
                                                <div class="col-md-3">
                                                <div class="single-choose text-center">
                                                  <div class="choose-icon pos-rltv">
                                                   <i class="<%=itemSeccionB.CssClass %>"></i> 
                                                 </div>
                                                 <div class="choose-title">
                                                  <h5><%=itemSeccionB.Titulo %></h5>
                                                </div>
                                                <div class="choose-des">
                                                 <p><%=itemSeccionB.Texto%></p> 
                                               </div>
                                             </div>
                                        </div>
                                        <% } %>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>    
        <!--choose us area start-->
        <%} %>
       
        <%if (_dataAboutUs.ListaSeccionC.Count > 0)
            {%>
        <!--out team area start-->
        <div class="discunt-featured-onsale-area pt-60">
            <div class="container">
                <div class="row">
                    <div class="product-area tab-cars-style">
                         <div class="col-xs-12 text-center">
                        <div class="heading-title heading-style pos-rltv mb-50 text-center">
                            
                            <%   var _dataTitleSeccionC = _dataAboutUs.ListaTextos.Find(x => x.NumPosition == 3);
                                if(_dataTitleSeccionC != null)
                                {
                                    Response.Write("<h5 class='uppercase'>" + _dataTitleSeccionC.Texto + "</h5>");
                                }
                            %>
                        </div>
                   </div>
                        <div class="clearfix"></div>
                        <div class="content-tab-product-category">
                            <!-- Tab panes -->
                            <div class="tab-content">
                                <div role="tabpanel" class="tab-pane fade in active" id="newarrival">
                                    <div class="total-new-arrival new-arrival-slider-active carsoule-btn">                           
                                        <% foreach (var itemEquipo in _dataAboutUs.ListaSeccionC)
                                            { %>
                                        <div class="col-md-3">
                                                <!-- single team start-->
                                                <div class="single-product single-member">
                                                    <div class="product-img">
                                                        <div class="single-prodcut-img  product-overlay pos-rltv">
                                                            <a href="#"> <img alt="<%=itemEquipo.Fotografia.Alt %>" title="<%=itemEquipo.Fotografia.Title %>" src="<%=itemEquipo.Fotografia.UrlImagen %>"></a>
                                                        </div>
                                                        <div class="product-icon socile-icon-tooltip text-center">
                                                            <ul>
                                                                <% foreach (var itemRSEquipo in itemEquipo.ListaRedesSociales)
                                                                    {
                                                                        Response.Write("<li><a href='" + itemRSEquipo.UrlBase + itemRSEquipo.Cuenta + "' data-tooltip='" + itemRSEquipo.Nombre + "' class='cpare'><i class='" + itemRSEquipo.CssClassIcon + "'></i></a></li>");
                                                                    } %>
                                                            </ul>
                                                        </div>
                                                        <div class="member-info">
                                                            <h5><%=itemEquipo.Nombre %></h5>
                                                            <p><%=itemEquipo.Puesto %></p>
                                                        </div>
                                                    </div>
                                                </div>
                                                <!-- single team end-->
                                        </div>
                                        <% } %>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <br>  
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
            
        </div>
        <!--out team area end-->
        <% } %>
</asp:Content>