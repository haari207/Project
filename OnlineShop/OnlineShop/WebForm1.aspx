<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="OnlineShop.WebForm1" %>
<%@ Register Assembly="OnlineShop" Namespace="OnlineShop" TagPrefix="cool" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
  
    <cool:MyCustomControl id="c1" runat="server" text="hello world" />
          </form>
</body>
</html>
