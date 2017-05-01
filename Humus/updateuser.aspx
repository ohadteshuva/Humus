<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updateuser.aspx.cs" Inherits="updateuser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat = "server" id="updateuser1" action="updateuser.aspx" >
    <div>
    <style type = "text/css">
        h1 {color:Fuchsia; font-size: xx-large; text-align:center}
        h3{color:Lime; font-size: medium; text-align:center}
        
    </style>
   <h1>username to update:</h1> 
    <center><input type="text" name = "username" /></center>
    <br />
    <h3> the old password </h3>    
    <center><input type = "password" name = "oldpassword" /></center>
    <br />
    <h3> the new password:</h3>
   
    <center> <input type = "password" name = "newpassword" /></center>
     <br />
    <center><input type = "submit" name = "sub" value = "update" /></center> 
     <br />
   <h3> <%=usermsg %> </h3>  
    </div>
    </form>
</body>
</html>
