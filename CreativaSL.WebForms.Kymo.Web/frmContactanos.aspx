<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmContactanos.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmContactanos" %>

<asp:Content runat="server" ContentPlaceHolderID="cphPrincipal">

<!--breadcumb area start -->
        <%  var imgTitle = _dataContact.ListaImagenes.Find(x => x.NumPosition == 1);
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
                        var _dataTitle = _dataContact.ListaTextos.Find(x => x.NumPosition == 1);
                        if(_dataTitle != null)
                        {
                            Response.Write("<h5>" + _dataTitle.Texto + "</h5>");
                        }
                    %>
                </div>
                <ol class="breadcrumb">
                    <li class="home"><a title="Go to Home Page" href="/Home">Inicio</a></li>
                    <li class="active">Contacto</li>
                </ol>
            </div>
        </div>
        <!--breadcumb area end -->
        
        <!--map area start-->
        <div class="map-area">
            <div id="googleMap"></div>
        </div>
        <!--map area end-->
        
        <!--contact info are start-->
        <div class="contact-info ptb-70">
            <div class="container">
                <div class="row">
                    <div class="col-md-6 col-sm-6">
                       <p class="form-messege" id="form-messege"></p>
                         <div class="row" id="IDContacto">
                             <form id="contact-form" method="post">
                                  <div class="col-md-6">
                                       <div class="input-box mb-20">
                                           <input class="info" id="Nombre" name="Nombre" placeholder="Nombre completo" type="text">
                                       </div>
                                   </div>
                                  <div class="col-md-6">
                                       <div class="input-box mb-20">
                                           <input class="info" id="Correo" name="Correo"  placeholder="Correo" type="email">
                                       </div>
                                   </div>
                                  <div class="col-md-6">
                                       <div class="input-box mb-20">
                                           <input class="info" id="Telefono" name="Telefono" placeholder="Telefono" type="text">
                                       </div>
                                   </div>
                                  <div class="col-md-6">
                                       <div class="input-box mb-20">
                                           <input name="Direccion" id="Direccion" class="info" placeholder="Dirección" type="text"> 
                                       </div>
                                   </div>
                                    <div class="col-md-12">
                                        <div class="input-box mb-20">
                                            <textarea class="info" id="Mensaje" name="Mensaje" placeholder="Mensaje"></textarea>
                                        </div>
                                    </div>
                                  <div class="col-xs-12">
                                     <div class="input-box tci-box">
                                     <button class="btn-def btn2 btn-kymo" type="submit">ENVIAR</button>
                                </div>
                                      <%-- <div class="input-box">
                                           <input name="submit" class="sbumit-btn" value="Submit" type="submit"> 
                                       </div>--%>
                                   </div>
                                   
                               </form>
                         </div>
                    </div>
                    <div class="col-md-6 col-sm-6">
                        <div class="single-footer contact-us contact-us-2">
                            <div class="heading-title text-center mb-50">
                                <%
                                    var _dataTextCont = _dataContact.ListaTextos.Find(x => x.NumPosition == 2);
                                    if(_dataTextCont != null)
                                    {
                                        Response.Write("<h5 class='uppercase'>" + _dataTextCont.Texto + "</h5> ");
                                    }
                                %>
                                </div>
                            <ul class="contact-info">
                                <% if (_dataContact.Telefonos.Count > 0) { %>
                                <li>
                                    <div class="contact-icon"> <i class="zmdi zmdi-phone-paused"></i> </div>
                                    <div class="contact-text">
                                        <p>
                                            <% foreach (var itemTelefono in _dataContact.Telefonos)
                                                                            {
                                                                                Response.Write("<span>" + itemTelefono + "</span>");
                                                                            } %>
                                        </p>
                                    </div>
                                </li>
                                <% }
                                    if (_dataContact.Correos.Count > 0)
                                    {%>
                                <li>
                                    <div class="contact-icon"> <i class="zmdi zmdi-email-open"></i> </div>
                                    <div class="contact-text">
                                        <p>
                                            <% foreach (var itemCorreo in _dataContact.Correos)
                                        {
                                            Response.Write("<span>" + itemCorreo + "</span>");
                                        } %>
                                        </p>
                                    </div>
                                </li>
                                <% }
                                    if (!string.IsNullOrEmpty(_dataContact.Direccion)) {%>
                                <li>
                                    <div class="contact-icon"> <i class="zmdi zmdi-pin-drop"></i> </div>
                                    <div class="contact-text">
                                        <p>
                                            <% Response.Write("<span>" + _dataContact.Direccion + "</span> "); %>
                                        </p>
                                    </div>
                                </li>
                                <% } %>
                            </ul>
                            <div class="social-icon-wraper mt-25">
                                <div class="social-icon socile-icon-style-1">
                                    <ul>
                                        <%
                                            foreach(var item in _dataContact.ListaRedesSociales)
                                            {
                                                Response.Write("<li><a href='" + item.UrlBase + item.Cuenta + "'><i class='" + item.CssClassIcon + "'></i></a></li>");
                                            }
                                        %>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="col-xs-12">
                       <div class="pos-rltv">
                            <div class="contact-des">
                                <%
                                    var _dataText = _dataContact.ListaTextos.Find(x => x.NumPosition == 3);
                                    if(_dataText != null)
                                    {
                                        Response.Write("<p>" + _dataText.Texto + "</p>");
                                    }
                                %>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!--contact info are end-->
</asp:Content>

<asp:Content ContentPlaceHolderID="cphScripts" runat="server">
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyA-IIoucJ-70FQg6xZsORjQCUPHCVj9GV4"></script>
    <%--<script src="../assets/js/google-map.js"></script>--%>
    <script>
    function initialize() {
                    var mapOptions = {
                        zoom: 14,
                        scrollwheel: false,
                        //center: new google.maps.LatLng( 23.8103,90.4125),
                        <%Response.Write("center: new google.maps.LatLng(" + _dataContact.Latitud.ToString().Replace(",", ".") + ", " + _dataContact.Longitud.ToString().Replace(",", ".") + ")"); %>
                    };
                    var map = new google.maps.Map(document.getElementById('googleMap'),
                        mapOptions
                    );
                    var marker = new google.maps.Marker({
                    position: map.getCenter(),
                    animation:google.maps.Animation.BOUNCE,
                    icon: '../assets/images/icons/map-marker.png',
                    map: map
                    });

                    map.setOptions({});

    var styles = [
        {
            "featureType": "water",
            "elementType": "geometry",
            "stylers": [
                {
                    "color": "#e9e9e9"
                },
                {
                    "lightness": 17
                }
            ]
        },
        {
            "featureType": "landscape",
            "elementType": "geometry",
            "stylers": [
                {
                    "color": "#f5f5f5"
                },
                {
                    "lightness": 20
                }
            ]
        },
        {
            "featureType": "road.highway",
            "elementType": "geometry.fill",
            "stylers": [
                {
                    "color": "#ffffff"
                },
                {
                    "lightness": 17
                }
            ]
        },
        {
            "featureType": "road.highway",
            "elementType": "geometry.stroke",
            "stylers": [
                {
                    "color": "#ffffff"
                },
                {
                    "lightness": 29
                },
                {
                    "weight": 0.2
                }
            ]
        },
        {
            "featureType": "road.arterial",
            "elementType": "geometry",
            "stylers": [
                {
                    "color": "#ffffff"
                },
                {
                    "lightness": 18
                }
            ]
        },
        {
            "featureType": "road.local",
            "elementType": "geometry",
            "stylers": [
                {
                    "color": "#ffffff"
                },
                {
                    "lightness": 16
                }
            ]
        },
        {
            "featureType": "poi",
            "elementType": "geometry",
            "stylers": [
                {
                    "color": "#f5f5f5"
                },
                {
                    "lightness": 21
                }
            ]
        },
        {
            "featureType": "poi.park",
            "elementType": "geometry",
            "stylers": [
                {
                    "color": "#dedede"
                },
                {
                    "lightness": 21
                }
            ]
        },
        {
            "elementType": "labels.text.stroke",
            "stylers": [
                {
                    "visibility": "on"
                },
                {
                    "color": "#ffffff"
                },
                {
                    "lightness": 16
                }
            ]
        },
        {
            "elementType": "labels.text.fill",
            "stylers": [
                {
                    "saturation": 36
                },
                {
                    "color": "#333333"
                },
                {
                    "lightness": 40
                }
            ]
        },
        {
            "elementType": "labels.icon",
            "stylers": [
                {
                    "visibility": "off"
                }
            ]
        },
        {
            "featureType": "transit",
            "elementType": "geometry",
            "stylers": [
                {
                    "color": "#f2f2f2"
                },
                {
                    "lightness": 19
                }
            ]
        },
        {
            "featureType": "administrative",
            "elementType": "geometry.fill",
            "stylers": [
                {
                    "color": "#fefefe"
                },
                {
                    "lightness": 20
                }
            ]
        },
        {
            "featureType": "administrative",
            "elementType": "geometry.stroke",
            "stylers": [
                {
                    "color": "#fefefe"
                },
                {
                    "lightness": 17
                },
                {
                    "weight": 1.2
                }
            ]
        }
    ];

    map.setOptions({styles: styles});   

                }
    google.maps.event.addDomListener(window, 'load', initialize);
        </script>
    <script src="../assets/js/form-validation.js"></script>
    <script>
    jQuery(document).ready(function() {
            FormValidator.init(2);
            });
    </script>
</asp:Content>