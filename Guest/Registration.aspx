<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="LaptopStore.Guest.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Name:<asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    Gender:<asp:RadioButtonList ID="rdbgender" runat="server" RepeatDirection="Horizontal">
        <asp:ListItem>male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
           </asp:RadioButtonList>
    Email:<asp:TextBox runat="server" ID="txtemail"></asp:TextBox>
    Photo:<asp:FileUpload runat="server" ID="fileimage" />
    username:<asp:TextBox runat="server" ID="txtusername"></asp:TextBox>
    password:<asp:TextBox runat="server" ID="txtpassword"></asp:TextBox>
    <asp:Button runat="server" ID="btnsave" Text="save" OnClick="btnsave_Click" />
</asp:Content>
