<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="movies1insert.aspx.cs" Inherits="movies1_webapp.movies1insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Enter movie details</h1>
            <table>
            <tr><td> MovieName</td><td>  :<asp:TextBox ID="txtmname" runat="server"></asp:TextBox></td> </tr>
            <tr><td>HeroName</td> <td> :<asp:TextBox ID="txtheroname" runat="server"></asp:TextBox></td></tr>
            <tr><td> HeroinName</td><td>  :<asp:TextBox ID="txtheroinname" runat="server"></asp:TextBox></td> </tr>
            <tr><td> Budget</td><td>  :<asp:TextBox ID="txtbudget" runat="server" TextMode="Number" ></asp:TextBox></tr>
                </table>
             <asp:Button ID="btnInsert" runat="server" Text="Add"  OnClick="btnInsert_Click" />
            
        </div>
    </form>
</body> 
</html>
