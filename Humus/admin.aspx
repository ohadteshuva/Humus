<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <style type = "text/css">
        h1 {color: Aqua; font-size: xx-large; text-align:center}
        h3{color:Blue; font-size: medium; text-align:center}
    </style>
    <br />
    <h1>homepage:</h1>
     <center><a href = "homepage1.aspx" > homepage </a></center>
     <br />
     <h3>removeuser:</h3>
      <center><a href = "removeuser.aspx" > remove user </a></center>
      <br />
      <h1>update!!!</h1>
      <center><a href = "updateuser.aspx"> update user </a></center>
      <br />
      <center><a href = "logout.aspx"> log out </a></center>
    </form>
</body>
</html>
