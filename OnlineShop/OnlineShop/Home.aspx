<%@ Page Title="" Language="C#" MasterPageFile="~/MyTemplate.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineShop.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <asp:Button ID="Button1" runat="server" BackColor="#0000CC" BorderColor="#FF0066" BorderStyle="Solid" BorderWidth="3px" ForeColor="White" Text="Button" />
    <asp:TextBox ID="TextBox1" runat="server" BackColor="White" BorderColor="#0000CC" BorderStyle="Double" BorderWidth="2px" ForeColor="#0099FF"></asp:TextBox>
    <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="pid" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
        <Fields>
            <asp:BoundField DataField="pid" HeaderText="pid" ReadOnly="True" SortExpression="pid" />
            <asp:BoundField DataField="pname" HeaderText="pname" SortExpression="pname" />
            <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="pimage" HeaderText="pimage" SortExpression="pimage" />
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
</p>
<p>
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="pid" DataSourceID="SqlDataSource1" GroupItemCount="3">
        <AlternatingItemTemplate>
            <td runat="server" style="">pid:
                <asp:Label ID="pidLabel" runat="server" Text='<%# Eval("pid") %>' BackColor="Blue" />
                <br />pname:
                <asp:Label ID="pnameLabel" runat="server" Text='<%# Eval("pname") %>' />
                <br />description:
                <asp:Label ID="descriptionLabel" runat="server" Text='<%# Eval("description") %>' />
                <br />price:
                <asp:Label ID="priceLabel" runat="server" Text='<%# Eval("price") %>' BackColor="Red" />
                <br />pimage:
                <asp:Image ID="Image3" runat="server" ImageUrl='<%# Eval("pimage") %>' />
                <br /></td>
        </AlternatingItemTemplate>
        <EditItemTemplate>
            <td runat="server" style="">pid:
                <asp:Label ID="pidLabel1" runat="server" Text='<%# Eval("pid") %>' BackColor="#009933" />
                <br />pname:
                <asp:TextBox ID="pnameTextBox" runat="server" Text='<%# Bind("pname") %>' />
                <br />description:
                <asp:TextBox ID="descriptionTextBox" runat="server" Text='<%# Bind("description") %>' />
                <br />price:
                <asp:TextBox ID="priceTextBox" runat="server" Text='<%# Bind("price") %>' />
                <br />pimage:
                <asp:TextBox ID="pimageTextBox" runat="server" Text='<%# Bind("pimage") %>' />
                <br />
                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                <br /></td>
        </EditItemTemplate>
        <EmptyDataTemplate>
            <table runat="server" style="">
                <tr>
                    <td>No data was returned.</td>
                </tr>
            </table>
        </EmptyDataTemplate>
        <EmptyItemTemplate>
<td runat="server" />
        </EmptyItemTemplate>
        <GroupTemplate>
            <tr id="itemPlaceholderContainer" runat="server">
                <td id="itemPlaceholder" runat="server"></td>
            </tr>
        </GroupTemplate>
        <InsertItemTemplate>
            <td runat="server" style="">pid:
                <asp:TextBox ID="pidTextBox" runat="server" Text='<%# Bind("pid") %>' />
                <br />pname:
                <asp:TextBox ID="pnameTextBox" runat="server" Text='<%# Bind("pname") %>' />
                <br />description:
                <asp:TextBox ID="descriptionTextBox" runat="server" Text='<%# Bind("description") %>' />
                <br />price:
                <asp:TextBox ID="priceTextBox" runat="server" Text='<%# Bind("price") %>' />
                <br />pimage:
                <asp:TextBox ID="pimageTextBox" runat="server" Text='<%# Bind("pimage") %>' />
                <br />
                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                <br />
                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                <br /></td>
        </InsertItemTemplate>
        <ItemTemplate>
            <td runat="server" style="">pid:
                <asp:Label ID="pidLabel" runat="server" Text='<%# Eval("pid") %>' BackColor="#009933" />
                <br />pname:
                <asp:Label ID="pnameLabel" runat="server" Text='<%# Eval("pname") %>' />
                <br />description:
                <asp:Label ID="descriptionLabel" runat="server" Text='<%# Eval("description") %>' />
                <br />price:
                <asp:Label ID="priceLabel" runat="server" Text='<%# Eval("price") %>' BackColor="Red" />
                <br />pimage:
                <asp:Image ID="Image2" runat="server" ImageUrl='<%# Eval("pimage") %>' />
                <br /></td>
        </ItemTemplate>
        <LayoutTemplate>
            <table runat="server">
                <tr runat="server">
                    <td runat="server">
                        <table id="groupPlaceholderContainer" runat="server" border="0" style="">
                            <tr id="groupPlaceholder" runat="server">
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr runat="server">
                    <td runat="server" style=""></td>
                </tr>
            </table>
        </LayoutTemplate>
        <SelectedItemTemplate>
            <td runat="server" style="">pid:
                <asp:Label ID="pidLabel" runat="server" Text='<%# Eval("pid") %>' />
                <br />pname:
                <asp:Label ID="pnameLabel" runat="server" Text='<%# Eval("pname") %>' />
                <br />description:
                <asp:Label ID="descriptionLabel" runat="server" Text='<%# Eval("description") %>' />
                <br />price:
                <asp:Label ID="priceLabel" runat="server" Text='<%# Eval("price") %>' />
                <br />pimage:
                <asp:Label ID="pimageLabel" runat="server" Text='<%# Eval("pimage") %>' />
                <br /></td>
        </SelectedItemTemplate>
    </asp:ListView>
</p>
<p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:OnlineshopConnectionString %>" DeleteCommand="DELETE FROM [products] WHERE [pid] = @original_pid AND (([pname] = @original_pname) OR ([pname] IS NULL AND @original_pname IS NULL)) AND (([description] = @original_description) OR ([description] IS NULL AND @original_description IS NULL)) AND (([price] = @original_price) OR ([price] IS NULL AND @original_price IS NULL)) AND (([pimage] = @original_pimage) OR ([pimage] IS NULL AND @original_pimage IS NULL))" InsertCommand="INSERT INTO [products] ([pid], [pname], [description], [price], [pimage]) VALUES (@pid, @pname, @description, @price, @pimage)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [products]" UpdateCommand="UPDATE [products] SET [pname] = @pname, [description] = @description, [price] = @price, [pimage] = @pimage WHERE [pid] = @original_pid AND (([pname] = @original_pname) OR ([pname] IS NULL AND @original_pname IS NULL)) AND (([description] = @original_description) OR ([description] IS NULL AND @original_description IS NULL)) AND (([price] = @original_price) OR ([price] IS NULL AND @original_price IS NULL)) AND (([pimage] = @original_pimage) OR ([pimage] IS NULL AND @original_pimage IS NULL))">
        <DeleteParameters>
            <asp:Parameter Name="original_pid" Type="String" />
            <asp:Parameter Name="original_pname" Type="String" />
            <asp:Parameter Name="original_description" Type="String" />
            <asp:Parameter Name="original_price" Type="Int32" />
            <asp:Parameter Name="original_pimage" Type="String" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="pid" Type="String" />
            <asp:Parameter Name="pname" Type="String" />
            <asp:Parameter Name="description" Type="String" />
            <asp:Parameter Name="price" Type="Int32" />
            <asp:Parameter Name="pimage" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="pname" Type="String" />
            <asp:Parameter Name="description" Type="String" />
            <asp:Parameter Name="price" Type="Int32" />
            <asp:Parameter Name="pimage" Type="String" />
            <asp:Parameter Name="original_pid" Type="String" />
            <asp:Parameter Name="original_pname" Type="String" />
            <asp:Parameter Name="original_description" Type="String" />
            <asp:Parameter Name="original_price" Type="Int32" />
            <asp:Parameter Name="original_pimage" Type="String" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
<p>
    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            
            <h1 style="color:red">Product Details</h1>
          <table border="2">

        </HeaderTemplate>
        <ItemTemplate>
            <tr style="font-weight:bold;background-color:tomato">
                <td><%# Eval("pid") %></td>
                <td><%# Eval("pname") %></td>
                <td><%# Eval("price") %></td>
                <td><%# Eval("description") %></td>

            </tr>
            
        </ItemTemplate>
        <AlternatingItemTemplate>
            <tr style="background-color: lightblue">
                <td><%# Eval("pid") %></td>
                <td><%# Eval("pname") %></td>
                <td><%# Eval("price") %></td>
                <td><%# Eval("description") %></td>
            </tr>
        </AlternatingItemTemplate>
        <SeparatorTemplate>
            <tr style="font-weight:bold;background-color:darkgrey;font-weight:bold">
                <td colspan="4" style="background-color: lightgray; text-align: center;">
                </td>
            </tr>
        </SeparatorTemplate>
        <FooterTemplate>
            </table>
            <h2> Total Item present is 5</h2>
        </FooterTemplate>
                                         

    </asp:Repeater>
    </p>
<p>
    &nbsp;</p>
<p>
</p>
</asp:Content>
