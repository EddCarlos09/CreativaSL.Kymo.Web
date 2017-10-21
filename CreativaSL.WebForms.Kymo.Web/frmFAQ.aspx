<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmFAQ.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmFAQ" %>

<asp:Content runat="server" ContentPlaceHolderID="cphPrincipal">

    <!--breadcumb area start -->
    <%  var imgTitle = _dataFaqs.ListaImagenes.Find(x => x.NumPosition == 1);
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
                        var _dataTitle = _dataFaqs.ListaTextos.Find(x => x.NumPosition == 1);
                        if(_dataTitle != null)
                        {
                            Response.Write("<h5>" + _dataTitle.Texto + "</h5>");
                        }
                    %>
                </div>
            <ol class="breadcrumb">
                <li class="home"><a title="Go to Home Page" href="/Home">Inicio</a></li>
                <li class="active">Preguntas frecuentes</li>
            </ol>
        </div>
    </div>
    <!--breadcumb area end -->
            
    <!--Total area start-->
    <div class="col-xs-12 text-center">
        <div class="heading-title heading-style pos-rltv mtb-50 text-center">
            <%
                var _dataTitle2 = _dataFaqs.ListaTextos.Find(x => x.NumPosition == 2);
                if(_dataTitle2 != null)
                {
                    Response.Write("<h5 class='uppercase'>" + _dataTitle2.Texto + "</h5>");
                }
            %>
        </div>
    </div>
    <div class="clearfix"></div>
            
    <!--new-arrival on-sale Top-ratted area start-->
    <div class="arrival-ratted-sale-area pb-70">
        <div class="container">
            <div class="row">
                <% foreach (var itemFaq in _dataFaqs.ListaFaqs)
                    { %>  
                    <div class="col-md-12">
                        <h5 class="uppercase"><%=itemFaq.Titulo%></h5>
                        <p><%=itemFaq.Texto %></p>
                    </div>
                <% } %>
            </div>
        </div>
    </div>
    <!--new-arrival on-sale Top-ratted area end-->     

</asp:Content>