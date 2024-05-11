<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="movies1_webapp.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div align="center">
           <h1>Welcome to login page</h1>
            <table>
            <tr>
                <td>UserName:</td>
                <td><asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            </tr>
            <tr>
                <td>Password:</td>
                <td><asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2" align="center"><asp:Button ID="btnlogin" runat="server" Text="login" OnClick="btnlogin_Click" /></td>   
            </tr>
            <tr>
                <td colspan="2" align="center"><asp:LinkButton ID="lnkreg" runat="server" Text="Register" OnClick="lnkreg_Click" /></td>   
            </tr>
                </table>
            
        </div>
    </form>
</body>
</html>
