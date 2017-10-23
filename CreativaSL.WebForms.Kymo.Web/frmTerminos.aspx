<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="frmTerminos.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmTerminos" %>

<asp:Content ContentPlaceHolderID="cphPrincipal" runat="server">

    <!--breadcumb area start -->
    <%  var imgTitle = _dataTerminos.ListaImagenes.Find(x => x.NumPosition == 1);
            if (imgTitle == null)
            {
        %>
            <div class="breadcumb-area breadcumb overlay pos-rltv" style="background:rgba(0, 0, 0, 0) url('assets/images/bg/breadcumb.jpg') no-repeat scroll 0 0;">
        <%}
        else
        {
            Response.Write("<div class='breadcumb-area breadcumb overlay pos-rltv' style='background:rgba(0, 0, 0, 0) url(" + imgTitle.UrlImagen + ") no-repeat scroll 0 0;'>");
        }%>
            <div class="breadcumb-area overlay pos-rltv">
                <div class="bread-main">
                    <div class="bred-hading text-center">
                        <%for (int i = 0; i < _dataTerminos.ListaTextos.Count; i++)
                            { %>
                        <h5><%=_dataTerminos.ListaTextos[i].Texto %></h5> </div>
                    <%i++; %>
                    <ol class="breadcrumb">
                        <li class="home"><a title="Go to Home Page" href="index.html"><%=_dataTerminos.ListaTextos[i].Texto %></a></li>
                        <%} %>
                        
                    </ol>
                </div>
            </div>
                </div>
            <!--breadcumb area end -->
            
            <!--Total area start-->
            <div class="col-xs-12 text-center">
                <div class="heading-title heading-style pos-rltv mtb-50 text-center">
                    <h5 class="uppercase">Terminos y condiciones</h5> 
                </div>
            </div>
            <div class="clearfix"></div>
            
            <!--new-arrival on-sale Top-ratted area start-->
            <div class="arrival-ratted-sale-area pb-70">
                <div class="container">
                    <div class="row">
                        
                      <div class="jumbotron text-center">
                          <h2 ></h2>
                      </div>
                        <%foreach (var itemTerminos in _dataTerminos.ListaTerminos)
                            { %>
                      <p><strong><%=itemTerminos.Titulo %></strong><%=itemTerminos.Texto %> </p>
                        <%} %>
                      

                    </div>
                </div>
            </div>
            <!--new-arrival on-sale Top-ratted area end-->   

</asp:Content>