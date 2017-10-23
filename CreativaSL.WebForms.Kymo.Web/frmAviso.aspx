<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmAviso.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmAviso" %>

<asp:Content runat="server" ContentPlaceHolderID="cphPrincipal">

    
            <!--breadcumb area start -->
    <%  var imgTitle = _dataAviso.ListaImagenes.Find(x => x.NumPosition == 1);
            if (imgTitle == null)
            {
        %>
    <div class="breadcumb-area breadcumb overlay pos-rltv" style="background: rgba(0, 0, 0, 0) url('assets/images/bg/breadcumb.jpg') no-repeat scroll 0 0;">
        <%}
            else
            {
                Response.Write("<div class='breadcumb-area breadcumb overlay pos-rltv' style='background:rgba(0, 0, 0, 0) url(" + imgTitle.UrlImagen + ") no-repeat scroll 0 0;'>");
            }%>
        <div class="breadcumb-area overlay pos-rltv">
            <div class="bread-main">
                <%for (int i = 0; i < _dataAviso.ListaTextos.Count; i++)
                    {%>
                <div class="bred-hading text-center">
                    <h5><%=_dataAviso.ListaTextos[i].Texto%></h5>
                </div>
                <%i++; %>
                <ol class="breadcrumb">
                    <li class="home"><a title="Go to Home Page" href="index.html"><%=_dataAviso.ListaTextos[i].Texto %></a></li>
                    <%} %>
                </ol>
            </div>
        </div>
    </div>
            <!--breadcumb area end -->
            
            <!--Total area start-->
           
            
            <!--new-arrival on-sale Top-ratted area start-->
            <div class="arrival-ratted-sale-area pb-70">
                <div class="container">
                    <div class="row">

                        <%foreach (var ItemAviso in _dataAviso.ListaAvisos)
                            {%>
                        <div class="jumbotron text-center"><h2><%=ItemAviso.Titulo%></h2> </div>
                        <p><strong><%=ItemAviso.Texto%></strong></p>
                        <%} %>
                    </div>
                </div>
            </div>
            <!--new-arrival on-sale Top-ratted area end-->   

</asp:Content>