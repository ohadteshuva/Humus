<%@ Page Language="C#" AutoEventWireup="true" CodeFile="removeuser.aspx.cs" Inherits="removeuser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat = "server" id="removeuser1" action="removeuser.aspx"  >
    <div>
      <style type = "text/css">
        h1 {color: Aqua; font-size: xx-large; text-align:center}
        h3{color:Blue; font-size: medium; text-align:center}
    </style>
    <h1>remove this user:</h1>
    <br />
    <h1>username:</h1>
   <h3><input type = "text" id = "username" name = "username" /> </h3> 
   <h1><input type = "submit" id = "Submit1" name="del" value = "delete" /></h1>
   <h1> <%=usermsg %></h1>
    </div>
    </form>
</body>
</html>
