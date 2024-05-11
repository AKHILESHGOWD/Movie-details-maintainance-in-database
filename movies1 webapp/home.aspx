<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="movies1_webapp.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            
            <h1>Welcome to Home page</h1>
            <asp:LinkButton ID="lnksmd" runat="server" Text="Save moveis details" OnClick="lnksmd_Click"></asp:LinkButton>&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lnkedit" runat="server" Text="Edit movies details" OnClick="lnkedit_Click"></asp:LinkButton>&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lnkdisply" runat="server" Text="Disply movies details" OnClick="lnkdisply_Click"></asp:LinkButton>&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="lnkdelete" runat="server" Text="Delete movies details" OnClick="lnkdelete_Click"></asp:LinkButton><br />
            <asp:LinkButton ID="lnklagout" runat="server" Text="Lagout" OnClick="lnklagout_Click"></asp:LinkButton>&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
