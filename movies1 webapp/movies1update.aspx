﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="movies1update.aspx.cs" Inherits="movies1_webapp.movies1update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Update movies1 data</h1>
            <table>
            <tr><td>ID</td><td>:<asp:TextBox ID="txtid" type="number" runat="server"></asp:TextBox></td> 
            <td><asp:Button runat="server" ID="btnsearch" Text="Search" OnClick="btnsearch_Click" /></td> </tr>
            <tr><td>Moviename</td><td>:<asp:TextBox ID="txtmname" runat="server"></asp:TextBox></td> </tr>
            <tr><td>Heroname</td><td>:<asp:TextBox ID="txtheroname" runat="server"></asp:TextBox></td> </tr>
            <tr><td>Heroinename</td><td>:<asp:TextBox ID="txtheroinename" runat="server"></asp:TextBox></td> </tr>
            <tr><td>Budget</td><td>:<asp:TextBox ID="txtbudget" runat="server"></asp:TextBox></td> </tr>
                </table>
           <asp:Button runat="server"  ID="btnupdate" Text="Edit" OnClick="btnupdate_Click" />
        </div>
    </form>
</body>
</html>
