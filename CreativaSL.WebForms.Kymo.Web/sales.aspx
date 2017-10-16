<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sales.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.sales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                <a href="/Login/salesreportsummary/2010">Iniciar sesión</a>
            </AnonymousTemplate>
            <LoggedInTemplate>
                <form runat="server">
                    <asp:Button ID="btnLogOff" OnClick="btnLogOff_Click" runat="server" Text="Cerrar sesión" />
                </form>
            </LoggedInTemplate>
        </asp:LoginView>

</body>
</html>
