<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signin1.aspx.cs" Inherits="signin1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
   <style type = "text/css">
        h1 {color: Aqua; font-size: xx-large; text-align:center}
        h3{color:Blue; font-size: medium; text-align:center}
    </style>

   <form runat = "server" id="signin" action="signin1.aspx"  >
     <h1> username:</h1> 
   <center> <input type = "text" id = "username" name = "username" /> </center> 
    <h3>password:</h3>
    <center> <input type = "text" id = "password" name = "password" /></center> 
    <center><input type = "submit" value = "submit" /></center>
    <center><input type= "reset" value = "reset" /></center>
     <center><a href = "signup1.aspx" > sign up </a></center>
    </form>
    <h1><%=mesasge %></h1>
</body>
</html>