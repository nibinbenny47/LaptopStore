<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Brand.aspx.cs" Inherits="LaptopStore.Admin.Brand" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href=" //cdn.datatables.net/1.10.23/css/jquery.dataTables.min.css" rel="stylesheet" />
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblname" runat="server" Text="Enter name"></asp:Label>
            <asp:TextBox runat="server" ID="txtname"></asp:TextBox><br />
            <asp:Button ID="btnsave" runat="server" Text="save" OnClick="btnsave_Click1" />
            <br />
            <asp:GridView ID="grdbrand" runat="server" AutoGenerateColumns="false" OnRowCommand="grdbrand_RowCommand"  >
                <Columns>
                    <asp:BoundField HeaderText="Name" DataField="brand_name" />
                   <asp:TemplateField>
                        
                        <ItemTemplate>
                            <asp:Button ID="btnDelete" runat="server" CommandArgument='<%#Eval("brand_id") %>' CommandName="del" Text="Delete" />
                            <%--<asp:Button ID="btnEdit" runat="server" CommandArgument='<%# Eval("brand_id") %>' CommandName="ed" Text="Edit" />--%>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
        <script src="//cdn.datatables.net/1.10.23/js/jquery.dataTables.min.js"></script>
   
</body>
</html>
