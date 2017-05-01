<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signup1.aspx.cs" Inherits="signup1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<script>
    function checkit() {
        var Email = document.getElementById("mail").value;
        var ch = false;
        for (var i = 0; i < Email.length; i++) {
            if (Email[i] == '@')
                ch = true;
        }
        if (ch == false) {
            alert("the email is not good try again");
            return false;
        }

        var user = document.getElementById("username").value;
        var count = 0;
        for (var i = 0; i < user.length; i++) {
            count++;
        }
        if (count < 5) {
            alert("the username is less than 5 letters");
            return false;
        }

        var password = document.getElementById("password").value;
        var check = document.getElementById("check").value;
        if (password != check) {
            alert("the passwords dont match");
            return false;
        }
        return true;





    }
      

    

</script>
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
<style type = "text/css">
        h1 {color:Fuchsia; font-size: xx-large; text-align:center}
        h3{color:Lime; font-size: medium; text-align:center}
        
    </style>
    <form runat="server" id="signup" action="signup1.aspx" onsubmit="return checkit()">
    <br />
     <h1>username:</h1>
   <center> <input type="text" id="username" name="username" /> </center>
    <br />
    <h3>name :</h3>
   <center> <input type="text" id="name" name="name" /> </center>
    <br />
    <h1>password:</h1>
   <center> <input type="text" id="password" name="password" /> </center>
    <br />
    <h3>more password:</h3>
  <center>  <input type="text" id="check" name="check" /> </center>
    <br />
    <h1>email adress:</h1>
   <center> <input type="text" id="mail" name="mail" /> </center>
    <br />
    <h3>is admin?</h3>
   <center> <input type="text" id="admin" name="admin" /> </center>
   <br />
   <center> <input type="submit" value="send" /> </center>
   <br />
   <center> <input type="reset" value="reset" /> </center>
   <br />
    <a href="signin1.aspx">sign in </a>
    </form>
</body>
</html>
