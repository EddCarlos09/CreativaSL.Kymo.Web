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
        <div class="container">            
            <div class="inner"></div>
            <br />
            <br />
            <br />
            <br />
            <div class="inner2"></div>
        </div>
    </form>
    <script>
        "<%for(int i = 0; i< Lista.Count; i++){%>"        

        datoo = "<%=Lista[i].Nombre%>";      
        $(".inner2").append("<p>" + datoo + "</p>");        
      
        "<% } %>"
        
        
    </script>
</body>    
</html>
