<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Brand.aspx.cs" Inherits="LaptopStore.Admin.Brand" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblname" runat="server" Text="Enter name"></asp:Label>
            <asp:TextBox runat="server" ID="txtname"></asp:TextBox><br />
            <asp:Button ID="btnsave" runat="server" Text="save" OnClick="btnsave_Click1" />
        </div>
    </form>
</body>
</html>
