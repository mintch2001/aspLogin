<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SessionLogin.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server"> ID : </asp:Label>
            <asp:TextBox runat="server" ID="txtID"></asp:TextBox><br />
            <asp:Label runat="server"> Password : </asp:Label>
            <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
            <asp:button runat="server" ID="loginClick" Text="Login" OnClick="loginClick_Click"/>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
