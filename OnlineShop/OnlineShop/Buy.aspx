<%@ Page Title="" Language="C#" theme="Skin1" MasterPageFile="~/MyTemplate.Master" AutoEventWireup="true" CodeBehind="Buy.aspx.cs" Inherits="OnlineShop.Buy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <asp:Image ID="Image2" runat="server" />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
</p>
<p>
    <asp:Label ID="Label6" runat="server" Text=" Quantity"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 13px; margin-top: 31px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" BackColor="Blue" ForeColor="White" OnClick="Button1_Click" Text=" Confirm Buy" Width="145px" />
</p>
<p>
</p>
</asp:Content>
