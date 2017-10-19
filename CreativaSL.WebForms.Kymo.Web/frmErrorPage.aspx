<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmErrorPage.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmErrorPage" %>

<asp:Content runat="server" ContentPlaceHolderID="cphPrincipal">

        <!--breadcumb area start -->
        <div class="breadcumb-area breadcumb-3 overlay pos-rltv">
            <div class="bread-main">
                <div class="bred-hading text-center">
                    <h5>Detalles Error</h5> </div>
                <ol class="breadcrumb">
                    <li class="home"><a title="Go to Home Page" href="/Home">Inicio</a></li>
                    <li class="active">404</li>
                </ol>
            </div>
        </div>
        <!--breadcumb area end -->
        
        <!--404 area start-->
        <div class="area-404 ptb-80">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12 col-sm-12 col-xs-12">
                           <div class="content-404 text-center">
                                <img src="assets/images/img_404.png" alt="">
                            <div class="text-404">
                                <h1>Oops ! La página solicitada no existe.</h1>
                                <p>Colca otro término de busqueda</p>
                            </div>
                            <div class="search-box serch-404">
                                <form action="#">
                                    <div class="input-box">
                                        <input type="text" class="single-input" placeholder="Search....">
                                        <button class="src-btn src-btn-blog"><i class="fa fa-search"></i></button>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
           </div>
        <!--404 area end-->        

</asp:Content>
