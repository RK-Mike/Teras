<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="teräs.aspx.cs" Inherits="aspTeräs.teräs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 212px;
            width: 257px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:<br />
            <asp:TextBox ID="username" runat="server" Height="16px" Width="114px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            Password:</div>
        <p>
            <asp:TextBox ID="password" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="info" runat="server" Text="Label" Visible="true"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Width="55px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Tyontekija" Width="102px" />
    </form>
</body>
</html>
