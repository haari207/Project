<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddControl.ascx.cs" Inherits="OnlineShop.AddControl" %>
<style type="text/css">
    .auto-style1 {
        width: 212px;
    }
</style>

<p>
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label2" runat="server" BackColor="#FFFF99" ForeColor="Red" Text=" Addition of two numbers"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Enter number</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Enter number2</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text=" Add numbers" />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</p>
<p>
    &nbsp;</p>

