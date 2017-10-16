<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTest.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div>
       <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/salesreportsummary/2010">
            Sales Report - All locales, 2010
        </asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" 
            NavigateUrl="~/salesreport/WA/2011">
            Sales Report - WA, 2011
        </asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" 
            NavigateUrl="~/expensereport">
            Expense Report - Default Locale and Year (US, current year)
        </asp:HyperLink>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <a href="Prueba/2/1" id="link" >Click Me</a>
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                <a href="/Login/Test">Iniciar sesión</a>
            </AnonymousTemplate>
            <LoggedInTemplate>
                <form runat="server">
                    <asp:Button ID="btnLogOff" OnClick="btnLogOff_Click" runat="server" Text="Cerrar sesión" />
                </form>
            </LoggedInTemplate>
        </asp:LoginView>
    </div>
</body>
</html>
