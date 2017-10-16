<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAppend.aspx.cs" Inherits="CreativaSL.WebForms.Kymo.Web.frmAppend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>   
    <script src="https://code.jquery.com/jquery-1.10.2.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
    <h2>Greetings</h2>
        
            <div class="inner"></div>
            <div class="inner"></div>
        
    </form>
    <script>
        $(".inner").append("<p>Test</p>");
    </script>
</body>
    
</html>
