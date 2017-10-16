<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAppend.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmAppend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">
    <div class="inner">
        Hey!        
    </div>
        <script>
        $(".inner").append("<p>Test</p>");
    </script>
    </form>
    
</body>
    
</html>
