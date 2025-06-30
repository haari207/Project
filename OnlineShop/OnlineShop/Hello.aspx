<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hello.aspx.cs" Inherits="OnlineShop.Hello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 22px" Text=" ADD" Width="109px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Button" />
        </p>
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text=" Store in cookie" Width="189px" />
        </p>
        <p>
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text=" Read cookie" />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
