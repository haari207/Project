<%@ Page Title="" Language="C#" theme="Skin1" MasterPageFile="~/MyTemplate.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="OnlineShop.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style24 {
        width: 214px;
    }
    .auto-style25 {
        width: 238px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    &nbsp;<br/>
        <script>
            function myfunc(source, args) {
                if (args.Value =="India" || args.Value =="Canada" || args.Value =="Japan") {
                    args.IsValid = true;
                } else {
                    args.IsValid = false;
                }
            }
        </script>
    </p>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style24">&nbsp;</td>
            <td class="auto-style25">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">Username</td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox1" runat="server" Width="176px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter Username" Display="None"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">Password</td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox2" runat="server" Width="177px"></asp:TextBox>
            </td>
            <td>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password Mismatch" Display="None"></asp:CompareValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">Confirm Password</td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox3" runat="server" Width="182px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">Gender</td>
            <td class="auto-style25">
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" />
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">Email</td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox4" runat="server" Width="177px"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage=" Invalid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="None"></asp:RegularExpressionValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">Age</td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox5" runat="server" Width="177px"></asp:TextBox>
            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage=" you are not eligible" MaximumValue="100" MinimumValue="10" Type="Integer" Display="None"></asp:RangeValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24">Nationality</td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox6" runat="server" Width="170px"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox6" ErrorMessage=" You are living in wrong country" ClientValidationFunction="myfunc" Display="None"></asp:CustomValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</p>
<p>
    <asp:Button ID="Button1" runat="server" BackColor="Blue" BorderColor="Blue" ForeColor="White" Text=" Register" Width="103px" OnClick="Button1_Click" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
