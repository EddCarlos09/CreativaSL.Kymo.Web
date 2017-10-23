<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.Login" %>

<asp:Content runat="server" ContentPlaceHolderID="cphPrincipal">
    <!--breadcumb area start -->
        <div class="breadcumb-area breadcumb-6 overlay pos-rltv">
            <div class="bread-main">
                <div class="bred-hading text-center">
                    <h5>Iniciar Sesión</h5> </div>
                <ol class="breadcrumb">
                    <li class="home"><a title="Go to Home Page" href="index.html">Inicio</a></li>
                    <li class="active">Iniciar Sesión</li>
                </ol>
            </div>
        </div>
        <!--breadcumb area end -->
        
<!-- Account Area Start -->
        <div class="account-area ptb-80">
            <div class="container">
                <div class="row">
                    <div class="col-sm-12 col-xs-12">
                        <form name="CustomLogin" method="post" class="login-side">
                            <div class="login-reg">
                                <h3>Iniciar Sesión</h3>
                                <div class="input-box mb-20">
                                    <label class="control-label">Email</label>
                                    <input type="email" placeholder="E-Mail" value="" name="email" class="info">
                                </div>
                                <div class="input-box">
                                    <label class="control-label">Contraseña</label>
                                    <input type="password" placeholder="Contraseña" value="" name="password" class="info">
                                </div>
                            </div>
                            <div class="frm-action">
                                <div class="input-box tci-box">
                                    <input type="submit" class="btn-def btn2" value="Iniciar sesión" />
                                </div>
                                <span>
                             <input class="remr" type="checkbox"> Recordar 
                         </span>
                                <a href="/Recovery" class="forgotten forg">Olvidé mi contraseña</a>
                            </div>
                        </form>
                    </div>
                    
                </div>
            </div>
        </div>
        <!-- Account Area End -->
    </asp:Content>